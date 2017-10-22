using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub
{
    enum BodyParts { Head = 1, Body, Legs };
    public partial class Form1 : Form
    {
        Player player1 = new Player("Вы");
        Player player2 = new Player("Компьютер");
        int count = 0;  //к-во тиков таймера
        int tick = 0;   //текущий тик таймера
        //true - игрок атакует, false - игрок атакует.
        bool stage = true;
        int choise = 0;
        int compChoise = 0;

        public Form1()
        {
            InitializeComponent();

            this.Shown += Form1_Shown;

            Name1.Text = player1.Name;
            Name2.Text = player2.Name;

            SetHP();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Focus();
            textBox2.Text = "Выбираем игрока который защищается/атакует";
        }

        private void ChangeStage() {
            if (stage)
            {
                label6.Text = "атакуете";
                label7.Text = "защищается";
            }
            else {
                label6.Text = "защищаетесь";
                label7.Text = "атакует";
            }
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            Random rand = new Random();
            count = rand.Next(15, 17);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();

            if (!stage)
                stage = true;
            else
                stage = false;

            ChangeStage();
            Invalidate();
            if (tick > count)
            {
                timer1.Enabled = false;
                textBox2.Text = "Выбор сделан!\r\n Вы ";
                if (stage)
                    textBox2.Text += "атакуете.";
                else
                    textBox2.Text += "защищаетесь.";
            }
            tick++;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "...";
        }

        private void SetHP() {
            progressBar1.Value = player1.Hp;
            progressBar2.Value = player2.Hp;
            hp1.Text = player1.Hp.ToString();
            hp2.Text = player2.Hp.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                if (choise != 0)
                {
                    RoundStart();
                }
                else {
                    textBox2.Text = "Выберите часть тела!";
                }
            }
            else {
                textBox2.Text = "Делается выбор!";
            }
           
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
            radioButton2.Checked = false;
            radioButton1.Checked = false;

            choise = 3;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            radioButton1.Checked = false;
            radioButton3.Checked = false;

            choise = 2;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            choise = 1;
        }

        private void RoundStart() {

            if (!timer2.Enabled)
            {
                count = new Random().Next(10, 20);
                tick = 0;
                timer2.Enabled = true;

                compChoise = count % 3 + 1;

                textBox2.Text = "Начинаем раунд!";
            }
            else {
                timer2.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (tick < count)
            {
                switch (tick % 3)
                {
                    case 0:
                        arrow1.Visible = true;
                        arrow2.Visible = false;
                        arrow3.Visible = false;
                        break;
                    case 1:
                        arrow2.Visible = true;
                        arrow1.Visible = false;
                        arrow3.Visible = false;
                        break;
                    case 2:
                        arrow3.Visible = true;
                        arrow2.Visible = false;
                        arrow1.Visible = false;
                        break;
                }

                tick++;
            }
            else {
                RoundStart();
            }
        }
    }
}
