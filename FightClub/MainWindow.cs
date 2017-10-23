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
        Player player1;                 //первый игрок
        Player player2;                 //второй игрок (компьютер)

        int count = 0;                  //к-во тиков таймера
        int tick = 0;                   //текущий тик таймера
        
        bool stage = true;              //true - игрок атакует, false - игрок атакует.
        bool nextRound = true;          //запускается ли следующий раунд (тип нажатия кнопки)
        BodyParts choise = 0;           //выбор игрока
        BodyParts compChoise = 0;       //выбор компьютера
        int intRound = 1;               //счетчик раундов

        public MainWindow()
        {
            InitializeComponent();

            player1 = new Player(Program.inputName.PlayerName);
            player2 = new Player("Компьютер");

            player1.Block += Block;
            player1.Wound += Wound;
            player1.Death += Death;

            player2.Block += Block;
            player2.Wound += Wound;
            player2.Death += Death;

            Name1.Text = player1.Name;
            Name2.Text = player2.Name;
            Name12.Text = player1.Name;
            Name22.Text = player2.Name;

            SetHP();
            SetRound();
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

        //перерисовать стадию (защита/атака)
        private void ChangeStage() {
            if (stage)
            {
                Status1.Text = "атакует";
                Status2.Text = "защищается";
            }
            else {
                Status1.Text = "защищается";
                Status2.Text = "атакует";
            }
        }
        //перерисовать хп
        private void SetHP()
        {
            progressBar1.Value = player1.Hp;
            progressBar2.Value = player2.Hp;
            hp1.Text = player1.Hp.ToString();
            hp2.Text = player2.Hp.ToString();
        }
        //установить раунд
        private void SetRound() {
            round.Text = intRound.ToString();
        }

        //обработчики событий
        public void Block(object sender, PlayerEventArgs args)
        {
            Player player = sender as Player;

            textBox1.AppendText(args.name + " отбился от удара. Урон не был получен.\r\n\r\n");
            textBox2.Text = args.name + " отбился!";
        }
        public void Wound(object sender, PlayerEventArgs args)
        {
            Player player = sender as Player;

            textBox1.AppendText(args.name + " не смог отбиться от удара. Был получен урон в размере " + args.power + " хп. " + "У " + args.name + " осталось " + args.hp +" хп.\r\n\r\n");
            textBox2.Text = args.name + " получает урон!";
        }
        public void Death(object sender, PlayerEventArgs args)
        {
            StartButton.Enabled = false;

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

        //старт/конец раунда
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (nextRound)
            {
                if (!RandomStageTimer.Enabled)
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

                StartButton.Text = "Запустить раунд!";

                HeadRadioButton.Enabled = true;
                BodyRadioButton.Enabled = true;
                LegsRadioButton.Enabled = true;
                HeadRadioButton.Checked = false;
                BodyRadioButton.Checked = false;
                LegsRadioButton.Checked = false;
                choise = 0;

                arrow1.Visible = false;
                arrow2.Visible = false;
                arrow3.Visible = false;
                compChoise = 0;
            }
        }

        /***Радиобаттоны***/
        //выбор атаки по ногам
        private void LegsRadioButton_Click(object sender, EventArgs e)
        {
            LegsRadioButton.Checked = true;
            BodyRadioButton.Checked = false;
            HeadRadioButton.Checked = false;

            choise = (BodyParts)3;

            textBox2.Text = player1.Name + " выбирает удар по ногам!";
        }
        //выбор атаки в корпус
        private void BodyRadioButton_Click(object sender, EventArgs e)
        {
            BodyRadioButton.Checked = true;
            HeadRadioButton.Checked = false;
            LegsRadioButton.Checked = false;

            choise = (BodyParts)2;

            textBox2.Text = player1.Name + " выбирает удар в корпус!";
        }
        //выбор атаки в голову
        private void HeadRadioButton_Click(object sender, EventArgs e)
        {
            HeadRadioButton.Checked = true;
            BodyRadioButton.Checked = false;
            LegsRadioButton.Checked = false;

            choise = (BodyParts)1;

            textBox2.Text = player1.Name + " выбирает удар в голову!";
        }

        //запуск раунда
        private void RoundStart() {

            if (!RandomOponentChoise.Enabled)
            {
                count = new Random().Next(10, 20);
                tick = 0;
                RandomOponentChoise.Enabled = true;

                compChoise = (BodyParts)(count % 3 + 1);

                HeadRadioButton.Enabled = false;
                BodyRadioButton.Enabled = false;
                LegsRadioButton.Enabled = false;

                textBox2.Text = "Начинаем раунд " + intRound;
            }
            else {
                RandomOponentChoise.Enabled = false;

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
                StartButton.Text = "Закончить раунд";
            }
        }


        /****таймеры****/
        //рандомный выбор атаки компьютером
        private void RandomOponentChoise_Tick(object sender, EventArgs e)
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
        //рандомный выбор начала игры (защита/атака)
        private void RandomStageTimer_Tick(object sender, EventArgs e)
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
                RandomStageTimer.Enabled = false;
                textBox2.Text = "Выбор сделан!\r\n Вы ";
                if (stage)
                    textBox2.Text += "атакуете.";
                else
                    textBox2.Text += "защищаетесь.";
            }
            tick++;
        }

    }
}
