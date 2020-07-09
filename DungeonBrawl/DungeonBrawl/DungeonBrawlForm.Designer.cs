namespace DungeonBrawl
{
   partial class DungeonBrawlForm
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
         this.infoPanel = new System.Windows.Forms.Panel();
         this.okBut = new System.Windows.Forms.Button();
         this.chooseTargetLab = new System.Windows.Forms.Label();
         this.target3But = new System.Windows.Forms.Button();
         this.target2But = new System.Windows.Forms.Button();
         this.target1Butt = new System.Windows.Forms.Button();
         this.specialButton = new System.Windows.Forms.Button();
         this.defendButton = new System.Windows.Forms.Button();
         this.attackButton = new System.Windows.Forms.Button();
         this.selectedHeroLabel = new System.Windows.Forms.Label();
         this.battleLogLabel = new System.Windows.Forms.Label();
         this.battleLogBox = new System.Windows.Forms.RichTextBox();
         this.battleImagePanel = new System.Windows.Forms.Panel();
         this.gameOverLabel = new System.Windows.Forms.Label();
         this.enemy3ImgPan = new System.Windows.Forms.Panel();
         this.panel7 = new System.Windows.Forms.Panel();
         this.enemy2ImgPan = new System.Windows.Forms.Panel();
         this.panel9 = new System.Windows.Forms.Panel();
         this.enemy1ImgPan = new System.Windows.Forms.Panel();
         this.hero3ImgPan = new System.Windows.Forms.Panel();
         this.panel5 = new System.Windows.Forms.Panel();
         this.hero2ImgPan = new System.Windows.Forms.Panel();
         this.panel3 = new System.Windows.Forms.Panel();
         this.hero1ImgPan = new System.Windows.Forms.Panel();
         this.enemy3StatLabel = new System.Windows.Forms.Label();
         this.enemy2StatLabel = new System.Windows.Forms.Label();
         this.enemy1StatLabel = new System.Windows.Forms.Label();
         this.hero3StatLabel = new System.Windows.Forms.Label();
         this.hero2StatLabel = new System.Windows.Forms.Label();
         this.hero1StatLabel = new System.Windows.Forms.Label();
         this.enemiesLabel = new System.Windows.Forms.Label();
         this.heroesLabel = new System.Windows.Forms.Label();
         this.levelLabel = new System.Windows.Forms.Label();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.infoPanel.SuspendLayout();
         this.battleImagePanel.SuspendLayout();
         this.enemy3ImgPan.SuspendLayout();
         this.enemy2ImgPan.SuspendLayout();
         this.hero3ImgPan.SuspendLayout();
         this.hero2ImgPan.SuspendLayout();
         this.menuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // infoPanel
         // 
         this.infoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.infoPanel.Controls.Add(this.okBut);
         this.infoPanel.Controls.Add(this.chooseTargetLab);
         this.infoPanel.Controls.Add(this.target3But);
         this.infoPanel.Controls.Add(this.target2But);
         this.infoPanel.Controls.Add(this.target1Butt);
         this.infoPanel.Controls.Add(this.specialButton);
         this.infoPanel.Controls.Add(this.defendButton);
         this.infoPanel.Controls.Add(this.attackButton);
         this.infoPanel.Controls.Add(this.selectedHeroLabel);
         this.infoPanel.Controls.Add(this.battleLogLabel);
         this.infoPanel.Controls.Add(this.battleLogBox);
         this.infoPanel.Location = new System.Drawing.Point(-6, 582);
         this.infoPanel.Margin = new System.Windows.Forms.Padding(4);
         this.infoPanel.Name = "infoPanel";
         this.infoPanel.Size = new System.Drawing.Size(1253, 297);
         this.infoPanel.TabIndex = 0;
         // 
         // okBut
         // 
         this.okBut.Location = new System.Drawing.Point(428, 124);
         this.okBut.Margin = new System.Windows.Forms.Padding(4);
         this.okBut.Name = "okBut";
         this.okBut.Size = new System.Drawing.Size(78, 64);
         this.okBut.TabIndex = 10;
         this.okBut.Text = "GO!";
         this.okBut.UseVisualStyleBackColor = true;
         this.okBut.Click += new System.EventHandler(this.okBut_Click);
         // 
         // chooseTargetLab
         // 
         this.chooseTargetLab.AutoSize = true;
         this.chooseTargetLab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
         this.chooseTargetLab.Location = new System.Drawing.Point(230, 21);
         this.chooseTargetLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.chooseTargetLab.Name = "chooseTargetLab";
         this.chooseTargetLab.Size = new System.Drawing.Size(186, 25);
         this.chooseTargetLab.TabIndex = 9;
         this.chooseTargetLab.Text = "CHOOSE TARGET";
         this.chooseTargetLab.Visible = false;
         // 
         // target3But
         // 
         this.target3But.Location = new System.Drawing.Point(234, 198);
         this.target3But.Margin = new System.Windows.Forms.Padding(4);
         this.target3But.Name = "target3But";
         this.target3But.Size = new System.Drawing.Size(153, 64);
         this.target3But.TabIndex = 8;
         this.target3But.Text = "DRAGON";
         this.target3But.UseVisualStyleBackColor = true;
         this.target3But.Visible = false;
         this.target3But.Click += new System.EventHandler(this.target3But_Click);
         // 
         // target2But
         // 
         this.target2But.Location = new System.Drawing.Point(234, 124);
         this.target2But.Margin = new System.Windows.Forms.Padding(4);
         this.target2But.Name = "target2But";
         this.target2But.Size = new System.Drawing.Size(153, 64);
         this.target2But.TabIndex = 7;
         this.target2But.Text = "OGRE";
         this.target2But.UseVisualStyleBackColor = true;
         this.target2But.Visible = false;
         this.target2But.Click += new System.EventHandler(this.target2But_Click);
         // 
         // target1Butt
         // 
         this.target1Butt.Location = new System.Drawing.Point(234, 51);
         this.target1Butt.Margin = new System.Windows.Forms.Padding(4);
         this.target1Butt.Name = "target1Butt";
         this.target1Butt.Size = new System.Drawing.Size(153, 64);
         this.target1Butt.TabIndex = 6;
         this.target1Butt.Text = "BANDIT";
         this.target1Butt.UseVisualStyleBackColor = true;
         this.target1Butt.Visible = false;
         this.target1Butt.Click += new System.EventHandler(this.target1Butt_Click);
         // 
         // specialButton
         // 
         this.specialButton.Location = new System.Drawing.Point(38, 198);
         this.specialButton.Margin = new System.Windows.Forms.Padding(4);
         this.specialButton.Name = "specialButton";
         this.specialButton.Size = new System.Drawing.Size(153, 64);
         this.specialButton.TabIndex = 5;
         this.specialButton.Text = "SPECIAL";
         this.specialButton.UseVisualStyleBackColor = true;
         this.specialButton.Click += new System.EventHandler(this.specialButton_Click);
         // 
         // defendButton
         // 
         this.defendButton.Location = new System.Drawing.Point(38, 124);
         this.defendButton.Margin = new System.Windows.Forms.Padding(4);
         this.defendButton.Name = "defendButton";
         this.defendButton.Size = new System.Drawing.Size(153, 64);
         this.defendButton.TabIndex = 4;
         this.defendButton.Text = "DEFEND";
         this.defendButton.UseVisualStyleBackColor = true;
         this.defendButton.Click += new System.EventHandler(this.defendButton_Click);
         // 
         // attackButton
         // 
         this.attackButton.Location = new System.Drawing.Point(38, 51);
         this.attackButton.Margin = new System.Windows.Forms.Padding(4);
         this.attackButton.Name = "attackButton";
         this.attackButton.Size = new System.Drawing.Size(153, 64);
         this.attackButton.TabIndex = 3;
         this.attackButton.Text = "ATTACK";
         this.attackButton.UseVisualStyleBackColor = true;
         this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
         // 
         // selectedHeroLabel
         // 
         this.selectedHeroLabel.AutoSize = true;
         this.selectedHeroLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
         this.selectedHeroLabel.Location = new System.Drawing.Point(34, 21);
         this.selectedHeroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.selectedHeroLabel.Name = "selectedHeroLabel";
         this.selectedHeroLabel.Size = new System.Drawing.Size(121, 25);
         this.selectedHeroLabel.TabIndex = 2;
         this.selectedHeroLabel.Text = "Hero: HERO";
         // 
         // battleLogLabel
         // 
         this.battleLogLabel.AutoSize = true;
         this.battleLogLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
         this.battleLogLabel.Location = new System.Drawing.Point(532, 6);
         this.battleLogLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.battleLogLabel.Name = "battleLogLabel";
         this.battleLogLabel.Size = new System.Drawing.Size(136, 25);
         this.battleLogLabel.TabIndex = 1;
         this.battleLogLabel.Text = "BATTLE LOG";
         // 
         // battleLogBox
         // 
         this.battleLogBox.BackColor = System.Drawing.SystemColors.GrayText;
         this.battleLogBox.ForeColor = System.Drawing.SystemColors.Window;
         this.battleLogBox.Location = new System.Drawing.Point(536, 36);
         this.battleLogBox.Margin = new System.Windows.Forms.Padding(4);
         this.battleLogBox.Name = "battleLogBox";
         this.battleLogBox.Size = new System.Drawing.Size(689, 234);
         this.battleLogBox.TabIndex = 0;
         this.battleLogBox.Text = "";
         // 
         // battleImagePanel
         // 
         this.battleImagePanel.BackgroundImage = global::DungeonBrawl.Properties.Resources.CAVE2;
         this.battleImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.battleImagePanel.Controls.Add(this.gameOverLabel);
         this.battleImagePanel.Controls.Add(this.enemy3ImgPan);
         this.battleImagePanel.Controls.Add(this.enemy2ImgPan);
         this.battleImagePanel.Controls.Add(this.enemy1ImgPan);
         this.battleImagePanel.Controls.Add(this.hero3ImgPan);
         this.battleImagePanel.Controls.Add(this.hero2ImgPan);
         this.battleImagePanel.Controls.Add(this.hero1ImgPan);
         this.battleImagePanel.Controls.Add(this.enemy3StatLabel);
         this.battleImagePanel.Controls.Add(this.enemy2StatLabel);
         this.battleImagePanel.Controls.Add(this.enemy1StatLabel);
         this.battleImagePanel.Controls.Add(this.hero3StatLabel);
         this.battleImagePanel.Controls.Add(this.hero2StatLabel);
         this.battleImagePanel.Controls.Add(this.hero1StatLabel);
         this.battleImagePanel.Controls.Add(this.enemiesLabel);
         this.battleImagePanel.Controls.Add(this.heroesLabel);
         this.battleImagePanel.Controls.Add(this.levelLabel);
         this.battleImagePanel.Controls.Add(this.menuStrip1);
         this.battleImagePanel.Location = new System.Drawing.Point(-6, -2);
         this.battleImagePanel.Margin = new System.Windows.Forms.Padding(4);
         this.battleImagePanel.Name = "battleImagePanel";
         this.battleImagePanel.Size = new System.Drawing.Size(1253, 585);
         this.battleImagePanel.TabIndex = 1;
         // 
         // gameOverLabel
         // 
         this.gameOverLabel.AutoSize = true;
         this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gameOverLabel.Location = new System.Drawing.Point(486, 305);
         this.gameOverLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.gameOverLabel.Name = "gameOverLabel";
         this.gameOverLabel.Size = new System.Drawing.Size(253, 42);
         this.gameOverLabel.TabIndex = 16;
         this.gameOverLabel.Text = "GAME OVER";
         this.gameOverLabel.Visible = false;
         // 
         // enemy3ImgPan
         // 
         this.enemy3ImgPan.Controls.Add(this.panel7);
         this.enemy3ImgPan.Location = new System.Drawing.Point(950, 398);
         this.enemy3ImgPan.Margin = new System.Windows.Forms.Padding(4);
         this.enemy3ImgPan.Name = "enemy3ImgPan";
         this.enemy3ImgPan.Size = new System.Drawing.Size(146, 136);
         this.enemy3ImgPan.TabIndex = 14;
         // 
         // panel7
         // 
         this.panel7.Location = new System.Drawing.Point(4, 146);
         this.panel7.Margin = new System.Windows.Forms.Padding(4);
         this.panel7.Name = "panel7";
         this.panel7.Size = new System.Drawing.Size(146, 136);
         this.panel7.TabIndex = 11;
         // 
         // enemy2ImgPan
         // 
         this.enemy2ImgPan.Controls.Add(this.panel9);
         this.enemy2ImgPan.Location = new System.Drawing.Point(950, 252);
         this.enemy2ImgPan.Margin = new System.Windows.Forms.Padding(4);
         this.enemy2ImgPan.Name = "enemy2ImgPan";
         this.enemy2ImgPan.Size = new System.Drawing.Size(146, 136);
         this.enemy2ImgPan.TabIndex = 13;
         // 
         // panel9
         // 
         this.panel9.Location = new System.Drawing.Point(4, 146);
         this.panel9.Margin = new System.Windows.Forms.Padding(4);
         this.panel9.Name = "panel9";
         this.panel9.Size = new System.Drawing.Size(146, 136);
         this.panel9.TabIndex = 11;
         // 
         // enemy1ImgPan
         // 
         this.enemy1ImgPan.Location = new System.Drawing.Point(950, 106);
         this.enemy1ImgPan.Margin = new System.Windows.Forms.Padding(4);
         this.enemy1ImgPan.Name = "enemy1ImgPan";
         this.enemy1ImgPan.Size = new System.Drawing.Size(146, 136);
         this.enemy1ImgPan.TabIndex = 12;
         // 
         // hero3ImgPan
         // 
         this.hero3ImgPan.Controls.Add(this.panel5);
         this.hero3ImgPan.Location = new System.Drawing.Point(165, 398);
         this.hero3ImgPan.Margin = new System.Windows.Forms.Padding(4);
         this.hero3ImgPan.Name = "hero3ImgPan";
         this.hero3ImgPan.Size = new System.Drawing.Size(146, 136);
         this.hero3ImgPan.TabIndex = 11;
         // 
         // panel5
         // 
         this.panel5.Location = new System.Drawing.Point(4, 146);
         this.panel5.Margin = new System.Windows.Forms.Padding(4);
         this.panel5.Name = "panel5";
         this.panel5.Size = new System.Drawing.Size(146, 136);
         this.panel5.TabIndex = 11;
         // 
         // hero2ImgPan
         // 
         this.hero2ImgPan.Controls.Add(this.panel3);
         this.hero2ImgPan.Location = new System.Drawing.Point(165, 252);
         this.hero2ImgPan.Margin = new System.Windows.Forms.Padding(4);
         this.hero2ImgPan.Name = "hero2ImgPan";
         this.hero2ImgPan.Size = new System.Drawing.Size(146, 136);
         this.hero2ImgPan.TabIndex = 10;
         // 
         // panel3
         // 
         this.panel3.Location = new System.Drawing.Point(4, 146);
         this.panel3.Margin = new System.Windows.Forms.Padding(4);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(146, 136);
         this.panel3.TabIndex = 11;
         // 
         // hero1ImgPan
         // 
         this.hero1ImgPan.Location = new System.Drawing.Point(165, 106);
         this.hero1ImgPan.Margin = new System.Windows.Forms.Padding(4);
         this.hero1ImgPan.Name = "hero1ImgPan";
         this.hero1ImgPan.Size = new System.Drawing.Size(146, 136);
         this.hero1ImgPan.TabIndex = 9;
         // 
         // enemy3StatLabel
         // 
         this.enemy3StatLabel.AutoSize = true;
         this.enemy3StatLabel.Location = new System.Drawing.Point(1108, 418);
         this.enemy3StatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.enemy3StatLabel.Name = "enemy3StatLabel";
         this.enemy3StatLabel.Size = new System.Drawing.Size(100, 75);
         this.enemy3StatLabel.TabIndex = 8;
         this.enemy3StatLabel.Text = "DRAGON\r\nHP: 20/20\r\nSP: 5/5";
         // 
         // enemy2StatLabel
         // 
         this.enemy2StatLabel.AutoSize = true;
         this.enemy2StatLabel.Location = new System.Drawing.Point(1108, 272);
         this.enemy2StatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.enemy2StatLabel.Name = "enemy2StatLabel";
         this.enemy2StatLabel.Size = new System.Drawing.Size(100, 75);
         this.enemy2StatLabel.TabIndex = 7;
         this.enemy2StatLabel.Text = "OGRE\r\nHP: 20/20\r\nSP: 5/5";
         // 
         // enemy1StatLabel
         // 
         this.enemy1StatLabel.AutoSize = true;
         this.enemy1StatLabel.Location = new System.Drawing.Point(1108, 126);
         this.enemy1StatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.enemy1StatLabel.Name = "enemy1StatLabel";
         this.enemy1StatLabel.Size = new System.Drawing.Size(100, 75);
         this.enemy1StatLabel.TabIndex = 6;
         this.enemy1StatLabel.Text = "BANDIT\r\nHP: 20/20\r\nSP: 5/5";
         // 
         // hero3StatLabel
         // 
         this.hero3StatLabel.AutoSize = true;
         this.hero3StatLabel.Location = new System.Drawing.Point(22, 418);
         this.hero3StatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.hero3StatLabel.Name = "hero3StatLabel";
         this.hero3StatLabel.Size = new System.Drawing.Size(100, 75);
         this.hero3StatLabel.TabIndex = 5;
         this.hero3StatLabel.Text = "CLERIC\r\nHP: 20/20\r\nSP: 5/5";
         // 
         // hero2StatLabel
         // 
         this.hero2StatLabel.AutoSize = true;
         this.hero2StatLabel.Location = new System.Drawing.Point(23, 272);
         this.hero2StatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.hero2StatLabel.Name = "hero2StatLabel";
         this.hero2StatLabel.Size = new System.Drawing.Size(100, 75);
         this.hero2StatLabel.TabIndex = 4;
         this.hero2StatLabel.Text = "MAGE\r\nHP: 20/20\r\nSP: 5/5";
         // 
         // hero1StatLabel
         // 
         this.hero1StatLabel.AutoSize = true;
         this.hero1StatLabel.Location = new System.Drawing.Point(23, 126);
         this.hero1StatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.hero1StatLabel.Name = "hero1StatLabel";
         this.hero1StatLabel.Size = new System.Drawing.Size(106, 75);
         this.hero1StatLabel.TabIndex = 3;
         this.hero1StatLabel.Text = "WARRIOR\r\nHP: 20/20\r\nSP: 5/5";
         // 
         // enemiesLabel
         // 
         this.enemiesLabel.AutoSize = true;
         this.enemiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.enemiesLabel.Location = new System.Drawing.Point(1045, 36);
         this.enemiesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.enemiesLabel.Name = "enemiesLabel";
         this.enemiesLabel.Size = new System.Drawing.Size(196, 44);
         this.enemiesLabel.TabIndex = 2;
         this.enemiesLabel.Text = "ENEMIES";
         // 
         // heroesLabel
         // 
         this.heroesLabel.AutoSize = true;
         this.heroesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.heroesLabel.Location = new System.Drawing.Point(-1, 36);
         this.heroesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.heroesLabel.Name = "heroesLabel";
         this.heroesLabel.Size = new System.Drawing.Size(185, 44);
         this.heroesLabel.TabIndex = 1;
         this.heroesLabel.Text = "HEROES";
         // 
         // levelLabel
         // 
         this.levelLabel.AutoSize = true;
         this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.levelLabel.Location = new System.Drawing.Point(546, 36);
         this.levelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.levelLabel.Name = "levelLabel";
         this.levelLabel.Size = new System.Drawing.Size(112, 29);
         this.levelLabel.TabIndex = 0;
         this.levelLabel.Text = "LEVEL 1";
         // 
         // menuStrip1
         // 
         this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
         this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
         this.menuStrip1.Size = new System.Drawing.Size(1253, 40);
         this.menuStrip1.TabIndex = 15;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // gameToolStripMenuItem
         // 
         this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.howToPlayToolStripMenuItem});
         this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
         this.gameToolStripMenuItem.Size = new System.Drawing.Size(85, 34);
         this.gameToolStripMenuItem.Text = "Game";
         // 
         // newGameToolStripMenuItem
         // 
         this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
         this.newGameToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
         this.newGameToolStripMenuItem.Text = "New Game";
         this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
         // 
         // exitToolStripMenuItem
         // 
         this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         this.exitToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
         this.exitToolStripMenuItem.Text = "Exit";
         this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
         // 
         // howToPlayToolStripMenuItem
         // 
         this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
         this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
         this.howToPlayToolStripMenuItem.Text = "How to Play";
         this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
         // 
         // DungeonBrawlForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1238, 872);
         this.Controls.Add(this.battleImagePanel);
         this.Controls.Add(this.infoPanel);
         this.MainMenuStrip = this.menuStrip1;
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "DungeonBrawlForm";
         this.Text = "DungeonBrawl";
         this.infoPanel.ResumeLayout(false);
         this.infoPanel.PerformLayout();
         this.battleImagePanel.ResumeLayout(false);
         this.battleImagePanel.PerformLayout();
         this.enemy3ImgPan.ResumeLayout(false);
         this.enemy2ImgPan.ResumeLayout(false);
         this.hero3ImgPan.ResumeLayout(false);
         this.hero2ImgPan.ResumeLayout(false);
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel infoPanel;
      private System.Windows.Forms.Button specialButton;
      private System.Windows.Forms.Button defendButton;
      private System.Windows.Forms.Button attackButton;
      private System.Windows.Forms.Label selectedHeroLabel;
      private System.Windows.Forms.Label battleLogLabel;
      private System.Windows.Forms.RichTextBox battleLogBox;
      private System.Windows.Forms.Panel battleImagePanel;
      private System.Windows.Forms.Label enemy3StatLabel;
      private System.Windows.Forms.Label enemy2StatLabel;
      private System.Windows.Forms.Label enemy1StatLabel;
      private System.Windows.Forms.Label hero3StatLabel;
      private System.Windows.Forms.Label hero2StatLabel;
      private System.Windows.Forms.Label hero1StatLabel;
      private System.Windows.Forms.Label enemiesLabel;
      private System.Windows.Forms.Label heroesLabel;
      private System.Windows.Forms.Label levelLabel;
      private System.Windows.Forms.Panel enemy3ImgPan;
      private System.Windows.Forms.Panel panel7;
      private System.Windows.Forms.Panel enemy2ImgPan;
      private System.Windows.Forms.Panel panel9;
      private System.Windows.Forms.Panel enemy1ImgPan;
      private System.Windows.Forms.Panel hero3ImgPan;
      private System.Windows.Forms.Panel panel5;
      private System.Windows.Forms.Panel hero2ImgPan;
      private System.Windows.Forms.Panel panel3;
      private System.Windows.Forms.Panel hero1ImgPan;
      private System.Windows.Forms.Label chooseTargetLab;
      private System.Windows.Forms.Button target3But;
      private System.Windows.Forms.Button target2But;
      private System.Windows.Forms.Button target1Butt;
        private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.Button okBut;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
    }
}

