namespace GuessGame
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.lstDogruTahminler = new System.Windows.Forms.ListBox();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(328, 192);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(170, 59);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lstDogruTahminler
            // 
            this.lstDogruTahminler.FormattingEnabled = true;
            this.lstDogruTahminler.ItemHeight = 16;
            this.lstDogruTahminler.Location = new System.Drawing.Point(28, 51);
            this.lstDogruTahminler.Name = "lstDogruTahminler";
            this.lstDogruTahminler.Size = new System.Drawing.Size(179, 324);
            this.lstDogruTahminler.TabIndex = 1;
            // 
            // txtGuess
            // 
            this.txtGuess.Enabled = false;
            this.txtGuess.Location = new System.Drawing.Point(328, 134);
            this.txtGuess.Multiline = true;
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(170, 35);
            this.txtGuess.TabIndex = 2;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(559, 320);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(192, 55);
            this.btnNewGame.TabIndex = 3;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lstDogruTahminler);
            this.Controls.Add(this.btnCheck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ListBox lstDogruTahminler;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnNewGame;
    }
}

