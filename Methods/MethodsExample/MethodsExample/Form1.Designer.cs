namespace MethodsExample
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEksi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnArti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // btnEksi
            // 
            this.btnEksi.Location = new System.Drawing.Point(27, 159);
            this.btnEksi.Name = "btnEksi";
            this.btnEksi.Size = new System.Drawing.Size(182, 74);
            this.btnEksi.TabIndex = 1;
            this.btnEksi.Text = "-";
            this.btnEksi.UseVisualStyleBackColor = true;
            this.btnEksi.Click += new System.EventHandler(this.btnEksi_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 74);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnArti
            // 
            this.btnArti.Location = new System.Drawing.Point(512, 159);
            this.btnArti.Name = "btnArti";
            this.btnArti.Size = new System.Drawing.Size(219, 74);
            this.btnArti.TabIndex = 3;
            this.btnArti.Text = "+";
            this.btnArti.UseVisualStyleBackColor = true;
            this.btnArti.Click += new System.EventHandler(this.btnArti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnArti);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEksi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEksi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnArti;
    }
}

