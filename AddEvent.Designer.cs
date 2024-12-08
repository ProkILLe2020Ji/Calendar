
namespace Calendr
{
    partial class AddEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEvent));
            this.save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txdate = new System.Windows.Forms.TextBox();
            this.txevent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.save.Location = new System.Drawing.Point(73, 206);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(130, 40);
            this.save.TabIndex = 0;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Событие:";
            // 
            // txdate
            // 
            this.txdate.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.txdate.Location = new System.Drawing.Point(16, 45);
            this.txdate.Name = "txdate";
            this.txdate.Size = new System.Drawing.Size(266, 28);
            this.txdate.TabIndex = 3;
            // 
            // txevent
            // 
            this.txevent.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.txevent.Location = new System.Drawing.Point(16, 141);
            this.txevent.Name = "txevent";
            this.txevent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txevent.Size = new System.Drawing.Size(266, 28);
            this.txevent.TabIndex = 4;
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 277);
            this.Controls.Add(this.txevent);
            this.Controls.Add(this.txdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить событие";
            this.Load += new System.EventHandler(this.AddEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txdate;
        private System.Windows.Forms.TextBox txevent;
    }
}