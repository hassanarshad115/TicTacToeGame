namespace TicTacToeGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startNewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b1button = new System.Windows.Forms.Button();
            this.b2button = new System.Windows.Forms.Button();
            this.b3button = new System.Windows.Forms.Button();
            this.b4button = new System.Windows.Forms.Button();
            this.b5button = new System.Windows.Forms.Button();
            this.b6button = new System.Windows.Forms.Button();
            this.b7button = new System.Windows.Forms.Button();
            this.b8button = new System.Windows.Forms.Button();
            this.b9button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playersnamegroupBox = new System.Windows.Forms.GroupBox();
            this.playertwonametextBox = new System.Windows.Forms.TextBox();
            this.playeronenametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectxgroupBox = new System.Windows.Forms.GroupBox();
            this.playertwoxradioButton = new System.Windows.Forms.RadioButton();
            this.playeronexradioButton = new System.Windows.Forms.RadioButton();
            this.startplayergroupBox = new System.Windows.Forms.GroupBox();
            this.playertwostartradioButton = new System.Windows.Forms.RadioButton();
            this.playeronestartradioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.marquelabel5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.playersnamegroupBox.SuspendLayout();
            this.selectxgroupBox.SuspendLayout();
            this.startplayergroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::TicTacToeGame.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startNewGameToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.gameToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // startNewGameToolStripMenuItem
            // 
            this.startNewGameToolStripMenuItem.Image = global::TicTacToeGame.Properties.Resources.startgame;
            this.startNewGameToolStripMenuItem.Name = "startNewGameToolStripMenuItem";
            this.startNewGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startNewGameToolStripMenuItem.Text = "&Start New Game";
            this.startNewGameToolStripMenuItem.Click += new System.EventHandler(this.startNewGameToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Image = global::TicTacToeGame.Properties.Resources.resetgame;
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetToolStripMenuItem.Text = "&Reset Game";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::TicTacToeGame.Properties.Resources.about;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // b1button
            // 
            this.b1button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b1button.BackgroundImage")));
            this.b1button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b1button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b1button.Location = new System.Drawing.Point(136, 53);
            this.b1button.Name = "b1button";
            this.b1button.Size = new System.Drawing.Size(90, 85);
            this.b1button.TabIndex = 1;
            this.b1button.UseVisualStyleBackColor = true;
            this.b1button.Click += new System.EventHandler(this.button_click);
            // 
            // b2button
            // 
            this.b2button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b2button.BackgroundImage")));
            this.b2button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b2button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b2button.Location = new System.Drawing.Point(232, 53);
            this.b2button.Name = "b2button";
            this.b2button.Size = new System.Drawing.Size(90, 85);
            this.b2button.TabIndex = 1;
            this.b2button.UseVisualStyleBackColor = true;
            this.b2button.Click += new System.EventHandler(this.button_click);
            // 
            // b3button
            // 
            this.b3button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b3button.BackgroundImage")));
            this.b3button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b3button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b3button.Location = new System.Drawing.Point(327, 53);
            this.b3button.Name = "b3button";
            this.b3button.Size = new System.Drawing.Size(90, 85);
            this.b3button.TabIndex = 1;
            this.b3button.UseVisualStyleBackColor = true;
            this.b3button.Click += new System.EventHandler(this.button_click);
            // 
            // b4button
            // 
            this.b4button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b4button.BackgroundImage")));
            this.b4button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b4button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b4button.Location = new System.Drawing.Point(136, 143);
            this.b4button.Name = "b4button";
            this.b4button.Size = new System.Drawing.Size(90, 85);
            this.b4button.TabIndex = 1;
            this.b4button.UseVisualStyleBackColor = true;
            this.b4button.Click += new System.EventHandler(this.button_click);
            // 
            // b5button
            // 
            this.b5button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b5button.BackgroundImage")));
            this.b5button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b5button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b5button.Location = new System.Drawing.Point(232, 143);
            this.b5button.Name = "b5button";
            this.b5button.Size = new System.Drawing.Size(90, 85);
            this.b5button.TabIndex = 1;
            this.b5button.UseVisualStyleBackColor = true;
            this.b5button.Click += new System.EventHandler(this.button_click);
            // 
            // b6button
            // 
            this.b6button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b6button.BackgroundImage")));
            this.b6button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b6button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b6button.Location = new System.Drawing.Point(327, 143);
            this.b6button.Name = "b6button";
            this.b6button.Size = new System.Drawing.Size(90, 85);
            this.b6button.TabIndex = 1;
            this.b6button.UseVisualStyleBackColor = true;
            this.b6button.Click += new System.EventHandler(this.button_click);
            // 
            // b7button
            // 
            this.b7button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b7button.BackgroundImage")));
            this.b7button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b7button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b7button.Location = new System.Drawing.Point(136, 233);
            this.b7button.Name = "b7button";
            this.b7button.Size = new System.Drawing.Size(90, 85);
            this.b7button.TabIndex = 1;
            this.b7button.UseVisualStyleBackColor = true;
            this.b7button.Click += new System.EventHandler(this.button_click);
            // 
            // b8button
            // 
            this.b8button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b8button.BackgroundImage")));
            this.b8button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b8button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b8button.Location = new System.Drawing.Point(232, 233);
            this.b8button.Name = "b8button";
            this.b8button.Size = new System.Drawing.Size(90, 85);
            this.b8button.TabIndex = 1;
            this.b8button.UseVisualStyleBackColor = true;
            this.b8button.Click += new System.EventHandler(this.button_click);
            // 
            // b9button
            // 
            this.b9button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b9button.BackgroundImage")));
            this.b9button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b9button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b9button.Location = new System.Drawing.Point(327, 233);
            this.b9button.Name = "b9button";
            this.b9button.Size = new System.Drawing.Size(90, 85);
            this.b9button.TabIndex = 1;
            this.b9button.UseVisualStyleBackColor = true;
            this.b9button.Click += new System.EventHandler(this.button_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(636, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "All right reserved with hassanmalik.com";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // playersnamegroupBox
            // 
            this.playersnamegroupBox.BackColor = System.Drawing.Color.Transparent;
            this.playersnamegroupBox.Controls.Add(this.playertwonametextBox);
            this.playersnamegroupBox.Controls.Add(this.playeronenametextBox);
            this.playersnamegroupBox.Controls.Add(this.label2);
            this.playersnamegroupBox.Controls.Add(this.label3);
            this.playersnamegroupBox.ForeColor = System.Drawing.Color.White;
            this.playersnamegroupBox.Location = new System.Drawing.Point(436, 48);
            this.playersnamegroupBox.Name = "playersnamegroupBox";
            this.playersnamegroupBox.Size = new System.Drawing.Size(282, 89);
            this.playersnamegroupBox.TabIndex = 3;
            this.playersnamegroupBox.TabStop = false;
            this.playersnamegroupBox.Text = "Players Name:";
            this.playersnamegroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // playertwonametextBox
            // 
            this.playertwonametextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.playertwonametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playertwonametextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.playertwonametextBox.Location = new System.Drawing.Point(126, 48);
            this.playertwonametextBox.Name = "playertwonametextBox";
            this.playertwonametextBox.Size = new System.Drawing.Size(150, 23);
            this.playertwonametextBox.TabIndex = 1;
            // 
            // playeronenametextBox
            // 
            this.playeronenametextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.playeronenametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playeronenametextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.playeronenametextBox.Location = new System.Drawing.Point(126, 18);
            this.playeronenametextBox.Name = "playeronenametextBox";
            this.playeronenametextBox.Size = new System.Drawing.Size(150, 23);
            this.playeronenametextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(9, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player One Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(9, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Player Two Name:";
            // 
            // selectxgroupBox
            // 
            this.selectxgroupBox.BackColor = System.Drawing.Color.Transparent;
            this.selectxgroupBox.Controls.Add(this.playertwoxradioButton);
            this.selectxgroupBox.Controls.Add(this.playeronexradioButton);
            this.selectxgroupBox.ForeColor = System.Drawing.Color.White;
            this.selectxgroupBox.Location = new System.Drawing.Point(438, 142);
            this.selectxgroupBox.Name = "selectxgroupBox";
            this.selectxgroupBox.Size = new System.Drawing.Size(280, 83);
            this.selectxgroupBox.TabIndex = 3;
            this.selectxgroupBox.TabStop = false;
            this.selectxgroupBox.Text = "X For Player";
            // 
            // playertwoxradioButton
            // 
            this.playertwoxradioButton.AutoSize = true;
            this.playertwoxradioButton.BackColor = System.Drawing.Color.Maroon;
            this.playertwoxradioButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playertwoxradioButton.BackgroundImage")));
            this.playertwoxradioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playertwoxradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playertwoxradioButton.ForeColor = System.Drawing.Color.Snow;
            this.playertwoxradioButton.Location = new System.Drawing.Point(115, 32);
            this.playertwoxradioButton.Name = "playertwoxradioButton";
            this.playertwoxradioButton.Size = new System.Drawing.Size(88, 17);
            this.playertwoxradioButton.TabIndex = 0;
            this.playertwoxradioButton.Text = "Player Two";
            this.playertwoxradioButton.UseVisualStyleBackColor = false;
            // 
            // playeronexradioButton
            // 
            this.playeronexradioButton.AutoSize = true;
            this.playeronexradioButton.BackColor = System.Drawing.Color.Maroon;
            this.playeronexradioButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playeronexradioButton.BackgroundImage")));
            this.playeronexradioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playeronexradioButton.Checked = true;
            this.playeronexradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playeronexradioButton.ForeColor = System.Drawing.Color.Snow;
            this.playeronexradioButton.Location = new System.Drawing.Point(10, 32);
            this.playeronexradioButton.Name = "playeronexradioButton";
            this.playeronexradioButton.Size = new System.Drawing.Size(87, 17);
            this.playeronexradioButton.TabIndex = 0;
            this.playeronexradioButton.TabStop = true;
            this.playeronexradioButton.Text = "Player One";
            this.playeronexradioButton.UseVisualStyleBackColor = false;
            // 
            // startplayergroupBox
            // 
            this.startplayergroupBox.BackColor = System.Drawing.Color.Transparent;
            this.startplayergroupBox.Controls.Add(this.playertwostartradioButton);
            this.startplayergroupBox.Controls.Add(this.playeronestartradioButton);
            this.startplayergroupBox.ForeColor = System.Drawing.Color.White;
            this.startplayergroupBox.Location = new System.Drawing.Point(438, 227);
            this.startplayergroupBox.Name = "startplayergroupBox";
            this.startplayergroupBox.Size = new System.Drawing.Size(280, 77);
            this.startplayergroupBox.TabIndex = 4;
            this.startplayergroupBox.TabStop = false;
            this.startplayergroupBox.Text = "Start Player:";
            // 
            // playertwostartradioButton
            // 
            this.playertwostartradioButton.AutoSize = true;
            this.playertwostartradioButton.BackColor = System.Drawing.Color.Maroon;
            this.playertwostartradioButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playertwostartradioButton.BackgroundImage")));
            this.playertwostartradioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playertwostartradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playertwostartradioButton.ForeColor = System.Drawing.Color.Snow;
            this.playertwostartradioButton.Location = new System.Drawing.Point(114, 32);
            this.playertwostartradioButton.Name = "playertwostartradioButton";
            this.playertwostartradioButton.Size = new System.Drawing.Size(88, 17);
            this.playertwostartradioButton.TabIndex = 0;
            this.playertwostartradioButton.Text = "Player Two";
            this.playertwostartradioButton.UseVisualStyleBackColor = false;
            // 
            // playeronestartradioButton
            // 
            this.playeronestartradioButton.AutoSize = true;
            this.playeronestartradioButton.BackColor = System.Drawing.Color.Maroon;
            this.playeronestartradioButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playeronestartradioButton.BackgroundImage")));
            this.playeronestartradioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playeronestartradioButton.Checked = true;
            this.playeronestartradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playeronestartradioButton.ForeColor = System.Drawing.Color.Snow;
            this.playeronestartradioButton.Location = new System.Drawing.Point(10, 32);
            this.playeronestartradioButton.Name = "playeronestartradioButton";
            this.playeronestartradioButton.Size = new System.Drawing.Size(87, 17);
            this.playeronestartradioButton.TabIndex = 0;
            this.playeronestartradioButton.TabStop = true;
            this.playeronestartradioButton.Text = "Player One";
            this.playeronestartradioButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(271, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Welcome to My first Game Tic Tac Toe";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TicTacToeGame.Properties.Resources.hassan1;
            this.pictureBox1.Location = new System.Drawing.Point(734, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // marquelabel5
            // 
            this.marquelabel5.AutoSize = true;
            this.marquelabel5.BackColor = System.Drawing.Color.Transparent;
            this.marquelabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marquelabel5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.marquelabel5.Location = new System.Drawing.Point(12, 321);
            this.marquelabel5.Name = "marquelabel5";
            this.marquelabel5.Size = new System.Drawing.Size(272, 15);
            this.marquelabel5.TabIndex = 2;
            this.marquelabel5.Text = "    Welcome to My first Game Tic Tac Toe ";
            this.marquelabel5.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(769, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Label for Time";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToeGame.Properties.Resources.game;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(866, 360);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.startplayergroupBox);
            this.Controls.Add(this.selectxgroupBox);
            this.Controls.Add(this.playersnamegroupBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.marquelabel5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b9button);
            this.Controls.Add(this.b6button);
            this.Controls.Add(this.b3button);
            this.Controls.Add(this.b8button);
            this.Controls.Add(this.b5button);
            this.Controls.Add(this.b2button);
            this.Controls.Add(this.b7button);
            this.Controls.Add(this.b4button);
            this.Controls.Add(this.b1button);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe Game  develop by Hassan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.playersnamegroupBox.ResumeLayout(false);
            this.playersnamegroupBox.PerformLayout();
            this.selectxgroupBox.ResumeLayout(false);
            this.selectxgroupBox.PerformLayout();
            this.startplayergroupBox.ResumeLayout(false);
            this.startplayergroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startNewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button b1button;
        private System.Windows.Forms.Button b2button;
        private System.Windows.Forms.Button b3button;
        private System.Windows.Forms.Button b4button;
        private System.Windows.Forms.Button b5button;
        private System.Windows.Forms.Button b6button;
        private System.Windows.Forms.Button b7button;
        private System.Windows.Forms.Button b8button;
        private System.Windows.Forms.Button b9button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox playersnamegroupBox;
        private System.Windows.Forms.TextBox playertwonametextBox;
        private System.Windows.Forms.TextBox playeronenametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox selectxgroupBox;
        private System.Windows.Forms.RadioButton playertwoxradioButton;
        private System.Windows.Forms.RadioButton playeronexradioButton;
        private System.Windows.Forms.GroupBox startplayergroupBox;
        private System.Windows.Forms.RadioButton playertwostartradioButton;
        private System.Windows.Forms.RadioButton playeronestartradioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label marquelabel5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
    }
}

