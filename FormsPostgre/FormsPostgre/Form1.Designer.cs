namespace FormsPostgre
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
            this.lstActors = new System.Windows.Forms.ListBox();
            this.listFilms = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstActors
            // 
            this.lstActors.FormattingEnabled = true;
            this.lstActors.Location = new System.Drawing.Point(12, 12);
            this.lstActors.Name = "lstActors";
            this.lstActors.Size = new System.Drawing.Size(148, 238);
            this.lstActors.TabIndex = 0;
            this.lstActors.SelectedIndexChanged += new System.EventHandler(this.lstActors_SelectedIndexChanged);
            // 
            // listFilms
            // 
            this.listFilms.FormattingEnabled = true;
            this.listFilms.Location = new System.Drawing.Point(203, 64);
            this.listFilms.Name = "listFilms";
            this.listFilms.Size = new System.Drawing.Size(154, 186);
            this.listFilms.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "снимался в";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 293);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listFilms);
            this.Controls.Add(this.lstActors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstActors;
        private System.Windows.Forms.ListBox listFilms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

