using System;
using System.IO;
using System.Windows.Forms;
namespace WinForm_Txt_read
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddFriend_Click(object sender, EventArgs e)
        {
         StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Friends\\" + NameTB.Text + " " + SurnameTB + ".txt" );
            sw.WriteLine(label1.Text + " " +  );
        
        
        
        
        
        
        
        }
    } }