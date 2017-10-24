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
    public enum BodyParts { Head = 1, Body, Legs };

    public partial class MainWindow : Form
    {
        Game game;

        int count = 0;
        int tick = 0;

        public MainWindow()
        {
            InitializeComponent();

            game = new Game(this, Program.inputName.PlayerName, "Компьютер");
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            StartButton.Focus();
            textBox2.Text = "Выбираем игрока который защищается/атакует";

            Random rand = new Random();
            count = rand.Next(15, 17);
            RandomStageTimer.Enabled = true;
        }
        private void MainWindow_Click(object sender, EventArgs e)
        {
            textBox2.Text = "...";
        }

        //старт/конец раунда
        private void StartButton_Click(object sender, EventArgs e)
        {
            game.StartGame();
        }

        /***Радиобаттоны***/
        //выбор атаки по ногам
        private void LegsRadioButton_Click(object sender, EventArgs e)
        {
            LegsRadioButton.Checked = true;
            BodyRadioButton.Checked = false;
            HeadRadioButton.Checked = false;

            game.choise = (BodyParts)3;

            textBox2.Text = game.player1.Name + " выбирает удар по ногам!";
        }
        //выбор атаки в корпус
        private void BodyRadioButton_Click(object sender, EventArgs e)
        {
            BodyRadioButton.Checked = true;
            HeadRadioButton.Checked = false;
            LegsRadioButton.Checked = false;

            game.choise = (BodyParts)2;

            textBox2.Text = game.player1.Name + " выбирает удар в корпус!";
        }
        //выбор атаки в голову
        private void HeadRadioButton_Click(object sender, EventArgs e)
        {
            HeadRadioButton.Checked = true;
            BodyRadioButton.Checked = false;
            LegsRadioButton.Checked = false;

            game.choise = (BodyParts)1;

            textBox2.Text = game.player1.Name + " выбирает удар в голову!";
        }

        /****таймеры****/
        //рандомный выбор атаки компьютером
        private void RandomOponentChoise_Tick(object sender, EventArgs e)
        {
            if (game.tick <= game.count)
            {
                switch (game.tick % 3)
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

                game.tick++;
            }
            else {
                game.RoundStart();
            }
        }
        //рандомный выбор начала игры (защита/атака)
        private void RandomStageTimer_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();

            if (!game.stage)
                game.stage = true;
            else
                game.stage = false;

            game.ChangeStage();

            if (tick > count)
            {
                RandomStageTimer.Enabled = false;
                textBox2.Text = "Выбор сделан!\r\n Вы ";
                if (game.stage)
                    textBox2.Text += "атакуете.";
                else
                    textBox2.Text += "защищаетесь.";
            }
            tick++;
        }
    }
}
