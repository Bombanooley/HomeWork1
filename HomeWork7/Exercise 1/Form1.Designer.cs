namespace Homework7
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
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnThrow = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.игратьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblQuestMsg = new System.Windows.Forms.Label();
            this.lblQuest = new System.Windows.Forms.Label();
            this.lblSteps = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(211, 44);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(147, 43);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+1";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(211, 128);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(147, 43);
            this.btnMult.TabIndex = 1;
            this.btnMult.Text = "x2";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnThrow
            // 
            this.btnThrow.Location = new System.Drawing.Point(211, 209);
            this.btnThrow.Name = "btnThrow";
            this.btnThrow.Size = new System.Drawing.Size(147, 43);
            this.btnThrow.TabIndex = 2;
            this.btnThrow.Text = "Сброс";
            this.btnThrow.UseVisualStyleBackColor = true;
            this.btnThrow.Click += new System.EventHandler(this.btnThrow_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNum.Location = new System.Drawing.Point(83, 146);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(24, 25);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "0";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(55, 260);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(110, 13);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "Количество ходов: 0";
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.игратьToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(370, 24);
            this.Menu.TabIndex = 5;
            this.Menu.Text = "menuStrip1";
            // 
            // игратьToolStripMenuItem
            // 
            this.игратьToolStripMenuItem.Name = "игратьToolStripMenuItem";
            this.игратьToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.игратьToolStripMenuItem.Text = "Играть";
            this.игратьToolStripMenuItem.Click += new System.EventHandler(this.игратьToolStripMenuItem_Click);
            // 
            // lblQuestMsg
            // 
            this.lblQuestMsg.AutoSize = true;
            this.lblQuestMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestMsg.Location = new System.Drawing.Point(50, 51);
            this.lblQuestMsg.Name = "lblQuestMsg";
            this.lblQuestMsg.Size = new System.Drawing.Size(95, 24);
            this.lblQuestMsg.TabIndex = 6;
            this.lblQuestMsg.Text = "Получите\r\n";
            this.lblQuestMsg.Visible = false;
            // 
            // lblQuest
            // 
            this.lblQuest.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblQuest.AutoSize = true;
            this.lblQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuest.Location = new System.Drawing.Point(84, 75);
            this.lblQuest.Name = "lblQuest";
            this.lblQuest.Size = new System.Drawing.Size(79, 24);
            this.lblQuest.TabIndex = 7;
            this.lblQuest.Text = "lblQuest";
            this.lblQuest.Visible = false;
            // 
            // lblSteps
            // 
            this.lblSteps.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblSteps.AutoSize = true;
            this.lblSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSteps.Location = new System.Drawing.Point(69, 99);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(76, 24);
            this.lblSteps.TabIndex = 8;
            this.lblSteps.Text = "lblSteps";
            this.lblSteps.Visible = false;
            // 
            // btnUndo
            // 
            this.btnUndo.Enabled = false;
            this.btnUndo.Location = new System.Drawing.Point(38, 209);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(147, 43);
            this.btnUndo.TabIndex = 9;
            this.btnUndo.Text = "Отмена";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 283);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.lblQuest);
            this.Controls.Add(this.lblQuestMsg);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.btnThrow);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.Menu;
            this.MaximumSize = new System.Drawing.Size(386, 322);
            this.MinimumSize = new System.Drawing.Size(386, 322);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удвоитель";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnThrow;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem игратьToolStripMenuItem;
        public System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblCount;
        public System.Windows.Forms.Label lblQuestMsg;
        public System.Windows.Forms.Label lblQuest;
        public System.Windows.Forms.Label lblSteps;
        public System.Windows.Forms.Button btnUndo;
    }
}

