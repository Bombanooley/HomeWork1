namespace Exercise_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btNew = new System.Windows.Forms.Button();
            this.btTry = new System.Windows.Forms.Button();
            this.lblAnsw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(12, 120);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(164, 44);
            this.btNew.TabIndex = 0;
            this.btNew.Text = "Загадать новое число";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btTry
            // 
            this.btTry.Location = new System.Drawing.Point(194, 120);
            this.btTry.Name = "btTry";
            this.btTry.Size = new System.Drawing.Size(164, 44);
            this.btTry.TabIndex = 1;
            this.btTry.Text = "Проверить число";
            this.btTry.UseVisualStyleBackColor = true;
            this.btTry.Click += new System.EventHandler(this.btTry_Click);
            // 
            // lblAnsw
            // 
            this.lblAnsw.AutoSize = true;
            this.lblAnsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnsw.Location = new System.Drawing.Point(114, 36);
            this.lblAnsw.Name = "lblAnsw";
            this.lblAnsw.Size = new System.Drawing.Size(147, 42);
            this.lblAnsw.TabIndex = 2;
            this.lblAnsw.Text = "lblAnsw";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 176);
            this.Controls.Add(this.lblAnsw);
            this.Controls.Add(this.btTry);
            this.Controls.Add(this.btNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNew;
        public System.Windows.Forms.Button btTry;
        public System.Windows.Forms.Label lblAnsw;
    }
}

