using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.Utils;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        ToolTipHelper helper;

        public Form1()
        {
            InitializeComponent();

            helper = new ToolTipHelper(barManager1);
            helper.ShowToolTipInMenuItems = true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            helper.ShowToolTipInMenuItems = false;
        }
    }
}