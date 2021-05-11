using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using DevExpress.XtraBars.Alerter;

namespace Contact
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public int tries = 5;
        public int time = 0;
        
        
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textEdit1.Text == globvar.username && textEdit2.Text == globvar.password)
                {
                    Form1 frm = new Form1();
                    frm.Show();

                    XtraForm1 frm1 = new XtraForm1();
                    frm1.Close();
                }
                else
                {
                    MessageBox.Show("Try again", MessageBoxIcon.Information.ToString());
                    tries--;
                    if(tries == 0)
                    {
                        MessageBox.Show("Please wait for 60 seconds", MessageBoxIcon.Warning.ToString());
                        Thread.Sleep(60000);
                        MessageBox.Show("You Can now try again", MessageBoxIcon.Information.ToString());
                        tries = 5;
                        
                       
                       
                    }
                }
            }
            catch(Exception g)
            {
                MessageBox.Show(g.Message);
            }
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
        }
    }
}