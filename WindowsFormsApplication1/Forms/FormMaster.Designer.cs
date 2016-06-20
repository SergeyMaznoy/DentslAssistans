namespace WindowsFormsApplication1
{
    partial class FormMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaster));
            this.butMat = new System.Windows.Forms.Button();
            this.butDoc = new System.Windows.Forms.Button();
            this.butPatients = new System.Windows.Forms.Button();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // butMat
            // 
            this.butMat.Location = new System.Drawing.Point(12, 35);
            this.butMat.Name = "butMat";
            this.butMat.Size = new System.Drawing.Size(75, 23);
            this.butMat.TabIndex = 2;
            this.butMat.Text = "Матеріали";
            this.butMat.UseVisualStyleBackColor = true;
            this.butMat.Click += new System.EventHandler(this.ButMatClick);
            // 
            // butDoc
            // 
            this.butDoc.Location = new System.Drawing.Point(155, 35);
            this.butDoc.Name = "butDoc";
            this.butDoc.Size = new System.Drawing.Size(75, 23);
            this.butDoc.TabIndex = 3;
            this.butDoc.Text = "Врачи";
            this.butDoc.UseVisualStyleBackColor = true;
            // 
            // butPatients
            // 
            this.butPatients.Location = new System.Drawing.Point(296, 35);
            this.butPatients.Name = "butPatients";
            this.butPatients.Size = new System.Drawing.Size(75, 23);
            this.butPatients.TabIndex = 4;
            this.butPatients.Text = "Пациеты";
            this.butPatients.UseVisualStyleBackColor = true;
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(128, 116);
            this.Calendar.Name = "Calendar";
            this.Calendar.ShowToday = false;
            this.Calendar.TabIndex = 8;
            this.Calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendarDateSelected);
            // 
            // FormMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 388);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.butPatients);
            this.Controls.Add(this.butDoc);
            this.Controls.Add(this.butMat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMaster";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "DentAss";
            this.Load += new System.EventHandler(this.FormMasterLoad);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butPatients;
        private System.Windows.Forms.Button butDoc;
        private System.Windows.Forms.Button butMat;
        private System.Windows.Forms.MonthCalendar Calendar;
    }
}

