using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub
{
    public partial class InputName : Form
    {
        private string playerName;      //имя игрока
        public bool Status = false;     //было ли введено имя

        public string PlayerName { get { return playerName; } }

        public InputName()
        {
            InitializeComponent();
        }

        private void ConfirmName_Click(object sender, EventArgs e)
        {
            if (textName.TextLength > 0)
            {
                Status = true;
                playerName = textName.Text;
                Close();
            }
        }

        private void textName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textName.TextLength > 0)
                {
                    Status = true;
                    playerName = textName.Text;
                    Close();
                }
            }
        }
    }
}
