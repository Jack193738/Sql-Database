using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Contact
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string name;
        string age;
        string email;
        string phonenum;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                // image filters  
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    // display image in picture box  
                    pictureBox1.Image = new Bitmap(open.FileName);
                   
                }







            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                name = textBox1.Text;
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                age = textBox5.Text;
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                email = textBox4.Text;
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                phonenum = textBox3.Text;
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string folder = @"C:\Tmp\";

                string fileName = "Test.txt";

                string fullPath = folder + fileName;
                string[] details = { name, age, email, phonenum };
                File.WriteAllLines(fullPath, details);

            }
            catch(Exception g)
            {
                MessageBox.Show(g.Message);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datastoreDataSet.names' table. You can move, or remove it, as needed.
            this.namesTableAdapter.Fill(this.datastoreDataSet.names);

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            namesTableAdapter.Update(datastoreDataSet.names);
        }
    }
}
