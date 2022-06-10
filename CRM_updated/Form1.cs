using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_updated
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var btn = (Control)sender;

            pages.SetPage(btn.Tag.ToString());
            indicator.Top = btn.Top + (btn.Height / 2 - indicator.Height / 2);
        }
    }
}
