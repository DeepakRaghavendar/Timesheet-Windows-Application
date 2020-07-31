namespace TimeSheet_Application
{
    partial class TimeSheetForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.newButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.timesheetGridView = new System.Windows.Forms.DataGridView();
            this.StateofTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleofTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfTask = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DurationofTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HourlyRateofTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Action_1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.timesheetGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(609, 172);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 37);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.new_Button_Clicked);
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(811, 172);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(105, 37);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // timesheetGridView
            // 
            this.timesheetGridView.AllowUserToAddRows = false;
            this.timesheetGridView.AllowUserToOrderColumns = true;
            this.timesheetGridView.AllowUserToResizeRows = false;
            this.timesheetGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timesheetGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timesheetGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StateofTask,
            this.TitleofTask,
            this.TypeOfTask,
            this.DurationofTask,
            this.HourlyRateofTask,
            this.Total,
            this.Action,
            this.Action_1});
            this.timesheetGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.timesheetGridView.Location = new System.Drawing.Point(52, 246);
            this.timesheetGridView.MultiSelect = false;
            this.timesheetGridView.Name = "timesheetGridView";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.timesheetGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.timesheetGridView.RowHeadersWidth = 62;
            this.timesheetGridView.RowTemplate.Height = 28;
            this.timesheetGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.timesheetGridView.Size = new System.Drawing.Size(1819, 520);
            this.timesheetGridView.TabIndex = 3;
            this.timesheetGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.timesheetGridView_CellContentClick_1);
            // 
            // StateofTask
            // 
            this.StateofTask.HeaderText = "State";
            this.StateofTask.MinimumWidth = 8;
            this.StateofTask.Name = "StateofTask";
            this.StateofTask.ReadOnly = true;
            this.StateofTask.Width = 150;
            // 
            // TitleofTask
            // 
            this.TitleofTask.HeaderText = "Title";
            this.TitleofTask.MinimumWidth = 8;
            this.TitleofTask.Name = "TitleofTask";
            this.TitleofTask.Width = 150;
            // 
            // TypeOfTask
            // 
            this.TypeOfTask.HeaderText = "Type";
            this.TypeOfTask.Items.AddRange(new object[] {
            "Telephone Call",
            "Research",
            "Draft Documentation"});
            this.TypeOfTask.MinimumWidth = 8;
            this.TypeOfTask.Name = "TypeOfTask";
            this.TypeOfTask.Width = 150;
            // 
            // DurationofTask
            // 
            this.DurationofTask.HeaderText = "Duration";
            this.DurationofTask.MinimumWidth = 8;
            this.DurationofTask.Name = "DurationofTask";
            this.DurationofTask.Width = 150;
            // 
            // HourlyRateofTask
            // 
            this.HourlyRateofTask.HeaderText = "Hourly Rate ($)";
            this.HourlyRateofTask.MinimumWidth = 8;
            this.HourlyRateofTask.Name = "HourlyRateofTask";
            this.HourlyRateofTask.Width = 150;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total ($)";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 150;
            // 
            // Action
            // 
            this.Action.HeaderText = "Edit Action";
            this.Action.MinimumWidth = 8;
            this.Action.Name = "Action";
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action.Width = 150;
            // 
            // Action_1
            // 
            this.Action_1.HeaderText = "Delete Action";
            this.Action_1.MinimumWidth = 8;
            this.Action_1.Name = "Action_1";
            this.Action_1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action_1.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(598, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Timesheet Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1039, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Default Hourly Rate";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1263, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "$250.50";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TimeSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 693);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timesheetGridView);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.newButton);
            this.Name = "TimeSheetForm";
            this.Text = "Timesheet Windows Application";
            this.Load += new System.EventHandler(this.Timesheet_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timesheetGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DataGridView timesheetGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateofTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleofTask;
        private System.Windows.Forms.DataGridViewComboBoxColumn TypeOfTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationofTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn HourlyRateofTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewLinkColumn Action;
        private System.Windows.Forms.DataGridViewLinkColumn Action_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

