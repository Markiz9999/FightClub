using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    class Game
    {
        private MainWindow mainWindow;         //форма вывода
        public Player player1;                 //первый игрок
        public Player player2;                 //второй игрок (компьютер)

        public int count = 0;                   //к-во тиков таймера
        public int tick = 0;                    //текущий тик таймера

        public bool stage = true;              //true - игрок атакует, false - игрок атакует.
        public bool nextRound = true;          //запускается ли следующий раунд (тип нажатия кнопки)
        public BodyParts choise = 0;           //выбор игрока
        public BodyParts compChoise = 0;       //выбор компьютера
        public int intRound = 1;               //счетчик раундов

        public Game(MainWindow MainWindow, string Name1, string Name2)
        {
            mainWindow = MainWindow;

            player1 = new Player(Name1);
            player2 = new Player(Name2);

            mainWindow.Name1.Text = Name1;
            mainWindow.Name2.Text = Name2;
            mainWindow.Name12.Text = Name1;
            mainWindow.Name22.Text = Name2;

            player1.Block += Block;
            player1.Wound += Wound;
            player1.Death += Death;

            player2.Block += Block;
            player2.Wound += Wound;
            player2.Death += Death;

            SetHP();
            SetRound();
        }

        public void StartGame() {
            if (nextRound)
            {
                if (!mainWindow.RandomStageTimer.Enabled)
                {
                    if (choise != 0)
                    {
                        RoundStart();
                    }
                    else
                    {
                        mainWindow.textBox2.Text = "Выберите часть тела!";
                    }
                }
                else
                {
                    mainWindow.textBox2.Text = "Делается выбор!";
                }
            }
            else
            {
                mainWindow.textBox2.Text = "Раунд " + intRound + " завершен!";

                intRound++;
                ChangeStage();
                SetRound();
                nextRound = true;

                mainWindow.StartButton.Text = "Запустить раунд!";

                mainWindow.HeadRadioButton.Enabled = true;
                mainWindow.BodyRadioButton.Enabled = true;
                mainWindow.LegsRadioButton.Enabled = true;
                mainWindow.HeadRadioButton.Checked = false;
                mainWindow.BodyRadioButton.Checked = false;
                mainWindow.LegsRadioButton.Checked = false;
                choise = 0;

                mainWindow.arrow1.Visible = false;
                mainWindow.arrow2.Visible = false;
                mainWindow.arrow3.Visible = false;
                compChoise = 0;
            }
        }

        //запуск раунда
        public void RoundStart()
        {

            if (!mainWindow.RandomOponentChoise.Enabled)
            {
                count = new Random().Next(10, 20);
                tick = 0;
                mainWindow.RandomOponentChoise.Enabled = true;

                compChoise = (BodyParts)(count % 3 + 1);

                mainWindow.HeadRadioButton.Enabled = false;
                mainWindow.BodyRadioButton.Enabled = false;
                mainWindow.LegsRadioButton.Enabled = false;

                mainWindow.textBox2.Text = "Начинаем раунд " + intRound;
            }
            else
            {
                mainWindow.RandomOponentChoise.Enabled = false;

                switch (count % 3)
                {
                    case 0:
                        mainWindow.arrow1.Visible = true;
                        mainWindow.arrow2.Visible = false;
                        mainWindow.arrow3.Visible = false;
                        break;
                    case 1:
                        mainWindow.arrow2.Visible = true;
                        mainWindow.arrow1.Visible = false;
                        mainWindow.arrow3.Visible = false;
                        break;
                    case 2:
                        mainWindow.arrow3.Visible = true;
                        mainWindow.arrow2.Visible = false;
                        mainWindow.arrow1.Visible = false;
                        break;
                }

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
                mainWindow.StartButton.Text = "Закончить раунд";
            }
        }

        //перерисовать стадию (защита/атака)
        public void ChangeStage()
        {
            if (stage)
            {
                mainWindow.Status1.Text = "атакует";
                mainWindow.Status2.Text = "защищается";
            }
            else
            {
                mainWindow.Status1.Text = "защищается";
                mainWindow.Status2.Text = "атакует";
            }
        }
        //перерисовать хп
        public void SetHP()
        {
            mainWindow.progressBar1.Value = player1.Hp;
            mainWindow.progressBar2.Value = player2.Hp;
            mainWindow.hp1.Text = player1.Hp.ToString();
            mainWindow.hp2.Text = player2.Hp.ToString();
        }
        //установить раунд
        public void SetRound()
        {
            mainWindow.round.Text = intRound.ToString();
        }

        //обработчики событий
        public void Block(object sender, PlayerEventArgs args)
        {
            Player player = sender as Player;

            mainWindow.textBox1.AppendText(args.name + " отбился от удара. Урон не был получен.\r\n\r\n");
            mainWindow.textBox2.Text = args.name + " отбился!";
        }
        public void Wound(object sender, PlayerEventArgs args)
        {
            Player player = sender as Player;

            mainWindow.textBox1.AppendText(args.name + " не смог отбиться от удара. Был получен урон в размере " + args.power + " хп. " + "У " + args.name + " осталось " + args.hp + " хп.\r\n\r\n");
            mainWindow.textBox2.Text = args.name + " получает урон!";
        }
        public void Death(object sender, PlayerEventArgs args)
        {
            mainWindow.StartButton.Enabled = false;

            if (sender == player1)
            {
                mainWindow.textBox1.AppendText(player2.Name + " побеждает. " + player1.Name + " проигрывает\r\n");
                mainWindow.textBox2.Text = player2.Name + " победил!\r\n" + player1.Name + " проиграл!\r\n";
            }
            else
            {
                mainWindow.textBox1.AppendText(player1.Name + " побеждает. " + player2.Name + " проигрывает\r\n");
                mainWindow.textBox2.Text = player1.Name + " победил!\r\n" + player2.Name + " проиграл!\r\n";
            }
        }

        //отписаться от событий
        ~Game(){
            //отписаться от событий
            player1.Block -= Block;
            player1.Wound -= Wound;
            player1.Death -= Death;

            player2.Block -= Block;
            player2.Wound -= Wound;
            player2.Death -= Death;
        }
    }
}
