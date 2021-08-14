
namespace Panic_Progress
{
    partial class WordPlayFight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordPlayFight));
            this.label6 = new System.Windows.Forms.Label();
            this.mainTextbox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.doneButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.monsterPB = new System.Windows.Forms.PictureBox();
            this.pbValues = new System.Windows.Forms.Timer(this.components);
            this.TimeLimitTimer = new System.Windows.Forms.Timer(this.components);
            this.avatarPB = new System.Windows.Forms.PictureBox();
            this.surpriseTimer = new System.Windows.Forms.Timer(this.components);
            this.thanosTimer = new System.Windows.Forms.Timer(this.components);
            this.easydTimer = new System.Windows.Forms.Timer(this.components);
            this.mediumdTimer = new System.Windows.Forms.Timer(this.components);
            this.harddTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.instructionText = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.monsterName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Label();
            this.myProgressBar1 = new Panic_Progress.MyProgressBar();
            this.AutoSave = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.monsterPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Moonbeam", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(452, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 40);
            this.label6.TabIndex = 12;
            // 
            // mainTextbox
            // 
            this.mainTextbox.BackColor = System.Drawing.Color.MistyRose;
            this.mainTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTextbox.Font = new System.Drawing.Font("Moonbeam", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTextbox.Location = new System.Drawing.Point(355, 102);
            this.mainTextbox.Name = "mainTextbox";
            this.mainTextbox.Size = new System.Drawing.Size(982, 719);
            this.mainTextbox.TabIndex = 3;
            this.mainTextbox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Moonbeam", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(705, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "Panic Progress";
            // 
            // doneButton
            // 
            this.doneButton.Font = new System.Drawing.Font("Moonbeam", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneButton.Location = new System.Drawing.Point(726, 906);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(87, 38);
            this.doneButton.TabIndex = 17;
            this.doneButton.Text = "Done!";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Moonbeam", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(832, 906);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(87, 38);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Moonbeam", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(939, 906);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(87, 38);
            this.startButton.TabIndex = 15;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // monsterPB
            // 
            this.monsterPB.Image = ((System.Drawing.Image)(resources.GetObject("monsterPB.Image")));
            this.monsterPB.Location = new System.Drawing.Point(1359, 133);
            this.monsterPB.Name = "monsterPB";
            this.monsterPB.Size = new System.Drawing.Size(280, 230);
            this.monsterPB.TabIndex = 19;
            this.monsterPB.TabStop = false;
            // 
            // pbValues
            // 
            this.pbValues.Tick += new System.EventHandler(this.pbValues_Tick);
            // 
            // TimeLimitTimer
            // 
            this.TimeLimitTimer.Tick += new System.EventHandler(this.TimeLimitTimer_Tick);
            // 
            // avatarPB
            // 
            this.avatarPB.Image = ((System.Drawing.Image)(resources.GetObject("avatarPB.Image")));
            this.avatarPB.Location = new System.Drawing.Point(12, 133);
            this.avatarPB.Name = "avatarPB";
            this.avatarPB.Size = new System.Drawing.Size(284, 277);
            this.avatarPB.TabIndex = 22;
            this.avatarPB.TabStop = false;
            // 
            // surpriseTimer
            // 
            this.surpriseTimer.Tick += new System.EventHandler(this.surpriseTimer_Tick);
            // 
            // thanosTimer
            // 
            this.thanosTimer.Tick += new System.EventHandler(this.thanosTimer_Tick);
            // 
            // easydTimer
            // 
            this.easydTimer.Tick += new System.EventHandler(this.easydTimer_Tick);
            // 
            // mediumdTimer
            // 
            this.mediumdTimer.Tick += new System.EventHandler(this.mediumdTimer_Tick);
            // 
            // harddTimer
            // 
            this.harddTimer.Tick += new System.EventHandler(this.harddTimer_Tick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(12, 502);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(237, 235);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(1379, 449);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(237, 235);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(1357, 766);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(282, 172);
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "draft";
            // 
            // instructionText
            // 
            this.instructionText.AutoSize = true;
            this.instructionText.Font = new System.Drawing.Font("Moonbeam", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionText.ForeColor = System.Drawing.Color.LightCoral;
            this.instructionText.Location = new System.Drawing.Point(350, 824);
            this.instructionText.Name = "instructionText";
            this.instructionText.Size = new System.Drawing.Size(77, 29);
            this.instructionText.TabIndex = 26;
            this.instructionText.Text = "label2";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Moonbeam", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.Salmon;
            this.userNameLabel.Location = new System.Drawing.Point(92, 84);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(119, 29);
            this.userNameLabel.TabIndex = 27;
            this.userNameLabel.Text = "Username";
            // 
            // monsterName
            // 
            this.monsterName.AutoSize = true;
            this.monsterName.Font = new System.Drawing.Font("Moonbeam", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monsterName.ForeColor = System.Drawing.Color.Salmon;
            this.monsterName.Location = new System.Drawing.Point(1374, 84);
            this.monsterName.Name = "monsterName";
            this.monsterName.Size = new System.Drawing.Size(108, 29);
            this.monsterName.TabIndex = 28;
            this.monsterName.Text = "Monster";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Moonbeam", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1075, 909);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "Press start to begin!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Moonbeam", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 909);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Press done, if there\'s no timer";
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Font = new System.Drawing.Font("Minerva", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(1657, 9);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(50, 53);
            this.exitButton.TabIndex = 31;
            this.exitButton.Text = "X";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // myProgressBar1
            // 
            this.myProgressBar1.Location = new System.Drawing.Point(712, 46);
            this.myProgressBar1.Name = "myProgressBar1";
            this.myProgressBar1.Size = new System.Drawing.Size(222, 47);
            this.myProgressBar1.TabIndex = 21;
            // 
            // AutoSave
            // 
            this.AutoSave.Tick += new System.EventHandler(this.AutoSave_Tick);
            // 
            // WordPlayFight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1707, 961);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monsterName);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.instructionText);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.mainTextbox);
            this.Controls.Add(this.avatarPB);
            this.Controls.Add(this.myProgressBar1);
            this.Controls.Add(this.monsterPB);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WordPlayFight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordPlayFight";
            ((System.ComponentModel.ISupportInitialize)(this.monsterPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox monsterPB;
        private System.Windows.Forms.PictureBox avatarPB;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.Timer TimeLimitTimer;
        public System.Windows.Forms.Timer pbValues;
        public System.Windows.Forms.Timer surpriseTimer;
        public System.Windows.Forms.Timer thanosTimer;
        public System.Windows.Forms.Timer easydTimer;
        public System.Windows.Forms.Timer mediumdTimer;
        public System.Windows.Forms.Timer harddTimer;
        public System.Windows.Forms.RichTextBox mainTextbox;
        public MyProgressBar myProgressBar1;
        private System.Windows.Forms.Label instructionText;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label monsterName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.Timer AutoSave;
    }
}