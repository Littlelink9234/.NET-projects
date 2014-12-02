namespace DogRacingGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startRace = new System.Windows.Forms.Button();
            this.alLabelBet = new System.Windows.Forms.Label();
            this.bobLabelBet = new System.Windows.Forms.Label();
            this.joeLabelBet = new System.Windows.Forms.Label();
            this.numOfDog = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numBetAmount = new System.Windows.Forms.NumericUpDown();
            this.betButton = new System.Windows.Forms.Button();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.bettorNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.racetrackPicBox = new System.Windows.Forms.PictureBox();
            this.raceTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBetAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.startRace);
            this.groupBox1.Controls.Add(this.alLabelBet);
            this.groupBox1.Controls.Add(this.bobLabelBet);
            this.groupBox1.Controls.Add(this.joeLabelBet);
            this.groupBox1.Controls.Add(this.numOfDog);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numBetAmount);
            this.groupBox1.Controls.Add(this.betButton);
            this.groupBox1.Controls.Add(this.alRadioButton);
            this.groupBox1.Controls.Add(this.bobRadioButton);
            this.groupBox1.Controls.Add(this.joeRadioButton);
            this.groupBox1.Controls.Add(this.bettorNameLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // startRace
            // 
            this.startRace.Location = new System.Drawing.Point(508, 151);
            this.startRace.Name = "startRace";
            this.startRace.Size = new System.Drawing.Size(105, 41);
            this.startRace.TabIndex = 12;
            this.startRace.Text = "Race!";
            this.startRace.UseVisualStyleBackColor = true;
            this.startRace.Click += new System.EventHandler(this.betButton_Click);
            // 
            // alLabelBet
            // 
            this.alLabelBet.AutoSize = true;
            this.alLabelBet.Location = new System.Drawing.Point(456, 86);
            this.alLabelBet.Name = "alLabelBet";
            this.alLabelBet.Size = new System.Drawing.Size(42, 16);
            this.alLabelBet.TabIndex = 11;
            this.alLabelBet.Text = "label6";
            // 
            // bobLabelBet
            // 
            this.bobLabelBet.AutoSize = true;
            this.bobLabelBet.Location = new System.Drawing.Point(456, 61);
            this.bobLabelBet.Name = "bobLabelBet";
            this.bobLabelBet.Size = new System.Drawing.Size(42, 16);
            this.bobLabelBet.TabIndex = 10;
            this.bobLabelBet.Text = "label5";
            // 
            // joeLabelBet
            // 
            this.joeLabelBet.AutoSize = true;
            this.joeLabelBet.Location = new System.Drawing.Point(456, 35);
            this.joeLabelBet.Name = "joeLabelBet";
            this.joeLabelBet.Size = new System.Drawing.Size(42, 16);
            this.joeLabelBet.TabIndex = 9;
            this.joeLabelBet.Text = "label4";
            // 
            // numOfDog
            // 
            this.numOfDog.Location = new System.Drawing.Point(259, 172);
            this.numOfDog.Name = "numOfDog";
            this.numOfDog.Size = new System.Drawing.Size(66, 23);
            this.numOfDog.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dog:";
            // 
            // numBetAmount
            // 
            this.numBetAmount.Location = new System.Drawing.Point(137, 172);
            this.numBetAmount.Name = "numBetAmount";
            this.numBetAmount.Size = new System.Drawing.Size(62, 23);
            this.numBetAmount.TabIndex = 6;
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(54, 172);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(68, 23);
            this.betButton.TabIndex = 5;
            this.betButton.Text = "bets";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click_1);
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(9, 107);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(37, 20);
            this.alRadioButton.TabIndex = 4;
            this.alRadioButton.TabStop = true;
            this.alRadioButton.Text = "Al";
            this.alRadioButton.UseVisualStyleBackColor = true;
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(9, 84);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(47, 20);
            this.bobRadioButton.TabIndex = 3;
            this.bobRadioButton.TabStop = true;
            this.bobRadioButton.Text = "Bob";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Location = new System.Drawing.Point(9, 61);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(45, 20);
            this.joeRadioButton.TabIndex = 2;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "Joe";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            // 
            // bettorNameLabel
            // 
            this.bettorNameLabel.AutoSize = true;
            this.bettorNameLabel.Location = new System.Drawing.Point(6, 174);
            this.bettorNameLabel.Name = "bettorNameLabel";
            this.bettorNameLabel.Size = new System.Drawing.Size(42, 16);
            this.bettorNameLabel.TabIndex = 1;
            this.bettorNameLabel.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum bet";
            // 
            // dog4
            // 
            this.dog4.Image = global::DogRacingGame.Properties.Resources.dog;
            this.dog4.Location = new System.Drawing.Point(12, 210);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(94, 50);
            this.dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dog4.TabIndex = 5;
            this.dog4.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.Image = global::DogRacingGame.Properties.Resources.dog;
            this.dog3.Location = new System.Drawing.Point(12, 154);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(94, 50);
            this.dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dog3.TabIndex = 4;
            this.dog3.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.Image = global::DogRacingGame.Properties.Resources.dog;
            this.dog2.Location = new System.Drawing.Point(12, 89);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(95, 50);
            this.dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dog2.TabIndex = 3;
            this.dog2.TabStop = false;
            // 
            // dog1
            // 
            this.dog1.Image = global::DogRacingGame.Properties.Resources.dog;
            this.dog1.Location = new System.Drawing.Point(12, 33);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(94, 50);
            this.dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dog1.TabIndex = 2;
            this.dog1.TabStop = false;
            // 
            // racetrackPicBox
            // 
            this.racetrackPicBox.Image = global::DogRacingGame.Properties.Resources.racetrack;
            this.racetrackPicBox.Location = new System.Drawing.Point(11, 13);
            this.racetrackPicBox.Name = "racetrackPicBox";
            this.racetrackPicBox.Size = new System.Drawing.Size(631, 275);
            this.racetrackPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.racetrackPicBox.TabIndex = 1;
            this.racetrackPicBox.TabStop = false;
            // 
            // raceTimer
            // 
            this.raceTimer.Tick += new System.EventHandler(this.raceTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 505);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.racetrackPicBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBetAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox racetrackPicBox;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.Button startRace;
        private System.Windows.Forms.Label alLabelBet;
        private System.Windows.Forms.Label bobLabelBet;
        private System.Windows.Forms.Label joeLabelBet;
        private System.Windows.Forms.NumericUpDown numOfDog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numBetAmount;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Label bettorNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer raceTimer;

    }
}

