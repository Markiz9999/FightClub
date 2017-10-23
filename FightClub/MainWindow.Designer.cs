namespace FightClub
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.round = new System.Windows.Forms.Label();
            this.Name1 = new System.Windows.Forms.Label();
            this.Name2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.StartButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.hp1 = new System.Windows.Forms.Label();
            this.hp2 = new System.Windows.Forms.Label();
            this.Name12 = new System.Windows.Forms.Label();
            this.Status1 = new System.Windows.Forms.Label();
            this.Status2 = new System.Windows.Forms.Label();
            this.Name22 = new System.Windows.Forms.Label();
            this.HeadRadioButton = new System.Windows.Forms.RadioButton();
            this.BodyRadioButton = new System.Windows.Forms.RadioButton();
            this.LegsRadioButton = new System.Windows.Forms.RadioButton();
            this.RandomStageTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.arrow1 = new System.Windows.Forms.Label();
            this.arrow2 = new System.Windows.Forms.Label();
            this.arrow3 = new System.Windows.Forms.Label();
            this.RandomOponentChoise = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(527, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Раунд";
            // 
            // round
            // 
            this.round.AutoSize = true;
            this.round.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.round.Location = new System.Drawing.Point(678, 9);
            this.round.Name = "round";
            this.round.Size = new System.Drawing.Size(42, 67);
            this.round.TabIndex = 1;
            this.round.Text = "i";
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name1.Location = new System.Drawing.Point(196, 9);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(67, 46);
            this.Name1.TabIndex = 2;
            this.Name1.Text = "Вы";
            // 
            // Name2
            // 
            this.Name2.AutoSize = true;
            this.Name2.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name2.Location = new System.Drawing.Point(925, 9);
            this.Name2.Name = "Name2";
            this.Name2.Size = new System.Drawing.Size(174, 46);
            this.Name2.TabIndex = 3;
            this.Name2.Text = "Компьтер";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(73, 70);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(341, 27);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 100;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(402, 189);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(446, 373);
            this.textBox1.TabIndex = 2;
            // 
            // progressBar2
            // 
            this.progressBar2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar2.Location = new System.Drawing.Point(842, 70);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(341, 27);
            this.progressBar2.Step = 1;
            this.progressBar2.TabIndex = 7;
            this.progressBar2.Value = 100;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(494, 587);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(258, 43);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Запустить раунд!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(566, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 46);
            this.label5.TabIndex = 9;
            this.label5.Text = "Судья";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(402, 126);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(446, 56);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "...";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hp1
            // 
            this.hp1.AutoSize = true;
            this.hp1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hp1.Location = new System.Drawing.Point(420, 69);
            this.hp1.Name = "hp1";
            this.hp1.Size = new System.Drawing.Size(45, 28);
            this.hp1.TabIndex = 11;
            this.hp1.Text = "100";
            // 
            // hp2
            // 
            this.hp2.AutoSize = true;
            this.hp2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hp2.Location = new System.Drawing.Point(791, 70);
            this.hp2.Name = "hp2";
            this.hp2.Size = new System.Drawing.Size(45, 28);
            this.hp2.TabIndex = 12;
            this.hp2.Text = "100";
            // 
            // Name12
            // 
            this.Name12.AutoSize = true;
            this.Name12.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name12.Location = new System.Drawing.Point(66, 189);
            this.Name12.Name = "Name12";
            this.Name12.Size = new System.Drawing.Size(70, 42);
            this.Name12.TabIndex = 13;
            this.Name12.Text = "Вы:";
            // 
            // Status1
            // 
            this.Status1.AutoSize = true;
            this.Status1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status1.Location = new System.Drawing.Point(158, 231);
            this.Status1.Name = "Status1";
            this.Status1.Size = new System.Drawing.Size(139, 42);
            this.Status1.TabIndex = 14;
            this.Status1.Text = "атакуете";
            // 
            // Status2
            // 
            this.Status2.AutoSize = true;
            this.Status2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status2.Location = new System.Drawing.Point(1044, 231);
            this.Status2.Name = "Status2";
            this.Status2.Size = new System.Drawing.Size(188, 42);
            this.Status2.TabIndex = 16;
            this.Status2.Text = "защищается";
            // 
            // Name22
            // 
            this.Name22.AutoSize = true;
            this.Name22.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name22.Location = new System.Drawing.Point(864, 189);
            this.Name22.Name = "Name22";
            this.Name22.Size = new System.Drawing.Size(193, 42);
            this.Name22.TabIndex = 15;
            this.Name22.Text = "Компьютер:";
            // 
            // HeadRadioButton
            // 
            this.HeadRadioButton.AutoCheck = false;
            this.HeadRadioButton.AutoSize = true;
            this.HeadRadioButton.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeadRadioButton.Location = new System.Drawing.Point(117, 326);
            this.HeadRadioButton.Name = "HeadRadioButton";
            this.HeadRadioButton.Size = new System.Drawing.Size(156, 50);
            this.HeadRadioButton.TabIndex = 17;
            this.HeadRadioButton.TabStop = true;
            this.HeadRadioButton.Text = "Голова";
            this.HeadRadioButton.UseVisualStyleBackColor = true;
            this.HeadRadioButton.Click += new System.EventHandler(this.HeadRadioButton_Click);
            // 
            // BodyRadioButton
            // 
            this.BodyRadioButton.AutoCheck = false;
            this.BodyRadioButton.AutoSize = true;
            this.BodyRadioButton.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BodyRadioButton.Location = new System.Drawing.Point(117, 383);
            this.BodyRadioButton.Name = "BodyRadioButton";
            this.BodyRadioButton.Size = new System.Drawing.Size(155, 50);
            this.BodyRadioButton.TabIndex = 18;
            this.BodyRadioButton.TabStop = true;
            this.BodyRadioButton.Text = "Корпус";
            this.BodyRadioButton.UseVisualStyleBackColor = true;
            this.BodyRadioButton.Click += new System.EventHandler(this.BodyRadioButton_Click);
            // 
            // LegsRadioButton
            // 
            this.LegsRadioButton.AutoCheck = false;
            this.LegsRadioButton.AutoSize = true;
            this.LegsRadioButton.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LegsRadioButton.Location = new System.Drawing.Point(117, 440);
            this.LegsRadioButton.Name = "LegsRadioButton";
            this.LegsRadioButton.Size = new System.Drawing.Size(123, 50);
            this.LegsRadioButton.TabIndex = 19;
            this.LegsRadioButton.TabStop = true;
            this.LegsRadioButton.Text = "Ноги";
            this.LegsRadioButton.UseVisualStyleBackColor = true;
            this.LegsRadioButton.Click += new System.EventHandler(this.LegsRadioButton_Click);
            // 
            // RandomStageTimer
            // 
            this.RandomStageTimer.Interval = 200;
            this.RandomStageTimer.Tick += new System.EventHandler(this.RandomStageTimer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1012, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 46);
            this.label3.TabIndex = 20;
            this.label3.Text = "Голова";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1012, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 46);
            this.label4.TabIndex = 21;
            this.label4.Text = "Корпус";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(1012, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 46);
            this.label9.TabIndex = 22;
            this.label9.Text = "Ноги";
            // 
            // arrow1
            // 
            this.arrow1.AutoSize = true;
            this.arrow1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrow1.Location = new System.Drawing.Point(978, 336);
            this.arrow1.Name = "arrow1";
            this.arrow1.Size = new System.Drawing.Size(41, 39);
            this.arrow1.TabIndex = 23;
            this.arrow1.Text = "→";
            this.arrow1.Visible = false;
            // 
            // arrow2
            // 
            this.arrow2.AutoSize = true;
            this.arrow2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrow2.Location = new System.Drawing.Point(978, 391);
            this.arrow2.Name = "arrow2";
            this.arrow2.Size = new System.Drawing.Size(41, 39);
            this.arrow2.TabIndex = 24;
            this.arrow2.Text = "→";
            this.arrow2.Visible = false;
            // 
            // arrow3
            // 
            this.arrow3.AutoSize = true;
            this.arrow3.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrow3.Location = new System.Drawing.Point(978, 448);
            this.arrow3.Name = "arrow3";
            this.arrow3.Size = new System.Drawing.Size(41, 39);
            this.arrow3.TabIndex = 25;
            this.arrow3.Text = "→";
            this.arrow3.Visible = false;
            // 
            // RandomOponentChoise
            // 
            this.RandomOponentChoise.Tick += new System.EventHandler(this.RandomOponentChoise_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.arrow3);
            this.Controls.Add(this.arrow2);
            this.Controls.Add(this.arrow1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LegsRadioButton);
            this.Controls.Add(this.BodyRadioButton);
            this.Controls.Add(this.HeadRadioButton);
            this.Controls.Add(this.Status2);
            this.Controls.Add(this.Name22);
            this.Controls.Add(this.Status1);
            this.Controls.Add(this.Name12);
            this.Controls.Add(this.hp2);
            this.Controls.Add(this.hp1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Name2);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.round);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Бойцовский клуб";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Click += new System.EventHandler(this.MainWindow_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label round;
        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.Label Name2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label hp1;
        private System.Windows.Forms.Label hp2;
        private System.Windows.Forms.Label Name12;
        private System.Windows.Forms.Label Status1;
        private System.Windows.Forms.Label Status2;
        private System.Windows.Forms.Label Name22;
        private System.Windows.Forms.RadioButton HeadRadioButton;
        private System.Windows.Forms.RadioButton BodyRadioButton;
        private System.Windows.Forms.RadioButton LegsRadioButton;
        private System.Windows.Forms.Timer RandomStageTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label arrow1;
        private System.Windows.Forms.Label arrow2;
        private System.Windows.Forms.Label arrow3;
        private System.Windows.Forms.Timer RandomOponentChoise;
        public System.Windows.Forms.TextBox textBox1;
    }
}

