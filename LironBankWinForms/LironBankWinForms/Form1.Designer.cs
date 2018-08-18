namespace LironBankWinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Finished = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameForgetFullness = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Finished
            // 
            this.Finished.Location = new System.Drawing.Point(337, 101);
            this.Finished.Name = "Finished";
            this.Finished.Size = new System.Drawing.Size(143, 23);
            this.Finished.TabIndex = 0;
            this.Finished.Text = "Click Here Once Finsihed";
            this.Finished.UseVisualStyleBackColor = true;
            this.Finished.Click += new System.EventHandler(this.Finished_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(16, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Enter Your Username Here";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.passwordTextBox.Location = new System.Drawing.Point(603, 129);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(154, 20);
            this.passwordTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(600, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please Enter Your Password Here";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.UsernameTextBox.Location = new System.Drawing.Point(31, 129);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(154, 20);
            this.UsernameTextBox.TabIndex = 3;
            // 
            // UsernameForgetFullness
            // 
            this.UsernameForgetFullness.Location = new System.Drawing.Point(144, 281);
            this.UsernameForgetFullness.Name = "UsernameForgetFullness";
            this.UsernameForgetFullness.Size = new System.Drawing.Size(549, 23);
            this.UsernameForgetFullness.TabIndex = 4;
            this.UsernameForgetFullness.Text = "IF YOU FORGOT YOUR USERNAME AND YOU ALREADY HAVE AN ACCOUNT CLICK HERE";
            this.UsernameForgetFullness.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UsernameForgetFullness);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Finished);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Finished;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Button UsernameForgetFullness;
    }
}

