using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

/*
 * 메뉴 설명 
 * @Param {Type} 설명
 * @Return {Type} 설명
 */

namespace hypervSetting
{
    public class Cmd : IProcess 
    {
        private Process cmd;
        private static readonly Lazy<Cmd> instance =
            new Lazy<Cmd>(() => new Cmd());

        public static Cmd Instance 
        {
            get
            {
                return instance.Value;
            }
        }
        private Cmd()
        {
            cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
        }

        /*
         * CMD 시작
         */
        public void start()
        {
            cmd.Start();
        }
        /*
         * CMD 종료
         */
        public void stop()
        {
            cmd.WaitForExit();
            cmd.Close();
        }
        /*
         * ipconfig 입력해 나온 텍스트를 이용해 사용할 ethernet 주소 값 출력
         * @Return {string} ethernet에 대한 값 ex) 이더넷 13 
         */
        public string getEthernet()
        {
            start();
            string ethernet = "";
            cmd.StandardInput.Write(@"ipconfig" + Environment.NewLine);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            string resultValue = cmd.StandardOutput.ReadToEnd();
            string[] resultLines = resultValue.Split('\n');
            List<string> ethernetArr = new List<string>();
            List<string> ipv4Arr = new List<string>();

            for (int i = 0; i < resultLines.Length; i++)
            {
                if (Regex.IsMatch(resultLines[i], @"^([ㄱ-힇]{3}\s){2}(이더넷|vEthernet).*?(\d*?)\:"))
                {
                    ethernetArr.Add(resultLines[i]);
                }
                if (Regex.IsMatch(resultLines[i], @"^\s+IPv4"))
                {
                    ipv4Arr.Add(resultLines[i]);
                }
            }
            for (int i = 0; i < ipv4Arr.Count; i++)
            {
                if (Regex.IsMatch(ipv4Arr[i], @"192\.168"))
                {
                    ethernet = Regex.Replace(ethernetArr[i], @"^([ㄱ-힇]{3}\s){2}(이더넷|vEthernet).*?(\d*?)\:", "$3");
                }
            }

            if (!ethernet.Equals(""))
            {
                ethernet = " " + ethernet;
            }
            stop();
            return ethernet;
        }
        /*
         * 네트워크 연결 창 실행
         */
        public void ncpacpl()
        {
            start();
            cmd.StandardInput.Write(@"ncpa.cpl" + Environment.NewLine);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            stop();
        }
        /*
         * IP를 고정으로 변경
         * @Param {string} ethernet에 대한 값 ex) 이더넷 13
         * @Param {string} 변경할 IP 주소
         */
        public void ipChange(string ethernet, string new_Ip)
        {
            start();
            cmd.StandardInput.Write(@"netsh interface ipv4 set address name=""이더넷" + ethernet + "\" static " + new_Ip + " 255.255.254.0 192.168.0.1" + Environment.NewLine);
            cmd.StandardInput.Write(@"netsh interface ipv4 set dns name=""이더넷" + ethernet + "\" static 168.126.63.1" + Environment.NewLine);
            cmd.StandardInput.Write(@"netsh interface ipv4 add dns name=""이더넷" + ethernet + "\" 168.126.63.2" + Environment.NewLine);

            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            stop();
        }

        /*
         * 호스트네임 변경
         * @Param {string} 기존 호스트네임 
         * @Param {string} 변경할 호스트네임
         */
        public void nameChange(string hostName, string new_Name)
        {
            start();
            cmd.StandardInput.Write(@"wmic ComputerSystem Where Name=""" + hostName + "\" Call Rename Name=\"" + new_Name + "\"" + Environment.NewLine);

            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            stop();
        }

        /*
         * portproxy 삭제
         * @Param {decimal} listenport 값
         */
        public void portproxyDel(decimal listenport)
        {
            start();
            cmd.StandardInput.Write(@"netsh interface portproxy delete v4tov4 listenport=" + listenport + "" + Environment.NewLine);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            stop();
        }

        /*
         * portproxy 초기화
         */
        public void portproxyReset()
        {
            start();
            cmd.StandardInput.Write(@"netsh interface portproxy reset" + Environment.NewLine);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            stop();
        }

        /*
         * 설정된 portproxy 조회
         * @Return {string} 조회된 portproxy 내용 
         */
        public string portproxyView()
        {
            start();
            cmd.StandardInput.Write(@"netsh interface portproxy show all" + Environment.NewLine);

            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            string resultValue = cmd.StandardOutput.ReadToEnd();

            stop();
            return resultValue;
        }

        /*
         * custom, paste 일 때 portproxy 세팅
         * @Param {int} listenport
         * @Param {int} connectport
         * @Param {string} connectaddress
         */
        public void portproxySet(int listenport, int connectport = -1, string connectaddress = "")
        {
            start();
            if (connectport > 0)
            {
                cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=" + listenport + " connectport=" + connectport + " connectaddress=" + connectaddress + "" + Environment.NewLine);
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
            }
            else
            {
                cmd.StandardInput.Write(@"netsh interface portproxy delete v4tov4 listenport=" + listenport + "" + Environment.NewLine);
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
            }
            stop();
        }
        /*
         * default 일 때 portproxy 세팅
         * @Param {int} was,prd 에 따라 case 파악을 위한 값
         * @Param {string} connectaddress
         */
        public void portproxySetDefault(int caseChk, string connectaddress)
        {
            start();
            if(caseChk == 1)
            {
                cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=80 connectport=80 connectaddress=" + connectaddress + "" + Environment.NewLine);
                cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=443 connectport=443 connectaddress=" + connectaddress + "" + Environment.NewLine);
                cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=8082 connectport=8082 connectaddress=" + connectaddress + "" + Environment.NewLine);

            }
            if (caseChk == 2)
            {
                cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=10080 connectport=80 connectaddress=" + connectaddress + "" + Environment.NewLine);
                cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=10443 connectport=443 connectaddress=" + connectaddress + "" + Environment.NewLine);
                cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=18082 connectport=8082 connectaddress=" + connectaddress + "" + Environment.NewLine);
            }
            if (caseChk == 3)
            {
                cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=3200 connectport=3200 connectaddress=" + connectaddress + "" + Environment.NewLine);
                cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=3300 connectport=3300 connectaddress=" + connectaddress + "" + Environment.NewLine);
            }
            if (caseChk == 4)
            {
                cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=3201 connectport=3200 connectaddress=" + connectaddress + "" + Environment.NewLine);
                cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=3301 connectport=3300 connectaddress=" + connectaddress + "" + Environment.NewLine);
            }
            if (caseChk == 5)
            {
                cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=3202 connectport=3200 connectaddress=" + connectaddress + "" + Environment.NewLine);
                cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=3302 connectport=3300 connectaddress=" + connectaddress + "" + Environment.NewLine);
            }

            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            stop();
        }

    }

}


