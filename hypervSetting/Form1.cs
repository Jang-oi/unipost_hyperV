using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace hypervSetting
{

    public partial class Form1 : Form
    {
        String hostName = Dns.GetHostName();
        string hostIp = "";
        Regex ipRegex = new Regex(@"[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}");
        Regex portproxyRegex = new Regex(@"\*\s+\d+\s+[0-9.]+\s+\d+");
        string ethernet = "";
        Process cmd;
        public string GetLocalIP()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress LocalIPAddress in host.AddressList)
            {
                if (LocalIPAddress.AddressFamily == AddressFamily.InterNetwork)
                {
                    hostIp = LocalIPAddress.ToString();
                    return hostIp;
                }
            }
            return hostIp;
        }

        public void ipConfig()
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

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

            cmd.WaitForExit();
            cmd.Close();

        }

        public void npcacpl()
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.Write(@"ncpa.cpl" + Environment.NewLine);

            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            cmd.Close();
        }

        public Form1()
        {
            InitializeComponent();
            initCmd();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetLocalIP();
            old_Name.Text = hostName;
            old_Ip.Text = hostIp;
            new_Ip.Text = hostIp;
        }

        private void nameChangeBtn_Click(object sender, EventArgs e)
        {

            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.Write(@"wmic ComputerSystem Where Name=""" + hostName + "\" Call Rename Name=\"" + new_Name.Text + "\"" + Environment.NewLine);

            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            cmd.Close();

            DialogResult result = MessageBox.Show("컴퓨터를 지금 다시시작하시겠습니까??", "컴퓨터 다시시작", MessageBoxButtons.YesNo);

            switch (result)
            {
                case DialogResult.Yes:
                    {
                        Process.Start("shutdown.exe", "-r -f -t 00");
                        break;
                    }
                case DialogResult.No:
                    {
                        MessageBox.Show("다시시작 해야 호스트네임이 적용됩니다.");
                        break;
                    }
            }


        }

        private void ipChangeBtn_Click(object sender, EventArgs e)
        {   
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            ipConfig();

            if (ipRegex.IsMatch(new_Ip.Text))
            {
                cmd.StandardInput.Write(@"netsh interface ipv4 set address name=""이더넷" + ethernet + "\" static " + new_Ip.Text + " 255.255.254.0 192.168.0.1" + Environment.NewLine);
                cmd.StandardInput.Write(@"netsh interface ipv4 set dns name=""이더넷" + ethernet + "\" static 168.126.63.1" + Environment.NewLine);
                cmd.StandardInput.Write(@"netsh interface ipv4 add dns name=""이더넷" + ethernet + "\" 168.126.63.2" + Environment.NewLine);

                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();

                cmd.WaitForExit();
                cmd.Close();

                MessageBox.Show("변경 완료");
                npcacpl();
            }
            else
            {
                MessageBox.Show("IP 형식을 제대로 작성해주세요.");
            }
        }

        private void portproxyAddBtn_Click(object sender, EventArgs e)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            Type TextBox = typeof(TextBox);

            int spaceChk = 0;
            bool wordChk = false;
            if (defaultChk.Checked)
            {
                cmd.Start();

                for (int i = 0; i < panel1.Controls.Count; i++)
                {
                    if (panel1.Controls[i].GetType().Equals(TextBox))
                    {
                        if (ipRegex.IsMatch(panel1.Controls[i].Text))
                        {
                            wordChk = true;
                            switch (panel1.Controls[i].Name)
                            {
                                case "WAS_DEV":
                                    {
                                        cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=80 connectport=80 connectaddress=" + WAS_DEV.Text + "" + Environment.NewLine);
                                        cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=443 connectport=443 connectaddress=" + WAS_DEV.Text + "" + Environment.NewLine);
                                        cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=8082 connectport=8082 connectaddress=" + WAS_DEV.Text + "" + Environment.NewLine);
                                        break;
                                    }
                                case "WAS_PRD":
                                    {
                                        cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=10080 connectport=80 connectaddress=" + WAS_PRD.Text + "" + Environment.NewLine);
                                        cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=10443 connectport=443 connectaddress=" + WAS_PRD.Text + "" + Environment.NewLine);
                                        cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=18082 connectport=8082 connectaddress=" + WAS_PRD.Text + "" + Environment.NewLine);
                                        break;
                                    }
                                case "SAP_DEV":
                                    {
                                        cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=3200 connectport=3200 connectaddress=" + SAP_DEV.Text + "" + Environment.NewLine);
                                        cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=3300 connectport=3300 connectaddress=" + SAP_DEV.Text + "" + Environment.NewLine);
                                        break;
                                    }
                                case "SAP_QAS":
                                    {
                                        cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=3201 connectport=3200 connectaddress=" + SAP_QAS.Text + "" + Environment.NewLine);
                                        cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=3301 connectport=3300 connectaddress=" + SAP_QAS.Text + "" + Environment.NewLine);
                                        break;
                                    }
                                case "SAP_PRD":
                                    {
                                        cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=3202 connectport=3200 connectaddress=" + SAP_PRD.Text + "" + Environment.NewLine);
                                        cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=3302 connectport=3300 connectaddress=" + SAP_PRD.Text + "" + Environment.NewLine);
                                        break;
                                    }
                            }
                        }

                        if(panel1.Controls[i].Text.Equals("")) {
                            spaceChk += 1;
                        }
                    }
                }
                WAS_DEV.Text = "";
                WAS_PRD.Text = "";
                SAP_DEV.Text = "";
                SAP_QAS.Text = "";
                SAP_PRD.Text = "";

                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
                cmd.Close();
                if(spaceChk != 5 && wordChk)
                {
                    MessageBox.Show("추가 완료");
                } else
                {
                    MessageBox.Show("값이 공백 또는 올바르지 않은 형식입니다.");
                }
               
            }
            else if(customChk.Checked)
            {
                cmd.Start();

                if (ipRegex.IsMatch(connectaddress.Text))
                {
                    cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=" + listenport.Value + " connectport=" + connectport.Value + " connectaddress=" + connectaddress.Text + "" + Environment.NewLine);

                    listenport.Value = 0;
                    connectport.Value = 0;
                    connectaddress.Text = "";

                    cmd.StandardInput.Flush();
                    cmd.StandardInput.Close();
                    cmd.WaitForExit();
                    cmd.Close();

                    MessageBox.Show("추가 완료");
                }
                else
                {
                    MessageBox.Show("IP주소를 제대로 입력해주세요.");
                }
            }
            else if(pasteChk.Checked)
            {
                string[] result;
                char[] empty = { ' ' };
                for (int i = 0; i < pasteBox.Lines.Length; i++)
                {
                    if (portproxyRegex.IsMatch(pasteBox.Lines[i]))
                    {
                        cmd.Start();

                        result = pasteBox.Lines[i].Split(empty, StringSplitOptions.RemoveEmptyEntries);
                        cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=" + result[1] + " connectport=" + result[3] + " connectaddress=" + result[2] + "" + Environment.NewLine);

                        cmd.StandardInput.Flush();
                        cmd.StandardInput.Close();
                        cmd.WaitForExit();
                        cmd.Close();

                       
                    }
                }
                MessageBox.Show("추가 완료");
            }
        }

        private void portproxyViewBtn_Click(object sender, EventArgs e)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.Write(@"netsh interface portproxy show all" + Environment.NewLine);

            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            string resultValue = cmd.StandardOutput.ReadToEnd();
            
            cmd.WaitForExit();
            cmd.Close();
            panel3.Visible = true;
            panel3.BringToFront();
            portproxyViewBox.Text = resultValue;
            portproxyViewBox.Font = new Font(FontFamily.GenericMonospace, portproxyViewBox.Font.Size);
            portproxyViewBox.Visible = true;
            
        }
        private void portproxyResetBtn_Click(object sender, EventArgs e)
        {
            if(pasteChk.Checked)
            {
                pasteBox.Text = "";
            } else
            {
                DialogResult result = MessageBox.Show("초기화 하시겠습니까??", "포트프록시 초기화", MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.Yes:
                        {
                            Process cmd = new Process();
                            cmd.StartInfo.FileName = "cmd.exe";
                            cmd.StartInfo.RedirectStandardInput = true;
                            cmd.StartInfo.RedirectStandardOutput = true;
                            cmd.StartInfo.CreateNoWindow = true;
                            cmd.StartInfo.UseShellExecute = false;
                            cmd.Start();

                            cmd.StandardInput.Write(@"netsh interface portproxy reset" + Environment.NewLine);

                            cmd.StandardInput.Flush();
                            cmd.StandardInput.Close();
                            cmd.WaitForExit();
                            cmd.Close();
                            break;
                        }
                    case DialogResult.No:
                        {
                            break;
                        }
                }
            }

        }

        private void portproxyDelBtn_Click(object sender, EventArgs e)
        {
            startCmd();
            cmd.StandardInput.Write(@"netsh interface portproxy delete v4tov4 listenport=" + listenport.Value + "" + Environment.NewLine);
            listenport.Value = 0;
            connectport.Value = 0;
            connectaddress.Text = "";
            stopCmd();
            MessageBox.Show("삭제 완료");

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex != 1)
            {
                panel4.SendToBack();
            } else
            {
                defaultChk.Checked = true;
            }
            
        }

        private void portproxyViewBoxBtn_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void customChk_CheckedChanged(object sender, EventArgs e)
        {
            if (customChk.Checked)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel4.Visible = false;
            }
        }

        private void pasteChk_CheckedChanged(object sender, EventArgs e)
        {
            if(pasteChk.Checked)
            {
                panel4.Visible = true;
                panel4.BringToFront();
                pasteBox.Font = new Font(FontFamily.GenericMonospace, pasteBox.Font.Size);
            }
        }

        private void defaultChk_CheckedChanged(object sender, EventArgs e)
        {
            if (defaultChk.Checked)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel4.Visible = false;
            }
        }

        private void setPortproxy(int a, int b = -1, string c = "")
        {
            startCmd();
            if(b > 0)
            {
                cmd.StandardInput.Write(@"netsh interface portproxy add v4tov4 listenport=" + a + " connectport=" + b + " connectaddress=" + c + "" + Environment.NewLine);
            } else
            {
                cmd.StandardInput.Write(@"netsh interface portproxy delete v4tov4 listenport=" + a + "" + Environment.NewLine);
            }
            listenport.Value = 0;
            connectport.Value = 0;
            connectaddress.Text = "";
            stopCmd();

            MessageBox.Show("삭제 완료");
        }

        private void initCmd()
        {
            cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
        }

        private void startCmd()
        {
            cmd.Start();
        }

        private void stopCmd()
        {
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            cmd.Close();
        }

    }
}
