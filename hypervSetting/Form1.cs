﻿using System;
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
        Cmd cmd = Cmd.Instance;
        public string GetLocalIP()
        {
            string hostIp = "";
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
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            String hostName = Dns.GetHostName();
            old_Name.Text = hostName;
            old_Ip.Text = GetLocalIP();
            new_Ip.Text = GetLocalIP();
        }
        private void nameChangeBtn_Click(object sender, EventArgs e)
        {
            String hostName = Dns.GetHostName();
            cmd.nameChange(hostName, new_Name.Text);
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
            Regex ipRegex = new Regex(@"[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}");
            if (ipRegex.IsMatch(new_Ip.Text))
            {
                cmd.ipChange(cmd.getEthernet(), new_Ip.Text);
                MessageBox.Show("변경 완료");
                cmd.ncpacpl();
            }
            else
            {
                MessageBox.Show("IP 형식을 제대로 작성해주세요.");
            }
        }

        private void portproxyAddBtn_Click(object sender, EventArgs e)
        {
            Type TextBox = typeof(TextBox);
            Regex ipRegex = new Regex(@"[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}");
            Regex portproxyRegex = new Regex(@"\*\s+\d+\s+[0-9.]+\s+\d+");
            int spaceChk = 0;
            int caseChk = 0;
            bool wordChk = false;
            if (defaultChk.Checked)
            {

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
                                        caseChk = 1;
                                        cmd.portproxySetDefault(caseChk, WAS_DEV.Text);
                                        break;
                                    }
                                case "WAS_PRD":
                                    {
                                        caseChk = 2;
                                        cmd.portproxySetDefault(caseChk, WAS_PRD.Text);
                                        break;
                                    }
                                case "SAP_DEV":
                                    {
                                        caseChk = 3;
                                        cmd.portproxySetDefault(caseChk, SAP_DEV.Text);
                                     
                                        break;
                                    }
                                case "SAP_QAS":
                                    {
                                        caseChk = 4;
                                        cmd.portproxySetDefault(caseChk, SAP_QAS.Text);
                                    
                                        break;
                                    }
                                case "SAP_PRD":
                                    {
                                        caseChk = 5;
                                        cmd.portproxySetDefault(caseChk, SAP_PRD.Text);
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

                if (ipRegex.IsMatch(connectaddress.Text))
                {
                    cmd.portproxySet(Decimal.ToInt32(listenport.Value), Decimal.ToInt32(connectport.Value), connectaddress.Text);
                    listenport.Value = 0;
                    connectport.Value = 0;
                    connectaddress.Text = "";

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
                        result = pasteBox.Lines[i].Split(empty, StringSplitOptions.RemoveEmptyEntries);
                        cmd.portproxySet(Convert.ToInt32(result[1]), Convert.ToInt32(result[3]), result[2]);
                    }
                }
                MessageBox.Show("추가 완료");
            }
        }

        private void portproxyViewBtn_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.BringToFront();
            portproxyViewBox.Text = cmd.portproxyView();
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
                            cmd.portproxyReset();
                            MessageBox.Show("초기화 완료");
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
            cmd.portproxySet(Decimal.ToInt32(listenport.Value));
            listenport.Value = 0;
            connectport.Value = 0;
            connectaddress.Text = "";
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

    }
}
