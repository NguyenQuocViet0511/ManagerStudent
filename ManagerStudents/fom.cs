using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerStudents
{
    public partial class fom : Form
    {
        List<Account> Listaccount = ListAccount.Setting1.Listaccount;
        public fom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
          
           
               
            Application.Exit();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if(Checkacount(account.Text, password.Text))
            {
                PROGRAMFORM PRG = new PROGRAMFORM();
                PRG.Show(); //  only use it , not click to other tap
                this.Hide();
                PRG.Logout += PRG_Logout;
            }   
            else
            {
                MessageBox.Show("erro account and password", "please enter again");

            }    
           
           
        }

        private void PRG_Logout(object sender, EventArgs e)
        {
            (sender as PROGRAMFORM).exita = false;
            (sender as PROGRAMFORM).Close();
            this.Show();
        }
       public bool Checkacount(String account , String password)
        {
            for(int i = 0;i< Listaccount.Count;i++)
            {
                if(account == Listaccount[i].NameAccount1 && password == Listaccount[i].PassWord)
                {
                    return true;
                }
               
            }
            return false;
        }

        private void fom_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("you wanna exit", "erre", MessageBoxButtons.OKCancel) != DialogResult.OK)
                e.Cancel = true;
        }
    }
}
