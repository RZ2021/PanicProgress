
namespace Panic_Progress
{
    partial class NewFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewFile));
            this.startButton = new System.Windows.Forms.Button();
            this.surpriseTimer = new System.Windows.Forms.Timer(this.components);
            this.titleLabel = new System.Windows.Forms.Label();
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.mainTB = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.SaveTimer = new System.Windows.Forms.Timer(this.components);
            this.exitButton = new System.Windows.Forms.Label();
            this.modeCBLabel = new System.Windows.Forms.Label();
            this.modesPanel = new System.Windows.Forms.Panel();
            this.ghostCB = new System.Windows.Forms.CheckBox();
            this.distractCB = new System.Windows.Forms.CheckBox();
            this.eraserCB = new System.Windows.Forms.CheckBox();
            this.surpriseCB = new System.Windows.Forms.CheckBox();
            this.wordGoalCB = new System.Windows.Forms.CheckBox();
            this.stLabel = new System.Windows.Forms.Label();
            this.maxTB = new System.Windows.Forms.RichTextBox();
            this.wordGoalTB = new System.Windows.Forms.RichTextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.wgLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.eraserLabel = new System.Windows.Forms.Label();
            this.minTB = new System.Windows.Forms.RichTextBox();
            this.eraserTB = new System.Windows.Forms.RichTextBox();
            this.distractLabel = new System.Windows.Forms.Label();
            this.distractTB = new System.Windows.Forms.RichTextBox();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.PB2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pbValues = new System.Windows.Forms.Timer(this.components);
            this.eraserTimer = new System.Windows.Forms.Timer(this.components);
            this.easydTimer = new System.Windows.Forms.Timer(this.components);
            this.mediumdTimer = new System.Windows.Forms.Timer(this.components);
            this.hardTimer = new System.Windows.Forms.Timer(this.components);
            this.PB3 = new System.Windows.Forms.PictureBox();
            this.ghostTimer = new System.Windows.Forms.Timer(this.components);
            this.Ghost2Timer = new System.Windows.Forms.Timer(this.components);
            this.modeNotes = new System.Windows.Forms.Label();
            this.progressBar = new Panic_Progress.MyProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            this.panel1.SuspendLayout();
            this.modesPanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB3)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Moonbeam", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(781, 937);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(111, 38);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // surpriseTimer
            // 
            this.surpriseTimer.Interval = 30000;
            this.surpriseTimer.Tick += new System.EventHandler(this.surpriseTimer_Tick);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Moonbeam", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(813, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(274, 48);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Panic Progress";
            // 
            // PB1
            // 
            this.PB1.BackColor = System.Drawing.Color.Transparent;
            this.PB1.Location = new System.Drawing.Point(1164, 604);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(373, 339);
            this.PB1.TabIndex = 5;
            this.PB1.TabStop = false;
            this.PB1.Visible = false;
            // 
            // mainTB
            // 
            this.mainTB.BackColor = System.Drawing.Color.MistyRose;
            this.mainTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTB.Enabled = false;
            this.mainTB.Font = new System.Drawing.Font("Moonbeam", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTB.Location = new System.Drawing.Point(458, 121);
            this.mainTB.Name = "mainTB";
            this.mainTB.Size = new System.Drawing.Size(983, 793);
            this.mainTB.TabIndex = 3;
            this.mainTB.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Moonbeam", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Notes:";
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.instructionsLabel.Font = new System.Drawing.Font("Moonbeam", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.ForeColor = System.Drawing.Color.Salmon;
            this.instructionsLabel.Location = new System.Drawing.Point(12, 491);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(308, 28);
            this.instructionsLabel.TabIndex = 1;
            this.instructionsLabel.Text = "Hit the start button when";
            this.instructionsLabel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.modeNotes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 405);
            this.panel1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Moonbeam", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(438, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 40);
            this.label6.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Moonbeam", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(916, 937);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(111, 37);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Font = new System.Drawing.Font("Moonbeam", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.Location = new System.Drawing.Point(1045, 936);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(113, 38);
            this.restartButton.TabIndex = 8;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // SaveTimer
            // 
            this.SaveTimer.Tick += new System.EventHandler(this.SaveTimer_Tick);
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Font = new System.Drawing.Font("Minerva", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(1959, -2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(50, 53);
            this.exitButton.TabIndex = 32;
            this.exitButton.Text = "X";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // modeCBLabel
            // 
            this.modeCBLabel.AutoSize = true;
            this.modeCBLabel.Font = new System.Drawing.Font("Moonbeam", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeCBLabel.Location = new System.Drawing.Point(1473, 112);
            this.modeCBLabel.Name = "modeCBLabel";
            this.modeCBLabel.Size = new System.Drawing.Size(309, 40);
            this.modeCBLabel.TabIndex = 33;
            this.modeCBLabel.Text = "Choose Your Mode";
            // 
            // modesPanel
            // 
            this.modesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modesPanel.Controls.Add(this.ghostCB);
            this.modesPanel.Controls.Add(this.distractCB);
            this.modesPanel.Controls.Add(this.eraserCB);
            this.modesPanel.Controls.Add(this.surpriseCB);
            this.modesPanel.Controls.Add(this.wordGoalCB);
            this.modesPanel.Location = new System.Drawing.Point(1481, 155);
            this.modesPanel.Name = "modesPanel";
            this.modesPanel.Size = new System.Drawing.Size(324, 208);
            this.modesPanel.TabIndex = 35;
            // 
            // ghostCB
            // 
            this.ghostCB.AutoSize = true;
            this.ghostCB.Font = new System.Drawing.Font("Moonbeam", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghostCB.ForeColor = System.Drawing.Color.Salmon;
            this.ghostCB.Location = new System.Drawing.Point(3, 155);
            this.ghostCB.Name = "ghostCB";
            this.ghostCB.Size = new System.Drawing.Size(104, 33);
            this.ghostCB.TabIndex = 37;
            this.ghostCB.Text = "Ghost";
            this.ghostCB.UseVisualStyleBackColor = true;
            // 
            // distractCB
            // 
            this.distractCB.AutoSize = true;
            this.distractCB.Font = new System.Drawing.Font("Moonbeam", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distractCB.ForeColor = System.Drawing.Color.Salmon;
            this.distractCB.Location = new System.Drawing.Point(3, 117);
            this.distractCB.Name = "distractCB";
            this.distractCB.Size = new System.Drawing.Size(168, 33);
            this.distractCB.TabIndex = 37;
            this.distractCB.Text = "Distractions";
            this.distractCB.UseVisualStyleBackColor = true;
            this.distractCB.CheckedChanged += new System.EventHandler(this.distractCB_CheckedChanged);
            // 
            // eraserCB
            // 
            this.eraserCB.AutoSize = true;
            this.eraserCB.Font = new System.Drawing.Font("Moonbeam", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eraserCB.ForeColor = System.Drawing.Color.Salmon;
            this.eraserCB.Location = new System.Drawing.Point(3, 79);
            this.eraserCB.Name = "eraserCB";
            this.eraserCB.Size = new System.Drawing.Size(100, 33);
            this.eraserCB.TabIndex = 37;
            this.eraserCB.Text = "Eraser";
            this.eraserCB.UseVisualStyleBackColor = true;
            this.eraserCB.CheckedChanged += new System.EventHandler(this.eraserCB_CheckedChanged);
            // 
            // surpriseCB
            // 
            this.surpriseCB.AutoSize = true;
            this.surpriseCB.Font = new System.Drawing.Font("Moonbeam", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surpriseCB.ForeColor = System.Drawing.Color.Salmon;
            this.surpriseCB.Location = new System.Drawing.Point(3, 41);
            this.surpriseCB.Name = "surpriseCB";
            this.surpriseCB.Size = new System.Drawing.Size(186, 33);
            this.surpriseCB.TabIndex = 37;
            this.surpriseCB.Text = "Surprise Timer";
            this.surpriseCB.UseVisualStyleBackColor = true;
            this.surpriseCB.CheckedChanged += new System.EventHandler(this.surpriseCB_CheckedChanged);
            // 
            // wordGoalCB
            // 
            this.wordGoalCB.AutoSize = true;
            this.wordGoalCB.Font = new System.Drawing.Font("Moonbeam", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordGoalCB.ForeColor = System.Drawing.Color.Salmon;
            this.wordGoalCB.Location = new System.Drawing.Point(3, 3);
            this.wordGoalCB.Name = "wordGoalCB";
            this.wordGoalCB.Size = new System.Drawing.Size(155, 33);
            this.wordGoalCB.TabIndex = 36;
            this.wordGoalCB.Text = "Word Goal";
            this.wordGoalCB.UseVisualStyleBackColor = true;
            this.wordGoalCB.CheckedChanged += new System.EventHandler(this.wordGoalCB_CheckedChanged);
            // 
            // stLabel
            // 
            this.stLabel.AutoSize = true;
            this.stLabel.Font = new System.Drawing.Font("Moonbeam", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stLabel.Location = new System.Drawing.Point(6, 139);
            this.stLabel.Name = "stLabel";
            this.stLabel.Size = new System.Drawing.Size(402, 24);
            this.stLabel.TabIndex = 38;
            this.stLabel.Text = "Enter range in minutes for Surprise Timer:";
            // 
            // maxTB
            // 
            this.maxTB.BackColor = System.Drawing.Color.MistyRose;
            this.maxTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxTB.Enabled = false;
            this.maxTB.Font = new System.Drawing.Font("Moonbeam", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTB.Location = new System.Drawing.Point(249, 207);
            this.maxTB.Margin = new System.Windows.Forms.Padding(4);
            this.maxTB.Name = "maxTB";
            this.maxTB.Size = new System.Drawing.Size(190, 36);
            this.maxTB.TabIndex = 40;
            this.maxTB.Text = "";
            // 
            // wordGoalTB
            // 
            this.wordGoalTB.BackColor = System.Drawing.Color.MistyRose;
            this.wordGoalTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wordGoalTB.Enabled = false;
            this.wordGoalTB.Font = new System.Drawing.Font("Moonbeam", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordGoalTB.Location = new System.Drawing.Point(9, 86);
            this.wordGoalTB.Margin = new System.Windows.Forms.Padding(4);
            this.wordGoalTB.Name = "wordGoalTB";
            this.wordGoalTB.Size = new System.Drawing.Size(430, 36);
            this.wordGoalTB.TabIndex = 37;
            this.wordGoalTB.Text = "";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Moonbeam", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.Location = new System.Drawing.Point(5, 178);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(89, 20);
            this.minLabel.TabIndex = 41;
            this.minLabel.Text = "Min Time:";
            // 
            // wgLabel
            // 
            this.wgLabel.AutoSize = true;
            this.wgLabel.Font = new System.Drawing.Font("Moonbeam", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wgLabel.Location = new System.Drawing.Point(5, 58);
            this.wgLabel.Name = "wgLabel";
            this.wgLabel.Size = new System.Drawing.Size(284, 24);
            this.wgLabel.TabIndex = 36;
            this.wgLabel.Text = "Enter your word count goal:";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Moonbeam", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.Location = new System.Drawing.Point(245, 178);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(93, 20);
            this.maxLabel.TabIndex = 42;
            this.maxLabel.Text = "Max Time:";
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Font = new System.Drawing.Font("Moonbeam", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.Location = new System.Drawing.Point(3, 11);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(297, 33);
            this.settingsLabel.TabIndex = 34;
            this.settingsLabel.Text = "Choose Your Settings";
            // 
            // eraserLabel
            // 
            this.eraserLabel.AutoSize = true;
            this.eraserLabel.Font = new System.Drawing.Font("Moonbeam", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eraserLabel.Location = new System.Drawing.Point(5, 259);
            this.eraserLabel.Name = "eraserLabel";
            this.eraserLabel.Size = new System.Drawing.Size(411, 24);
            this.eraserLabel.TabIndex = 43;
            this.eraserLabel.Text = "Enter the number of letters to be erased:";
            // 
            // minTB
            // 
            this.minTB.BackColor = System.Drawing.Color.MistyRose;
            this.minTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minTB.Enabled = false;
            this.minTB.Font = new System.Drawing.Font("Moonbeam", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTB.Location = new System.Drawing.Point(9, 207);
            this.minTB.Margin = new System.Windows.Forms.Padding(4);
            this.minTB.Name = "minTB";
            this.minTB.Size = new System.Drawing.Size(194, 36);
            this.minTB.TabIndex = 39;
            this.minTB.Text = "";
            // 
            // eraserTB
            // 
            this.eraserTB.BackColor = System.Drawing.Color.MistyRose;
            this.eraserTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eraserTB.Enabled = false;
            this.eraserTB.Font = new System.Drawing.Font("Moonbeam", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eraserTB.Location = new System.Drawing.Point(10, 294);
            this.eraserTB.Margin = new System.Windows.Forms.Padding(4);
            this.eraserTB.Name = "eraserTB";
            this.eraserTB.Size = new System.Drawing.Size(429, 36);
            this.eraserTB.TabIndex = 44;
            this.eraserTB.Text = "";
            // 
            // distractLabel
            // 
            this.distractLabel.AutoSize = true;
            this.distractLabel.Font = new System.Drawing.Font("Moonbeam", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distractLabel.Location = new System.Drawing.Point(6, 346);
            this.distractLabel.Name = "distractLabel";
            this.distractLabel.Size = new System.Drawing.Size(314, 24);
            this.distractLabel.TabIndex = 45;
            this.distractLabel.Text = "Enter the distractions difficulty:";
            // 
            // distractTB
            // 
            this.distractTB.BackColor = System.Drawing.Color.MistyRose;
            this.distractTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.distractTB.Enabled = false;
            this.distractTB.Font = new System.Drawing.Font("Moonbeam", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distractTB.Location = new System.Drawing.Point(9, 404);
            this.distractTB.Margin = new System.Windows.Forms.Padding(4);
            this.distractTB.Name = "distractTB";
            this.distractTB.Size = new System.Drawing.Size(430, 36);
            this.distractTB.TabIndex = 46;
            this.distractTB.Text = "";
            // 
            // settingsPanel
            // 
            this.settingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsPanel.Controls.Add(this.label7);
            this.settingsPanel.Controls.Add(this.levelLabel);
            this.settingsPanel.Controls.Add(this.distractTB);
            this.settingsPanel.Controls.Add(this.distractLabel);
            this.settingsPanel.Controls.Add(this.eraserTB);
            this.settingsPanel.Controls.Add(this.minTB);
            this.settingsPanel.Controls.Add(this.eraserLabel);
            this.settingsPanel.Controls.Add(this.settingsLabel);
            this.settingsPanel.Controls.Add(this.maxLabel);
            this.settingsPanel.Controls.Add(this.wgLabel);
            this.settingsPanel.Controls.Add(this.minLabel);
            this.settingsPanel.Controls.Add(this.wordGoalTB);
            this.settingsPanel.Controls.Add(this.maxTB);
            this.settingsPanel.Controls.Add(this.stLabel);
            this.settingsPanel.Location = new System.Drawing.Point(1480, 396);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(491, 519);
            this.settingsPanel.TabIndex = 45;
            // 
            // PB2
            // 
            this.PB2.Location = new System.Drawing.Point(1093, 87);
            this.PB2.Name = "PB2";
            this.PB2.Size = new System.Drawing.Size(373, 339);
            this.PB2.TabIndex = 47;
            this.PB2.TabStop = false;
            this.PB2.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Moonbeam", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(304, 24);
            this.label7.TabIndex = 37;
            this.label7.Text = "Press start when you\'re ready!";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Moonbeam", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.Location = new System.Drawing.Point(6, 370);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(222, 24);
            this.levelLabel.TabIndex = 47;
            this.levelLabel.Text = "Easy, Medium, or Hard";
            // 
            // pbValues
            // 
            this.pbValues.Tick += new System.EventHandler(this.pbValues_Tick);
            // 
            // eraserTimer
            // 
            this.eraserTimer.Tick += new System.EventHandler(this.eraserTimer_Tick);
            // 
            // easydTimer
            // 
            this.easydTimer.Tick += new System.EventHandler(this.easydTimer_Tick);
            // 
            // mediumdTimer
            // 
            this.mediumdTimer.Tick += new System.EventHandler(this.mediumdTimer_Tick);
            // 
            // hardTimer
            // 
            this.hardTimer.Tick += new System.EventHandler(this.hardTimer_Tick);
            // 
            // PB3
            // 
            this.PB3.Location = new System.Drawing.Point(65, 536);
            this.PB3.Name = "PB3";
            this.PB3.Size = new System.Drawing.Size(373, 339);
            this.PB3.TabIndex = 4;
            this.PB3.TabStop = false;
            this.PB3.Visible = false;
            // 
            // ghostTimer
            // 
            this.ghostTimer.Tick += new System.EventHandler(this.ghostTimer_Tick);
            // 
            // Ghost2Timer
            // 
            this.Ghost2Timer.Tick += new System.EventHandler(this.Ghost2Timer_Tick);
            // 
            // modeNotes
            // 
            this.modeNotes.AutoSize = true;
            this.modeNotes.BackColor = System.Drawing.Color.Transparent;
            this.modeNotes.Font = new System.Drawing.Font("Moonbeam", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeNotes.Location = new System.Drawing.Point(99, 144);
            this.modeNotes.Name = "modeNotes";
            this.modeNotes.Size = new System.Drawing.Size(64, 30);
            this.modeNotes.TabIndex = 2;
            this.modeNotes.Text = "here";
            this.modeNotes.Click += new System.EventHandler(this.modeNotes_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Salmon;
            this.progressBar.Enabled = false;
            this.progressBar.Location = new System.Drawing.Point(818, 60);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(269, 40);
            this.progressBar.TabIndex = 46;
            this.progressBar.Visible = false;
            // 
            // NewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2011, 995);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.PB2);
            this.Controls.Add(this.PB1);
            this.Controls.Add(this.PB3);
            this.Controls.Add(this.mainTB);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.modesPanel);
            this.Controls.Add(this.modeCBLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.modesPanel.ResumeLayout(false);
            this.modesPanel.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer surpriseTimer;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.RichTextBox mainTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Timer SaveTimer;
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.Label modeCBLabel;
        private System.Windows.Forms.Panel modesPanel;
        private System.Windows.Forms.CheckBox ghostCB;
        private System.Windows.Forms.CheckBox distractCB;
        private System.Windows.Forms.CheckBox eraserCB;
        private System.Windows.Forms.CheckBox surpriseCB;
        private System.Windows.Forms.CheckBox wordGoalCB;
        private System.Windows.Forms.Label stLabel;
        private System.Windows.Forms.RichTextBox maxTB;
        private System.Windows.Forms.RichTextBox wordGoalTB;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label wgLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Label eraserLabel;
        private System.Windows.Forms.RichTextBox minTB;
        private System.Windows.Forms.RichTextBox eraserTB;
        private System.Windows.Forms.Label distractLabel;
        private System.Windows.Forms.RichTextBox distractTB;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer pbValues;
        private System.Windows.Forms.Timer eraserTimer;
        private System.Windows.Forms.Timer easydTimer;
        private System.Windows.Forms.Timer mediumdTimer;
        private System.Windows.Forms.Timer hardTimer;
        private MyProgressBar progressBar;
        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.PictureBox PB2;
        private System.Windows.Forms.PictureBox PB3;
        private System.Windows.Forms.Timer ghostTimer;
        private System.Windows.Forms.Timer Ghost2Timer;
        private System.Windows.Forms.Label modeNotes;
    }
}

