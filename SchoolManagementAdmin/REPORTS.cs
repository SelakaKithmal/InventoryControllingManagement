using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Diagnostics;

namespace SATHOSA_ICS
{
    public partial class REPORTS : MetroForm
    {
        public REPORTS()
        {
            InitializeComponent();
        }

        private void REPORTS_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://selaka/Reports_SELA/Pages/Report.aspx?ItemPath=%2fSathosa+Customer+Report%2fCUSTOMER+FULL+LIST ");
            Process.Start(sInfo);
        }
    }
}
