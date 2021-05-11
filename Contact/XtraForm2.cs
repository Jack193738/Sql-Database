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

namespace Contact
{
    
  
    
    public partial class XtraForm2 : DevExpress.XtraEditors.XtraForm
    {
        //public string password;
        //public string username;
        public XtraForm2()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            globvar.username = textEdit1.Text;
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
           globvar.password = textEdit2.Text;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
          



            XtraForm1 frm = new XtraForm1();
            frm.Show();
            Thread.Sleep(2000);
            XtraForm2 frm1 = new XtraForm2();
            frm1.Close();
            
            
            
        }

        private void XtraForm2_Load(object sender, EventArgs e)
        {

        }
        
        
    }
}