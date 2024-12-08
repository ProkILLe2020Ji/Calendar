
namespace Calendr
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
            this.Next = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lbdate = new System.Windows.Forms.Label();
            this.addEvent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.Next.Location = new System.Drawing.Point(669, 788);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(95, 45);
            this.Next.TabIndex = 1;
            this.Next.Text = "Вперед";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Previous
            // 
            this.Previous.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.Previous.Location = new System.Drawing.Point(578, 788);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(85, 45);
            this.Previous.TabIndex = 2;
            this.Previous.Text = "Назад";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Понедельник";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(200, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вторник";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(385, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Среда";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(570, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Четверг";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(755, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Пятница";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(940, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Суббота";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(1125, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 26);
            this.label7.TabIndex = 9;
            this.label7.Text = "Воскресенье";
            // 
            // daycontainer
            // 
            this.daycontainer.Location = new System.Drawing.Point(17, 135);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(1296, 647);
            this.daycontainer.TabIndex = 0;
            // 
            // lbdate
            // 
            this.lbdate.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F);
            this.lbdate.ForeColor = System.Drawing.Color.Black;
            this.lbdate.Location = new System.Drawing.Point(428, 26);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(459, 40);
            this.lbdate.TabIndex = 10;
            this.lbdate.Text = "Month YEAR";
            this.lbdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addEvent
            // 
            this.addEvent.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.addEvent.Location = new System.Drawing.Point(20, 788);
            this.addEvent.Name = "addEvent";
            this.addEvent.Size = new System.Drawing.Size(208, 45);
            this.addEvent.TabIndex = 11;
            this.addEvent.Text = "Добавить событие";
            this.addEvent.UseVisualStyleBackColor = true;
            this.addEvent.Click += new System.EventHandler(this.AddEvent_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(1228, 788);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 845);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addEvent);
            this.Controls.Add(this.lbdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.daycontainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.Button addEvent;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.FlowLayoutPanel daycontainer;
    }
}

