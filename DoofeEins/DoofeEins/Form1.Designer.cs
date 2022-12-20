namespace DoofeEins
{
    partial class gameScreen
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameScreen));
            this.allScreens = new System.Windows.Forms.TabControl();
            this.menuScreen = new System.Windows.Forms.TabPage();
            this.tutorialButton = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.PictureBox();
            this.twoPlayerButton = new System.Windows.Forms.PictureBox();
            this.onePlayerButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.runningGameScreen = new System.Windows.Forms.TabPage();
            this.roundGroup = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.roundInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.playerTwoPanel = new System.Windows.Forms.Panel();
            this.playerTwoLabel = new System.Windows.Forms.Label();
            this.playerTwoPoints = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.exposeButton = new System.Windows.Forms.Button();
            this.rollDiceButton = new System.Windows.Forms.Button();
            this.playerOnePanel = new System.Windows.Forms.Panel();
            this.playerOneLabel = new System.Windows.Forms.Label();
            this.playerOnePoints = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.allRounds = new System.Windows.Forms.Label();
            this.twoPlayerScreen = new System.Windows.Forms.TabPage();
            this.settingsScreen = new System.Windows.Forms.TabPage();
            this.playMuteMusic = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tutorialScreen = new System.Windows.Forms.TabPage();
            this.backButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.onePlayerAllPoints = new System.Windows.Forms.Label();
            this.twoPlayerAllPoints = new System.Windows.Forms.Label();
            this.allScreens.SuspendLayout();
            this.menuScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tutorialButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoPlayerButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onePlayerButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.runningGameScreen.SuspendLayout();
            this.roundGroup.SuspendLayout();
            this.playerTwoPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.playerOnePanel.SuspendLayout();
            this.settingsScreen.SuspendLayout();
            this.tutorialScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // allScreens
            // 
            this.allScreens.Controls.Add(this.menuScreen);
            this.allScreens.Controls.Add(this.runningGameScreen);
            this.allScreens.Controls.Add(this.twoPlayerScreen);
            this.allScreens.Controls.Add(this.settingsScreen);
            this.allScreens.Controls.Add(this.tutorialScreen);
            this.allScreens.Location = new System.Drawing.Point(-17, -34);
            this.allScreens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allScreens.Name = "allScreens";
            this.allScreens.SelectedIndex = 0;
            this.allScreens.Size = new System.Drawing.Size(564, 643);
            this.allScreens.TabIndex = 0;
            // 
            // menuScreen
            // 
            this.menuScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(29)))), ((int)(((byte)(14)))));
            this.menuScreen.Controls.Add(this.tutorialButton);
            this.menuScreen.Controls.Add(this.settingsButton);
            this.menuScreen.Controls.Add(this.twoPlayerButton);
            this.menuScreen.Controls.Add(this.onePlayerButton);
            this.menuScreen.Controls.Add(this.pictureBox1);
            this.menuScreen.Location = new System.Drawing.Point(4, 21);
            this.menuScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuScreen.Name = "menuScreen";
            this.menuScreen.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuScreen.Size = new System.Drawing.Size(556, 618);
            this.menuScreen.TabIndex = 0;
            this.menuScreen.Text = "menu";
            // 
            // tutorialButton
            // 
            this.tutorialButton.BackColor = System.Drawing.Color.Black;
            this.tutorialButton.BackgroundImage = global::DoofeEins.Properties.Resources.tutorialButton;
            this.tutorialButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tutorialButton.Location = new System.Drawing.Point(22, 535);
            this.tutorialButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tutorialButton.Name = "tutorialButton";
            this.tutorialButton.Size = new System.Drawing.Size(510, 60);
            this.tutorialButton.TabIndex = 2;
            this.tutorialButton.TabStop = false;
            this.tutorialButton.Click += new System.EventHandler(this.tutorialButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Black;
            this.settingsButton.BackgroundImage = global::DoofeEins.Properties.Resources.settingsButton;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.Location = new System.Drawing.Point(22, 462);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(510, 60);
            this.settingsButton.TabIndex = 2;
            this.settingsButton.TabStop = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // twoPlayerButton
            // 
            this.twoPlayerButton.BackColor = System.Drawing.Color.Black;
            this.twoPlayerButton.BackgroundImage = global::DoofeEins.Properties.Resources.twoPlayerButton;
            this.twoPlayerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twoPlayerButton.Location = new System.Drawing.Point(22, 386);
            this.twoPlayerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.twoPlayerButton.Name = "twoPlayerButton";
            this.twoPlayerButton.Size = new System.Drawing.Size(510, 60);
            this.twoPlayerButton.TabIndex = 2;
            this.twoPlayerButton.TabStop = false;
            this.twoPlayerButton.Click += new System.EventHandler(this.twoPlayerButton_Click);
            // 
            // onePlayerButton
            // 
            this.onePlayerButton.BackColor = System.Drawing.Color.Black;
            this.onePlayerButton.BackgroundImage = global::DoofeEins.Properties.Resources.onePlayerButton;
            this.onePlayerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onePlayerButton.Location = new System.Drawing.Point(22, 310);
            this.onePlayerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.onePlayerButton.Name = "onePlayerButton";
            this.onePlayerButton.Size = new System.Drawing.Size(510, 60);
            this.onePlayerButton.TabIndex = 2;
            this.onePlayerButton.TabStop = false;
            this.onePlayerButton.Click += new System.EventHandler(this.onePlayerButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DoofeEins.Properties.Resources.menuScreenBg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(541, 310);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // runningGameScreen
            // 
            this.runningGameScreen.BackgroundImage = global::DoofeEins.Properties.Resources.bg;
            this.runningGameScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.runningGameScreen.Controls.Add(this.roundGroup);
            this.runningGameScreen.Controls.Add(this.playerTwoPanel);
            this.runningGameScreen.Controls.Add(this.gamePanel);
            this.runningGameScreen.Location = new System.Drawing.Point(4, 21);
            this.runningGameScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.runningGameScreen.Name = "runningGameScreen";
            this.runningGameScreen.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.runningGameScreen.Size = new System.Drawing.Size(556, 618);
            this.runningGameScreen.TabIndex = 1;
            this.runningGameScreen.Text = "runningGameScreen";
            // 
            // roundGroup
            // 
            this.roundGroup.BackgroundImage = global::DoofeEins.Properties.Resources.rundenanzahl;
            this.roundGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundGroup.Controls.Add(this.cancelButton);
            this.roundGroup.Controls.Add(this.startButton);
            this.roundGroup.Controls.Add(this.roundInput);
            this.roundGroup.Controls.Add(this.label1);
            this.roundGroup.Location = new System.Drawing.Point(30, 150);
            this.roundGroup.Name = "roundGroup";
            this.roundGroup.Size = new System.Drawing.Size(497, 253);
            this.roundGroup.TabIndex = 4;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(44)))), ((int)(((byte)(20)))));
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(77)))), ((int)(((byte)(32)))));
            this.cancelButton.FlatAppearance.BorderSize = 3;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Alagard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(283, 201);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(137, 37);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Abbrechen";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(44)))), ((int)(((byte)(20)))));
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(77)))), ((int)(((byte)(32)))));
            this.startButton.FlatAppearance.BorderSize = 3;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Alagard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(101, 201);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 37);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Starten";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // roundInput
            // 
            this.roundInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(44)))), ((int)(((byte)(20)))));
            this.roundInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roundInput.Font = new System.Drawing.Font("Alagard", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundInput.ForeColor = System.Drawing.Color.White;
            this.roundInput.Location = new System.Drawing.Point(55, 160);
            this.roundInput.Name = "roundInput";
            this.roundInput.Size = new System.Drawing.Size(389, 35);
            this.roundInput.TabIndex = 1;
            this.roundInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.roundInput.TextChanged += new System.EventHandler(this.roundInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(169, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mögliche Runden: 1-100";
            // 
            // playerTwoPanel
            // 
            this.playerTwoPanel.BackColor = System.Drawing.Color.Transparent;
            this.playerTwoPanel.Controls.Add(this.playerTwoLabel);
            this.playerTwoPanel.Controls.Add(this.twoPlayerAllPoints);
            this.playerTwoPanel.Controls.Add(this.playerTwoPoints);
            this.playerTwoPanel.Location = new System.Drawing.Point(391, 22);
            this.playerTwoPanel.Name = "playerTwoPanel";
            this.playerTwoPanel.Size = new System.Drawing.Size(137, 569);
            this.playerTwoPanel.TabIndex = 3;
            this.playerTwoPanel.Visible = false;
            // 
            // playerTwoLabel
            // 
            this.playerTwoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerTwoLabel.Font = new System.Drawing.Font("Alagard", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoLabel.Location = new System.Drawing.Point(14, 15);
            this.playerTwoLabel.Name = "playerTwoLabel";
            this.playerTwoLabel.Size = new System.Drawing.Size(123, 32);
            this.playerTwoLabel.TabIndex = 0;
            this.playerTwoLabel.Text = "Spieler 2";
            this.playerTwoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerTwoPoints
            // 
            this.playerTwoPoints.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerTwoPoints.Font = new System.Drawing.Font("Alagard", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoPoints.Location = new System.Drawing.Point(15, 46);
            this.playerTwoPoints.Name = "playerTwoPoints";
            this.playerTwoPoints.Size = new System.Drawing.Size(120, 32);
            this.playerTwoPoints.TabIndex = 0;
            this.playerTwoPoints.Text = "RP: 0";
            this.playerTwoPoints.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.Transparent;
            this.gamePanel.Controls.Add(this.exposeButton);
            this.gamePanel.Controls.Add(this.rollDiceButton);
            this.gamePanel.Controls.Add(this.playerOnePanel);
            this.gamePanel.Controls.Add(this.label2);
            this.gamePanel.Controls.Add(this.allRounds);
            this.gamePanel.Location = new System.Drawing.Point(25, 25);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(503, 569);
            this.gamePanel.TabIndex = 3;
            this.gamePanel.Visible = false;
            this.gamePanel.VisibleChanged += new System.EventHandler(this.gamePanel_VisibileChange);
            // 
            // exposeButton
            // 
            this.exposeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(23)))));
            this.exposeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exposeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(77)))), ((int)(((byte)(32)))));
            this.exposeButton.FlatAppearance.BorderSize = 5;
            this.exposeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exposeButton.Font = new System.Drawing.Font("Alagard", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exposeButton.Location = new System.Drawing.Point(162, 467);
            this.exposeButton.Name = "exposeButton";
            this.exposeButton.Size = new System.Drawing.Size(174, 62);
            this.exposeButton.TabIndex = 2;
            this.exposeButton.Text = "Aussetzen";
            this.exposeButton.UseVisualStyleBackColor = false;
            this.exposeButton.Click += new System.EventHandler(this.exposeButton_Click);
            // 
            // rollDiceButton
            // 
            this.rollDiceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(23)))));
            this.rollDiceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rollDiceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(77)))), ((int)(((byte)(32)))));
            this.rollDiceButton.FlatAppearance.BorderSize = 5;
            this.rollDiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollDiceButton.Font = new System.Drawing.Font("Alagard", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollDiceButton.Location = new System.Drawing.Point(162, 389);
            this.rollDiceButton.Name = "rollDiceButton";
            this.rollDiceButton.Size = new System.Drawing.Size(174, 62);
            this.rollDiceButton.TabIndex = 2;
            this.rollDiceButton.Text = "Würfeln";
            this.rollDiceButton.UseVisualStyleBackColor = false;
            this.rollDiceButton.Click += new System.EventHandler(this.rollDiceButton_Click);
            // 
            // playerOnePanel
            // 
            this.playerOnePanel.Controls.Add(this.playerOneLabel);
            this.playerOnePanel.Controls.Add(this.onePlayerAllPoints);
            this.playerOnePanel.Controls.Add(this.playerOnePoints);
            this.playerOnePanel.Location = new System.Drawing.Point(3, 3);
            this.playerOnePanel.Name = "playerOnePanel";
            this.playerOnePanel.Size = new System.Drawing.Size(146, 566);
            this.playerOnePanel.TabIndex = 1;
            this.playerOnePanel.Visible = false;
            // 
            // playerOneLabel
            // 
            this.playerOneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerOneLabel.Font = new System.Drawing.Font("Alagard", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneLabel.Location = new System.Drawing.Point(3, 11);
            this.playerOneLabel.Name = "playerOneLabel";
            this.playerOneLabel.Size = new System.Drawing.Size(120, 32);
            this.playerOneLabel.TabIndex = 0;
            this.playerOneLabel.Text = "Spieler 1";
            this.playerOneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerOnePoints
            // 
            this.playerOnePoints.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerOnePoints.Font = new System.Drawing.Font("Alagard", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOnePoints.Location = new System.Drawing.Point(4, 43);
            this.playerOnePoints.Name = "playerOnePoints";
            this.playerOnePoints.Size = new System.Drawing.Size(120, 32);
            this.playerOnePoints.TabIndex = 0;
            this.playerOnePoints.Text = "RP: 0";
            this.playerOnePoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Alagard", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 58);
            this.label2.TabIndex = 0;
            this.label2.Text = "Runden";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // allRounds
            // 
            this.allRounds.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allRounds.Font = new System.Drawing.Font("Alagard", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allRounds.Location = new System.Drawing.Point(173, 15);
            this.allRounds.Name = "allRounds";
            this.allRounds.Size = new System.Drawing.Size(154, 32);
            this.allRounds.TabIndex = 0;
            this.allRounds.Text = "0/0";
            this.allRounds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // twoPlayerScreen
            // 
            this.twoPlayerScreen.Location = new System.Drawing.Point(4, 25);
            this.twoPlayerScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.twoPlayerScreen.Name = "twoPlayerScreen";
            this.twoPlayerScreen.Size = new System.Drawing.Size(556, 614);
            this.twoPlayerScreen.TabIndex = 2;
            this.twoPlayerScreen.Text = "twoPlayer";
            this.twoPlayerScreen.UseVisualStyleBackColor = true;
            // 
            // settingsScreen
            // 
            this.settingsScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsScreen.BackgroundImage")));
            this.settingsScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsScreen.Controls.Add(this.playMuteMusic);
            this.settingsScreen.Controls.Add(this.splitter2);
            this.settingsScreen.Controls.Add(this.splitter1);
            this.settingsScreen.Controls.Add(this.button1);
            this.settingsScreen.Controls.Add(this.label5);
            this.settingsScreen.Controls.Add(this.label4);
            this.settingsScreen.Location = new System.Drawing.Point(4, 21);
            this.settingsScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsScreen.Name = "settingsScreen";
            this.settingsScreen.Size = new System.Drawing.Size(556, 618);
            this.settingsScreen.TabIndex = 3;
            this.settingsScreen.Text = "settingsScreen";
            this.settingsScreen.UseVisualStyleBackColor = true;
            // 
            // playMuteMusic
            // 
            this.playMuteMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(44)))), ((int)(((byte)(20)))));
            this.playMuteMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playMuteMusic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(77)))), ((int)(((byte)(32)))));
            this.playMuteMusic.FlatAppearance.BorderSize = 3;
            this.playMuteMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playMuteMusic.Font = new System.Drawing.Font("Alagard", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playMuteMusic.Location = new System.Drawing.Point(128, 168);
            this.playMuteMusic.Name = "playMuteMusic";
            this.playMuteMusic.Size = new System.Drawing.Size(88, 28);
            this.playMuteMusic.TabIndex = 8;
            this.playMuteMusic.Text = "An";
            this.playMuteMusic.UseVisualStyleBackColor = false;
            this.playMuteMusic.Click += new System.EventHandler(this.playMuteMusic_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(3, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 618);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 618);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(44)))), ((int)(((byte)(20)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(77)))), ((int)(((byte)(32)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Alagard", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Zurück";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Alagard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Musik:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Alagard", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(473, 63);
            this.label4.TabIndex = 0;
            this.label4.Text = "Einstellungen";
            // 
            // tutorialScreen
            // 
            this.tutorialScreen.BackgroundImage = global::DoofeEins.Properties.Resources.bg;
            this.tutorialScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tutorialScreen.Controls.Add(this.backButton);
            this.tutorialScreen.Controls.Add(this.label3);
            this.tutorialScreen.Controls.Add(this.pictureBox2);
            this.tutorialScreen.Location = new System.Drawing.Point(4, 25);
            this.tutorialScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tutorialScreen.Name = "tutorialScreen";
            this.tutorialScreen.Size = new System.Drawing.Size(556, 614);
            this.tutorialScreen.TabIndex = 4;
            this.tutorialScreen.Text = "tutorialScreen";
            this.tutorialScreen.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(44)))), ((int)(((byte)(20)))));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(77)))), ((int)(((byte)(32)))));
            this.backButton.FlatAppearance.BorderSize = 3;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Alagard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(16, 37);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(110, 37);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Zurück";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Alagard", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(503, 310);
            this.label3.TabIndex = 1;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::DoofeEins.Properties.Resources.doofe_eins;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(132, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 143);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // onePlayerAllPoints
            // 
            this.onePlayerAllPoints.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.onePlayerAllPoints.Font = new System.Drawing.Font("Alagard", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onePlayerAllPoints.Location = new System.Drawing.Point(3, 65);
            this.onePlayerAllPoints.Name = "onePlayerAllPoints";
            this.onePlayerAllPoints.Size = new System.Drawing.Size(120, 32);
            this.onePlayerAllPoints.TabIndex = 0;
            this.onePlayerAllPoints.Text = "AP: 0";
            this.onePlayerAllPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // twoPlayerAllPoints
            // 
            this.twoPlayerAllPoints.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.twoPlayerAllPoints.Font = new System.Drawing.Font("Alagard", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoPlayerAllPoints.Location = new System.Drawing.Point(14, 71);
            this.twoPlayerAllPoints.Name = "twoPlayerAllPoints";
            this.twoPlayerAllPoints.Size = new System.Drawing.Size(120, 32);
            this.twoPlayerAllPoints.TabIndex = 0;
            this.twoPlayerAllPoints.Text = "AP: 0";
            this.twoPlayerAllPoints.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gameScreen
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::DoofeEins.Properties.Resources.settingsBg;
            this.ClientSize = new System.Drawing.Size(527, 593);
            this.Controls.Add(this.allScreens);
            this.Font = new System.Drawing.Font("Alagard", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.MaximizeBox = false;
            this.Name = "gameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doofe Eins";
            this.Load += new System.EventHandler(this.gameScreen_Load);
            this.allScreens.ResumeLayout(false);
            this.menuScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tutorialButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoPlayerButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onePlayerButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.runningGameScreen.ResumeLayout(false);
            this.roundGroup.ResumeLayout(false);
            this.roundGroup.PerformLayout();
            this.playerTwoPanel.ResumeLayout(false);
            this.gamePanel.ResumeLayout(false);
            this.playerOnePanel.ResumeLayout(false);
            this.settingsScreen.ResumeLayout(false);
            this.settingsScreen.PerformLayout();
            this.tutorialScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl allScreens;
        private System.Windows.Forms.TabPage menuScreen;
        private System.Windows.Forms.TabPage runningGameScreen;
        private System.Windows.Forms.TabPage twoPlayerScreen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox onePlayerButton;
        private System.Windows.Forms.TabPage settingsScreen;
        private System.Windows.Forms.TabPage tutorialScreen;
        private System.Windows.Forms.PictureBox tutorialButton;
        private System.Windows.Forms.PictureBox settingsButton;
        private System.Windows.Forms.PictureBox twoPlayerButton;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label allRounds;
        private System.Windows.Forms.Label playerOneLabel;
        private System.Windows.Forms.Label playerTwoLabel;
        private System.Windows.Forms.Panel playerTwoPanel;
        private System.Windows.Forms.Label playerTwoPoints;
        private System.Windows.Forms.Panel playerOnePanel;
        private System.Windows.Forms.Label playerOnePoints;
        private System.Windows.Forms.Button rollDiceButton;
        private System.Windows.Forms.Button exposeButton;
        private System.Windows.Forms.Panel roundGroup;
        private System.Windows.Forms.TextBox roundInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button playMuteMusic;
        private System.Windows.Forms.Label twoPlayerAllPoints;
        private System.Windows.Forms.Label onePlayerAllPoints;

    }
}

