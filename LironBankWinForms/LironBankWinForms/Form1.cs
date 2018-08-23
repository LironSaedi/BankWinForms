using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LironBankWinForms
{
    
    public partial class Form1 : Form
    {

        
       

        Bank bank = new Bank();
       public bool Continue = false;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Finished_Click(object sender, EventArgs e)
        {
            string textBoxUser = UsernameTextBox.Text;
            string textBoxPass = passwordTextBox.Text;
            bool checkerUser = false;
            if(bank.Login(textBoxUser, textBoxPass) )
            {
                LoginLabel.Visible = true;
                LoginLabel.Text = "         You Have Logged In          ";
            }
            else
            {
                LoginLabel.Visible = true;
                LoginLabel.Text = "         You Have Failed To Login            ";
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UsernameForgetFullness_Click(object sender, EventArgs e)
        {

        }
    }
}
