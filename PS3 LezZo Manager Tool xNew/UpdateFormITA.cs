using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net;
using DevExpress;
using DevExpress.XtraBars;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.Data;
using DevExpress.UserSkins;
using DevExpress.Printing;
using DevExpress.Sparkline;
using DevExpress.XtraSplashScreen;
using DevExpress.Sparkline.Core;
using DevExpress.XtraTab;

namespace PS3_LezZo_Manager_Tool_xNew
{
    public partial class UpdateFormITA : DevExpress.XtraEditors.XtraForm
    {
        public UpdateFormITA()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
        }

        private void UpdateFormITA_Load(object sender, EventArgs e)
        {
            simpleButton1_Click(sender, e);
        }

        private void DownloadProgressUpd(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBarControl1.EditValue = e.ProgressPercentage;
        }

        private void CompletedDown(object sender, AsyncCompletedEventArgs e)
        {
            XtraMessageBox.Show("Download Completato! \nAvvia la nuova versione e goditela :) \nTroverai l'archivio aggiornato nella cartella del Tool.", "Fatto!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Application.Exit();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string URL = "http://www.cybermodding.it/Manager_Tool/";
            string appName = "PS3_LezZo_Manager_XMB_Tool_Update.rar";

            WebClient webc = new WebClient();
            webc.DownloadFileAsync(new Uri(URL + appName), "PS3_LezZo_Manager_XMB_Tool_Update.rar");
            webc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDown);
            webc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressUpd);
        }
    }
}