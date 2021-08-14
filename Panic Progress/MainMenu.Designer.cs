
namespace Panic_Progress
{
    partial class MainMenu
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
            this.PPButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.wpButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PPButton
            // 
            this.PPButton.BackColor = System.Drawing.Color.White;
            this.PPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PPButton.Font = new System.Drawing.Font("Pyunji R", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PPButton.Location = new System.Drawing.Point(467, 296);
            this.PPButton.Name = "PPButton";
            this.PPButton.Size = new System.Drawing.Size(206, 45);
            this.PPButton.TabIndex = 0;
            this.PPButton.Text = "Panic Progress";
            this.PPButton.UseVisualStyleBackColor = false;
            this.PPButton.Click += new System.EventHandler(this.PPButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pyunji R", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(374, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 70);
            this.label1.TabIndex = 4;
            this.label1.Text = "Panic Progress";
            // 
            // wpButton
            // 
            this.wpButton.BackColor = System.Drawing.Color.White;
            this.wpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wpButton.Font = new System.Drawing.Font("Pyunji R", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.wpButton.Location = new System.Drawing.Point(467, 349);
            this.wpButton.Name = "wpButton";
            this.wpButton.Size = new System.Drawing.Size(206, 45);
            this.wpButton.TabIndex = 5;
            this.wpButton.Text = "Word Play";
            this.wpButton.UseVisualStyleBackColor = false;
            this.wpButton.Click += new System.EventHandler(this.wpButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.White;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Pyunji R", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.settingsButton.Location = new System.Drawing.Point(467, 400);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(206, 45);
            this.settingsButton.TabIndex = 7;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Font = new System.Drawing.Font("Minerva", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(1068, 9);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(50, 53);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "X";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.White;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Pyunji R", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginButton.Location = new System.Drawing.Point(467, 245);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(206, 45);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Pyunji R", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userNameLabel.Location = new System.Drawing.Point(525, 97);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(0, 32);
            this.userNameLabel.TabIndex = 10;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1130, 697);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.wpButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PPButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PPButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button wpButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.Button loginButton;
        public System.Windows.Forms.Label userNameLabel;
    }
}