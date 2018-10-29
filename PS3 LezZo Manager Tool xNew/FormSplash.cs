using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using PS3_LezZo_Manager_Tool_xNew;
using PS3_LezZo_Manager_Tool_xNew.Properties;

namespace PS3_LezZo_Manager_Tool_xNew
{
    public partial class FormSplash : SplashScreen
    {
        public FormSplash()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void FormSplash_Load(object sender, EventArgs e)
        {
            
        }
    }
}