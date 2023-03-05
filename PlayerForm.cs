using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Esport
{
    public partial class PlayerForm : Form
    {
        static BindingList<Player> listPlayer = new BindingList<Player>();
        public static string Setname = "";
        public static string SetUsername = "";
        public int setIndex;
        public PlayerForm()
        {
            InitializeComponent();
            this.dataGridView1.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.DataSource = listPlayer;
            this.button1.Enabled= false;
        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            AddPlayerForm AddPlayerForm = new AddPlayerForm();
            AddPlayerForm.ShowDialog();

            if(AddPlayerForm.DialogResult == DialogResult.OK)
            {
                string name = AddPlayerForm.Setname;
                string usernmae = AddPlayerForm.Setusername;

                Player newPlayer = new Player(name, usernmae);
                listPlayer.Add(newPlayer);
                this.dataGridView1.DataSource = listPlayer;
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void selectedPlayer(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string name = row.Cells[0].Value.ToString();
                string username = row.Cells[1].Value.ToString();
                this.label4.Text = name;
                this.label5.Text = username;
                Setname = name;
                SetUsername = username;
                setIndex = e.RowIndex;
            }
            this.button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listPlayer.RemoveAt(setIndex);
            this.DialogResult = DialogResult.OK;
        }
    }
}
