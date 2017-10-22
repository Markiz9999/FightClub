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
        Player player1;
        Player player2;
        int count = 0;  //к-во тиков таймера
        int tick = 0;   //текущий тик таймера
        
        bool stage = true;      //true - игрок атакует, false - игрок атакует.
        bool nextRound = true;
        int choise = 0;
        int compChoise = 0;
        int intRound = 1;

        public Form1()
        {
            InitializeComponent();

            this.Shown += Form1_Shown;

            player1 = new Player("Игрок");
            player2 = new Player("Компьютер");

            player1.Block += Block;
            player1.Wound += Wound;
            player1.Death += Death;

            player2.Block += Block;
            player2.Wound += Wound;
            player2.Death += Death;

            Name1.Text = player1.Name;
            Name2.Text = player2.Name;
            label2.Text = player1.Name;
            label8.Text = player2.Name;

            SetHP();
            SetRound();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Focus();
            textBox2.Text = "Выбираем игрока который защищается/атакует";

            Random rand = new Random();
            count = rand.Next(15, 17);
            timer1.Enabled = true;
        }

        private void ChangeStage() {
            if (stage)
            {
                label6.Text = "атакует";
                label7.Text = "защищается";
            }
            else {
                label6.Text = "защищается";
                label7.Text = "атакует";
            }
        }
        private void SetHP()
        {
            progressBar1.Value = player1.Hp;
            progressBar2.Value = player2.Hp;
            hp1.Text = player1.Hp.ToString();
            hp2.Text = player2.Hp.ToString();
        }
        private void SetRound() {
            round.Text = intRound.ToString();
        }

        public void Block(object sender)
        {
            Player player = sender as Player;

            textBox1.AppendText(player.Name + " отбился от удара. Урон не был получен.\r\n\r\n");
            textBox2.Text = player.Name + " отбился!";
        }

        public void Wound(object sender)
        {
            Player player = sender as Player;

            textBox1.AppendText(player.Name + " не смог отбиться от удара. Был получен урон в размере 10 хп.\r\n\r\n");
            textBox2.Text = player.Name + " получает урон!";
        }

        public void Death(object sender)
        {
            button1.Enabled = false;

            if (sender == player1)
            {
                textBox1.AppendText(player2.Name + " побеждает. " + player1.Name + " проигрывает\r\n");
                textBox2.Text = player2.Name + " победил!\r\n" + player1.Name + " проиграл!\r\n";
            }
            else {
                textBox1.AppendText(player1.Name + " побеждает. " + player2.Name + " проигрывает\r\n");
                textBox2.Text = player1.Name + " победил!\r\n" + player2.Name + " проиграл!\r\n";
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {  }

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (nextRound)
            {
                if (!timer1.Enabled)
                {
                    if (choise != 0)
                    {
                        RoundStart();
                    }
                    else
                    {
                        textBox2.Text = "Выберите часть тела!";
                    }
                }
                else
                {
                    textBox2.Text = "Делается выбор!";
                }
            }
            else
            {
                textBox2.Text = "Раунд " + intRound + " завершен!";

                intRound++;
                ChangeStage();
                SetRound();
                nextRound = true;

                button1.Text = "Запустить раунд!";

                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                choise = 0;

                arrow1.Visible = false;
                arrow2.Visible = false;
                arrow3.Visible = false;
                compChoise = 0;
            }
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
            radioButton2.Checked = false;
            radioButton1.Checked = false;

            choise = 3;

            textBox2.Text = player1.Name + " выбирает удар по ногам!";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            radioButton1.Checked = false;
            radioButton3.Checked = false;

            choise = 2;

            textBox2.Text = player1.Name + " выбирает удар в корпус!";
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            choise = 1;

            textBox2.Text = player1.Name + " выбирает удар в голову!";
        }

        private void RoundStart() {

            if (!timer2.Enabled)
            {
                count = new Random().Next(10, 20);
                tick = 0;
                timer2.Enabled = true;

                compChoise = count % 3 + 1;

                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;

                textBox2.Text = "Начинаем раунд " + intRound;
            }
            else {
                timer2.Enabled = false;

                if (stage)
                {
                    player2.SetBlock((BodyParts)compChoise);
                    player2.GetHit((BodyParts)choise);

                    stage = false;
                }
                else
                {
                    player1.SetBlock((BodyParts)choise);
                    player1.GetHit((BodyParts)compChoise);

                    stage = true;
                }
                SetHP();
                nextRound = false;
                button1.Text = "Закончить раунд";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (tick <= count)
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
