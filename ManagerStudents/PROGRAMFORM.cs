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
    public partial class PROGRAMFORM : Form
    {
        public bool exita = true;
        public PROGRAMFORM()
        {
            InitializeComponent();
        }
        public event EventHandler Logout; // create 1 envent commission
        private void logout_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs()); //  tao

        }

        private void PROGRAMFORM_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(exita) // bang true
            Application.Exit();
        }

        private void exit_Click(object sender, EventArgs e)
        {

            if (exita) // bang true
                Application.Exit();


        }

        private void PROGRAMFORM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exita) // true
                if (MessageBox.Show("you wanna exit ", "erro", MessageBoxButtons.OKCancel) != DialogResult.OK)
                    e.Cancel = true;
        }
    }
}
