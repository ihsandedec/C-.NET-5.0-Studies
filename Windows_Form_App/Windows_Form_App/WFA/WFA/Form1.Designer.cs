namespace WFA
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
            this.btnClick = new System.Windows.Forms.Button();
            this.btnTrue = new System.Windows.Forms.Button();
            this.btnFalse = new System.Windows.Forms.Button();
            this.btnFalse3 = new System.Windows.Forms.Button();
            this.btnFalse2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.Color.White;
            this.btnClick.Location = new System.Drawing.Point(261, 144);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(164, 79);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.button1_Click);
            this.btnClick.MouseLeave += new System.EventHandler(this.btnClick_MouseLeave);
            this.btnClick.MouseHover += new System.EventHandler(this.btnClick_MouseHover);
            // 
            // btnTrue
            // 
            this.btnTrue.Location = new System.Drawing.Point(31, 22);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(111, 53);
            this.btnTrue.TabIndex = 1;
            this.btnTrue.UseVisualStyleBackColor = true;
            this.btnTrue.MouseEnter += new System.EventHandler(this.btnTrue_MouseEnter);
            // 
            // btnFalse
            // 
            this.btnFalse.Location = new System.Drawing.Point(577, 22);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(111, 53);
            this.btnFalse.TabIndex = 1;
            this.btnFalse.UseVisualStyleBackColor = true;
            this.btnFalse.MouseEnter += new System.EventHandler(this.btnFalse_MouseEnter);
            // 
            // btnFalse3
            // 
            this.btnFalse3.Location = new System.Drawing.Point(577, 311);
            this.btnFalse3.Name = "btnFalse3";
            this.btnFalse3.Size = new System.Drawing.Size(111, 53);
            this.btnFalse3.TabIndex = 1;
            this.btnFalse3.UseVisualStyleBackColor = true;
            this.btnFalse3.MouseEnter += new System.EventHandler(this.btnFalse3_MouseEnter);
            // 
            // btnFalse2
            // 
            this.btnFalse2.Location = new System.Drawing.Point(31, 311);
            this.btnFalse2.Name = "btnFalse2";
            this.btnFalse2.Size = new System.Drawing.Size(111, 53);
            this.btnFalse2.TabIndex = 1;
            this.btnFalse2.UseVisualStyleBackColor = true;
            this.btnFalse2.MouseEnter += new System.EventHandler(this.btnFalse2_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 403);
            this.Controls.Add(this.btnFalse2);
            this.Controls.Add(this.btnFalse3);
            this.Controls.Add(this.btnFalse);
            this.Controls.Add(this.btnTrue);
            this.Controls.Add(this.btnClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.Button btnFalse;
        private System.Windows.Forms.Button btnFalse3;
        private System.Windows.Forms.Button btnFalse2;
    }
}

