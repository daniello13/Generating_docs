namespace GeneratorDocs
{
    partial class MainWin
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Create = new System.Windows.Forms.Button();
            this.Russian = new System.Windows.Forms.GroupBox();
            this.English = new System.Windows.Forms.GroupBox();
            this.UFamily = new System.Windows.Forms.TextBox();
            this.UNameOtc = new System.Windows.Forms.TextBox();
            this.UCollege = new System.Windows.Forms.TextBox();
            this.USpecialnost = new System.Windows.Forms.TextBox();
            this.USpezializaz = new System.Windows.Forms.TextBox();
            this.ULearnPrg = new System.Windows.Forms.TextBox();
            this.UProfQual = new System.Windows.Forms.TextBox();
            this.ProfQual = new System.Windows.Forms.TextBox();
            this.LearnPrg = new System.Windows.Forms.TextBox();
            this.Spezializaz = new System.Windows.Forms.TextBox();
            this.Specialnost = new System.Windows.Forms.TextBox();
            this.College = new System.Windows.Forms.TextBox();
            this.NameOtc = new System.Windows.Forms.TextBox();
            this.Family = new System.Windows.Forms.TextBox();
            this.saver = new System.Windows.Forms.SaveFileDialog();
            this.Russian.SuspendLayout();
            this.English.SuspendLayout();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(369, 297);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 0;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.button1_Click);
            // 
            // Russian
            // 
            this.Russian.Controls.Add(this.UProfQual);
            this.Russian.Controls.Add(this.ULearnPrg);
            this.Russian.Controls.Add(this.USpezializaz);
            this.Russian.Controls.Add(this.USpecialnost);
            this.Russian.Controls.Add(this.UCollege);
            this.Russian.Controls.Add(this.UNameOtc);
            this.Russian.Controls.Add(this.UFamily);
            this.Russian.Location = new System.Drawing.Point(12, 12);
            this.Russian.Name = "Russian";
            this.Russian.Size = new System.Drawing.Size(220, 214);
            this.Russian.TabIndex = 1;
            this.Russian.TabStop = false;
            this.Russian.Text = "Ukrainian";
            // 
            // English
            // 
            this.English.Controls.Add(this.ProfQual);
            this.English.Controls.Add(this.LearnPrg);
            this.English.Controls.Add(this.Spezializaz);
            this.English.Controls.Add(this.Specialnost);
            this.English.Controls.Add(this.College);
            this.English.Controls.Add(this.NameOtc);
            this.English.Controls.Add(this.Family);
            this.English.Location = new System.Drawing.Point(252, 12);
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(263, 213);
            this.English.TabIndex = 2;
            this.English.TabStop = false;
            this.English.Text = "English";
            // 
            // UFamily
            // 
            this.UFamily.Location = new System.Drawing.Point(7, 20);
            this.UFamily.Name = "UFamily";
            this.UFamily.Size = new System.Drawing.Size(134, 20);
            this.UFamily.TabIndex = 0;
            this.UFamily.Text = "Фамилия";
            // 
            // UNameOtc
            // 
            this.UNameOtc.Location = new System.Drawing.Point(7, 47);
            this.UNameOtc.Name = "UNameOtc";
            this.UNameOtc.Size = new System.Drawing.Size(134, 20);
            this.UNameOtc.TabIndex = 1;
            this.UNameOtc.Text = "Имя и отчество";
            // 
            // UCollege
            // 
            this.UCollege.Location = new System.Drawing.Point(7, 74);
            this.UCollege.Name = "UCollege";
            this.UCollege.Size = new System.Drawing.Size(134, 20);
            this.UCollege.TabIndex = 2;
            this.UCollege.Text = "Учебное заведение";
            // 
            // USpecialnost
            // 
            this.USpecialnost.Location = new System.Drawing.Point(7, 101);
            this.USpecialnost.Name = "USpecialnost";
            this.USpecialnost.Size = new System.Drawing.Size(134, 20);
            this.USpecialnost.TabIndex = 3;
            this.USpecialnost.Text = "Специальность";
            // 
            // USpezializaz
            // 
            this.USpezializaz.Location = new System.Drawing.Point(7, 128);
            this.USpezializaz.Name = "USpezializaz";
            this.USpezializaz.Size = new System.Drawing.Size(134, 20);
            this.USpezializaz.TabIndex = 4;
            this.USpezializaz.Text = "Специализация";
            // 
            // ULearnPrg
            // 
            this.ULearnPrg.Location = new System.Drawing.Point(7, 155);
            this.ULearnPrg.Name = "ULearnPrg";
            this.ULearnPrg.Size = new System.Drawing.Size(134, 20);
            this.ULearnPrg.TabIndex = 5;
            this.ULearnPrg.Text = "Учебная программа";
            // 
            // UProfQual
            // 
            this.UProfQual.Location = new System.Drawing.Point(7, 182);
            this.UProfQual.Name = "UProfQual";
            this.UProfQual.Size = new System.Drawing.Size(134, 20);
            this.UProfQual.TabIndex = 6;
            this.UProfQual.Text = "Квалификация";
            // 
            // ProfQual
            // 
            this.ProfQual.Location = new System.Drawing.Point(6, 182);
            this.ProfQual.Name = "ProfQual";
            this.ProfQual.Size = new System.Drawing.Size(134, 20);
            this.ProfQual.TabIndex = 13;
            this.ProfQual.Text = "Qualification";
            // 
            // LearnPrg
            // 
            this.LearnPrg.Location = new System.Drawing.Point(6, 155);
            this.LearnPrg.Name = "LearnPrg";
            this.LearnPrg.Size = new System.Drawing.Size(134, 20);
            this.LearnPrg.TabIndex = 12;
            this.LearnPrg.Text = "Education programm";
            // 
            // Spezializaz
            // 
            this.Spezializaz.Location = new System.Drawing.Point(6, 128);
            this.Spezializaz.Name = "Spezializaz";
            this.Spezializaz.Size = new System.Drawing.Size(134, 20);
            this.Spezializaz.TabIndex = 11;
            this.Spezializaz.Text = "Study Programm";
            // 
            // Specialnost
            // 
            this.Specialnost.Location = new System.Drawing.Point(6, 101);
            this.Specialnost.Name = "Specialnost";
            this.Specialnost.Size = new System.Drawing.Size(134, 20);
            this.Specialnost.TabIndex = 10;
            this.Specialnost.Text = "Subject Area";
            // 
            // College
            // 
            this.College.Location = new System.Drawing.Point(6, 74);
            this.College.Name = "College";
            this.College.Size = new System.Drawing.Size(134, 20);
            this.College.TabIndex = 9;
            this.College.Text = "Institutions Name";
            // 
            // NameOtc
            // 
            this.NameOtc.Location = new System.Drawing.Point(6, 48);
            this.NameOtc.Name = "NameOtc";
            this.NameOtc.Size = new System.Drawing.Size(134, 20);
            this.NameOtc.TabIndex = 8;
            this.NameOtc.Text = "First Name";
            // 
            // Family
            // 
            this.Family.Location = new System.Drawing.Point(6, 20);
            this.Family.Name = "Family";
            this.Family.Size = new System.Drawing.Size(134, 20);
            this.Family.TabIndex = 7;
            this.Family.Text = "Last Name";
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 332);
            this.Controls.Add(this.English);
            this.Controls.Add(this.Russian);
            this.Controls.Add(this.Create);
            this.Name = "MainWin";
            this.Text = "GeneratorDocs";
            this.Russian.ResumeLayout(false);
            this.Russian.PerformLayout();
            this.English.ResumeLayout(false);
            this.English.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.GroupBox Russian;
        private System.Windows.Forms.TextBox UNameOtc;
        private System.Windows.Forms.TextBox UFamily;
        private System.Windows.Forms.GroupBox English;
        private System.Windows.Forms.TextBox USpezializaz;
        private System.Windows.Forms.TextBox USpecialnost;
        private System.Windows.Forms.TextBox UCollege;
        private System.Windows.Forms.TextBox UProfQual;
        private System.Windows.Forms.TextBox ULearnPrg;
        private System.Windows.Forms.TextBox ProfQual;
        private System.Windows.Forms.TextBox LearnPrg;
        private System.Windows.Forms.TextBox Spezializaz;
        private System.Windows.Forms.TextBox Specialnost;
        private System.Windows.Forms.TextBox College;
        private System.Windows.Forms.TextBox NameOtc;
        private System.Windows.Forms.TextBox Family;
        private System.Windows.Forms.SaveFileDialog saver;
    }
}

