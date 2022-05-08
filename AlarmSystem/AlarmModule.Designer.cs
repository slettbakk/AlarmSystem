namespace AlarmSystem
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAcknowledgeAll = new System.Windows.Forms.Button();
            this.lblRealTime = new System.Windows.Forms.Label();
            this.btnSortId = new System.Windows.Forms.Button();
            this.btnSortUnack = new System.Windows.Forms.Button();
            this.btnAckSelected = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 242);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAcknowledgeAll
            // 
            this.btnAcknowledgeAll.Location = new System.Drawing.Point(699, 302);
            this.btnAcknowledgeAll.Name = "btnAcknowledgeAll";
            this.btnAcknowledgeAll.Size = new System.Drawing.Size(133, 23);
            this.btnAcknowledgeAll.TabIndex = 4;
            this.btnAcknowledgeAll.Text = "Acknowledge All";
            this.btnAcknowledgeAll.UseVisualStyleBackColor = true;
            this.btnAcknowledgeAll.Click += new System.EventHandler(this.btnAcknowledgeAll_Click);
            // 
            // lblRealTime
            // 
            this.lblRealTime.AutoSize = true;
            this.lblRealTime.Location = new System.Drawing.Point(699, 344);
            this.lblRealTime.Name = "lblRealTime";
            this.lblRealTime.Size = new System.Drawing.Size(35, 13);
            this.lblRealTime.TabIndex = 5;
            this.lblRealTime.Text = "label1";
            // 
            // btnSortId
            // 
            this.btnSortId.Location = new System.Drawing.Point(31, 12);
            this.btnSortId.Name = "btnSortId";
            this.btnSortId.Size = new System.Drawing.Size(147, 23);
            this.btnSortId.TabIndex = 6;
            this.btnSortId.Text = "Sort By AlarmID Desc.";
            this.btnSortId.UseVisualStyleBackColor = true;
            this.btnSortId.Click += new System.EventHandler(this.btnSortId_Click);
            // 
            // btnSortUnack
            // 
            this.btnSortUnack.Location = new System.Drawing.Point(204, 12);
            this.btnSortUnack.Name = "btnSortUnack";
            this.btnSortUnack.Size = new System.Drawing.Size(147, 23);
            this.btnSortUnack.TabIndex = 7;
            this.btnSortUnack.Text = "Sort By Unacked Alarms";
            this.btnSortUnack.UseVisualStyleBackColor = true;
            this.btnSortUnack.Click += new System.EventHandler(this.btnSortUnack_Click);
            // 
            // btnAckSelected
            // 
            this.btnAckSelected.Location = new System.Drawing.Point(544, 302);
            this.btnAckSelected.Name = "btnAckSelected";
            this.btnAckSelected.Size = new System.Drawing.Size(135, 23);
            this.btnAckSelected.TabIndex = 8;
            this.btnAckSelected.Text = "Acknowledge Selected";
            this.btnAckSelected.UseVisualStyleBackColor = true;
            this.btnAckSelected.Click += new System.EventHandler(this.btnAckSelected_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 379);
            this.Controls.Add(this.btnAckSelected);
            this.Controls.Add(this.btnSortUnack);
            this.Controls.Add(this.btnSortId);
            this.Controls.Add(this.lblRealTime);
            this.Controls.Add(this.btnAcknowledgeAll);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Alarm Module";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAcknowledgeAll;
        private System.Windows.Forms.Label lblRealTime;
        private System.Windows.Forms.Button btnSortId;
        private System.Windows.Forms.Button btnSortUnack;
        private System.Windows.Forms.Button btnAckSelected;
    }
}

