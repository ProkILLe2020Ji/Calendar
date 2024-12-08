
namespace Calendr
{
    partial class EventForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            this.txdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.databaseDataSet = new Calendr.DatabaseDataSet();
            this.tblcalendarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_calendarTableAdapter = new Calendr.DatabaseDataSetTableAdapters.tbl_calendarTableAdapter();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcalendarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txdate
            // 
            this.txdate.BackColor = System.Drawing.Color.White;
            this.txdate.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.txdate.Location = new System.Drawing.Point(91, 9);
            this.txdate.Margin = new System.Windows.Forms.Padding(4);
            this.txdate.Name = "txdate";
            this.txdate.ReadOnly = true;
            this.txdate.Size = new System.Drawing.Size(388, 32);
            this.txdate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дата:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "События:";
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.btnsave.Location = new System.Drawing.Point(182, 391);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(145, 41);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Закрыть";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblcalendarBindingSource
            // 
            this.tblcalendarBindingSource.DataMember = "tbl_calendar";
            this.tblcalendarBindingSource.DataSource = this.databaseDataSet;
            // 
            // tbl_calendarTableAdapter
            // 
            this.tbl_calendarTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(18, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 285);
            this.panel1.TabIndex = 5;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 458);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "События";
            this.Load += new System.EventHandler(this.EventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcalendarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsave;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource tblcalendarBindingSource;
        private DatabaseDataSetTableAdapters.tbl_calendarTableAdapter tbl_calendarTableAdapter;
        private System.Windows.Forms.FlowLayoutPanel panel1;
    }
}