using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Net;
using DevExpress;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.Utils;
using DevExpress.Data;
using DevExpress.Printing;
using DevExpress.Sparkline;
using DevExpress.XtraSplashScreen;
using DevExpress.Sparkline.Core;
using DevExpress.Printing.Core;
using DevExpress.XtraBars;
using PS3ManagerAPI;

namespace PS3_LezZo_Manager_Tool_xNew
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Rand = new Random();
            Temperature = "OK";
        }

        #region NavBarItems
        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = true;
            groupControl2.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
        }
        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = true;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
        }
        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl4.Visible = true;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
        }
        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = true;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
        }
        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = true;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
        }
        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = true;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
        }
        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = true;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
        }
        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = true;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
        }
        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = true;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
        }
        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = true;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
        }
        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = true;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
        }
        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = true;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
        }
        private void navBarItem14_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = true;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
        }
        private void navBarItem15_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = true;
            groupControl16.Visible = false;
        }
        private void navBarItem16_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = true;
        }
        #endregion

        #region definitions
        public static PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();
        public string Temperature = "";
        private bool ftpconnected = false;
        private Random Rand;
        public FTPclient FtpClient;
        string directory;
        private bool iswebfree = true;
        private bool isdbwebfree = true;
        string dlferroxst = "dlferroxst.txt";
        string dlferroxcbr = "dlferroxcbr.txt";
        string dlferroxnobd = "dlferroxnobd.txt";
        string dlrebugrex = "dlrebugrex.txt";
        string dlrebugdrex = "dlrebugdrex.txt";
        string dlrebugmod = "dlrebugmod.txt";
        string dlhabibcbr = "dlhabibcbr.txt";
        string dlps3ita = "dlps3ita.txt";
        string dlplayerkpst = "dlplayerkpst.txt";
        string dlplayerkpcbr = "dlplayerkpcbr.txt";
        string dlplayerkpdb = "dlplayerkpdb.txt";
        string dldarknetst = "dldarknetst.txt";
        string dldarknetcbr = "dldarknetcbr.txt";

        string vFerroxstandard = "ferroxstandard.txt";
        string vFerroxcobra = "ferroxcobra.txt";
        string vFerroxnobd = "ferroxnobd.txt";
        string vRebugrex = "rebugrex.txt";
        string vRebugdrex = "rebugdrex.txt";
        string vRebugmod = "rebugmod.txt";
        string vHabibcobra = "habibcobra.txt";
        string vPs3ITA = "ps3ita.txt";
        string vPlayerkpstandard = "playerkpstandard.txt";
        string vPlayerkpcobra = "playerkpcobra.txt";
        string vPlayerkpdb = "playerkpdb.txt";
        string vDarknetstandard = "darknetstandard.txt";
        string vDarknetcobra = "darknetcobra.txt";
        #endregion

        #region AutoUpdate
        private static bool CheckForInternetConnection()
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() == true)
                return true;
            else return false;
        }

        private void CheckforUpdates()
        {
            string URL = "https://www.cybermodding.it/Manager_Tool/";
            string ToolVersion = "Version.txt";
            string Changelog = "Changelog.txt";

            try
            {
                WebClient wc = new WebClient();
                var UI = wc.DownloadString(URL + ToolVersion);
                var CL = wc.DownloadString(URL + Changelog);
                if (UI.Contains("2.0.2"))
                {

                }
                else
                {
                    if (splashScreenManager2.IsSplashFormVisible == true)
                    {
                        splashScreenManager2.CloseWaitForm();
                    }
                    if (XtraMessageBox.Show("A new Update is Available!! \nVersion: " + UI + "\n \n" + "Changelog: \n" + CL + "\n \n" + "Would you like to Download the Update now? \n", "New Update!!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        Hide();
                        UpdateForm UpdFrm = new UpdateForm();
                        UpdFrm.Show();
                    }
                    else
                    {

                    }
                }
            }
            catch
            {

            }
        }

        public void Check4Updates()
        {
            string URL = "https://www.cybermodding.it/Manager_Tool/";
            string ToolVersion = "Version.txt";
            string ChangelogENG = "ChangelogENG.txt";

            WebClient wc = new WebClient();
            var UI = wc.DownloadString(URL + ToolVersion);
            var CL = wc.DownloadString(URL + ChangelogENG);

            if (CheckForInternetConnection() == true)
            {
                if (UI.Contains("2.0.2"))
                {
                    XtraMessageBox.Show("No Updates Available for now.", "No Updates", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    if (XtraMessageBox.Show("A new Update is Available!! \nVersion: " + UI + "\n \n" + "Changelog: \n" + CL + "\n \n" + "Would you like to Download the Update now? \n", "New Update!!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        Hide();
                        UpdateForm UpdFrm = new UpdateForm();
                        UpdFrm.Show();
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Your Internet Connection seems not working. \nCheck it and retry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region ChangelogHistory
        private void ReadChangelog()
        {
            string URL = "https://www.cybermodding.it/Manager_Tool/";
            string Ch = "OLDChangelog.txt";

            if (CheckForInternetConnection() == true)
            {
                try
                {
                    WebClient wc = new WebClient();
                    var Changelog = wc.DownloadString(URL + Ch);

                    XtraMessageBox.Show("Here is the Changelog History of the Manager Tool: \n\n" + Changelog + "\n", "Changelog History", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch
                {

                }
            }
            else
            {
                XtraMessageBox.Show("Somethings goes wrong. \nMaybe your internet connection does not work. Check it and retry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Communications
        private void CheckforCommunications()
        {
            string URL = "https://www.cybermodding.it/Manager_Tool/";
            string ifcomm = "ifcomm.txt";
            string comm = "comm.txt";

            if (CheckForInternetConnection() == true)
            {
                try
                {
                    WebClient wc = new WebClient();
                    var checkifcomm = wc.DownloadString(URL + ifcomm);
                    if (checkifcomm.Contains("Yes"))
                    {
                        var yescomm = wc.DownloadString(URL + comm);
                        XtraMessageBox.Show("Here is the Communication from the developer: \n\n" + yescomm + "\n", "Communication from the Dev", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        XtraMessageBox.Show("There is no communication from the Dev for now.", "Communication from the Dev", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                catch
                {

                }
            }
            else
            {
                XtraMessageBox.Show("Somethings goes wrong. \nMaybe your internet connection does not work. Check it and retry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Gen
        private static class GeneratorS
        {
            private static Random rands = new Random();

            public static string Part1()
            {
                return "00000001008";
            }

            public static char Part2()
            {
                char[] chArray = "58C3A".ToCharArray();
                int index = GeneratorS.rands.Next(chArray.Length);
                return chArray[index];
            }

            public static string Part3()
            {
                return "000";
            }

            public static char Part4()
            {
                char[] chArray = "5B".ToCharArray();
                int index = Form1.GeneratorS.rands.Next(chArray.Length);
                return chArray[index];
            }

            public static string Part5()
            {
                return "140";
            }

            public static char Part6()
            {
                char[] chArray = "24D60318537".ToCharArray();
                int index = Form1.GeneratorS.rands.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part7()
            {
                char[] chArray = "B863DE257C1".ToCharArray();
                int index = Form1.GeneratorS.rands.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part8()
            {
                char[] chArray = "3EA7FB596C".ToCharArray();
                int index = Form1.GeneratorS.rands.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part9()
            {
                char[] chArray = "D304A5C82E".ToCharArray();
                int index = Form1.GeneratorS.rands.Next(chArray.Length);
                return chArray[index];
            }

            public static char Par1()
            {
                char[] chArray = "3B21CE7F".ToCharArray();
                int index = Form1.GeneratorS.rands.Next(chArray.Length);
                return chArray[index];
            }

            public static char Par2()
            {
                char[] chArray = "86C4F90B12".ToCharArray();
                int index = Form1.GeneratorS.rands.Next(chArray.Length);
                return chArray[index];
            }

            public static char Par3()
            {
                char[] chArray = "29CD153A67".ToCharArray();
                int index = Form1.GeneratorS.rands.Next(chArray.Length);
                return chArray[index];
            }

            public static char Par4()
            {
                char[] chArray = "1A3EDB98".ToCharArray();
                int index = Form1.GeneratorS.rands.Next(chArray.Length);
                return chArray[index];
            }

            public static char Par5()
            {
                char[] chArray = "480A2FB".ToCharArray();
                int index = Form1.GeneratorS.rands.Next(chArray.Length);
                return chArray[index];
            }

            public static char Par6()
            {
                char[] chArray = "9F75A8BE64D".ToCharArray();
                int index = Form1.GeneratorS.rands.Next(chArray.Length);
                return chArray[index];
            }

            public static char Par7()
            {
                char[] chArray = "897C1AFE".ToCharArray();
                int index = Form1.GeneratorS.rands.Next(chArray.Length);
                return chArray[index];
            }

            public static char Par8()
            {
                char[] chArray = "A7FB49683C".ToCharArray();
                int index = Form1.GeneratorS.rands.Next(chArray.Length);
                return chArray[index];
            }

            public static char Par9()
            {
                char[] chArray = "853662ACBFED".ToCharArray();
                int index = Form1.GeneratorS.rands.Next(chArray.Length);
                return chArray[index];
            }
        }

        private static class GeneratorP
        {
            private static Random randP = new Random();

            public static char Part1()
            {
                char[] chArray = "7B1CA08".ToCharArray();
                int index = randP.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part10()
            {
                char[] chArray = "19CD153A67".ToCharArray();
                int index = randP.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part11()
            {
                char[] chArray = "1A3EDB98".ToCharArray();
                int index = randP.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part12()
            {
                char[] chArray = "480A2FB".ToCharArray();
                int index = randP.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part13()
            {
                char[] chArray = "9F75A8BE64D".ToCharArray();
                int index = randP.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part14()
            {
                char[] chArray = "897C1AFE".ToCharArray();
                int index = randP.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part15()
            {
                char[] chArray = "A7FB49683C".ToCharArray();
                int index = randP.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part16()
            {
                char[] chArray = "85362ACBFED".ToCharArray();
                int index = randP.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part17()
            {
                char[] chArray = "B9014AC7T".ToCharArray();
                int index = randP.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part18()
            {
                char[] chArray = "0CB438AD".ToCharArray();
                int index = randP.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part19()
            {
                char[] chArray = "B019CA".ToCharArray();
                int index = randP.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part20()
            {
                char[] chArray = "A12630BDE".ToCharArray();
                int index = randP.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part21()
            {
                char[] chArray = "FC5E470".ToCharArray();
                int index = randP.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part2()
            {
                char[] chArray = "109D".ToCharArray();
                int index = randP.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part3()
            {
                char[] chArray = "217BC".ToCharArray();
                int index = randP.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part3a()
            {
                char[] chArray = "58C".ToCharArray();
                int index = randP.Next(chArray.Length);
                return chArray[index];
            }

            public static string Part3b()
            {
                return "000";
            }

            public static char Part3c()
            {
                char[] chArray = "5BA0".ToCharArray();
                int index = randP.Next(chArray.Length);
                return chArray[index];
            }

            public static string Part3d()
            {
                return "140";
            }

            public static char Part3e()
            {
                char[] chArray = "698A1".ToCharArray();
                int index = randP.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part3f()
            {
                char[] chArray = "1092ED".ToCharArray();
                int index = randP.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part3g()
            {
                char[] chArray = "CN8379R".ToCharArray();
                int index = randP.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part4()
            {
                char[] chArray = "24D60318537".ToCharArray();
                int index = randP.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part5()
            {
                char[] chArray = "B863DE257C1".ToCharArray();
                int index = randP.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part6()
            {
                char[] chArray = "3EA7FB8596C".ToCharArray();
                int index = randP.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part7()
            {
                char[] chArray = "D304A5C82E".ToCharArray();
                int index = randP.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part8()
            {
                char[] chArray = "3B21CE7F".ToCharArray();
                int index = randP.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part9()
            {
                char[] chArray = "86C4f90B12".ToCharArray();
                int index = randP.Next(chArray.Length);
                return chArray[index];
            }
        }

        private static class Generator
        {
            private static Random rand = new Random();

            public static string Part1()
            {
                return "0000000";
            }

            public static char Part10()
            {
                char[] chArray = "19CD153A67".ToCharArray();
                int index = rand.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part11()
            {
                char[] chArray = "1A3EDB98".ToCharArray();
                int index = rand.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part12()
            {
                char[] chArray = "480A2FB".ToCharArray();
                int index = rand.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part13()
            {
                char[] chArray = "9F75A8BE64D".ToCharArray();
                int index = rand.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part14()
            {
                char[] chArray = "897C1AFE".ToCharArray();
                int index = rand.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part15()
            {
                char[] chArray = "A7FB49683C".ToCharArray();
                int index = rand.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part16()
            {
                char[] chArray = "85362ACBFED".ToCharArray();
                int index = rand.Next(chArray.Length);
                return chArray[index];
            }

            public static string Part2()
            {
                return "100";
            }

            public static char Part3()
            {
                return '8';
            }

            public static char Part3a()
            {
                char[] chArray = "58C3A".ToCharArray();
                int index = rand.Next(chArray.Length);
                return chArray[index];
            }

            public static string Part3b()
            {
                return "000";
            }

            public static char Part3c()
            {
                char[] chArray = "5B".ToCharArray();
                int index = rand.Next(chArray.Length);
                return chArray[index];
            }

            public static string Part3d()
            {
                return "140";
            }

            public static char Part4()
            {
                char[] chArray = "24D60318537".ToCharArray();
                int index = rand.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part5()
            {
                char[] chArray = "B863DE257C1".ToCharArray();
                int index = rand.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part6()
            {
                char[] chArray = "3EA7FB8596C".ToCharArray();
                int index = rand.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part7()
            {
                char[] chArray = "D304A5C82E".ToCharArray();
                int index = rand.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part8()
            {
                char[] chArray = "3B21CE7F".ToCharArray();
                int index = rand.Next(chArray.Length);
                return chArray[index];
            }

            public static char Part9()
            {
                char[] chArray = "86C4F90B12".ToCharArray();
                int index = rand.Next(chArray.Length);
                return chArray[index];
            }
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(100);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            labelControl20.Text = Environment.UserName;
            if (CheckForInternetConnection() == true)
            {
                splashScreenManager2.ShowWaitForm();
                WebClient wc = new WebClient();
                var ferroxst = wc.DownloadString(URL + vFerroxstandard);
                var ferroxcbr = wc.DownloadString(URL + vFerroxcobra);
                var ferroxnobd = wc.DownloadString(URL + vFerroxnobd);
                var rebugrex = wc.DownloadString(URL + vRebugrex);
                var rebugdrex = wc.DownloadString(URL + vRebugdrex);
                var rebugmod = wc.DownloadString(URL + vRebugmod);
                var habibcbr = wc.DownloadString(URL + vHabibcobra);
                var ps3ita = wc.DownloadString(URL + vPs3ITA);
                var playerkpst = wc.DownloadString(URL + vPlayerkpstandard);
                var playerkpcbr = wc.DownloadString(URL + vPlayerkpcobra);
                var playerkpdb = wc.DownloadString(URL + vPlayerkpdb);
                var darknetst = wc.DownloadString(URL + vDarknetstandard);
                var darknetcbr = wc.DownloadString(URL + vDarknetcobra);

                var mm = wc.DownloadString(URL + multiman);
                var mmss = wc.DownloadString(URL + multiman_singstar);
                var wm = wc.DownloadString(URL + webman);
                var wmrbg = wc.DownloadString(URL + webmanrbg);
                var wmmtl = wc.DownloadString(URL + webmanmtl);
                var iris_stealth = wc.DownloadString(URL + irisman_stealth);
                var psnp = wc.DownloadString(URL + psnpatch);
                var sen = wc.DownloadString(URL + senenabler);
                var prep = wc.DownloadString(URL + prepntfs);
                var store = wc.DownloadString(URL + hbstore);
                var mamb = wc.DownloadString(URL + mamba);
                var wm_theme = wc.DownloadString(URL + webman_themes);
                var manag = wc.DownloadString(URL + managunz);
                var artem = wc.DownloadString(URL + artemis);
                var iris = wc.DownloadString(URL + Irisman);
                var playm = wc.DownloadString(URL + playmanager);
                var gsman = wc.DownloadString(URL + gamesonic);
                var ccontrolapi = wc.DownloadString(URL + ccapi);
                var smandeank = wc.DownloadString(URL + sman);
                var mmssrcybm = wc.DownloadString(URL + multiman_singstar_cybm);
                var openftp = wc.DownloadString(URL + ps3ftp);
                var xmbm2k = wc.DownloadString(URL + xmbm);

                comboBoxEdit13.Properties.Items.Insert(0, "Custom Firmware REBUG 3.55.4 REX");
                comboBoxEdit13.Properties.Items.Insert(1, "Custom Firmware REBUG 999 Downgrader");
                comboBoxEdit13.Properties.Items.Insert(2, "Custom Firmware ROGERO 999 Downgrader");
                comboBoxEdit13.Properties.Items.Insert(3, "Custom Firmware FERROX 3.55 NO-BD");
                comboBoxEdit13.Properties.Items.Insert(4, ferroxst);
                comboBoxEdit13.Properties.Items.Insert(5, ferroxcbr);
                comboBoxEdit13.Properties.Items.Insert(6, ferroxnobd);
                comboBoxEdit13.Properties.Items.Insert(7, rebugrex);
                comboBoxEdit13.Properties.Items.Insert(8, rebugdrex);
                comboBoxEdit13.Properties.Items.Insert(9, rebugmod);
                comboBoxEdit13.Properties.Items.Insert(10, habibcbr);
                comboBoxEdit13.Properties.Items.Insert(11, ps3ita);
                comboBoxEdit13.Properties.Items.Insert(12, playerkpst);
                comboBoxEdit13.Properties.Items.Insert(13, playerkpcbr);
                comboBoxEdit13.Properties.Items.Insert(14, playerkpdb);
                comboBoxEdit13.Properties.Items.Insert(15, darknetst);
                comboBoxEdit13.Properties.Items.Insert(16, darknetcbr);

                comboBoxEdit5.Properties.Items.Insert(0, "MultiMAN v" + mm);
                comboBoxEdit5.Properties.Items.Insert(1, "MultiMAN Singstar Build " + mmss);
                comboBoxEdit5.Properties.Items.Insert(2, "webMAN MOD v" + wm);
                comboBoxEdit5.Properties.Items.Insert(3, "webMAN MOD Theme Rebugification v" + wmrbg);
                comboBoxEdit5.Properties.Items.Insert(4, "webMAN MOD Theme Metalification v" + wmmtl);
                comboBoxEdit5.Properties.Items.Insert(5, "IrisMAN STEALTH v" + iris_stealth);
                comboBoxEdit5.Properties.Items.Insert(6, "PsnPatch v" + psnp);
                comboBoxEdit5.Properties.Items.Insert(7, "SEN Enabler v" + sen);
                comboBoxEdit5.Properties.Items.Insert(8, "PrepNTFS v" + prep);
                comboBoxEdit5.Properties.Items.Insert(9, "HomebrewStore Installer v" + store);
                comboBoxEdit5.Properties.Items.Insert(10, "MAMBA PRX Loader v" + mamb);
                comboBoxEdit5.Properties.Items.Insert(11, "PSNinja v4");
                comboBoxEdit5.Properties.Items.Insert(12, "webMAN MOD Theme Anonymous " + wm_theme);
                comboBoxEdit5.Properties.Items.Insert(13, "webMAN MOD Theme Basic White " + wm_theme);
                comboBoxEdit5.Properties.Items.Insert(14, "webMAN MOD Theme Black Steel " + wm_theme);
                comboBoxEdit5.Properties.Items.Insert(15, "webMAN MOD Theme inFamous " + wm_theme);
                comboBoxEdit5.Properties.Items.Insert(16, "webMAN MOD Theme iOS " + wm_theme);
                comboBoxEdit5.Properties.Items.Insert(17, "webMAN MOD Theme REBUG " + wm_theme);
                comboBoxEdit5.Properties.Items.Insert(18, "webMAN MOD Theme Red DarkneSs " + wm_theme);
                comboBoxEdit5.Properties.Items.Insert(19, "webMAN MOD Theme Steel Style " + wm_theme);
                comboBoxEdit5.Properties.Items.Insert(20, "ManaGunz v" + manag);
                comboBoxEdit5.Properties.Items.Insert(21, "Artemis " + artem);
                comboBoxEdit5.Properties.Items.Insert(22, "IrisMAN v" + iris);
                comboBoxEdit5.Properties.Items.Insert(23, "Play Manager v" + playm);
                comboBoxEdit5.Properties.Items.Insert(24, "Gamesonic v" + gsman);
                comboBoxEdit5.Properties.Items.Insert(25, "Control Console API v" + ccontrolapi);
                comboBoxEdit5.Properties.Items.Insert(26, "sMAN v" + smandeank);
                comboBoxEdit5.Properties.Items.Insert(27, "MultiMAN SS Cybm Build " + mmssrcybm);
                comboBoxEdit5.Properties.Items.Insert(28, "OpenPS3FTP " + openftp);
                comboBoxEdit5.Properties.Items.Insert(29, "XMBM+ 2k17 " + xmbm2k);
                CheckforUpdates();
                if (splashScreenManager2.IsSplashFormVisible == true)
                {
                    splashScreenManager2.CloseWaitForm();
                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Check4Updates();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Restart();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!PS3M_API.ConnectTarget(txtB_Ip.Text, Convert.ToInt32(7887)))
                {
                    XtraMessageBox.Show("Impossible to connect, check your Ps3 IP! \nNote: webMAN MOD is needed on your Console! \nOr maybe your Internet connection does not work.", "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    labelControl2.Text = "PS3MAPI Not Connected";
                }
                else
                {
                    labelControl9.Text = PS3M_API.PS3.GetFirmwareVersion_Str();
                    labelControl7.Text = PS3M_API.PS3.GetFirmwareType();
                    uint cpu;
                    uint rsx;
                    PS3M_API.PS3.GetTemperature(out cpu, out rsx);
                    labelControl11.Text = cpu.ToString() + "°";
                    labelControl13.Text = rsx.ToString() + "°";
                    labelControl2.Text = "PS3MAPI Connected";
                    timer1.Start();
                    timer3.Interval = 10000;
                    timer3.Start();
                    timer4.Interval = 11000;
                    timer4.Start();
                    textEdit2.Text = PS3M_API.PS3.GetPSID();
                    textEdit5.Text = PS3M_API.PS3.GetIDPS();
                    webBrowser1.Navigate(txtB_Ip.Text);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();

            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            int J = rand.Next(0, 255);
            int F = rand.Next(0, 255);
            int D = rand.Next(0, 255);
            int N = rand.Next(0, 255);

            labelControl20.ForeColor = Color.FromArgb(A, R, G, B);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            StringBuilder StringBuilder = new StringBuilder();
            StringBuilder.Append(Form1.GeneratorS.Part1());
            StringBuilder.Append(Form1.GeneratorS.Part2());
            StringBuilder.Append(Form1.GeneratorS.Part3());
            StringBuilder.Append(Form1.GeneratorS.Part4());
            StringBuilder.Append(Form1.GeneratorS.Part5());
            StringBuilder.Append(Form1.GeneratorS.Part6());
            StringBuilder.Append(Form1.GeneratorS.Part7());
            StringBuilder.Append(Form1.GeneratorS.Part8());
            StringBuilder.Append(Form1.GeneratorS.Part9());
            StringBuilder.Append(Form1.GeneratorS.Par1());
            StringBuilder.Append(Form1.GeneratorS.Par2());
            StringBuilder.Append(Form1.GeneratorS.Par3());
            StringBuilder.Append(Form1.GeneratorS.Par4());
            StringBuilder.Append(Form1.GeneratorS.Par5());
            StringBuilder.Append(Form1.GeneratorS.Par6());
            StringBuilder.Append(Form1.GeneratorS.Par7());
            StringBuilder.Append(Form1.GeneratorS.Par8());
            StringBuilder.Append(Form1.GeneratorS.Par9());
            textEdit5.Text = StringBuilder.ToString();

            if (textEdit5.Text.Length == 32)
            {
                try
                {
                    PS3M_API.PS3.SetIDPS(textEdit5.Text);
                    PS3M_API.PS3.Notify("IDPS Changed!");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Invalid ConsoleID!", "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (PS3M_API.IsConnected)
            {
                uint cpu;
                uint rsx;
                PS3M_API.PS3.GetTemperature(out cpu, out rsx);
                labelControl11.Text = cpu.ToString() + "°";
                labelControl13.Text = rsx.ToString() + "°";
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            WarningMsg wmsg = new WarningMsg();

            if (labelControl11.Text == "72°")
            {
                if (Temperature == "OK")
                {
                    wmsg.Show();
                    timer4.Stop();
                    timer5.Start();
                    Temperature = "Danger";
                }
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            WarningTemp wtmp = new WarningTemp();

            if (labelControl11.Text == "75°")
            {
                if (Temperature == "Danger")
                {
                    wtmp.Show();
                    timer5.Stop();
                    Temperature = "Finish";
                }
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            PS3M_API.DisconnectTarget();
            labelControl20.ForeColor = Color.White;
            labelControl1.ForeColor = Color.White;
            labelControl2.ForeColor = Color.White;
            labelControl2.Text = "...";
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();
            timer6.Stop();
            labelControl3.Text = "Welcome";
            labelControl3.ForeColor = Color.White;
            btnConnect.ForeColor = Color.White;
            XtraMessageBox.Show("Target Disconnected! Bye bye :)", "Disconnected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxEdit1.SelectedIndex == 0) PS3M_API.PS3.Power(PS3MAPI.PS3_CMD.PowerFlags.QuickReboot);
                else if (comboBoxEdit1.SelectedIndex == 1) PS3M_API.PS3.Power(PS3MAPI.PS3_CMD.PowerFlags.SoftReboot);
                else if (comboBoxEdit1.SelectedIndex == 2) PS3M_API.PS3.Power(PS3MAPI.PS3_CMD.PowerFlags.HardReboot);
                else if (comboBoxEdit1.SelectedIndex == 3) PS3M_API.PS3.Power(PS3MAPI.PS3_CMD.PowerFlags.ShutDown);
                PS3M_API.DisconnectTarget();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            try
            {

                if (comboBoxEdit3.SelectedIndex == 0)
                {
                    if (comboBoxEdit4.SelectedIndex == 0) PS3M_API.PS3.Led(PS3MAPI.PS3_CMD.LedColor.Red, PS3MAPI.PS3_CMD.LedMode.Off);
                    else if (comboBoxEdit4.SelectedIndex == 1) PS3M_API.PS3.Led(PS3MAPI.PS3_CMD.LedColor.Red, PS3MAPI.PS3_CMD.LedMode.On);
                    else if (comboBoxEdit4.SelectedIndex == 2) PS3M_API.PS3.Led(PS3MAPI.PS3_CMD.LedColor.Red, PS3MAPI.PS3_CMD.LedMode.BlinkFast);
                    else if (comboBoxEdit4.SelectedIndex == 3) PS3M_API.PS3.Led(PS3MAPI.PS3_CMD.LedColor.Red, PS3MAPI.PS3_CMD.LedMode.BlinkSlow);
                }
                else if (comboBoxEdit3.SelectedIndex == 1)
                {
                    if (comboBoxEdit4.SelectedIndex == 0) PS3M_API.PS3.Led(PS3MAPI.PS3_CMD.LedColor.Green, PS3MAPI.PS3_CMD.LedMode.Off);
                    else if (comboBoxEdit4.SelectedIndex == 1) PS3M_API.PS3.Led(PS3MAPI.PS3_CMD.LedColor.Green, PS3MAPI.PS3_CMD.LedMode.On);
                    else if (comboBoxEdit4.SelectedIndex == 2) PS3M_API.PS3.Led(PS3MAPI.PS3_CMD.LedColor.Green, PS3MAPI.PS3_CMD.LedMode.BlinkFast);
                    else if (comboBoxEdit4.SelectedIndex == 3) PS3M_API.PS3.Led(PS3MAPI.PS3_CMD.LedColor.Green, PS3MAPI.PS3_CMD.LedMode.BlinkSlow);
                }
                else if (comboBoxEdit3.SelectedIndex == 2)
                {
                    if (comboBoxEdit4.SelectedIndex == 0) PS3M_API.PS3.Led(PS3MAPI.PS3_CMD.LedColor.Yellow, PS3MAPI.PS3_CMD.LedMode.Off);
                    else if (comboBoxEdit4.SelectedIndex == 1) PS3M_API.PS3.Led(PS3MAPI.PS3_CMD.LedColor.Yellow, PS3MAPI.PS3_CMD.LedMode.On);
                    else if (comboBoxEdit4.SelectedIndex == 2) PS3M_API.PS3.Led(PS3MAPI.PS3_CMD.LedColor.Yellow, PS3MAPI.PS3_CMD.LedMode.BlinkFast);
                    else if (comboBoxEdit4.SelectedIndex == 3) PS3M_API.PS3.Led(PS3MAPI.PS3_CMD.LedColor.Yellow, PS3MAPI.PS3_CMD.LedMode.BlinkSlow);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxEdit2.SelectedIndex == 0) PS3M_API.PS3.RingBuzzer(PS3MAPI.PS3_CMD.BuzzerMode.Single);
                else if (comboBoxEdit2.SelectedIndex == 1) PS3M_API.PS3.RingBuzzer(PS3MAPI.PS3_CMD.BuzzerMode.Double);
                else if (comboBoxEdit2.SelectedIndex == 2) PS3M_API.PS3.RingBuzzer(PS3MAPI.PS3_CMD.BuzzerMode.Triple);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            try
            {
                PS3M_API.PS3.Notify(textEdit3.Text);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
            {
                if (PS3M_API.IsConnected)
                {
                    timer3.Interval = 10000;
                    timer3.Start();
                }
                else
                {
                    checkEdit1.Checked = false;
                    XtraMessageBox.Show("You have to Connect first.", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtB_Ip.Text + "/refresh.ps3");
            webBrowser1.Navigate(txtB_Ip.Text + "/restart.ps3");
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtB_Ip.Text + "/recovery.ps3");
            XtraMessageBox.Show("Sometimes it doesen't work.. Don't know why :)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtB_Ip.Text + "/cpursx.ps3?up");
        }

        private void simpleButton19_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtB_Ip.Text + "/cpursx.ps3?dn");
        }

        private void simpleButton21_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtB_Ip.Text + "/delete.ps3?history");
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtB_Ip.Text + "/quit.ps3");
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtB_Ip.Text + "/rebuild.ps3");
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtB_Ip.Text + "/mount.ps3/unmount");
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtB_Ip.Text + "/dump.ps3?lv2");
            XtraMessageBox.Show("LV2 Memory will be Dumped in a few seconds. \nThe Dump will be saved in dev_hdd0 :)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void simpleButton20_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtB_Ip.Text + "/browser.ps3$ingame_screenshot");
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtB_Ip.Text + "/dump.ps3?lv1");
            XtraMessageBox.Show("LV1 Memory will be Dumped in a few seconds. \nThe Dump will be saved in dev_hdd0 :)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void simpleButton23_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtB_Ip.Text + "/dump.ps3?full");
            XtraMessageBox.Show("Full Memory will be Dumped in few seconds. \nThe Dump will be saved in dev_hdd0 :)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void simpleButton24_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(txtB_Ip.Text + "/setup.ps3");
        }

        private void simpleButton26_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtB_Ip.Text + "/delete.ps3?uninstall");
            webBrowser1.Navigate(txtB_Ip.Text + "/reboot.ps3");
        }

        private void simpleButton25_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(txtB_Ip.Text);
        }

        private void cb_Syscall_8_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Syscall_8.Checked)
            {
                cb_Syscall_8_P1.Enabled = true;
                cb_Syscall_8_P2.Enabled = true;
                cb_Syscall_8_D.Enabled = true;
                if (!cb_Syscall_8_P1.Checked && !cb_Syscall_8_P2.Checked && !cb_Syscall_8_D.Checked) cb_Syscall_8_P1.Checked = true;
            }
            else
            {
                cb_Syscall_8_P1.Enabled = false;
                cb_Syscall_8_P2.Enabled = false;
                cb_Syscall_8_D.Enabled = false;
                cb_Syscall_8_P1.Checked = false;
                cb_Syscall_8_P2.Checked = false;
                cb_Syscall_8_D.Checked = false;
                cb_RemoveHook.Enabled = false;
                cb_RemoveHook.Checked = false;
            }
        }

        private void cb_Syscall_8_P1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Syscall_8_P1.Checked)
            {
                cb_Syscall_8_P2.Checked = false;
                cb_Syscall_8_D.Checked = false;
                cb_Syscall_8.Checked = true;
            }
            else if (!cb_Syscall_8_P1.Checked && !cb_Syscall_8_P2.Checked && !cb_Syscall_8_D.Checked) cb_Syscall_8.Checked = false;

        }

        private void cb_Syscall_8_P2_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Syscall_8_P2.Checked)
            {
                cb_Syscall_8_P1.Checked = false;
                cb_Syscall_8_D.Checked = false;
                cb_Syscall_8.Checked = true;
            }
            else if (!cb_Syscall_8_P1.Checked && !cb_Syscall_8_P2.Checked && !cb_Syscall_8_D.Checked) cb_Syscall_8.Checked = false;

        }

        private void cb_Syscall_8_D_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Syscall_8_D.Checked)
            {
                cb_RemoveHook.Enabled = true;
                cb_Syscall_8_P1.Checked = false;
                cb_Syscall_8_P2.Checked = false;
                cb_Syscall_8.Checked = true;
            }
            else
            {
                cb_RemoveHook.Enabled = false;
                cb_RemoveHook.Checked = false;
                if (!cb_Syscall_8_P1.Checked && !cb_Syscall_8_P2.Checked && !cb_Syscall_8_D.Checked) cb_Syscall_8.Checked = false;
            }
        }

        private void cb_RemoveHook_CheckedChanged(object sender, EventArgs e)
        {

        }

        #region Sysc
        private void SyscallTabUpdate()
        {
            if (PS3M_API.IsConnected)
            {
                if (PS3M_API.PS3.CheckSyscall(6))
                {
                    cb_Syscall_6.Enabled = true;
                    cb_Syscall_6.Checked = false;
                }
                else
                {
                    cb_Syscall_6.Enabled = false;
                    cb_Syscall_6.Checked = true;
                }
                if (PS3M_API.PS3.CheckSyscall(7))
                {
                    cb_Syscall_7.Enabled = true;
                    cb_Syscall_7.Checked = false;
                }
                else
                {
                    cb_Syscall_7.Enabled = false;
                    cb_Syscall_7.Checked = true;
                }
                if (PS3M_API.PS3.CheckSyscall(9))
                {
                    cb_Syscall_9.Enabled = true;
                    cb_Syscall_9.Checked = false;
                }
                else
                {
                    cb_Syscall_9.Enabled = false;
                    cb_Syscall_9.Checked = true;
                }
                if (PS3M_API.PS3.CheckSyscall(10))
                {
                    cb_Syscall_10.Enabled = true;
                    cb_Syscall_10.Checked = false;
                }
                else
                {
                    cb_Syscall_10.Enabled = false;
                    cb_Syscall_10.Checked = true;
                }

                if (PS3M_API.PS3.CheckSyscall(11))
                {
                    cb_Syscall_11.Enabled = true;
                    cb_Syscall_11.Checked = false;
                }
                else
                {
                    cb_Syscall_11.Enabled = false;
                    cb_Syscall_11.Checked = true;
                }
                if (PS3M_API.PS3.CheckSyscall(35))
                {
                    cb_Syscall_35.Enabled = true;
                    cb_Syscall_35.Checked = false;
                }
                else
                {
                    cb_Syscall_35.Enabled = false;
                    cb_Syscall_35.Checked = true;
                }
                if (PS3M_API.PS3.CheckSyscall(36))
                {
                    cb_Syscall_36.Enabled = true;
                    cb_Syscall_36.Checked = false;
                }
                else
                {
                    cb_Syscall_36.Enabled = false;
                    cb_Syscall_36.Checked = true;
                }
                if (PS3M_API.PS3.CheckSyscall(8))
                {
                    cb_Syscall_8.Enabled = true;
                    if (PS3M_API.PS3.PartialCheckSyscall8() == PS3MAPI.PS3_CMD.Syscall8Mode.Enabled)
                    {
                        cb_Syscall_8.Checked = false;
                        cb_Syscall_8_P1.Checked = false;
                        cb_Syscall_8_P2.Checked = false;
                        cb_Syscall_8_D.Checked = false;
                    }
                    else if (PS3M_API.PS3.PartialCheckSyscall8() == PS3MAPI.PS3_CMD.Syscall8Mode.Only_CobraMambaAndPS3MAPI_Enabled)
                    {
                        cb_Syscall_8.Checked = true;
                        cb_Syscall_8_P1.Checked = true;
                        cb_Syscall_8_P2.Checked = false;
                        cb_Syscall_8_D.Checked = false;
                    }
                    else if (PS3M_API.PS3.PartialCheckSyscall8() == PS3MAPI.PS3_CMD.Syscall8Mode.Only_PS3MAPI_Enabled)
                    {
                        cb_Syscall_8.Checked = true;
                        cb_Syscall_8_P1.Checked = false;
                        cb_Syscall_8_P2.Checked = true;
                        cb_Syscall_8_D.Checked = false;
                    }
                    else if (PS3M_API.PS3.PartialCheckSyscall8() == PS3MAPI.PS3_CMD.Syscall8Mode.FakeDisabled)
                    {
                        cb_Syscall_8.Checked = true;
                        cb_Syscall_8_P1.Checked = false;
                        cb_Syscall_8_P2.Checked = false;
                        cb_Syscall_8_D.Checked = false;
                    }
                }
                else
                {
                    cb_Syscall_8.Enabled = false;
                    cb_Syscall_8.Checked = true;
                    cb_Syscall_8_D.Enabled = false;
                    cb_Syscall_8_D.Checked = true;
                    cb_RemoveHook.Enabled = false;
                    cb_Syscall_8_P1.Enabled = false;
                    cb_Syscall_8_P1.Checked = false;
                    cb_Syscall_8_P2.Enabled = false;
                    cb_Syscall_8_P2.Checked = false;
                }
            }
        }
        #endregion

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_Syscall_6.Checked) PS3M_API.PS3.DisableSyscall(6);
                if (cb_Syscall_7.Checked) PS3M_API.PS3.DisableSyscall(7);
                if (cb_Syscall_9.Checked) PS3M_API.PS3.DisableSyscall(9);
                if (cb_Syscall_10.Checked) PS3M_API.PS3.DisableSyscall(10);
                if (cb_Syscall_11.Checked) PS3M_API.PS3.DisableSyscall(11);
                if (cb_Syscall_35.Checked) PS3M_API.PS3.DisableSyscall(35);
                if (cb_Syscall_36.Checked) PS3M_API.PS3.DisableSyscall(36);
                if (cb_Syscall_8.Checked)
                {
                    if (cb_Syscall_8_P1.Checked) PS3M_API.PS3.PartialDisableSyscall8(PS3MAPI.PS3_CMD.Syscall8Mode.Only_CobraMambaAndPS3MAPI_Enabled);
                    else if (cb_Syscall_8_P2.Checked) PS3M_API.PS3.PartialDisableSyscall8(PS3MAPI.PS3_CMD.Syscall8Mode.Only_PS3MAPI_Enabled);
                    else if (cb_Syscall_8_D.Checked)
                    {
                        if (cb_RemoveHook.Checked) PS3M_API.PS3.RemoveHook();
                        PS3M_API.PS3.DisableSyscall(8);
                    }
                }
                else PS3M_API.PS3.PartialDisableSyscall8(PS3MAPI.PS3_CMD.Syscall8Mode.Enabled);
                XtraMessageBox.Show("All selected Syscalls are now Disabled :)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                SyscallTabUpdate();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetFtpClient(FTPclient client, string dir)
        {
            FtpClient = client;
            client.OnNewMessageReceived += new FTPclient.NewMessageHandler(FtpClient_OnNewMessageReceived);
            foreach (FTPfileInfo folder in client.ListDirectoryDetail(dir))//"/"))
            {
                ListViewItem item = new ListViewItem();
                item.Text = folder.Filename;
                if (folder.FileType == FTPfileInfo.DirectoryEntryTypes.Directory)
                    item.SubItems.Add("Folder");
                else
                    item.SubItems.Add("File");
            }
        }

        private void FtpClient_OnNewMessageReceived(object myObject, NewMessageEventArgs e)
        {
            labelControl22.Text = e.StatusPath;
        }

        private void simpleButton28_Click(object sender, EventArgs e)
        {
            try
            {
                FTPclient Ftp = new FTPclient(textEdit1.Text);
                directory = "/";
                Ftp.CurrentDirectory = directory;
                SetFtpClient(Ftp, directory);
                comboBoxEdit6.SelectedIndex = 5;
                ftpconnected = true;
                webBrowser1.Navigate(textEdit1.Text + "/dev_blind");
                if (!PS3M_API.IsConnected)
                {
                    labelControl2.Text = "FTP Connected";
                }
                else
                {
                    labelControl2.Text = "PS3MAPI & FTP Connected";
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            simpleButton1.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox22.Visible = false;
            pictureBox108.Visible = false;
            pictureBox109.Visible = false;
            pictureBox110.Visible = false;
            pictureBox111.Visible = false;
            pictureBox112.Visible = false;
            pictureBox113.Visible = false;
            pictureBox114.Visible = false;
            pictureBox115.Visible = false;
            pictureBox116.Visible = false;
            pictureBox117.Visible = false;
            pictureBox118.Visible = false;
            pictureBox119.Visible = false;
            pictureBox122.Visible = false;
            pictureBox123.Visible = false;
            pictureBox124.Visible = false;
            pictureBox125.Visible = false;
            pictureBox126.Visible = false;
            pictureBox127.Visible = false;
            pictureBox128.Visible = false;
            pictureBox129.Visible = false;
            pictureBox130.Visible = false;
        }

        private void CompletedHomeb(object sender, AsyncCompletedEventArgs e)
        {
            if (XtraMessageBox.Show("Download Completed! \nNow you can Upload the Homebrew on your PS3 :)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                DownProgress.EditValue = 0;
                iswebfree = true;
                labelControl50.Text = "...";
                labelControl49.Text = "...";
            }
        }

        private void DownloadProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            DownProgress.EditValue = e.ProgressPercentage;
            labelControl49.Text = e.TotalBytesToReceive.ToString();
            labelControl50.Text = e.BytesReceived.ToString();
        }

        string URL = "https://www.cybermodding.it/Manager_Tool/";
        string webman = "webman.txt";
        string webmanrbg = "webmanrbg.txt";
        string webmanmtl = "webmanmtl.txt";
        string multiman = "multiman.txt";
        string multiman_singstar = "multiman_singstar.txt";
        string multiman_singstar_cybm = "multiman_singstar_cybm.txt";
        string sman = "sman.txt";
        string Irisman = "irisman.txt";
        string irisman_stealth = "irisman_stealth.txt";
        string psnpatch = "psnpatch.txt";
        string senenabler = "senenabler.txt";
        string prepntfs = "prepntfs.txt";
        string hbstore = "hbstore.txt";
        string mamba = "mamba.txt";
        string artemis = "artemis.txt";
        string managunz = "managunz.txt";
        string playmanager = "playmanager.txt";
        string webman_themes = "webman_themes";
        string gamesonic = "gamesonic.txt";
        string ccapi = "ccapi.txt";
        string ps3ftp = "openps3ftp.txt";
        string xmbm = "xmbm2k17.txt";
        string cfwex = "cfwExtras.txt";

        private bool IsWebCFree()
        {
            if (iswebfree == true)
                return true;
            else return false;
        }

        private void simpleButton29_Click(object sender, EventArgs e)
        {
            if (IsWebCFree() == true)
            {
                labelControl48.Text = "Downloaded";
                if (comboBoxEdit5.SelectedIndex == 0)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + multiman);
                        DownProgress.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/multiMAN_" + UI + ".pkg"), @"downloads/multiMAN_" + UI + ".pkg");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 1)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + multiman_singstar);
                        DownProgress.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/mmSS-R-build-" + UI + ".pkg"), @"downloads/multiMAN Stealth mmSS-R build " + UI + ".pkg");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 2)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + webman);
                        DownProgress.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/webMAN_MOD_" + UI + "_Updater.pkg"), @"downloads/webMAN_MOD_" + UI + "_Updater.pkg");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 3)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + webmanrbg);
                        DownProgress.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/webMAN_MOD_" + UI + "_Updater_rebugification_theme.pkg"), @"downloads/webMAN_MOD_" + UI + "_Updater_rebugification_theme.pkg");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 4)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + webmanmtl);
                        DownProgress.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/webMAN_MOD_" + UI + "_Updater_metalification_theme.pkg"), @"downloads/webMAN_MOD_" + UI + "_Updater_metalification_theme.pkg");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 5)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + irisman_stealth);
                        DownProgress.EditValue = 0;
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/IrisMAN_Stealth_" + UI + ".pkg"), @"downloads/IrisMAN Stealth " + UI + " By MIZIO90.pkg");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 6)
                {
                    try
                    {
                        iswebfree = false;
                        DownProgress.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + psnpatch);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/psnpatch_" + UI + ".pkg"), @"downloads/PsnPatch " + UI + ".pkg");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 7)
                {
                    try
                    {
                        iswebfree = false;
                        DownProgress.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + senenabler);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/SEN_Enabler_v" + UI + ".pkg"), @"downloads/SEN_Enabler_" + UI + ".pkg");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 8)
                {
                    try
                    {
                        iswebfree = false;
                        DownProgress.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + prepntfs);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/prepNTFS_" + UI + ".pkg"), @"downloads/prepNTFS_" + UI + ".pkg");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 9)
                {
                    try
                    {
                        iswebfree = false;
                        DownProgress.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + hbstore);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/HomebrewStore_Installer_" + UI + ".pkg"), @"downloads/HomebrewStore_Installer_" + UI + ".pkg");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 10)
                {
                    try
                    {
                        iswebfree = false;
                        DownProgress.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + mamba);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/MAMBA_PRX_Loader_" + UI + ".pkg"), @"downloads/MAMBA PRX Loader " + UI + ".pkg");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 11)
                {
                    try
                    {
                        iswebfree = false;
                        DownProgress.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PSNinja_4.0.pkg"), @"downloads/PSNinja_4.0.pkg");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 12)
                {
                    try
                    {
                        iswebfree = false;
                        DownProgress.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + webman_themes);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Anonymous_Theme_" + UI + ".pkg"), @"downloads/webMAN_MOD_Theme_Anonymous_" + UI + ".pkg");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 13)
                {
                    try
                    {
                        iswebfree = false;
                        DownProgress.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + webman_themes);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Basic_White_Theme_" + UI + ".pkg"), @"downloads/webMAN_MOD_Theme_Basic-White_" + UI + ".pkg");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 14)
                {
                    try
                    {
                        iswebfree = false;
                        DownProgress.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + webman_themes);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Black_Steel_Theme_" + UI + ".pkg"), @"downloads/webMAN_MOD_Theme_Black-Steel_" + UI + ".pkg");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 15)
                {
                    try
                    {
                        iswebfree = false;
                        DownProgress.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + webman_themes);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/inFamous_Theme_" + UI + ".pkg"), @"downloads/webMAN_MOD_Theme_inFamous_" + UI + ".pkg");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 16)
                {
                    try
                    {
                        iswebfree = false;
                        DownProgress.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + webman_themes);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/iOS_Theme_" + UI + ".pkg"), @"downloads/webMAN_MOD_Theme_iOS_" + UI + ".pkg");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 17)
                {
                    try
                    {
                        iswebfree = false;
                        DownProgress.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + webman_themes);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Rebug_Style_Theme_" + UI + ".pkg"), @"downloads/webMAN_MOD_Theme_REBUG-Style_" + UI + ".pkg");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 18)
                {
                    try
                    {
                        iswebfree = false;
                        DownProgress.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + webman_themes);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Red_DarkneSs_Theme_" + UI + ".pkg"), @"downloads/webMAN_MOD_Theme_Red-DarkneSs_" + UI + ".pkg");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 19)
                {
                    try
                    {
                        iswebfree = false;
                        DownProgress.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + webman_themes);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Steel_Style_Theme_" + UI + ".pkg"), @"downloads/webMAN_MOD_Theme_Steel-Style_" + UI + ".pkg");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 20)
                {
                    try
                    {
                        iswebfree = false;
                        DownProgress.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + managunz);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/ManaGunz_" + UI + ".pkg"), @"downloads/ManaGunZ_v" + UI + ".pkg");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 21)
                {
                    try
                    {
                        iswebfree = false;
                        DownProgress.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + artemis);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Artemis_" + UI + ".pkg"), @"downloads/Artemis_" + UI + ".pkg");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 22)
                {
                    try
                    {
                        iswebfree = false;
                        DownProgress.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + Irisman);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/IrisMAN_" + UI + ".pkg"), @"downloads/IrisMAN_v" + UI + ".pkg");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 23)
                {
                    try
                    {
                        iswebfree = false;
                        DownProgress.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + playmanager);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Play_Manager_" + UI + ".pkg"), @"downloads/Play Manager v" + UI + ".pkg");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 24)
                {
                    try
                    {
                        iswebfree = false;
                        DownProgress.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + gamesonic);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Gamesonic-Manager-" + UI + ".pkg"), @"downloads/Gamesonic Manager " + UI + ".pkg");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 25)
                {
                    try
                    {
                        iswebfree = false;
                        DownProgress.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + ccapi);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/CcApi_package_" + UI + ".rar"), @"downloads/Control Console API " + UI + ".rar");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 26)
                {
                    try
                    {
                        iswebfree = false;
                        DownProgress.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + sman);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/sMAN_v" + UI + ".rar"), @"downloads/sMAN v" + UI + ".rar");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 27)
                {
                    try
                    {
                        iswebfree = false;
                        DownProgress.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + multiman_singstar_cybm);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/mmSS-R-Cybm-build-" + UI + ".pkg"), @"downloads/MultiMAN Singstar Cybm Edition Build " + UI + ".pkg");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 28)
                {
                    try
                    {
                        iswebfree = false;
                        DownProgress.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + ps3ftp);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/OpenPS3FTP_v" + UI + ".zip"), @"downloads/OpenPS3FTP v" + UI + ".zip");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 29)
                {
                    try
                    {
                        iswebfree = false;
                        DownProgress.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + xmbm);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/XMBM+2k17-" + UI + ".pkg"), @"downloads/XMBM+ 2k17 " + UI + ".pkg");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit5.SelectedIndex == 30)
                {
                    try
                    {
                        iswebfree = false;
                        DownProgress.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URL + cfwex);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedHomeb);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/CFW_Extras_v" + UI + ".pkg"), @"downloads/CFW Extras Category v " + UI + ".pkg");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void FtpClient_OnUploadProgressChanged22(object sender, UploadProgressChangedArgs e)
        {
            progressBarControl9.Properties.Maximum = Convert.ToInt32(e.TotleBytes);
            progressBarControl9.EditValue = Convert.ToInt32(e.BytesUploaded);
            labelControl61.Text = e.TotleBytes.ToString();
            labelControl62.Text = e.BytesUploaded.ToString();
        }

        void FtpClient_OnUploadCompleted22(object sender, UploadCompletedArgs e)
        {
            if (XtraMessageBox.Show("Uploaded file to: " + textEdit4.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                progressBarControl9.EditValue = 0;
                labelControl61.Text = "...";
                labelControl62.Text = "...";
            }
        }

        private void COPY22(string source, string destination)
        {
            if (IsFile(source))
            {
                string target = Path.Combine(destination, Path.GetFileName(source));
                FtpClient.OnUploadProgressChanged += new FTPclient.UploadProgressChangedHandler(FtpClient_OnUploadProgressChanged22);
                FtpClient.OnUploadCompleted += new FTPclient.UploadCompletedHandler(FtpClient_OnUploadCompleted22);
                FtpClient.Upload(source, "\\" + target);
            }
        }

        void FtpClient_OnUploadProgressChanged(object sender, UploadProgressChangedArgs e)
        {
            DownProgress.Properties.Maximum = Convert.ToInt32(e.TotleBytes);
            DownProgress.EditValue = Convert.ToInt32(e.BytesUploaded);
            labelControl49.Text = e.TotleBytes.ToString();
            labelControl50.Text = e.BytesUploaded.ToString();
        }

        void FtpClient_OnUploadCompletedApp(object sender, UploadCompletedArgs e)
        {
            DownProgress.EditValue = 0;
            labelControl49.Text = "...";
            labelControl50.Text = "...";
        }

        void FtpClient_OnUploadProgressChangedTheme(object sender, UploadProgressChangedArgs e)
        {
            progressBarControl3.Properties.Maximum = Convert.ToInt32(e.TotleBytes);
            progressBarControl3.EditValue = Convert.ToInt32(e.BytesUploaded);
            labelControl52.Text = e.TotleBytes.ToString();
            labelControl51.Text = e.BytesUploaded.ToString();
        }

        void FtpClient_OnUploadCompletedTheme(object sender, UploadCompletedArgs e)
        {
            progressBarControl3.EditValue = 0;
            labelControl52.Text = "...";
            labelControl51.Text = "...";
        }

        void FtpClient_OnUploadProgressChangedMMTheme(object sender, UploadProgressChangedArgs e)
        {
            progressBarControl5.Properties.Maximum = Convert.ToInt32(e.TotleBytes);
            progressBarControl5.EditValue = Convert.ToInt32(e.BytesUploaded);
            labelControl56.Text = e.TotleBytes.ToString();
            labelControl55.Text = e.BytesUploaded.ToString();
        }

        void FtpClient_OnUploadCompletedMMTheme(object sender, UploadCompletedArgs e)
        {
            progressBarControl5.EditValue = 0;
            labelControl55.Text = "...";
            labelControl56.Text = "...";
        }

        private void COPY(string source, string destination, string type)
        {
            if (IsFile(source))
            {
                string target = Path.Combine(destination, Path.GetFileName(source));

                if (type == "App")
                {
                    FtpClient.OnUploadProgressChanged += new FTPclient.UploadProgressChangedHandler(FtpClient_OnUploadProgressChanged);
                    FtpClient.OnUploadCompleted += new FTPclient.UploadCompletedHandler(FtpClient_OnUploadCompletedApp);
                }
                else if (type == "Theme")
                {
                    FtpClient.OnUploadProgressChanged += new FTPclient.UploadProgressChangedHandler(FtpClient_OnUploadProgressChangedTheme);
                    FtpClient.OnUploadCompleted += new FTPclient.UploadCompletedHandler(FtpClient_OnUploadCompletedTheme);
                }
                else if (type == "MMTheme")
                {
                    FtpClient.OnUploadProgressChanged += new FTPclient.UploadProgressChangedHandler(FtpClient_OnUploadProgressChangedMMTheme);
                    FtpClient.OnUploadCompleted += new FTPclient.UploadCompletedHandler(FtpClient_OnUploadCompletedMMTheme);
                }

                FtpClient.Upload(source, "\\" + target);

                if (comboBoxEdit6.SelectedIndex == 2)
                {
                    XtraMessageBox.Show("Succesfully Uploaded! :) \nNow Restart your PS3 and enjoy your new Coldboot! ;)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (comboBoxEdit6.SelectedIndex == 3)
                {
                    XtraMessageBox.Show("Succesfully Uploaded! :) \nNow Restart your PS3 and enjoy your new XMB Wave! :)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (comboBoxEdit6.SelectedIndex == 4)
                {
                    XtraMessageBox.Show("Succesfully Uploaded! :) \nNow Restart your PS3 and enjoy your new PSN Logo! :)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (comboBoxEdit6.SelectedIndex == 5)
                {
                    XtraMessageBox.Show("Succesfully Uploaded! :) \nYour Package is ready to be installed from Install Package File. \nYou can delete it from dev_hdd0 / packages.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (comboBoxEdit6.SelectedIndex == 6)
                {
                    XtraMessageBox.Show("Succesfully Uploaded! :) \nYour new Theme is ready to be installed from the XMB Theme Settings :)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (comboBoxEdit6.SelectedIndex == 7)
                {
                    XtraMessageBox.Show("Succesfully Uploaded! :) \nYour new MultiMAN Theme is ready to be installed from the MultiMAN Theme Settings :)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                XtraMessageBox.Show("No File selected.. You have to select a .PKG File!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsFile(string path)
        {
            if ((File.GetAttributes(path) & FileAttributes.Directory) == FileAttributes.Directory)
                return false;
            return true;
        }

        private List<string> GetAllFileAndFolder(string path)
        {
            List<string> allFile = new List<string>();
            foreach (string dir in Directory.GetDirectories(path))
            {
                allFile.Add(dir);
            }
            foreach (string file in Directory.GetFiles(path))
            {
                allFile.Add(file);
            }

            return allFile;
        }

        private void simpleButton27_Click(object sender, EventArgs e)
        {
            if (ftpconnected == true)
            {
                comboBoxEdit6.SelectedIndex = 5;
                OpenFileDialog f = new OpenFileDialog();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    COPY(f.FileName, comboBoxEdit6.Text, "App");
                    labelControl48.Text = "Uploaded";
                }
            }
            else
            {
                XtraMessageBox.Show("To Upload files, you have to connect you PS3 via FTP. \nThe Connect FTP button is in the 'Connection & Homebrews' interface !!", "FTP Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton35_Click(object sender, EventArgs e)
        {
            simpleButton35.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            pictureBox21.Visible = false;
            pictureBox56.Visible = false;
            pictureBox70.Visible = false;
            pictureBox71.Visible = false;
            pictureBox72.Visible = false;
            pictureBox73.Visible = false;
            pictureBox74.Visible = false;
            pictureBox75.Visible = false;
            pictureBox76.Visible = false;
            pictureBox77.Visible = false;
            pictureBox78.Visible = false;
            pictureBox92.Visible = false;
            pictureBox93.Visible = false;
            pictureBox94.Visible = false;
            pictureBox95.Visible = false;
            pictureBox96.Visible = false;
            pictureBox97.Visible = false;
        }

        private void DownloadProgressWave(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBarControl1.EditValue = e.ProgressPercentage;
        }

        private void CompletedWave(object sender, AsyncCompletedEventArgs e)
        {
            if (XtraMessageBox.Show("Download Completed! \nNow you can Upload the Wave on your PS3 :)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                progressBarControl1.EditValue = 0;
            }
        }

        private void simpleButton31_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit6.SelectedIndex == 0)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Waves/Blue_Big/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 1)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Waves/Dancing_inthe_Dark_BG/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 2)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Waves/Dancing_inthe_Dark_Purple/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 3)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Waves/Electric_Blue_Purple/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 4)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Waves/Electric_Green_Yellow/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 5)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Waves/Fat_Glow_Dance_Purple/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 6)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Waves/Ghost_Blue_Yellow/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 7)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Waves/Ghost_Wave_v3/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 8)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Waves/Ghost_Wave/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 9)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Waves/Intense_Blue2Green/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 10)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Waves/Massive_Int_RednBlue/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 11)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Waves/Red_Smoke/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 12)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Waves/Super_Massive_Glow/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 13)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Waves/Z_Blue_Pink_Wow/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 14)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/Waves/electrica/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 15)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/Waves/fat_glow_blue/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 16)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/Waves/float_wave_blue/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 17)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/Waves/ghost_lonely_blue/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 18)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/Waves/ghost_remix/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 19)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/Waves/lonely_wave/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 20)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/Waves/purple_haze/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 21)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/Waves/red_dance/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 22)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/Waves/relax_wave/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 23)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/Waves/yellow/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 24)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Waves/Massive-blue/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 25)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Waves/OrangetoGreen/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 26)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Waves/Light-blue/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 27)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Waves/Old/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 28)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Waves/Blue-psiche/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit6.SelectedIndex == 29)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedWave);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressWave);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Waves/Violet-psiche/lines.qrc"), @"downloads/lines.qrc");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void simpleButton32_Click(object sender, EventArgs e)
        {
            comboBoxEdit6.SelectedIndex = 3;
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                COPY(f.FileName, comboBoxEdit6.Text, "Wave");
            }
        }

        private void simpleButton37_Click(object sender, EventArgs e)
        {
            simpleButton37.Visible = false;
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;
            pictureBox26.Visible = false;
            pictureBox27.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
            pictureBox30.Visible = false;
            pictureBox31.Visible = false;
            pictureBox32.Visible = false;
            pictureBox33.Visible = false;
            pictureBox34.Visible = false;
            pictureBox35.Visible = false;
            pictureBox36.Visible = false;
            pictureBox37.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox40.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox100.Visible = false;
            pictureBox101.Visible = false;
            pictureBox102.Visible = false;
            pictureBox120.Visible = false;
        }

        private void DownloadProgressCold(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBarControl2.EditValue = e.ProgressPercentage;
        }

        private void CompletedCold(object sender, AsyncCompletedEventArgs e)
        {
            if (XtraMessageBox.Show("Download Completed! \nNow you can Upload the Coldboot on your PS3 :)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                progressBarControl2.EditValue = 0;
            }
        }

        private void simpleButton30_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit7.SelectedIndex == 0)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedCold);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCold);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Coldboot/Akatsuki/coldboot.raf"), @"downloads/coldboot.raf");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit7.SelectedIndex == 1)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedCold);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCold);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Coldboot/apple/coldboot.raf"), @"downloads/coldboot.raf");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit7.SelectedIndex == 2)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedCold);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCold);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Coldboot/biohazard_aquila/coldboot.raf"), @"downloads/coldboot.raf");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit7.SelectedIndex == 3)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedCold);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCold);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Coldboot/green_bio/coldboot.raf"), @"downloads/coldboot.raf");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit7.SelectedIndex == 4)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedCold);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCold);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Coldboot/cfw_love/coldboot.raf"), @"downloads/coldboot.raf");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit7.SelectedIndex == 5)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedCold);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCold);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Coldboot/ted_the_bear/coldboot.raf"), @"downloads/coldboot.raf");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit7.SelectedIndex == 6)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedCold);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCold);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Coldboot/farfalla/coldboot.raf"), @"downloads/coldboot.raf");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit7.SelectedIndex == 7)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedCold);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCold);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Coldboot/fuck_policies/coldboot.raf"), @"downloads/coldboot.raf");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit7.SelectedIndex == 8)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedCold);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCold);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Coldboot/anime/coldboot.raf"), @"downloads/coldboot.raf");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit7.SelectedIndex == 9)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedCold);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCold);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Coldboot/itachi/coldboot.raf"), @"downloads/coldboot.raf");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit7.SelectedIndex == 10)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedCold);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCold);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Coldboot/kushmode/coldboot.raf"), @"downloads/coldboot.raf");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit7.SelectedIndex == 11)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedCold);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCold);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Coldboot/legalize/coldboot.raf"), @"downloads/coldboot.raf");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit7.SelectedIndex == 12)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedCold);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCold);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Coldboot/madara/coldboot.raf"), @"downloads/coldboot.raf");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit7.SelectedIndex == 13)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedCold);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCold);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Coldboot/minato/coldboot.raf"), @"downloads/coldboot.raf");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit7.SelectedIndex == 14)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedCold);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCold);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Coldboot/naruto/coldboot.raf"), @"downloads/coldboot.raf");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit7.SelectedIndex == 15)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedCold);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCold);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Coldboot/obito/coldboot.raf"), @"downloads/coldboot.raf");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit7.SelectedIndex == 16)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedCold);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCold);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Coldboot/rebug_logo/coldboot.raf"), @"downloads/coldboot.raf");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit7.SelectedIndex == 17)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedCold);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCold);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Coldboot/skeleton/coldboot.raf"), @"downloads/coldboot.raf");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit7.SelectedIndex == 18)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedCold);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCold);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Coldboot/sony_cant_stop/coldboot.raf"), @"downloads/coldboot.raf");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit7.SelectedIndex == 19)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedCold);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCold);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrew355.altervista.org/downloads/LezZo_Tool/Coldboot/zombies/coldboot.raf"), @"downloads/coldboot.raf");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit7.SelectedIndex == 20)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedCold);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCold);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Coldboot/Skrubz/coldboot.raf"), @"downloads/coldboot.raf");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit7.SelectedIndex == 21)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedCold);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCold);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Coldboot/States_Army/coldboot.raf"), @"downloads/coldboot.raf");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit7.SelectedIndex == 22)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedCold);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCold);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Coldboot/RastaMan/coldboot.raf"), @"downloads/coldboot.raf");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit7.SelectedIndex == 23)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedCold);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCold);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Coldboot/REBUG_MOD/coldboot.raf"), @"downloads/coldboot.raf");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            comboBoxEdit6.SelectedIndex = 2;
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                COPY(f.FileName, comboBoxEdit6.Text, "Coldboot");
            }
        }

        private void simpleButton33_Click(object sender, EventArgs e)
        {
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox47.Visible = false;
            pictureBox48.Visible = false;
            pictureBox49.Visible = false;
            pictureBox50.Visible = false;
            pictureBox51.Visible = false;
            pictureBox52.Visible = false;
            pictureBox53.Visible = false;
            pictureBox54.Visible = false;
            pictureBox55.Visible = false;
            simpleButton33.Visible = false;
        }

        private void DownloadProgressTheme(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBarControl3.EditValue = e.ProgressPercentage;
            labelControl51.Text = e.TotalBytesToReceive.ToString();
            labelControl50.Text = e.BytesReceived.ToString();
        }

        private void CompletedTheme(object sender, AsyncCompletedEventArgs e)
        {
            if (XtraMessageBox.Show("Download Completed! \nNow you can Upload the Theme on your PS3 :)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                progressBarControl3.EditValue = 0;
                iswebfree = true;
                labelControl51.Text = "...";
                labelControl50.Text = "...";
            }
        }

        private void simpleButton36_Click(object sender, EventArgs e)
        {
            if (IsWebCFree() == true)
            {
                labelControl53.Text = "Download";
                if (comboBoxEdit9.SelectedIndex == 0)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedTheme);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressTheme);
                        webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/xmb_themes/Anonymous.p3t"), @"downloads/Anonymous_Dynamic.p3t");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit9.SelectedIndex == 1)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedTheme);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressTheme);
                        webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/xmb_themes/apple.p3t"), @"downloads/Apple.p3t");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit9.SelectedIndex == 2)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedTheme);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressTheme);
                        webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/xmb_themes/Bloodborne.p3t"), @"downloads/Bloodborne.p3t");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit9.SelectedIndex == 3)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedTheme);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressTheme);
                        webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/xmb_themes/Cybermodding.p3t"), @"downloads/Cybermodding_Animated.p3t");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit9.SelectedIndex == 4)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedTheme);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressTheme);
                        webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/xmb_themes/DK_Media_Home.p3t"), @"downloads/DK_MediaHome.p3t");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit9.SelectedIndex == 5)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedTheme);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressTheme);
                        webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/xmb_themes/Heavy_Rain.p3t"), @"downloads/Heavy_Rain_Dynamic.p3t");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit9.SelectedIndex == 6)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedTheme);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressTheme);
                        webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/xmb_themes/Matrix_Code.p3t"), @"downloads/Hacking_Dynamic.p3t");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit9.SelectedIndex == 7)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedTheme);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressTheme);
                        webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/xmb_themes/Nazi_Zombie.p3t"), @"downloads/Nazi_Zombie.p3t");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit9.SelectedIndex == 8)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedTheme);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressTheme);
                        webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/xmb_themes/ps4_xmb.p3t"), @"downloads/PS4_XMB.p3t");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit9.SelectedIndex == 9)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedTheme);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressTheme);
                        webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/xmb_themes/Rebug_Dynamic.p3t"), @"downloads/Rebug_Dynamic.p3t");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit9.SelectedIndex == 10)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedTheme);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressTheme);
                        webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/xmb_themes/The_Matrix_Dynamic.p3t"), @"downloads/The_Matrix_Code.p3t");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit9.SelectedIndex == 11)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedTheme);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressTheme);
                        webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/xmb_themes/the_president.p3t"), @"downloads/The_President_Reloaded.p3t");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit9.SelectedIndex == 12)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedTheme);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressTheme);
                        webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/xmb_themes/Weed.p3t"), @"downloads/Weed_PS3.p3t");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton34_Click(object sender, EventArgs e)
        {
            if (ftpconnected == true)
            {
                comboBoxEdit6.SelectedIndex = 6;
                OpenFileDialog f = new OpenFileDialog();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    labelControl53.Text = "Upload";
                    COPY(f.FileName, comboBoxEdit6.Text, "Theme");
                }
            }
            else
            {
                XtraMessageBox.Show("To Upload files, you have to connect you PS3 via FTP. \nThe Connect FTP button is in the 'Connection & Homebrews' interface !!", "FTP Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void simpleButton40_Click(object sender, EventArgs e)
        {
            simpleButton40.Visible = false;
            pictureBox57.Visible = false;
            pictureBox58.Visible = false;
            pictureBox59.Visible = false;
            pictureBox60.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox63.Visible = false;
            pictureBox64.Visible = false;
            pictureBox65.Visible = false;
            pictureBox66.Visible = false;
            pictureBox67.Visible = false;
            pictureBox68.Visible = false;
            pictureBox69.Visible = false;
            pictureBox103.Visible = false;
            pictureBox104.Visible = false;
            pictureBox105.Visible = false;
            pictureBox106.Visible = false;
            pictureBox107.Visible = false;
            pictureBox121.Visible = false;
        }

        private void DownloadProgressPsnIcons(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBarControl4.EditValue = e.ProgressPercentage;
        }

        private void CompletedPsnIcons(object sender, AsyncCompletedEventArgs e)
        {
            if (XtraMessageBox.Show("Download Completed! \nNow you can Upload the PSN Icon on your PS3 :)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                progressBarControl4.EditValue = 0;
            }
        }

        private void simpleButton39_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit10.SelectedIndex == 0)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedPsnIcons);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressPsnIcons);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/psn_logo/Anonymous/xmb_plugin_normal.rco"), @"downloads/xmb_plugin_normal.rco");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit10.SelectedIndex == 1)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedPsnIcons);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressPsnIcons);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/psn_logo//Black_Blue/xmb_plugin_normal.rco"), @"downloads/xmb_plugin_normal.rco");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit10.SelectedIndex == 2)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedPsnIcons);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressPsnIcons);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/psn_logo/Gold/xmb_plugin_normal.rco"), @"downloads/xmb_plugin_normal.rco");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit10.SelectedIndex == 3)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedPsnIcons);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressPsnIcons);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/psn_logo/Grey/xmb_plugin_normal.rco"), @"downloads/xmb_plugin_normal.rco");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit10.SelectedIndex == 4)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedPsnIcons);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressPsnIcons);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/psn_logo/Pink/xmb_plugin_normal.rco"), @"downloads/xmb_plugin_normal.rco");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit10.SelectedIndex == 5)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedPsnIcons);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressPsnIcons);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/psn_logo/Psn_stuff/xmb_plugin_normal.rco"), @"downloads/xmb_plugin_normal.rco");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit10.SelectedIndex == 6)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedPsnIcons);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressPsnIcons);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/psn_logo/Psn_tool/xmb_plugin_normal.rco"), @"downloads/xmb_plugin_normal.rco");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit10.SelectedIndex == 7)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedPsnIcons);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressPsnIcons);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/psn_logo/Purple/xmb_plugin_normal.rco"), @"downloads/xmb_plugin_normal.rco");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit10.SelectedIndex == 8)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedPsnIcons);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressPsnIcons);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/psn_logo/Red/xmb_plugin_normal.rco"), @"downloads/xmb_plugin_normal.rco");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit10.SelectedIndex == 9)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedPsnIcons);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressPsnIcons);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/psn_logo/Silver_Ball/xmb_plugin_normal.rco"), @"downloads/xmb_plugin_normal.rco");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit10.SelectedIndex == 10)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedPsnIcons);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressPsnIcons);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/psn_logo/UltraBlue/xmb_plugin_normal.rco"), @"downloads/xmb_plugin_normal.rco");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit10.SelectedIndex == 11)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedPsnIcons);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressPsnIcons);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/psn_logo/Weed/xmb_plugin_normal.rco"), @"downloads/xmb_plugin_normal.rco");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit10.SelectedIndex == 12)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedPsnIcons);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressPsnIcons);
                    webClient.DownloadFileAsync(new Uri("http://www.homebrewsrv.altervista.org/LezZo_Tool/psn_logo/Zombie_Troll/xmb_plugin_normal.rco"), @"downloads/xmb_plugin_normal.rco");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit10.SelectedIndex == 13)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedPsnIcons);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressPsnIcons);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Psn_icons/GoldBlack/xmb_plugin_normal.rco"), @"downloads/xmb_plugin_normal.rco");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit10.SelectedIndex == 14)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedPsnIcons);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressPsnIcons);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Psn_icons/Rebug/xmb_plugin_normal.rco"), @"downloads/xmb_plugin_normal.rco");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit10.SelectedIndex == 15)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedPsnIcons);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressPsnIcons);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Psn_icons/Skull/xmb_plugin_normal.rco"), @"downloads/xmb_plugin_normal.rco");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit10.SelectedIndex == 16)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedPsnIcons);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressPsnIcons);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Psn_icons/Slim_purple/xmb_plugin_normal.rco"), @"downloads/xmb_plugin_normal.rco");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit10.SelectedIndex == 17)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedPsnIcons);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressPsnIcons);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Psn_icons/Slim_red/xmb_plugin_normal.rco"), @"downloads/xmb_plugin_normal.rco");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit10.SelectedIndex == 18)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedPsnIcons);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressPsnIcons);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Psn_icons/Rebug_Mod/xmb_plugin_normal.rco"), @"downloads/xmb_plugin_normal.rco");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void simpleButton38_Click(object sender, EventArgs e)
        {
            comboBoxEdit6.SelectedIndex = 4;
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                COPY(f.FileName, comboBoxEdit6.Text, "PSNLogo");
            }
        }

        private void comboBoxEdit10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit10.SelectedIndex == 0)
            {
                simpleButton40.Visible = true;
                pictureBox57.Visible = true;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox121.Visible = false;
            }
            if (comboBoxEdit10.SelectedIndex == 1)
            {
                simpleButton40.Visible = true;
                pictureBox57.Visible = false;
                pictureBox58.Visible = true;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox121.Visible = false;
            }
            if (comboBoxEdit10.SelectedIndex == 2)
            {
                simpleButton40.Visible = true;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = true;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox121.Visible = false;
            }
            if (comboBoxEdit10.SelectedIndex == 3)
            {
                simpleButton40.Visible = true;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = true;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox121.Visible = false;
            }
            if (comboBoxEdit10.SelectedIndex == 4)
            {
                simpleButton40.Visible = true;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = true;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox121.Visible = false;
            }
            if (comboBoxEdit10.SelectedIndex == 5)
            {
                simpleButton40.Visible = true;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = true;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox121.Visible = false;
            }
            if (comboBoxEdit10.SelectedIndex == 6)
            {
                simpleButton40.Visible = true;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = true;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox121.Visible = false;
            }
            if (comboBoxEdit10.SelectedIndex == 7)
            {
                simpleButton40.Visible = true;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = true;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox121.Visible = false;
            }
            if (comboBoxEdit10.SelectedIndex == 8)
            {
                simpleButton40.Visible = true;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = true;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox121.Visible = false;
            }
            if (comboBoxEdit10.SelectedIndex == 9)
            {
                simpleButton40.Visible = true;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = true;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox121.Visible = false;
            }
            if (comboBoxEdit10.SelectedIndex == 10)
            {
                simpleButton40.Visible = true;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = true;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox121.Visible = false;
            }
            if (comboBoxEdit10.SelectedIndex == 11)
            {
                simpleButton40.Visible = true;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = true;
                pictureBox69.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox121.Visible = false;
            }
            if (comboBoxEdit10.SelectedIndex == 12)
            {
                simpleButton40.Visible = true;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = true;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox121.Visible = false;
            }
            if (comboBoxEdit10.SelectedIndex == 13)
            {
                simpleButton40.Visible = true;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox103.Visible = true;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox121.Visible = false;
            }
            if (comboBoxEdit10.SelectedIndex == 14)
            {
                simpleButton40.Visible = true;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = true;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox121.Visible = false;
            }
            if (comboBoxEdit10.SelectedIndex == 15)
            {
                simpleButton40.Visible = true;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = true;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox121.Visible = false;
            }
            if (comboBoxEdit10.SelectedIndex == 16)
            {
                simpleButton40.Visible = true;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = true;
                pictureBox107.Visible = false;
                pictureBox121.Visible = false;
            }
            if (comboBoxEdit10.SelectedIndex == 17)
            {
                simpleButton40.Visible = true;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = true;
                pictureBox121.Visible = false;
            }
            if (comboBoxEdit10.SelectedIndex == 17)
            {
                simpleButton40.Visible = true;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox121.Visible = true;
            }
        }

        private void comboBoxEdit9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit9.SelectedIndex == 0)
            {
                simpleButton33.Visible = true;
                pictureBox43.Visible = true;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
            }
            if (comboBoxEdit9.SelectedIndex == 1)
            {
                simpleButton33.Visible = true;
                pictureBox43.Visible = false;
                pictureBox44.Visible = true;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
            }
            if (comboBoxEdit9.SelectedIndex == 2)
            {
                simpleButton33.Visible = true;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = true;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
            }
            if (comboBoxEdit9.SelectedIndex == 3)
            {
                simpleButton33.Visible = true;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = true;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
            }
            if (comboBoxEdit9.SelectedIndex == 4)
            {
                simpleButton33.Visible = true;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = true;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
            }
            if (comboBoxEdit9.SelectedIndex == 5)
            {
                simpleButton33.Visible = true;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = true;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
            }
            if (comboBoxEdit9.SelectedIndex == 6)
            {
                simpleButton33.Visible = true;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = true;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
            }
            if (comboBoxEdit9.SelectedIndex == 7)
            {
                simpleButton33.Visible = true;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = true;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
            }
            if (comboBoxEdit9.SelectedIndex == 8)
            {
                simpleButton33.Visible = true;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = true;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
            }
            if (comboBoxEdit9.SelectedIndex == 9)
            {
                simpleButton33.Visible = true;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = true;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
            }
            if (comboBoxEdit9.SelectedIndex == 10)
            {
                simpleButton33.Visible = true;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = true;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
            }
            if (comboBoxEdit9.SelectedIndex == 11)
            {
                simpleButton33.Visible = true;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = true;
                pictureBox55.Visible = false;
            }
            if (comboBoxEdit9.SelectedIndex == 12)
            {
                simpleButton33.Visible = true;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = true;
            }
        }

        private void comboBoxEdit8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit8.SelectedIndex == 0)
            {
                simpleButton37.Visible = true;
                pictureBox23.Visible = true;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox120.Visible = false;
            }
            if (comboBoxEdit8.SelectedIndex == 1)
            {
                simpleButton37.Visible = true;
                pictureBox23.Visible = false;
                pictureBox24.Visible = true;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox120.Visible = false;
            }
            if (comboBoxEdit8.SelectedIndex == 2)
            {
                simpleButton37.Visible = true;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = true;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox120.Visible = false;
            }
            if (comboBoxEdit8.SelectedIndex == 3)
            {
                simpleButton37.Visible = true;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = true;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox120.Visible = false;
            }
            if (comboBoxEdit8.SelectedIndex == 4)
            {
                simpleButton37.Visible = true;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = true;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox120.Visible = false;
            }
            if (comboBoxEdit8.SelectedIndex == 5)
            {
                simpleButton37.Visible = true;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = true;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox120.Visible = false;
            }
            if (comboBoxEdit8.SelectedIndex == 6)
            {
                simpleButton37.Visible = true;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = true;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox120.Visible = false;
            }
            if (comboBoxEdit8.SelectedIndex == 7)
            {
                simpleButton37.Visible = true;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = true;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox120.Visible = false;
            }
            if (comboBoxEdit8.SelectedIndex == 8)
            {
                simpleButton37.Visible = true;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = true;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox120.Visible = false;
            }
            if (comboBoxEdit8.SelectedIndex == 9)
            {
                simpleButton37.Visible = true;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = true;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox120.Visible = false;
            }
            if (comboBoxEdit8.SelectedIndex == 10)
            {
                simpleButton37.Visible = true;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = true;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox120.Visible = false;
            }
            if (comboBoxEdit8.SelectedIndex == 11)
            {
                simpleButton37.Visible = true;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = true;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox120.Visible = false;
            }
            if (comboBoxEdit8.SelectedIndex == 12)
            {
                simpleButton37.Visible = true;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = true;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox120.Visible = false;
            }
            if (comboBoxEdit8.SelectedIndex == 13)
            {
                simpleButton37.Visible = true;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = true;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox120.Visible = false;
            }
            if (comboBoxEdit8.SelectedIndex == 14)
            {
                simpleButton37.Visible = true;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = true;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox120.Visible = false;
            }
            if (comboBoxEdit8.SelectedIndex == 15)
            {
                simpleButton37.Visible = true;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = true;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox120.Visible = false;
            }
            if (comboBoxEdit8.SelectedIndex == 16)
            {
                simpleButton37.Visible = true;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = true;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox120.Visible = false;
            }
            if (comboBoxEdit8.SelectedIndex == 17)
            {
                simpleButton37.Visible = true;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = true;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox120.Visible = false;
            }
            if (comboBoxEdit8.SelectedIndex == 18)
            {
                simpleButton37.Visible = true;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = true;
                pictureBox42.Visible = false;
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox120.Visible = false;
            }
            if (comboBoxEdit8.SelectedIndex == 19)
            {
                simpleButton37.Visible = true;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = true;
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox120.Visible = false;
            }
            if (comboBoxEdit8.SelectedIndex == 20)
            {
                simpleButton37.Visible = true;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox100.Visible = true;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox120.Visible = false;
            }
            if (comboBoxEdit8.SelectedIndex == 21)
            {
                simpleButton37.Visible = true;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox100.Visible = false;
                pictureBox101.Visible = true;
                pictureBox102.Visible = false;
                pictureBox120.Visible = false;
            }
            if (comboBoxEdit8.SelectedIndex == 22)
            {
                simpleButton37.Visible = true;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = true;
                pictureBox120.Visible = false;
            }
            if (comboBoxEdit8.SelectedIndex == 23)
            {
                simpleButton37.Visible = true;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox120.Visible = true;
            }
        }

        private void comboBoxEdit7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit7.SelectedIndex == 0)
            {
                simpleButton35.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 1)
            {
                simpleButton35.Visible = true;
                pictureBox8.Visible = false;
                pictureBox9.Visible = true;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 2)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = true;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                simpleButton35.Visible = true;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 3)
            {
                simpleButton35.Visible = true;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = true;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 4)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = true;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                simpleButton35.Visible = true;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 5)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = true;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                simpleButton35.Visible = true;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 6)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = true;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                simpleButton35.Visible = true;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 7)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = true;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                simpleButton35.Visible = true;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 8)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = true;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                simpleButton35.Visible = true;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 9)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = true;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                simpleButton35.Visible = true;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 10)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = true;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                simpleButton35.Visible = true;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 11)
            {
                simpleButton35.Visible = true;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = true;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 12)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = true;
                simpleButton35.Visible = true;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 13)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                simpleButton35.Visible = true;
                pictureBox21.Visible = true;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }

            if (comboBoxEdit7.SelectedIndex == 14)
            {
                simpleButton35.Visible = true;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox56.Visible = true;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 15)
            {
                simpleButton35.Visible = true;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = true;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 16)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                simpleButton35.Visible = true;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = true;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 17)
            {
                simpleButton35.Visible = true;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = true;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 18)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                simpleButton35.Visible = true;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = true;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 19)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                simpleButton35.Visible = true;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = true;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 20)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                simpleButton35.Visible = true;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = true;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 21)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                simpleButton35.Visible = true;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = true;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 22)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                simpleButton35.Visible = true;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = true;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 23)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                simpleButton35.Visible = true;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = true;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 24)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                simpleButton35.Visible = true;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = true;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 25)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                simpleButton35.Visible = true;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = true;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 26)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                simpleButton35.Visible = true;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = true;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 27)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                simpleButton35.Visible = true;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = true;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 28)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                simpleButton35.Visible = true;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = true;
                pictureBox97.Visible = false;
            }
            if (comboBoxEdit7.SelectedIndex == 29)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                simpleButton35.Visible = true;
                pictureBox21.Visible = false;
                pictureBox56.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = true;
            }
        }

        private void comboBoxEdit5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit5.SelectedIndex == 0)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                simpleButton1.Visible = true;
                pictureBox119.Visible = false;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 1)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                simpleButton1.Visible = true;
                pictureBox119.Visible = false;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 2)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
                simpleButton1.Visible = true;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 3)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
                simpleButton1.Visible = true;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 4)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
                simpleButton1.Visible = true;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 5)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
                simpleButton1.Visible = true;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 6)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                simpleButton1.Visible = true;
                pictureBox119.Visible = false;
                pictureBox118.Visible = false;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 7)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                simpleButton1.Visible = true;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 8)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                simpleButton1.Visible = true;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 9)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = true;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox118.Visible = false;
                pictureBox117.Visible = false;
                pictureBox119.Visible = false;
                simpleButton1.Visible = true;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 10)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = true;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
                simpleButton1.Visible = true;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 11)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = true;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
                simpleButton1.Visible = true;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 12)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = true;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                simpleButton1.Visible = true;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 13)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = true;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
                simpleButton1.Visible = true;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 14)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = true;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
                simpleButton1.Visible = true;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 15)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = true;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                simpleButton1.Visible = true;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 16)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = true;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
                simpleButton1.Visible = true;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 17)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = true;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
                simpleButton1.Visible = true;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 18)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = true;
                pictureBox117.Visible = false;
                simpleButton1.Visible = true;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 19)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = true;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
                simpleButton1.Visible = true;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 20)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = true;
                pictureBox119.Visible = false;
                simpleButton1.Visible = true;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 21)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = true;
                simpleButton1.Visible = true;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 22)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
                simpleButton1.Visible = true;
                pictureBox122.Visible = true;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 23)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
                simpleButton1.Visible = true;
                pictureBox122.Visible = false;
                pictureBox123.Visible = true;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 24)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
                simpleButton1.Visible = true;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = true;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 25)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
                simpleButton1.Visible = true;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = true;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 26)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
                simpleButton1.Visible = true;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = true;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 27)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
                simpleButton1.Visible = true;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = true;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 28)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
                simpleButton1.Visible = true;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = true;
                pictureBox129.Visible = false;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 29)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
                simpleButton1.Visible = true;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = true;
                pictureBox130.Visible = false;
            }
            if (comboBoxEdit5.SelectedIndex == 30)
            {
                simpleButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox22.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
                simpleButton1.Visible = true;
                pictureBox122.Visible = false;
                pictureBox123.Visible = false;
                pictureBox124.Visible = false;
                pictureBox125.Visible = false;
                pictureBox126.Visible = false;
                pictureBox127.Visible = false;
                pictureBox128.Visible = false;
                pictureBox129.Visible = false;
                pictureBox130.Visible = true;
            }
        }

        private void simpleButton41_Click(object sender, EventArgs e)
        {
            simpleButton10.Visible = false;
            pictureBox79.Visible = false;
            pictureBox80.Visible = false;
            pictureBox81.Visible = false;
            pictureBox82.Visible = false;
            pictureBox83.Visible = false;
            pictureBox84.Visible = false;
            pictureBox85.Visible = false;
            pictureBox86.Visible = false;
            pictureBox87.Visible = false;
            pictureBox88.Visible = false;
            pictureBox89.Visible = false;
            pictureBox90.Visible = false;
            pictureBox91.Visible = false;
        }

        private void comboBoxEdit4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit4.SelectedIndex == 0)
            {
                simpleButton41.Visible = true;
                pictureBox79.Visible = true;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 1)
            {
                simpleButton41.Visible = true;
                pictureBox79.Visible = false;
                pictureBox80.Visible = true;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 2)
            {
                simpleButton41.Visible = true;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = true;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 3)
            {
                simpleButton41.Visible = true;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = true;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 4)
            {
                simpleButton41.Visible = true;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = true;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 5)
            {
                simpleButton41.Visible = true;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = true;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 6)
            {
                simpleButton41.Visible = true;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = true;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 7)
            {
                simpleButton41.Visible = true;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = true;
                pictureBox87.Visible = false;
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 8)
            {
                simpleButton41.Visible = true;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = true;
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 9)
            {
                simpleButton41.Visible = true;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
                pictureBox88.Visible = true;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 10)
            {
                simpleButton41.Visible = true;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
                pictureBox88.Visible = false;
                pictureBox89.Visible = true;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 11)
            {
                simpleButton41.Visible = true;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = true;
                pictureBox91.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 12)
            {
                simpleButton41.Visible = true;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = true;
            }
        }

        private void comboBoxEdit11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit11.SelectedIndex == 0)
            {
                simpleButton41.Visible = true;
                pictureBox79.Visible = true;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
            }
            if (comboBoxEdit11.SelectedIndex == 1)
            {
                simpleButton41.Visible = true;
                pictureBox79.Visible = false;
                pictureBox80.Visible = true;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
            }
            if (comboBoxEdit11.SelectedIndex == 2)
            {
                simpleButton41.Visible = true;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = true;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
            }
            if (comboBoxEdit11.SelectedIndex == 3)
            {
                simpleButton41.Visible = true;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = true;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
            }
            if (comboBoxEdit11.SelectedIndex == 4)
            {
                simpleButton41.Visible = true;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = true;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
            }
            if (comboBoxEdit11.SelectedIndex == 5)
            {
                simpleButton41.Visible = true;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = true;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
            }
            if (comboBoxEdit11.SelectedIndex == 6)
            {
                simpleButton41.Visible = true;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = true;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
            }
            if (comboBoxEdit11.SelectedIndex == 7)
            {
                simpleButton41.Visible = true;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = true;
                pictureBox87.Visible = false;
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
            }
            if (comboBoxEdit11.SelectedIndex == 8)
            {
                simpleButton41.Visible = true;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = true;
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
            }
            if (comboBoxEdit11.SelectedIndex == 9)
            {
                simpleButton41.Visible = true;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
                pictureBox88.Visible = true;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
            }
            if (comboBoxEdit11.SelectedIndex == 10)
            {
                simpleButton41.Visible = true;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
                pictureBox88.Visible = false;
                pictureBox89.Visible = true;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
            }
            if (comboBoxEdit11.SelectedIndex == 11)
            {
                simpleButton41.Visible = true;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = true;
                pictureBox91.Visible = false;
            }
            if (comboBoxEdit11.SelectedIndex == 12)
            {
                simpleButton41.Visible = true;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = true;
            }
        }

        private void DownloadProgressmmTheme(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBarControl5.EditValue = e.ProgressPercentage;
            labelControl56.Text = e.TotalBytesToReceive.ToString();
            labelControl55.Text = e.BytesReceived.ToString();
        }

        private void CompletedmmTheme(object sender, AsyncCompletedEventArgs e)
        {
            if (XtraMessageBox.Show("Download Completed! \nNow you can Upload the Theme on your PS3 :)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                progressBarControl5.EditValue = 0;
                iswebfree = true;
                labelControl56.Text = "...";
                labelControl55.Text = "...";
            }
        }

        private void simpleButton43_Click(object sender, EventArgs e)
        {
            if (IsWebCFree() == true)
            {
                labelControl57.Text = "Download";
                if (comboBoxEdit11.SelectedIndex == 0)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedmmTheme);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressmmTheme);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/mm_theme/mmCM-anonymous.thm"), @"downloads/mmCM-Anonymous.thm");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit11.SelectedIndex == 1)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedmmTheme);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressmmTheme);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/mm_theme/mmCM-arch.thm"), @"downloads/mmCM-Arch.thm");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit11.SelectedIndex == 2)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedmmTheme);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressmmTheme);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/mm_theme/mmCM-basic.thm"), @"downloads/mmCM-Basic.thm");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit11.SelectedIndex == 3)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedmmTheme);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressmmTheme);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/mm_theme/mmCM-gloss.thm"), @"downloads/mmCM-Gloss.thm");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit11.SelectedIndex == 4)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedmmTheme);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressmmTheme);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/mm_theme/mmCM-hypnotic.thm"), @"downloads/mmCM-Hypnotic.thm");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit11.SelectedIndex == 5)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedmmTheme);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressmmTheme);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/mm_theme/mmCM-louise.thm"), @"downloads/mmCM-Louise.thm");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit11.SelectedIndex == 6)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedmmTheme);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressmmTheme);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/mm_theme/mmCM-matrix.thm"), @"downloads/mmCM-Matrix.thm");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit11.SelectedIndex == 7)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedmmTheme);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressmmTheme);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/mm_theme/mmCM-metal.thm"), @"downloads/mmCM-Metal.thm");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit11.SelectedIndex == 8)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedmmTheme);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressmmTheme);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/mm_theme/mmCM-network.thm"), @"downloads/mmCM-Network.thm");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit11.SelectedIndex == 9)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedmmTheme);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressmmTheme);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/mm_theme/mmCM-rebug.thm"), @"downloads/mmCM-Rebug.thm");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit11.SelectedIndex == 10)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedmmTheme);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressmmTheme);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/mm_theme/mmCM-saturation.thm"), @"downloads/mmCM-Saturation.thm");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit11.SelectedIndex == 11)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedmmTheme);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressmmTheme);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/mm_theme/mmCM-space.thm"), @"downloads/mmCM-Space.thm");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit11.SelectedIndex == 12)
                {
                    try
                    {
                        iswebfree = false;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedmmTheme);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressmmTheme);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/mm_theme/mmCM-ztitus.thm"), @"downloads/mmCM-Ztitus.thm");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton42_Click(object sender, EventArgs e)
        {
            if (ftpconnected == true)
            {
                comboBoxEdit6.SelectedIndex = 7;
                OpenFileDialog f = new OpenFileDialog();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    labelControl53.Text = "Upload";
                    COPY(f.FileName, comboBoxEdit6.Text, "MMTheme");
                }
            }
            else
            {
                XtraMessageBox.Show("To Upload files, you have to connect you PS3 via FTP. \nThe Connect FTP button is in the 'Connection & Homebrews' interface !!", "FTP Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton44_Click(object sender, EventArgs e)
        {
            if (ftpconnected == true)
            {
                OpenFileDialog f = new OpenFileDialog();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    COPY22(f.FileName, textEdit4.Text);
                }
            }
            else
            {
                XtraMessageBox.Show("To Upload files, you have to connect you PS3 via FTP. \nThe Connect FTP button is in the 'Connection & Homebrews' interface !!", "FTP Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            
        }

        private void comboBoxEdit12_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit12.SelectedIndex == 0)
            {
                labelControl33.Text = "e07d2b84c9e9691c261b73e5f1aada20";
            }
            if (comboBoxEdit12.SelectedIndex == 1)
            {
                labelControl33.Text = "ca595ad9f3af8f1491d9c9b6921a8c61";
            }
            if (comboBoxEdit12.SelectedIndex == 2)
            {
                labelControl33.Text = "2c7ac82e02db9ce396618e6644a8c52d";
            }
            if (comboBoxEdit12.SelectedIndex == 3)
            {
                labelControl33.Text = "b2483b4abc157494447c9c409c036041";
            }
        }

        private void comboBoxEdit13_SelectedIndexChanged(object sender, EventArgs e)
        {
            string md5ferroxst = "md5ferroxst.txt";
            string md5ferroxcbr = "md5ferroxcbr.txt";
            string md5ferroxnobd = "md5ferroxnobd.txt";
            string md5rebugrex = "md5rebugrex.txt";
            string md5rebugdrex = "md5rebugdrex.txt";
            string md5rebugmod = "md5rebugmod.txt";
            string md5habibcbr = "md5habibcbr.txt";
            string md5ps3ita = "md5ps3ita.txt";
            string md5playerkpst = "md5playerkpst.txt";
            string md5playerkpcbr = "md5playerkpcbr.txt";
            string md5playerkpdb = "md5playerkpdb.txt";
            string md5darknetst = "md5darknetst.txt";
            string md5darknetcbr = "md5darknetcbr.txt";

            if (comboBoxEdit13.SelectedIndex == 0)
            {
                labelControl33.Text = "46541c4f97604068c05e363412478df5";
            }
            if (comboBoxEdit13.SelectedIndex == 1)
            {
                labelControl33.Text = "06aa0e07af7ead6e7e4bddf18ea3281f";
            }
            if (comboBoxEdit13.SelectedIndex == 2)
            {
                labelControl33.Text = "b67747f529d047d63151786544a58b50";
            }
            if (comboBoxEdit13.SelectedIndex == 3)
            {
                labelControl33.Text = "ed3403ff96048a4ds2037de013372a02";
            }

            if (comboBoxEdit13.SelectedIndex == 4)
            {
                WebClient wc = new WebClient();
                var md5 = wc.DownloadString(URL + md5ferroxst);
                labelControl33.Text = md5;
            }
            if (comboBoxEdit13.SelectedIndex == 5)
            {
                WebClient wc = new WebClient();
                var md5 = wc.DownloadString(URL + md5ferroxcbr);
                labelControl33.Text = md5;
            }
            if (comboBoxEdit13.SelectedIndex == 6)
            {
                WebClient wc = new WebClient();
                var md5 = wc.DownloadString(URL + md5ferroxnobd);
                labelControl33.Text = md5;
            }
            if (comboBoxEdit13.SelectedIndex == 7)
            {
                WebClient wc = new WebClient();
                var md5 = wc.DownloadString(URL + md5rebugrex);
                labelControl33.Text = md5;
            }
            if (comboBoxEdit13.SelectedIndex == 8)
            {
                WebClient wc = new WebClient();
                var md5 = wc.DownloadString(URL + md5rebugdrex);
                labelControl33.Text = md5;
            }
            if (comboBoxEdit13.SelectedIndex == 9)
            {
                WebClient wc = new WebClient();
                var md5 = wc.DownloadString(URL + md5rebugmod);
                labelControl33.Text = md5;
            }
            if (comboBoxEdit13.SelectedIndex == 10)
            {
                WebClient wc = new WebClient();
                var md5 = wc.DownloadString(URL + md5habibcbr);
                labelControl33.Text = md5;
            }
            if (comboBoxEdit13.SelectedIndex == 11)
            {
                WebClient wc = new WebClient();
                var md5 = wc.DownloadString(URL + md5ps3ita);
                labelControl33.Text = md5;
            }
            if (comboBoxEdit13.SelectedIndex == 12)
            {
                WebClient wc = new WebClient();
                var md5 = wc.DownloadString(URL + md5playerkpst);
                labelControl33.Text = md5;
            }
            if (comboBoxEdit13.SelectedIndex == 13)
            {
                WebClient wc = new WebClient();
                var md5 = wc.DownloadString(URL + md5playerkpcbr);
                labelControl33.Text = md5;
            }
            if (comboBoxEdit13.SelectedIndex == 14)
            {
                WebClient wc = new WebClient();
                var md5 = wc.DownloadString(URL + md5playerkpdb);
                labelControl33.Text = md5;
            }
            if (comboBoxEdit13.SelectedIndex == 15)
            {
                WebClient wc = new WebClient();
                var md5 = wc.DownloadString(URL + md5darknetst);
                labelControl33.Text = md5;
            }
            if (comboBoxEdit13.SelectedIndex == 16)
            {
                WebClient wc = new WebClient();
                var md5 = wc.DownloadString(URL + md5darknetcbr);
                labelControl33.Text = md5;
            }
        }

        private void DownloadProgressFw(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBarControl6.EditValue = e.ProgressPercentage;
            labelControl65.Text = e.TotalBytesToReceive.ToString();
            labelControl66.Text = e.BytesReceived.ToString();
        }

        private void CompletedFw(object sender, AsyncCompletedEventArgs e)
        {
            if (XtraMessageBox.Show("Download Completed! \nYou will find the Firmware in the downloads folder.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                progressBarControl6.EditValue = 0;
                labelControl65.Text = "...";
                labelControl66.Text = "...";
                isdbwebfree = true;
            }
        }

        private bool IswebCFree()
        {
            if (isdbwebfree == true)
                return true;
            else return false;
        }

        private void simpleButton46_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit12.SelectedIndex == 0)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        isdbwebfree = false;
                        progressBarControl6.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedFw);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressFw);
                        webClient.DownloadFileAsync(new Uri("http://download2152.mediafire.com/8ug7dwm7qmfg/l33tumeaenzmtc0/ofw+3.41+ps3.rar"), @"downloads/ORIGINAL_FIRMWARE_3.41.rar");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit12.SelectedIndex == 1)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        isdbwebfree = false;
                        progressBarControl6.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedFw);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressFw);
                        webClient.DownloadFileAsync(new Uri("http://download1655.mediafire.com/ngjlw0cea7og/n5lnl2t0e7e0en5/3.55+SONY.rar"), @"downloads/ORIGINAL_FIRMWARE_3.55.rar");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit12.SelectedIndex == 2)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        isdbwebfree = false;
                        progressBarControl6.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedFw);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressFw);
                        webClient.DownloadFileAsync(new Uri("http://deu01.ps3.update.playstation.net/update/ps3/image/eu/2016_0420_2c7ac82e02db9ce396618e6644a8c52d/PS3UPDAT.PUP"), @"downloads/ORIGINAL_FIRMWARE_4.80.PUP");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit12.SelectedIndex == 3)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        isdbwebfree = false;
                        progressBarControl6.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedFw);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressFw);
                        webClient.DownloadFileAsync(new Uri("http://deu01.ps3.update.playstation.net/update/ps3/image/eu/2016_1101_b2483b4abc157494447c9c409c036041/PS3UPDAT.PUP"), @"downloads/ORIGINAL_FIRMWARE_4.81.PUP");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void simpleButton45_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit13.SelectedIndex == 0)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        isdbwebfree = false;
                        progressBarControl6.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedFw);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressFw);
                        webClient.DownloadFileAsync(new Uri("http://scmods.com/rebug/firmware/REBUG_3.55.4_REX_PS3UPDAT.PUP"), @"downloads/CUSTOM_FIRMWARE_REBUG_3.55.4.PUP");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit13.SelectedIndex == 1)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        isdbwebfree = false;
                        progressBarControl6.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedFw);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressFw);
                        webClient.DownloadFileAsync(new Uri("http://scmods.com/rebug/firmware/REBUG_3.55.4_999_DGR_PS3UPDAT.PUP"), @"downloads/CUSTOM_FIRMWARE_REBUG_999_DOWNGRADER.PUP");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit13.SelectedIndex == 2)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        isdbwebfree = false;
                        progressBarControl6.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedFw);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressFw);
                        webClient.DownloadFileAsync(new Uri("https://mega.nz/#!T1sygaaD!qcC5aTdDgSYD71_LRX5YvIKBAKUQm9b70RrEmK_c2h4"), @"downloads/CUSTOM_FIRMWARE_ROGERO_999_DOWNGRADER.rar");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit13.SelectedIndex == 3)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        isdbwebfree = false;
                        progressBarControl6.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedFw);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressFw);
                        webClient.DownloadFileAsync(new Uri("https://mega.nz/#!ywdGgA7K!iCa1ZxSWtvfue-VXX3-d0b4HsiZY21baI5wymD_06NM"), @"downloads/CUSTOM_FIRMWARE_FERROX_3.55_NOBD.rar");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit13.SelectedIndex == 4)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        isdbwebfree = false;
                        progressBarControl6.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var V = webClient.DownloadString(URL + vFerroxstandard);
                        var UI = webClient.DownloadString(URL + dlferroxst);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedFw);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressFw);
                        webClient.DownloadFileAsync(new Uri(UI), @"downloads/" + V + ".PUP");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit13.SelectedIndex == 5)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        isdbwebfree = false;
                        progressBarControl6.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var V = webClient.DownloadString(URL + vFerroxcobra);
                        var UI = webClient.DownloadString(URL + dlferroxcbr);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedFw);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressFw);
                        webClient.DownloadFileAsync(new Uri(UI), @"downloads/" + V + ".PUP");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit13.SelectedIndex == 6)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        isdbwebfree = false;
                        progressBarControl6.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var V = webClient.DownloadString(URL + vFerroxnobd);
                        var UI = webClient.DownloadString(URL + dlferroxnobd);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedFw);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressFw);
                        webClient.DownloadFileAsync(new Uri(UI), @"downloads/" + V + ".PUP");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit13.SelectedIndex == 7)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        isdbwebfree = false;
                        progressBarControl6.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var V = webClient.DownloadString(URL + vRebugrex);
                        var UI = webClient.DownloadString(URL + dlrebugrex);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedFw);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressFw);
                        webClient.DownloadFileAsync(new Uri(UI), @"downloads/" + V + ".PUP");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit13.SelectedIndex == 8)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        isdbwebfree = false;
                        progressBarControl6.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var V = webClient.DownloadString(URL + vRebugdrex);
                        var UI = webClient.DownloadString(URL + dlrebugdrex);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedFw);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressFw);
                        webClient.DownloadFileAsync(new Uri(UI), @"downloads/" + V + ".PUP");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit13.SelectedIndex == 9)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        isdbwebfree = false;
                        progressBarControl6.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var V = webClient.DownloadString(URL + vRebugmod);
                        var UI = webClient.DownloadString(URL + dlrebugmod);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedFw);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressFw);
                        webClient.DownloadFileAsync(new Uri(UI), @"downloads/" + V + ".PUP");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit13.SelectedIndex == 10)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        isdbwebfree = false;
                        progressBarControl6.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var V = webClient.DownloadString(URL + vHabibcobra);
                        var UI = webClient.DownloadString(URL + dlhabibcbr);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedFw);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressFw);
                        webClient.DownloadFileAsync(new Uri(UI), @"downloads/" + V + ".PUP");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit13.SelectedIndex == 11)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        isdbwebfree = false;
                        progressBarControl6.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var V = webClient.DownloadString(URL + vPs3ITA);
                        var UI = webClient.DownloadString(URL + dlps3ita);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedFw);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressFw);
                        webClient.DownloadFileAsync(new Uri(UI), @"downloads/" + V + ".rar");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit13.SelectedIndex == 12)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        isdbwebfree = false;
                        progressBarControl6.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var V = webClient.DownloadString(URL + vPlayerkpstandard);
                        var UI = webClient.DownloadString(URL + dlplayerkpst);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedFw);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressFw);
                        webClient.DownloadFileAsync(new Uri(UI), @"downloads/" + V + ".PUP");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit13.SelectedIndex == 13)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        isdbwebfree = false;
                        progressBarControl6.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var V = webClient.DownloadString(URL + vPlayerkpcobra);
                        var UI = webClient.DownloadString(URL + dlplayerkpcbr);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedFw);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressFw);
                        webClient.DownloadFileAsync(new Uri(UI), @"downloads/" + V + ".PUP");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit13.SelectedIndex == 14)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        isdbwebfree = false;
                        progressBarControl6.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var V = webClient.DownloadString(URL + vPlayerkpdb);
                        string UI = webClient.DownloadString(URL + dlplayerkpdb);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedFw);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressFw);
                        webClient.DownloadFileAsync(new Uri(UI), @"downloads/" + V + ".PUP");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit13.SelectedIndex == 15)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        isdbwebfree = false;
                        progressBarControl6.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var V = webClient.DownloadString(URL + vDarknetstandard);
                        string UI = webClient.DownloadString(URL + dldarknetst);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedFw);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressFw);
                        webClient.DownloadFileAsync(new Uri(UI), @"downloads/" + V + ".PUP");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit13.SelectedIndex == 16)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        isdbwebfree = false;
                        progressBarControl6.EditValue = 0;
                        WebClient webClient = new WebClient();
                        var V = webClient.DownloadString(URL + vDarknetcobra);
                        string UI = webClient.DownloadString(URL + dldarknetcbr);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedFw);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressFw);
                        webClient.DownloadFileAsync(new Uri(UI), @"downloads/" + V + ".PUP");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBoxEdit15_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit15.SelectedIndex == 0)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                        Anti-Ban --- BLES01717 Only!!";
            }
            if (comboBoxEdit15.SelectedIndex == 1)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                        Anti-Ban --- BLES01718 Only!!";
            }
            if (comboBoxEdit15.SelectedIndex == 2)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                        Anti-Ban - NoRecoil - Laser - Steady Aim - Probation Bypass - Disable Protected Characters --- BLES01717 Only!!";
            }
            if (comboBoxEdit15.SelectedIndex == 3)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                        Anti-Ban - NoRecoil - Laser - Steady Aim - Probation Bypass - Disable Protected Characters --- BLES01718 Only!!";
            }
            if (comboBoxEdit15.SelectedIndex == 4)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                        Anti-Ban - NoRecoil - Laser - Steady Aim - Red Boxes - UAV - VSAT - WallHack - Floating Bodies - Target Finder - Probation Bypass - Disable Protected Characters --- BLES01717 Only!!";
            }
            if (comboBoxEdit15.SelectedIndex == 5)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                        Anti-Ban - NoRecoil - Laser - Steady Aim - Red Boxes - UAV - VSAT - WallHack - Floating Bodies - Target Finder - Probation Bypass - Disable Protected Characters --- BLES01718 Only!!";
            }
            if (comboBoxEdit15.SelectedIndex == 6)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                        Anti-Ban --- Zombie BLES01717 Only!!";
            }
            if (comboBoxEdit15.SelectedIndex == 7)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                        Anti-Ban --- Zombie BLES01718 Only!!";
            }
            if (comboBoxEdit15.SelectedIndex == 8)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                        Anti-Ban - NoRecoil - Steady Aim --- BLES02166 Only!!";
            }
            if (comboBoxEdit15.SelectedIndex == 9)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                        Anti-Ban - Steady Aim - NoRecoil - RedBoxes - UAV --- BLES02166 Only!!";
            }
            if (comboBoxEdit15.SelectedIndex == 10)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                        Anti-Ban - No Recoil - Steady Aim - Red Box - Advance UAV - REAL WallHack - SPRX Loader Function:  Load Ghosts.sprx --- BLES01945 Only!!";
            }
            if (comboBoxEdit15.SelectedIndex == 11)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                        Red Boxes - Glow Players - No Recoil - Advancde UAV - SPRX Loader Function:  Load MW3.sprx --- BLES01430 Only!!";
            }
            if (comboBoxEdit15.SelectedIndex == 12)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                        Script Bypass Function - SPRX Loader Function:  Load GTA.sprx -- By Erotiik & Proditaki  ---  BLES01807 Only!!";
            }
            if (comboBoxEdit15.SelectedIndex == 13)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                        Script Bypass Function - Bypass Object Function - SPRX Loader Function:  Load GTA.sprx -- By Semjases  ---  BLES01807 Only!!";
            }
        }

        private void comboBoxEdit14_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit14.SelectedIndex == 0)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                               BlackBird - NoRecoil - Disable Perk Check - Red Boxes - Steady Aim - Other Non Host Mods --- DEBUG EBOOT";
            }
            if (comboBoxEdit14.SelectedIndex == 1)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                      SPRX Loader Function:  Load Snow.sprx -- DEBUG EBOOT";
            }
            if (comboBoxEdit14.SelectedIndex == 2)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                      Anti-Ban -- DEBUG EBOOT";
            }
            if (comboBoxEdit14.SelectedIndex == 3)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                      Anti-Ban - NoRecoil - Laser - Steady Aim - Probation Bypass - Disable Protected Characters --- DEBUG EBOOT";
            }
            if (comboBoxEdit14.SelectedIndex == 4)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                      Anti-Ban - NoRecoil - Laser - Steady Aim - Probation Bypass - Disable Protected Characters - Red Boxes - UAV - VSAT - WallHack - Floating Bodies - Target Finder --- DEBUG EBOOT";
            }
            if (comboBoxEdit14.SelectedIndex == 5)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                      Anti-Ban --- Zombie DEBUG EBOOT";
            }
            if (comboBoxEdit14.SelectedIndex == 6)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                      SPRX Loader Function:  Load BO3.sprx --- DEBUG EBOOT";
            }
            if (comboBoxEdit14.SelectedIndex == 7)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                      Anti-Ban - SPRX Loader Function:  Load BO3.sprx --- DEBUG EBOOT";
            }
            if (comboBoxEdit14.SelectedIndex == 8)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                      Anti-Ban - NoRecoil - Steady Aim - UAV - RedBox - SPRX Loader Function:  Load BO3.sprx --- DEBUG EBOOT";
            }
            if (comboBoxEdit14.SelectedIndex == 9)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                      Anti-Ban --- Zombie DEBUG EBOOT";
            }
            if (comboBoxEdit14.SelectedIndex == 10)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                      Anti-Ban - SPRX Loader Function:  Load BO3.sprx --- Zombie DEBUG EBOOT";
            }
            if (comboBoxEdit14.SelectedIndex == 11)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                      Anti-Ban --- DEBUG EBOOT";
            }
            if (comboBoxEdit14.SelectedIndex == 12)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                      Anti-Ban - No Recoil - Steady Aim - Red Box - Advanced UAV --- DEBUG EBOOT";
            }
            if (comboBoxEdit14.SelectedIndex == 13)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                      Anti-Ban - No Recoil - Steady Aim - Red Box - Advance UAV - SPRX Loader Function:  Load Mod_Menu.sprx --- DEBUG EBOOT";
            }
            if (comboBoxEdit14.SelectedIndex == 14)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                      Anti-Ban - No Recoil - Steady Aim - Red Box - Advanced UAV - REAL WallHack - SPRX Loader Function:  Load Ghosts.sprx --- DEBUG EBOOT";
            }
            if (comboBoxEdit14.SelectedIndex == 15)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                        Red Boxes - Glow Players - No Recoil - Advanced UAV - SPRX Loader Function:  Load MW3.sprx --- DEBUG EBOOT";
            }
            if (comboBoxEdit14.SelectedIndex == 16)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                      Script Bypass - Function SPRX Loader Function:  Load GTA.sprx -- By Erotiik --- BLES DEBUG EBOOT";
            }
            if (comboBoxEdit14.SelectedIndex == 17)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                      Script Bypass Function - Object Bypass - SPRX Loader Function:  Load GTA.sprx -- By ?? --- BLES DEBUG EBOOT";
            }
            if (comboBoxEdit14.SelectedIndex == 18)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                      Script Bypass Function - Check Money Bypass - SPRX Loader Function:  Load GTA.sprx -- By RF0oD MoDz --- DEBUG EBOOT";
            }
            if (comboBoxEdit14.SelectedIndex == 19)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                      Script Bypass Function - SPRX Loader Function:  Load GTA.sprx - By Semjases --- DEBUG EBOOT";
            }
            if (comboBoxEdit14.SelectedIndex == 20)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                      Anti-Ban - SPRX Loader Function:  Load BO2.sprx -- DEBUG EBOOT";
            }
            if (comboBoxEdit14.SelectedIndex == 21)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:                                                                                                                       Script Bypass Function - Object Bypass - Money Check Bypass - Anti-Report - Anti Animation - Anti PFX - Anti Remove Weapons - Anti Vote Kick - No Rockstar Intro - Anti Explosion- Anti Freeze Tasks - Anti Timeout - Anti Check Stats - Anti Check MPPLY - Anti Teleport - Anti Error Server - Anti Get MAC Address - SPRX Loader Function:  Load gta5.sprx - By RFOoD MoDz --- DEBUG EBOOT";
            }
        }

        private void DownloadProgress4(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBarControl7.EditValue = e.ProgressPercentage;
            labelControl68.Text = e.TotalBytesToReceive.ToString();
            labelControl69.Text = e.BytesReceived.ToString();
        }

        private void CompletedEboot(object sender, AsyncCompletedEventArgs e)
        {
            if (XtraMessageBox.Show("Download Completed! \nYou will find the EBOOT in the downloads folder.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                progressBarControl7.EditValue = 0;
                isdbwebfree = true;
                labelControl68.Text = "...";
                labelControl69.Text = "...";
            }
        }

        private void simpleButton48_Click(object sender, EventArgs e)
        {
            if (IswebCFree() == true)
            {
                if (comboBoxEdit15.SelectedIndex == 0)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/BO2/Multiplayer/CEX/1/BLES01717-ANTIB-EBOOT.BIN"), @"downloads/BLES01717-ANTIB-EBOOT.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit15.SelectedIndex == 1)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/BO2/Multiplayer/CEX/1/BLES01718-ANTIB-EBOOT.BIN"), @"downloads/BLES01718-ANTIB-EBOOT.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit15.SelectedIndex == 2)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/BO2/Multiplayer/CEX/2/BLES01717-MOD-EBOOT.BIN"), @"downloads/BLES01717-MOD-EBOOT.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit15.SelectedIndex == 3)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/BO2/Multiplayer/CEX/2/BLES01718-MOD-EBOOT.BIN"), @"downloads/BLES01718-MOD-EBOOT.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit15.SelectedIndex == 4)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/BO2/Multiplayer/CEX/3/BLES01717-SUPERMOD-EBOOT.BIN"), @"downloads/BLES01717-SUPERMOD-EBOOT.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit15.SelectedIndex == 5)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/BO2/Multiplayer/CEX/3/BLES01718-SUPERMOD-EBOOT.BIN"), @"downloads/BLES01718-SUPERMOD-EBOOT.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit15.SelectedIndex == 6)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/BO2/Zombie/BLES01717-ZOMBIE-ANTIBAN-EBOOT.BIN"), @"downloads/BLES01717-ZOMBIE-ANTIBAN-EBOOT.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit15.SelectedIndex == 7)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/BO2/Zombie/BLES01718-ZOMBIE-ANTIBAN-EBOOT.BIN"), @"downloads/BLES01717-ZOMBIE-ANTIBAN-EBOOT.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit15.SelectedIndex == 8)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/BO3/CEX/BO3-BLESCEX-EBOOT-1.BIN"), @"downloads/BO3-BLESCEX-EBOOT-1.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit15.SelectedIndex == 9)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/BO3/CEX/BO3-BLESCEX-EBOOT-2.BIN"), @"downloads/BO3-BLESCEX-EBOOT-2.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit15.SelectedIndex == 10)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/Ghosts/CEX-1/GHOST-CEX-MOD-EBOOT.BIN"), @"downloads/GHOST-CEX-MOD-EBOOT.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit15.SelectedIndex == 11)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/MW3/MW3-CEX-EBOOT.BIN"), @"downloads/MW3-CEX-EBOOT.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit15.SelectedIndex == 12)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/LezZo-GTA-RTM/GTA_EBOOTS/CEX/CEX-EBOOT-SCRIPT-SPRX_GTA.sprx.BIN"), @"downloads/CEX-EBOOT-SCRIPT-SPRX_GTA.sprx.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit15.SelectedIndex == 13)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/LezZo-GTA-RTM/GTA_EBOOTS/CEX/CEX-BYPASS_OBJECT-SPRX_GTA.sprx-EBOOT.BIN"), @"downloads/CEX-BYPASS_OBJECT-SPRX_GTA.sprx-EBOOT.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton47_Click(object sender, EventArgs e)
        {
            if (IswebCFree() == true)
            {
                if (comboBoxEdit14.SelectedIndex == 0)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/BO1/BO1-DEX-EBOOT-SPRXLOAD.BIN"), @"downloads/BO1-DEX-EBOOT-SPRXLOAD.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit14.SelectedIndex == 1)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/BO1/BO1-DEX-MOD-EBOOT.BIN"), @"downloads/BO1-DEX-MOD-EBOOT.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit14.SelectedIndex == 2)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/BO2/Multiplayer/DEX/1/BO2-DEX-ANTIB-EBOOT.BIN"), @"downloads/BO2-DEX-ANTIB-EBOOT.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit14.SelectedIndex == 3)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/BO2/Multiplayer/DEX/2/BO2-DEX-MOD-EBOOT.BIN"), @"downloads/BO2-DEX-MOD-EBOOT.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit14.SelectedIndex == 4)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/BO2/Multiplayer/DEX/3/BO2-DEX-SUPERMOD-EBOOT.BIN"), @"downloads/BO2-DEX-SUPERMOD-EBOOT.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit14.SelectedIndex == 5)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/BO2/Zombie/BO2-ZOMBIE-DEX-ANTIBAN-EBOOT.BIN"), @"downloads/BO2-ZOMBIE-DEX-ANTIBAN-EBOOT.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit14.SelectedIndex == 6)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/BO3/DEX/EBOOT-Multi/BO3-DEBUG-ANTI-MODS-SPRX.BIN"), @"downloads/BO3-DEBUG-ANTI-MODS-SPRX.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit14.SelectedIndex == 7)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/BO3/DEX/EBOOT-Multi/BO3-DEBUG-ANTIBAN-SPRX.BIN"), @"downloads/BO3-DEBUG-ANTIBAN-SPRX.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit14.SelectedIndex == 8)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/BO3/DEX/EBOOT-Multi/BO3-DEBUG-CLEAN-SPRX.BIN"), @"downloads/BO3-DEBUG-CLEAN-SPRX.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit14.SelectedIndex == 9)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/BO3/DEX/EBOOT-Zombie/BO3-ZOMBIE-DEBUG-ANTIBAN-SPRX.BIN"), @"downloads/BO3-ZOMBIE-DEBUG-ANTIBAN-SPRX.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit14.SelectedIndex == 10)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/BO3/DEX/EBOOT-Zombie/BO3-ZOMBIE-DEBUG-ANTIBAN.BIN"), @"downloads/BO3-ZOMBIE-DEBUG-ANTIBAN.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit14.SelectedIndex == 11)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/Ghosts/DEX-4/GHOST-DEX-ANTIBAN-EBOOT.BIN"), @"downloads/GHOST-DEX-ANTIBAN-EBOOT.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit14.SelectedIndex == 12)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/Ghosts/DEX-1/GHOST-DEX-MOD1-EBOOT.BIN"), @"downloads/GHOST-DEX-MOD1-EBOOT.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit14.SelectedIndex == 13)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/Ghosts/DEX-3/GHOST-DEX-MOD3-EBOOT.BIN"), @"downloads/GHOST-DEX-MOD3-EBOOT.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit14.SelectedIndex == 14)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/Ghosts/DEX-2/GHOST-DEX-MOD2-EBOOT.BIN"), @"downloads/GHOST-DEX-MOD2-EBOOT.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit14.SelectedIndex == 15)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/MW3/MW3-DEX-EBOOT.BIN"), @"downloads/MW3-DEX-EBOOT.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit14.SelectedIndex == 16)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/LezZo-GTA-RTM/GTA_EBOOTS/DEX/DEX-EBOOT-SCRIPT-SPRX_GTA.sprx.BIN"), @"downloads/DEX-EBOOT-SCRIPT-SPRX_GTA.sprx.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit14.SelectedIndex == 17)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/LezZo-GTA-RTM/GTA_EBOOTS/DEX/DEX-BYPASS_OBJECT-SPRX_GTA.sprx-EBOOT.BIN"), @"downloads/DEX-BYPASS_OBJECT-SPRX_GTA.sprx-EBOOT.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit14.SelectedIndex == 18)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/LezZo-GTA-RTM/GTA_EBOOTS/DEX/RFOOD_EBOOT_SCRIPT_CHECK_BYPASS_SPRX_GTA.sprx.BIN"), @"downloads/RFOOD_EBOOT_SCRIPT_CHECK_BYPASS_SPRX_GTA.sprx.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit14.SelectedIndex == 19)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/LezZo-GTA-RTM/GTA_EBOOTS/DEX/SEMJASES_EBOOT_DEX_BYPASS_GTA.sprx.BIN"), @"downloads/SEMJASES_EBOOT_DEX_BYPASS_GTA.sprx.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit14.SelectedIndex == 20)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/PS3_DB/EBOOTS/BO2/Multiplayer/DEX/4/BO2-ANTIBAN-DEX-SPRX.BIN"), @"downloads/B02-ANTIBAN-DEX-SPRX-EBOOT.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxEdit14.SelectedIndex == 21)
                {
                    try
                    {
                        isdbwebfree = false;
                        progressBarControl7.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/LezZo-GTA-RTM/GTA_EBOOTS/DEX/EBOOT_RFOoDxMoDz_v1.3.BIN"), @"downloads/GTA5-DEX-RFOoD_MoDz_v1.3-EBOOT.BIN");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBoxEdit17_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit17.SelectedIndex == 0)
            {
                memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the selected Game.    If you want help to improve this Tool, send me your download links :)";
            }
            if (comboBoxEdit17.SelectedIndex == 1)
            {
                memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the selected Game.    If you want help to improve this Tool, send me your download links :)";
            }
            if (comboBoxEdit17.SelectedIndex == 2)
            {
                memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the selected Game.    If you want help to improve this Tool, send me your download links :)";
            }
            if (comboBoxEdit17.SelectedIndex == 3)
            {
                memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the selected Game.    If you want help to improve this Tool, send me your download links :)";
            }
            if (comboBoxEdit17.SelectedIndex == 4)
            {
                memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the selected Game.    If you want help to improve this Tool, send me your download links :)";
            }
            if (comboBoxEdit17.SelectedIndex == 5)
            {
                memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the selected Game.    If you want help to improve this Tool, send me your download links :)";
            }
            if (comboBoxEdit17.SelectedIndex == 6)
            {
                memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the selected Game.    If you want help to improve this Tool, send me your download links :)";
            }
            if (comboBoxEdit17.SelectedIndex == 7)
            {
                memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the selected Game.    If you want help to improve this Tool, send me your download links :)";
            }
            if (comboBoxEdit17.SelectedIndex == 8)
            {
                memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the selected Game.    If you want help to improve this Tool, send me your download links :)";
            }
            if (comboBoxEdit17.SelectedIndex == 9)
            {
                memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the selected Game.    If you want help to improve this Tool, send me your download links :)";
            }
            if (comboBoxEdit17.SelectedIndex == 10)
            {
                memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the selected Game.    If you want help to improve this Tool, send me your download links :)";
            }
            if (comboBoxEdit17.SelectedIndex == 11)
            {
                memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the selected Game.    If you want help to improve this Tool, send me your download links :)";
            }
            if (comboBoxEdit17.SelectedIndex == 12)
            {
                memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the selected Game.    If you want help to improve this Tool, send me your download links :)";
            }
            if (comboBoxEdit17.SelectedIndex == 13)
            {
                memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the selected Game.    If you want help to improve this Tool, send me your download links :)";
            }
            if (comboBoxEdit17.SelectedIndex == 14)
            {
                memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the selected Game.    If you want help to improve this Tool, send me your download links :)";
            }
            if (comboBoxEdit17.SelectedIndex == 15)
            {
                memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the selected Game.    If you want help to improve this Tool, send me your download links :)";
            }
            if (comboBoxEdit17.SelectedIndex == 16)
            {
                memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the selected Game.    If you want help to improve this Tool, send me your download links :)";
            }
            if (comboBoxEdit17.SelectedIndex == 17)
            {
                memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the selected Game.    If you want help to improve this Tool, send me your download links :)";
            }
            if (comboBoxEdit17.SelectedIndex == 18)
            {
                memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the Torrent. You will need BitTorrent or similar to download the Game.      If you want help to improve this Tool, send me your Links :)";
            }
            if (comboBoxEdit17.SelectedIndex == 19)
            {
                memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the Torrent. You will need BitTorrent or similar to download the Game.      If you want help to improve this Tool, send me your Links :)";
            }
            if (comboBoxEdit17.SelectedIndex == 20)
            {
                memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the Torrent. You will need BitTorrent or similar to download the Game.      If you want help to improve this Tool, send me your Links :)";
            }
            if (comboBoxEdit17.SelectedIndex == 21)
            {
                memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the Torrent. You will need BitTorrent or similar to download the Game.      If you want help to improve this Tool, send me your Links :)";
            }
            if (comboBoxEdit17.SelectedIndex == 22)
            {
                memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the Torrent. You will need BitTorrent or similar to download the Game.      If you want help to improve this Tool, send me your Links :)";
            }
            if (comboBoxEdit17.SelectedIndex == 23)
            {
                memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the Torrent. You will need BitTorrent or similar to download the Game.      If you want help to improve this Tool, send me your Links :)";
            }
            if (comboBoxEdit17.SelectedIndex == 24)
            {
                memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the selected Game.    If you want help to improve this Tool, send me your download links :)";
            }
            if (comboBoxEdit17.SelectedIndex == 25)
            {
                memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the selected Game.    If you want help to improve this Tool, send me your download links :)";
            }
            else if (comboBoxEdit17.SelectedIndex > 25)
            {
                memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the selected Game and of the Rap activation key.    If you want help to improve this Tool, send me your download links :)";
            }
        }

        private void comboBoxEdit16_SelectedIndexChanged(object sender, EventArgs e)
        {
            memoEdit2.Text = "In the Download you will find:                                                                                                                         Link to the Direct Download for the selected DLC. Available BLES & BLUS of almost all DLCs. If your region isn't available, you can convert the DLC.                   If you want help to improve this Tool, send me your download links :)";
        }

        private void DownloadProgress5(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBarControl8.EditValue = e.ProgressPercentage;
        }

        private void CompletedGames(object sender, AsyncCompletedEventArgs e)
        {
            if (XtraMessageBox.Show("Download Completed! \nYou will find the Link for the Game in the downloads folder.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                progressBarControl8.EditValue = 0;
            }
        }

        private void simpleButton50_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit17.SelectedIndex == 0)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/BOIII.rar"), @"downloads/COD-BOIII.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 1)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/Yakuza_Dead_Souls.rar"), @"downloads/Yakuza_Dead_Souls.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 2)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/MotoGP_2015.rar"), @"downloads/MotoGP_2015.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 3)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/SniperElite_Ultimate.rar"), @"downloads/SniperElite_Ultimate.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 4)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/GameofThrones.rar"), @"downloads/Game.of.Thrones.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 5)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/Uncharted3.rar"), @"downloads/Uncharted_3.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 6)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/Watch_Dogs.rar"), @"downloads/Watch_Dogs.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 7)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/Uefa_Euro_2016.rar"), @"downloads/Uefa_Euro_2016.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 8)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/Doom_3.rar"), @"downloads/Doom_3.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 9)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/Resident_Evil.rar"), @"downloads/Resident_Evil_Revelation.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 10)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/PrinceofPersia.rar"), @"downloads/Prince.of.Persia.Trylogy.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 11)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/Dark_Souls.rar"), @"downloads/Dark_Souls_Prepare_to_Die.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 12)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/Lightning_Return_FF.rar"), @"downloads/Lightning_Return_FF.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 13)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/DragonAge.rar"), @"downloads/DragonAge.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 14)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/Yakuza4.rar"), @"downloads/Yakuza_4.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 15)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/SilentHill.rar"), @"downloads/SilentHill_Homecoming.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 16)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/DeadIsland_GOTY.rar"), @"downloads/Dead_Island_GOTY.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 17)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/DeadIsland_Riptide.rar"), @"downloads/DeadIsland_Riptide.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 18)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/TheEvilWithin.rar"), @"downloads/The.Evil.Within.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 19)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/BeyondtwoSouls.rar"), @"downloads/BeyondtwoSouls.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 20)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/Advanced_Warfare.rar"), @"downloads/Advanced_Warfare.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 21)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/MW2.rar"), @"downloads/Modern_Warfare_2.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 22)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/MW3.rar"), @"downloads/Modern_Warfare_3.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 23)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/WWE_2016.rar"), @"downloads/WWE_2016.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 24)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/Battlefield_4.rar"), @"downloads/Battlefield_4.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 25)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/GTA_SanAndreas.rar"), @"downloads/GTA_SanAndreas.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 26)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/AssassinCreedUSA.rar"), @"downloads/AssassinCreedUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 27)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/AssassinCreedEU.rar"), @"downloads/AssassinCreedEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 28)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/AssassinCreed2USA.rar"), @"downloads/AssassinCreed2USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 29)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/AssassinCreed2EU.rar"), @"downloads/AssassinCreed2EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 30)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/AssassinCreed3USA.rar"), @"downloads/AssassinCreed3USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 31)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/AssassinCreed3EU.rar"), @"downloads/AssassinCreed3EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 32)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/AssassinCreed4USA.rar"), @"downloads/AssassinCreed4BlackFlagUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 33)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/AssassinCreed4EU.rar"), @"downloads/AssassinCreed4BlackFlagEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 34)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/AssassinCreedRevelationUSA.rar"), @"downloads/AssassinCreedRevelationUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 35)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/AssassinCreedRevelationEU.rar"), @"downloads/AssassinCreedRevelationEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 36)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/BatmanArkhamAsylumUSA.rar"), @"downloads/BatmanArkhamAsylumUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 37)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/BatmanArkhamAsylumEU.rar"), @"downloads/BatmanArkhamAsylumEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 38)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/BatmanArkhamOriginsUSA.rar"), @"downloads/BatmanArkhamOriginsUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 39)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/BatmanArkhamCityEU.rar"), @"downloads/BatmanArkhamCityEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 40)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/BatmanArkhamCityUSA.rar"), @"downloads/BatmanArkhamCityUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 41)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/BeyondGoodAndEvilUSA.rar"), @"downloads/BeyondGoodAndEvilUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 42)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/BeyondGoodAndEvilEU.rar"), @"downloads/BeyondGoodAndEvilEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 43)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/BorderlandsUSA.rar"), @"downloads/BorderlandsUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 44)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/BorderlandsEU.rar"), @"downloads/BorderlandsEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 45)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/Borderlands2USA.rar"), @"downloads/Borderlands2USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 46)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/Borderlands2EU.rar"), @"downloads/Borderlands2EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 47)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/CODBlackOpsUSA.rar"), @"downloads/CODBlackOpsUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 48)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/CODGhostsUSA.rar"), @"downloads/CODGhostsUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 49)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/CODGhostsEU.rar"), @"downloads/CODGhostsEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 50)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/Crysis2EU.rar"), @"downloads/Crysis2EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 51)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/Crysis3USA.rar"), @"downloads/Crysis3USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 52)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/Crysis3EU.rar"), @"downloads/Crysis3EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 53)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/CrysisHDUSA.rar"), @"downloads/CrysisHDUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 54)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/CrysisHDEU.rar"), @"downloads/CrysisHDEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 55)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DantesInfernoUSA.rar"), @"downloads/DantesInfernoUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 56)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DantesInfernoEU.rar"), @"downloads/DantesInfernoEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 57)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DarkSouls2USA.rar"), @"downloads/DarkSouls2USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 58)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DarkSouls2EU.rar"), @"downloads/DarkSouls2EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 59)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DarkSidersUSA.rar"), @"downloads/DarkSidersUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 60)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DarkSidersEU.rar"), @"downloads/DarkSidersEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 61)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DarkSiders2USA.rar"), @"downloads/DarkSiders2USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 62)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DarkSiders2EU.rar"), @"downloads/DarkSiders2EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 63)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DeadOrAlive5EU.rar"), @"downloads/DeadOrAlive5EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 64)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DeadSpaceUSA.rar"), @"downloads/DeadSpaceUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 65)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DeadSpaceEU.rar"), @"downloads/DeadSpaceEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 66)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DeadSpace2USA.rar"), @"downloads/DeadSpace2USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 67)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DeadSpace2EU.rar"), @"downloads/DeadSpace2EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 68)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DeadSpace3USA.rar"), @"downloads/DeadSpace3USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 69)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DeadSpace3EU.rar"), @"downloads/DeadSpace3EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 70)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DeathmatchVillageEU.rar"), @"downloads/DeathmatchVillageEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 71)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DemonsSoulsUSA.rar"), @"downloads/DemonsSoulsUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 72)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DemonsSoulsEU.rar"), @"downloads/DemonsSoulsEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 73)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DestinyUSA.rar"), @"downloads/DestinyUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 74)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DestinyEU.rar"), @"downloads/DestinyEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 75)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DevilMayCryCollectionUSA.rar"), @"downloads/DevilMayCryCollectionUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 76)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DevilMayCryCollectionEU.rar"), @"downloads/DevilMayCryCollectionEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 77)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DevilMayCryUSA.rar"), @"downloads/DevilMayCryUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 78)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DevilMayCryEU.rar"), @"downloads/DevilMayCryEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 79)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/Diablo3USA.rar"), @"downloads/Diablo3USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 80)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/Diablo3EU.rar"), @"downloads/Diablo3EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 81)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DishonoredUSA.rar"), @"downloads/DishonoredUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 82)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DishonoredEU.rar"), @"downloads/DishonoredEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 83)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DragonBallXenoverseEU.rar"), @"downloads/DragonBallXenoverseEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 84)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DragonBallBattleOfZUSA.rar"), @"downloads/DragonBallBattleOfZUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 85)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/DragonBallBattleOfZEU.rar"), @"downloads/DragonBallBattleOfZEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 86)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/EchodromeUSA.rar"), @"downloads/EchodromeUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 87)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/EchodromeEU.rar"), @"downloads/EchodromeEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 88)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/F1RaceStarsUSA.rar"), @"downloads/F1RaceStarsUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 89)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/F1RaceStarsEU.rar"), @"downloads/F1RaceStarsEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 90)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/FarCry2EU.rar"), @"downloads/FarCry2EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 91)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/FarCry2USA.rar"), @"downloads/FarCry2USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 92)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/FarCry3USA.rar"), @"downloads/FarCry3USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 93)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/FarCry3EU.rar"), @"downloads/FarCry3EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 94)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/FifaStreetUSA.rar"), @"downloads/FifaStreetUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 95)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/FifaStreetEU.rar"), @"downloads/FifaStreetEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 96)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/TomClancysGhostReconAdvancedWarf2EU.rar"), @"downloads/TomClancysGhostReconAdvancedWarf2EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 97)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/TomClancysGhostReconAdvancedWarf2USA.rar"), @"downloads/TomClancysGhostReconAdvancedWarf2USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 98)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/TomClancysGhostReconFutureSoldierUSA.rar"), @"downloads/TomClancysGhostReconFutureSoldierUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 99)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/GodOfWarGhostOfSpartaUSA.rar"), @"downloads/GodOfWarGhostOfSpartaUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 100)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/GodOfWarGhostOfSpartaEU.rar"), @"downloads/GodOfWarGhostOfSpartaEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 101)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/GodOfWarHDUSA.rar"), @"downloads/GodOfWarHDUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 102)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/GodOfWar2HDUSA.rar"), @"downloads/GodOfWar2HDUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 103)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/GodOfWar2HDEU.rar"), @"downloads/GodOfWar2HDEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 104)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/GodOfWarAscensionUSA.rar"), @"downloads/GodOfWarAscensionUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 105)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/GranTurismo6USA.rar"), @"downloads/GranTurismo6USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 106)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/GranTurismo6EU.rar"), @"downloads/GranTurismo6EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 107)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/GTALibertyCityEU.rar"), @"downloads/GTALibertyCityEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 108)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/GTALibertyCityUSA.rar"), @"downloads/GTALibertyCityUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 109)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/GTA4USA.rar"), @"downloads/GTA4USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 110)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/GTA4EU.rar"), @"downloads/GTA4EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 111)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/GTA5USA.rar"), @"downloads/GTA5USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 112)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/GTA5EU.rar"), @"downloads/GTA5EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 113)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/HitmanAbsolutionEU.rar"), @"downloads/HitmanAbsolutionEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 114)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/HitmanAbsolutionUSA.rar"), @"downloads/HitmanAbsolutionUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 115)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/Hitman2USA.rar"), @"downloads/Hitman2USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 116)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/Hitman2EU.rar"), @"downloads/Hitman2EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 117)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/HitmanBloodUSA.rar"), @"downloads/HitmanBloodUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 118)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/HitmanBloodEU.rar"), @"downloads/HitmanBloodEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 119)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/HitmanContractsUSA.rar"), @"downloads/HitmanContractsUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 120)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/HitmanContractsEU.rar"), @"downloads/HitmanContractsEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 121)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/HitmanSniperChallengeEU.rar"), @"downloads/HitmanSniperChallengeEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 122)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/HomefrontUSA.rar"), @"downloads/HomefrontUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 123)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/HouseOfTheDead3USA.rar"), @"downloads/HouseOfTheDead3USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 124)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/HouseOfTheDead3EU.rar"), @"downloads/HouseOfTheDead3EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 125)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/HouseOfTheDead4USA.rar"), @"downloads/HouseOfTheDead4USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 126)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/inFamousUSA.rar"), @"downloads/inFamousUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 127)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/inFamousEU.rar"), @"downloads/inFamousEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 128)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/inFamous2USA.rar"), @"downloads/inFamous2USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 129)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/inFamous2EU.rar"), @"downloads/inFamous2EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 130)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/inFamousFestivalOfBloodUSA.rar"), @"downloads/inFamousFestivalOfBloodUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 131)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/inFamousFestivalOfBloodEU.rar"), @"downloads/inFamousFestivalOfBloodEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 132)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/InjusticeUSA.rar"), @"downloads/InjusticeUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 133)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/IonAssaultUSA.rar"), @"downloads/IonAssaultUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 134)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/IonAssaultEU.rar"), @"downloads/IonAssaultEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 135)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/JustCause2USA.rar"), @"downloads/JustCause2USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 136)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/JustCause2EU.rar"), @"downloads/JustCause2EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 137)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/KillzoneEU.rar"), @"downloads/KillzoneEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 138)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/LaraCroftUSA.rar"), @"downloads/LaraCroftUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 139)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/LaraCroftEU.rar"), @"downloads/LaraCroftEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 140)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/LegoPiratesUSA.rar"), @"downloads/LegoPiratesUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 141)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/LegoPiratesEU.rar"), @"downloads/LegoPiratesEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 142)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/LegoBatman2USA.rar"), @"downloads/LegoBatman2USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 143)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/LegoMarvelUSA.rar"), @"downloads/LegoMarvelUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 144)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/Mafia2USA.rar"), @"downloads/Mafia2USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 145)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/Mafia2EU.rar"), @"downloads/Mafia2EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 146)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MaliciousUSA.rar"), @"downloads/MaliciousUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 147)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MaliciousEU.rar"), @"downloads/MaliciousEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 148)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MassEffectEU.rar"), @"downloads/MassEffectEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 149)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MassEffectUSA.rar"), @"downloads/MassEffectUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 150)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MassEffect2EU.rar"), @"downloads/MassEffect2EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 151)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MassEffect3EU.rar"), @"downloads/MassEffect3EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 152)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MaxPayne2USA.rar"), @"downloads/MaxPayne2USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 153)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MedalOfHonorFrontlineUSA.rar"), @"downloads/MedalOfHonorFrontlineUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 154)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MedalOfHonorWarfighterEU.rar"), @"downloads/MedalOfHonorWarfighterEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 155)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MedalOfHonorWarfighterUSA.rar"), @"downloads/MedalOfHonorWarfighterUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 156)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/Mercenaries2EU.rar"), @"downloads/Mercenaries2EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 157)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MetalGearRevengeanceEU.rar"), @"downloads/MetalGearRevengeanceEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 158)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MetalGearRevengeanceUSA.rar"), @"downloads/MetalGearRevengeanceUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 159)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MetalGearGroundZeroesEU.rar"), @"downloads/MetalGearGroundZeroesEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 160)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MetalGearGroundZeroesUSA.rar"), @"downloads/MetalGearGroundZeroesUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 161)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MetalGearPeaceWalkerEU.rar"), @"downloads/MetalGearPeaceWalkerEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 162)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MetalGear2EU.rar"), @"downloads/MetalGear2EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 163)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MetalGear3EU.rar"), @"downloads/MetalGear2EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 164)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MetalGear4USA.rar"), @"downloads/MetalGear4USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 165)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MetalGear5EU.rar"), @"downloads/MetalGear5TPPEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 166)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MetalSlug2EU.rar"), @"downloads/MetalSlug2EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 167)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MetalSlug3EU.rar"), @"downloads/MetalSlug3EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 168)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MetroLastNightEU.rar"), @"downloads/MetroLastNightEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 169)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MetroLastNightUSA.rar"), @"downloads/MetroLastNightUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 170)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MidnightClubUSA.rar"), @"downloads/MidnightClubUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 171)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MinecraftUSA.rar"), @"downloads/MinecraftUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 172)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MirrorsEdgeEU.rar"), @"downloads/MirrorsEdgeEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 173)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MirrorsEdgeUSA.rar"), @"downloads/MirrorsEdgeUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 174)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MortalKombat2EU.rar"), @"downloads/MortalKombat2EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 175)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/MortalKombat2USA.rar"), @"downloads/MortalKombat2USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 176)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/NarutoUNSEU.rar"), @"downloads/NarutoUNSEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 177)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/NFSRivalsEU.rar"), @"downloads/NFSRivalsEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 178)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/NFSHotPursuitEU.rar"), @"downloads/NFSHotPursuitEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 179)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/NFSHotPursuitUSA.rar"), @"downloads/NFSHotPursuitUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 180)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/NFSMostWantedEU.rar"), @"downloads/NFSMostWantedEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 181)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/NFSMostWantedUSA.rar"), @"downloads/NFSMostWantedUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 182)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/NFSShift2USA.rar"), @"downloads/NFSShift2USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 183)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/NFSTheRunEU.rar"), @"downloads/NFSTheRunEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 184)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/NFSTheRunUSA.rar"), @"downloads/NFSTheRunUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 185)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/OnePieceUSA.rar"), @"downloads/OnePieceUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 186)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/OnePiece2USA.rar"), @"downloads/OnePiece2USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 187)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/PayDay2EU.rar"), @"downloads/PayDay2EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 188)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/PayDay2USA.rar"), @"downloads/PayDay2USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 189)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/PrinceOfPersiaClassicUSA.rar"), @"downloads/PrinceOfPersiaClassicUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 190)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/PrinceOfPersiaTwoThronesEU.rar"), @"downloads/PrinceOfPersiaTwoThronesEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 191)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/PrinceOfPersiaTwoThronesUSA.rar"), @"downloads/PrinceOfPersiaTwoThronesUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 192)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/PrinceOfPersiaSandsOfTimeEU.rar"), @"downloads/PrinceOfPersiaSandsOfTimeEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 193)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/PrinceOfPersiaSandsOfTimeUSA.rar"), @"downloads/PrinceOfPersiaSandsOfTimeUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 194)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/PrototypeEU.rar"), @"downloads/PrototypeEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 195)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/PrototypeUSA.rar"), @"downloads/PrototypeUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 196)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/Prototype2USA.rar"), @"downloads/Prototype2USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 197)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/RainbowSixVegasUSA.rar"), @"downloads/RainbowSixVegasUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 198)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/RainbowSixVegas2USA.rar"), @"downloads/RainbowSixVegas2USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 199)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/RainbowSixVegas2EU.rar"), @"downloads/RainbowSixVegas2EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 200)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/RatchetAndClankEU.rar"), @"downloads/RatchetAndClankEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 201)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/RatchetAndClankUSA.rar"), @"downloads/RatchetAndClankUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 202)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/RatchetAndClank2EU.rar"), @"downloads/RatchetAndClank2EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 203)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/RatchetAndClank3EU.rar"), @"downloads/RatchetAndClank3EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 204)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/RedDeadRedemptionEU.rar"), @"downloads/RedDeadRedemptionEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 205)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/RedDeadRedemptionUSA.rar"), @"downloads/RedDeadRedemptionUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 206)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/RememberMeEU.rar"), @"downloads/RememberMeEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 207)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/RememberMeUSA.rar"), @"downloads/RememberMeUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 208)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/ResidentEvilDarksideEU.rar"), @"downloads/ResidentEvilDarksideEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 209)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/ResidentEvilDarksideUSA.rar"), @"downloads/ResidentEvilDarksideUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 210)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/ResidentEvil4EU.rar"), @"downloads/ResidentEvil4EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 211)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/ResidentEvil4USA.rar"), @"downloads/ResidentEvil4USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 212)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/ResidentEvilUmbrellaEU.rar"), @"downloads/ResidentEvilUmbrellaEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 213)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/ResidentEvilUmbrellaUSA.rar"), @"downloads/ResidentEvilUmbrellaUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 214)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/ResidentEvil5GoldEU.rar"), @"downloads/ResidentEvil5GoldEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 215)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/ResidentEvil5GoldUSA.rar"), @"downloads/ResidentEvil5GoldUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 216)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/ResidentEvil6EU.rar"), @"downloads/ResidentEvil6EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 217)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/ResidentEvil6USA.rar"), @"downloads/ResidentEvil6USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 218)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/ResidentEvilHDEU.rar"), @"downloads/ResidentEvilHDEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 219)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/ResidentEvilHDUSA.rar"), @"downloads/ResidentEvilHDUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 220)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/SaintsRow2EU.rar"), @"downloads/SaintsRow2EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 221)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/SaintsRow2USA.rar"), @"downloads/SaintsRow2USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 222)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/SaintsRow3EU.rar"), @"downloads/SaintsRow3EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 223)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/SaintsRow4EU.rar"), @"downloads/SaintsRow4EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 224)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/SaintsRow4USA.rar"), @"downloads/SaintsRow4USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 225)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/SniperGhostWarrior2EU.rar"), @"downloads/SniperGhostWarrior2EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 226)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/SniperGhostWarrior2USA.rar"), @"downloads/SniperGhostWarrior2USA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 227)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/SplinterCellPandoraTomorrowEU.rar"), @"downloads/SplinterCellPandoraTomorrowEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 228)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/SplinterCellhdEU.rar"), @"downloads/SplinterCellhdEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 229)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/TekkenRevolutionEU.rar"), @"downloads/TekkenRevolutionEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 230)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/TekkenRevolutionUSA.rar"), @"downloads/TekkenRevolutionUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 231)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/TekkenTag2EU.rar"), @"downloads/TekkenTag2EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 232)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/TheLastOfUsEU.rar"), @"downloads/TheLastOfUsEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 233)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/TheLastOfUsUSA.rar"), @"downloads/TheLastOfUsUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 234)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/TheWalkingDeadEU.rar"), @"downloads/TheWalkingDeadEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 235)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/TheWalkingDeadUSA.rar"), @"downloads/TheWalkingDeadUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 236)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/ThiefEU.rar"), @"downloads/ThiefEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 237)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/ThiefUSA.rar"), @"downloads/ThiefUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 238)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/TombRaiderEU.rar"), @"downloads/TombRaiderEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 239)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/TombRaiderUnderworldEU.rar"), @"downloads/TombRaiderUnderworldEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 240)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/TombRaiderUnderworldUSA.rar"), @"downloads/TombRaiderUnderworldUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 241)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/TransformersUSA.rar"), @"downloads/TransformersUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 242)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/UnchartedDrakesFortuneUSA.rar"), @"downloads/UnchartedDrakesFortuneUSA.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 243)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/UnchartedDrakesFortuneEU.rar"), @"downloads/UnchartedDrakesFortuneEU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit17.SelectedIndex == 244)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGames);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/Games/New/Uncharted2EU.rar"), @"downloads/Uncharted2EU.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CompletedDLC(object sender, AsyncCompletedEventArgs e)
        {
            if (XtraMessageBox.Show("Download Completed! \nYou will find the Link for the DLC in the downloads folder.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                progressBarControl8.EditValue = 0;
            }
        }

        private void simpleButton49_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit16.SelectedIndex == 0)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/BO2-Apocalypse-DLC.rar"), @"downloads/BO2-Apocalypse-DLC.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 1)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/BO2-Uprising-DLC.rar"), @"downloads/BO2-Uprising-DLC.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 2)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/BO2-Vengeance-DLC.rar"), @"downloads/BO2-Vengeance-DLC.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 3)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/BO2-Revolution-DLC.rar"), @"downloads/BO2-Revolution-DLC.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 4)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/BO2-Cyborg-Dragon-Camo-DLC.rar"), @"downloads/BO2-Cyborg-Dragon-Camo-DLC.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 5)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/BO3-Awakening-DLC.rar"), @"downloads/BO3-Awakening-DLC.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 6)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/Battlefield-4-DLC.rar"), @"downloads/Battlefield-4-DLC.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 7)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/Skyrim-DLC-Pack.rar"), @"downloads/Skyrim-DLC-Pack.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 8)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/BO1-ClassicZombie-DLC.rar"), @"downloads/BO1-ClassicZombie-DLC.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 9)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/BO1-FirstStrike-DLC.rar"), @"downloads/BO1-FirstStrike-DLC.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 10)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/BO1-Escalation-DLC.rar"), @"downloads/BO1-Escalation-DLC.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 11)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/BO1-Annihilation-DLC.rar"), @"downloads/BO1-Annihilation-DLC.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 12)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/BO1-Moon-DLC.rar"), @"downloads/BO1-Moon-DLC.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 13)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/AW-Supremacy-DLC.rar"), @"downloads/AW-Supremacy-DLC.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 14)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/Ghosts-DLC-Pack.rar"), @"downloads/Ghosts-DLC-Pack.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 15)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/Battlefield3-DLC-Pack.rar"), @"downloads/Battlefield3-DLC-Pack.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 16)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/Battlefield4premium.rar"), @"downloads/Battlefield-4-Premium.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 17)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/COD-AW-CollectorsUnlock.rar"), @"downloads/COD-AW-Collector's-Edition-Unlock.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 18)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/DragonAge-FeastdayPranks.rar"), @"downloads/Dragon-Age-Origins-Feastday-Pranks.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 19)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/StarhawkSolo-VictorRodriguez.rar"), @"downloads/Starhawk-Solo-Campaign-Victor-Rodriguez.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 20)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/GT5-LamborghiniLP640.rar"), @"downloads/GranTurismo-5-Lamborghini-MurcilagoLP-640-Chrome-Line.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 21)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/SaintsRow4BlingPack.rar"), @"downloads/Saints-Row-4-Bling-Bling-Pack.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 22)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/ME2-Arrival.rar"), @"downloads/ME2-Arrival.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 23)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/ME2-CerberusPack.rar"), @"downloads/ME2-CerberusPack.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 24)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/ME2-Genesis.rar"), @"downloads/ME2-Genesis.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 25)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/ME3-AppeareancePack.rar"), @"downloads/ME3-Alternate-Appeareance-Pack.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 26)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/ME3-Citadel.rar"), @"downloads/ME3-Citadel.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 27)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/ME3-EarthMPPack.rar"), @"downloads/ME3-Earth-Multiplayer-Pack.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 28)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/ME3-ExtendedCut.rar"), @"downloads/ME3-Extended-Cut.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 29)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/ME3-FromAshes.rar"), @"downloads/ME3-From-Ashes.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 30)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/ME3-GroundsidePack.rar"), @"downloads/ME3-Groundside-Resistance-Pack.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 31)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/ME3-Leviathan.rar"), @"downloads/ME3-Leviathan.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 32)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/ME3-Omega.rar"), @"downloads/ME3-Omega.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 33)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/ME3-OnlinePass.rar"), @"downloads/ME3-Online-Pass.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 34)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/ME3-RebellionPack.rar"), @"downloads/ME3-Rebellion-Pack.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 35)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/ME3-Reckoning.rar"), @"downloads/ME3-Reckoning.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 36)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/ME3-Resurgence.rar"), @"downloads/ME3-Resurgence.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 37)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/ME3-RetalliationPack.rar"), @"downloads/ME3-Retalliation-MP-Expansion-Pack.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 38)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/NarutoUNS-StormPack5.rar"), @"downloads/Naruto-UNS-Storm-Pack-5.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 39)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/Uncharted3-CoOpUnlock.rar"), @"downloads/Uncharted-3-Co-Op-Unlock.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 40)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/MaxPayne3-SilentKillerLoadout.rar"), @"downloads/Max-Payne-3-Silent-Killer-Loadout.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 41)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/SaintsRow4-SuperSaintsPack.rar"), @"downloads/Saints-Row-4-The-Super-Saints-Pack.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 42)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/DeadSpace-ObsidianWeaponPack.rar"), @"downloads/Dead-Space-Obsidian-Weapon-Pack.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 43)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/Dishonored-ArcadeAssassinPack.rar"), @"downloads/Dishonored-Arcade-Assassin-Pack.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 44)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/GT6-PerformancePack.rar"), @"downloads/Gran-Turismo-6-Performance-Pack.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 45)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/WatchDogs-ExclusiveMissions.rar"), @"downloads/Watch-Dogs-Exclusive-Missions.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 46)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/MirrorsEdge-PureTimeMapPack.rar"), @"downloads/Mirrors-Edge-Pure-Time-Trial-Map-Pack.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 47)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/RainbowSixVegas2-MPGiftPack.rar"), @"downloads/Rainbow-Six-Vegas-2-MP-Gift-Pack.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 48)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/DeadOrAlive5-NinjaClan2.rar"), @"downloads/Dead-Or-Alive5-Ninja-Clan-2.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 49)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/LANoire-ChicagoPianoWeapon.rar"), @"downloads/LA-Noire-The-Chicago-Piano-Weapon.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 50)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/Battlefield4-SecondAssault.rar"), @"downloads/Battlefield-4-Second-Assault.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 51)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/Ghosts-DynamicFreeFallMap.rar"), @"downloads/COD-Ghosts-Dynamic-Free-Fall-Map.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 52)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/GT5-CarPack3.rar"), @"downloads/Gran-Turismo-5-Car-Pack-3.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 53)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/RedDeadRedem-OutlawsEnd.rar"), @"downloads/Red-Dead-Redemption-Outlaws-to-the-End.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 54)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/AssassinCreed3-BenedictPack.rar"), @"downloads/Assassins-Creed-3-Benedict-Arnold-Pack.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 55)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/SniperElite-MPExpansion.rar"), @"downloads/Sniper-Elite-MP-Expansion.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 56)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/StarHawkSolo-MawofDespairMap.rar"), @"downloads/StarHawk-Solo-Maw-of-Despair-Co-Op-Map.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 57)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/Uncharted3-CoOpShadeMode.rar"), @"downloads/Uncharted-3-Co-Op-Shade-Survival-Mode.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 58)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/CODWAW-MapPack3.rar"), @"downloads/COD-WAW-Map-Pack-3.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxEdit16.SelectedIndex == 59)
            {
                try
                {
                    progressBarControl8.EditValue = 0;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDLC);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress5);
                    webClient.DownloadFileAsync(new Uri("https://www.cybermodding.it/Manager_Tool/DLC/DLC2/CODMW2-StimulusMapPack.rar"), @"downloads/COD-MW2-Stimulus-Map-Pack.rar");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReadChangelog();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            CheckforCommunications();
        }

        private void pictureBox99_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.cybermodding.it/forum.php");
        }

        private void simpleButton52_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.me/CyberModding");
        }

        private void simpleButton51_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.cybermodding.it/showthread.php?2485-LezZo-PS3-Manager-Tool-CID-Gen-FTP-Mod-Giochi-Ecc-Update-2-0-1");
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (textEdit2.Text.Length == 32)
            {
                PS3M_API.PS3.SetIDPS(textEdit2.Text);
                PS3M_API.PS3.Notify("New ConsoleID = " + textEdit2.Text);
            }
            else
            {
                XtraMessageBox.Show("Something goes wrong. IDPS Must be 32 characters! \nOr maybe you are not connected..", "Error..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (textEdit5.Text.Length == 32)
            {
                PS3M_API.PS3.SetPSID(textEdit5.Text);
                PS3M_API.PS3.Notify("New ConsoleID = " + textEdit5.Text);
            }
            else
            {
                XtraMessageBox.Show("Something goes wrong. PSID Must be 32 characters! \nOr maybe you are not connected..", "Error..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
