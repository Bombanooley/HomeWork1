namespace Homework7
{
    partial class Form2
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
            this.lblQ = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.btnCan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQ.Location = new System.Drawing.Point(39, 38);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(296, 20);
            this.lblQ.TabIndex = 0;
            this.lblQ.Text = "Какое число должен получить игрок?";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(43, 210);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(132, 41);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(120, 85);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(132, 49);
            this.textBox.TabIndex = 2;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(68, 164);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(248, 13);
            this.lblMes.TabIndex = 3;
            this.lblMes.Text = "Неверный формат. Введите натуральное число";
            this.lblMes.Visible = false;
            // 
            // btnCan
            // 
            this.btnCan.Location = new System.Drawing.Point(203, 210);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(132, 41);
            this.btnCan.TabIndex = 4;
            this.btnCan.Text = "Cancel";
            this.btnCan.UseVisualStyleBackColor = true;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 302);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblQ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Button btnCan;
    }
}