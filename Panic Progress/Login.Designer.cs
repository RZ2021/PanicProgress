
namespace Panic_Progress
{
    partial class Login
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
            this.exitButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nuButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.unTB = new System.Windows.Forms.RichTextBox();
            this.passTB = new System.Windows.Forms.RichTextBox();
            this.pass1Label = new System.Windows.Forms.Label();
            this.unLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Font = new System.Drawing.Font("Minerva", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(487, -1);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(50, 53);
            this.exitButton.TabIndex = 22;
            this.exitButton.Text = "X";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pyunji R", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(207, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 47);
            this.label1.TabIndex = 23;
            this.label1.Text = "Login";
            // 
            // nuButton
            // 
            this.nuButton.BackColor = System.Drawing.Color.MistyRose;
            this.nuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuButton.Font = new System.Drawing.Font("Pyunji R", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nuButton.Location = new System.Drawing.Point(274, 304);
            this.nuButton.Name = "nuButton";
            this.nuButton.Size = new System.Drawing.Size(141, 45);
            this.nuButton.TabIndex = 33;
            this.nuButton.Text = "New User";
            this.nuButton.UseVisualStyleBackColor = false;
            this.nuButton.Click += new System.EventHandler(this.nuButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.MistyRose;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Pyunji R", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginButton.Location = new System.Drawing.Point(104, 304);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(141, 45);
            this.loginButton.TabIndex = 32;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // unTB
            // 
            this.unTB.BackColor = System.Drawing.Color.MistyRose;
            this.unTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unTB.Font = new System.Drawing.Font("Pyunji R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.unTB.Location = new System.Drawing.Point(103, 132);
            this.unTB.Margin = new System.Windows.Forms.Padding(4);
            this.unTB.Name = "unTB";
            this.unTB.Size = new System.Drawing.Size(312, 36);
            this.unTB.TabIndex = 31;
            this.unTB.Text = "";
            // 
            // passTB
            // 
            this.passTB.BackColor = System.Drawing.Color.MistyRose;
            this.passTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passTB.Font = new System.Drawing.Font("Pyunji R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.passTB.Location = new System.Drawing.Point(103, 211);
            this.passTB.Margin = new System.Windows.Forms.Padding(4);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(312, 36);
            this.passTB.TabIndex = 30;
            this.passTB.Text = "";
            // 
            // pass1Label
            // 
            this.pass1Label.AutoSize = true;
            this.pass1Label.Font = new System.Drawing.Font("Pyunji R", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pass1Label.Location = new System.Drawing.Point(98, 176);
            this.pass1Label.Name = "pass1Label";
            this.pass1Label.Size = new System.Drawing.Size(123, 31);
            this.pass1Label.TabIndex = 25;
            this.pass1Label.Text = "Password:";
            // 
            // unLabel
            // 
            this.unLabel.AutoSize = true;
            this.unLabel.Font = new System.Drawing.Font("Pyunji R", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.unLabel.Location = new System.Drawing.Point(97, 99);
            this.unLabel.Name = "unLabel";
            this.unLabel.Size = new System.Drawing.Size(125, 31);
            this.unLabel.TabIndex = 24;
            this.unLabel.Text = "Username:";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Pyunji R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.errorLabel.Location = new System.Drawing.Point(99, 251);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 23);
            this.errorLabel.TabIndex = 35;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 442);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.nuButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.unTB);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.pass1Label);
            this.Controls.Add(this.unLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.RichTextBox unTB;
        private System.Windows.Forms.RichTextBox passTB;
        private System.Windows.Forms.Label pass1Label;
        private System.Windows.Forms.Label unLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button nuButton;
    }
}