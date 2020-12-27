namespace HomeWorkForms_2
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
            this.GenerateBT = new System.Windows.Forms.Button();
            this.moreOrLessBt = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.digitsGB = new System.Windows.Forms.GroupBox();
            this.unitsRB = new System.Windows.Forms.RadioButton();
            this.tensRB = new System.Windows.Forms.RadioButton();
            this.hundredsRB = new System.Windows.Forms.RadioButton();
            this.thousandsRB = new System.Windows.Forms.RadioButton();
            this.moreOrLessChB = new System.Windows.Forms.CheckBox();
            this.digitsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenerateBT
            // 
            this.GenerateBT.Location = new System.Drawing.Point(12, 34);
            this.GenerateBT.Name = "GenerateBT";
            this.GenerateBT.Size = new System.Drawing.Size(100, 23);
            this.GenerateBT.TabIndex = 0;
            this.GenerateBT.Text = "Сгенерировать";
            this.GenerateBT.UseVisualStyleBackColor = true;
            this.GenerateBT.Click += new System.EventHandler(this.GenerateBT_Click);
            // 
            // moreOrLessBt
            // 
            this.moreOrLessBt.Location = new System.Drawing.Point(12, 63);
            this.moreOrLessBt.Name = "moreOrLessBt";
            this.moreOrLessBt.Size = new System.Drawing.Size(100, 23);
            this.moreOrLessBt.TabIndex = 1;
            this.moreOrLessBt.Text = "Увеличить";
            this.moreOrLessBt.UseVisualStyleBackColor = true;
            this.moreOrLessBt.Click += new System.EventHandler(this.moreOrLessBt_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(12, 9);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(92, 13);
            this.resultLbl.TabIndex = 2;
            this.resultLbl.Text = "Результат:  9999";
            // 
            // digitsGB
            // 
            this.digitsGB.Controls.Add(this.thousandsRB);
            this.digitsGB.Controls.Add(this.hundredsRB);
            this.digitsGB.Controls.Add(this.tensRB);
            this.digitsGB.Controls.Add(this.unitsRB);
            this.digitsGB.Location = new System.Drawing.Point(118, 25);
            this.digitsGB.Name = "digitsGB";
            this.digitsGB.Size = new System.Drawing.Size(152, 68);
            this.digitsGB.TabIndex = 3;
            this.digitsGB.TabStop = false;
            this.digitsGB.Text = "Разряды";
            // 
            // unitsRB
            // 
            this.unitsRB.AutoSize = true;
            this.unitsRB.Checked = true;
            this.unitsRB.Location = new System.Drawing.Point(7, 20);
            this.unitsRB.Name = "unitsRB";
            this.unitsRB.Size = new System.Drawing.Size(70, 17);
            this.unitsRB.TabIndex = 0;
            this.unitsRB.TabStop = true;
            this.unitsRB.Text = "Единицы";
            this.unitsRB.UseVisualStyleBackColor = true;
            // 
            // tensRB
            // 
            this.tensRB.AutoSize = true;
            this.tensRB.Location = new System.Drawing.Point(7, 43);
            this.tensRB.Name = "tensRB";
            this.tensRB.Size = new System.Drawing.Size(69, 17);
            this.tensRB.TabIndex = 1;
            this.tensRB.TabStop = true;
            this.tensRB.Text = "Десятки";
            this.tensRB.UseVisualStyleBackColor = true;
            // 
            // hundredsRB
            // 
            this.hundredsRB.AutoSize = true;
            this.hundredsRB.Location = new System.Drawing.Point(83, 20);
            this.hundredsRB.Name = "hundredsRB";
            this.hundredsRB.Size = new System.Drawing.Size(55, 17);
            this.hundredsRB.TabIndex = 2;
            this.hundredsRB.TabStop = true;
            this.hundredsRB.Text = "Сотни";
            this.hundredsRB.UseVisualStyleBackColor = true;
            // 
            // thousandsRB
            // 
            this.thousandsRB.AutoSize = true;
            this.thousandsRB.Location = new System.Drawing.Point(83, 44);
            this.thousandsRB.Name = "thousandsRB";
            this.thousandsRB.Size = new System.Drawing.Size(63, 17);
            this.thousandsRB.TabIndex = 3;
            this.thousandsRB.TabStop = true;
            this.thousandsRB.Text = "Тысячи";
            this.thousandsRB.UseVisualStyleBackColor = true;
            // 
            // moreOrLessChB
            // 
            this.moreOrLessChB.AutoSize = true;
            this.moreOrLessChB.Checked = true;
            this.moreOrLessChB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.moreOrLessChB.Location = new System.Drawing.Point(15, 102);
            this.moreOrLessChB.Name = "moreOrLessChB";
            this.moreOrLessChB.Size = new System.Drawing.Size(144, 17);
            this.moreOrLessChB.TabIndex = 4;
            this.moreOrLessChB.Text = "Увеличить/Уменьшить";
            this.moreOrLessChB.UseVisualStyleBackColor = true;
            this.moreOrLessChB.CheckedChanged += new System.EventHandler(this.moreOrLessChB_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 130);
            this.Controls.Add(this.moreOrLessChB);
            this.Controls.Add(this.digitsGB);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.moreOrLessBt);
            this.Controls.Add(this.GenerateBT);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeWorkForms_2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.digitsGB.ResumeLayout(false);
            this.digitsGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateBT;
        private System.Windows.Forms.Button moreOrLessBt;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.GroupBox digitsGB;
        private System.Windows.Forms.RadioButton thousandsRB;
        private System.Windows.Forms.RadioButton hundredsRB;
        private System.Windows.Forms.RadioButton tensRB;
        private System.Windows.Forms.RadioButton unitsRB;
        private System.Windows.Forms.CheckBox moreOrLessChB;
    }
}

