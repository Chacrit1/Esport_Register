using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esport
{
    public partial class AddTeamForm : Form
    {
        public static string Setname = "";
        public static string Setusername = "";
        public AddTeamForm()
        {
            InitializeComponent();
        }
        private void seletedPlayer(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            PlayerForm playerForm = new PlayerForm();
            playerForm.ShowDialog();

            if (playerForm.DialogResult == DialogResult.OK)
            {
                string name = PlayerForm.Setname;
                string username = PlayerForm.SetUsername;
                if (button.Name == "buttonSec1")
                {
                    this.textBox2.Text = name;
                    this.textBox3.Text = username;
       
                }
                if (button.Name == "buttonSec2")
                {
                    this.textBox5.Text = name;
                    this.textBox4.Text = username;

                }
                if (button.Name == "buttonSec3")
                {
                    this.textBox7.Text = name;
                    this.textBox6.Text = username;
    
                }
                if (button.Name == "buttonSec4")
                {
                    this.textBox9.Text = name;
                    this.textBox8.Text = username;
       
                }
                if (button.Name == "buttonSec5")
                {
                    this.textBox11.Text = name;
                    this.textBox10.Text = username;
          
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string team = this.textBox1.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
