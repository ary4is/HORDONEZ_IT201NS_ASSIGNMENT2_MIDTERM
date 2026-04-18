namespace HORDONEZ_IT201NS_ASSIGNMENT2_MIDTERM
{
    partial class DailyPlannerForm
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
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.grpTasks = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTask = new System.Windows.Forms.Label();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.lblPrio = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstHighPrio = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cboPrio = new System.Windows.Forms.ComboBox();
            this.lstMedPrio = new System.Windows.Forms.ListBox();
            this.lstLowPrio = new System.Windows.Forms.ListBox();
            this.grpAdd.SuspendLayout();
            this.grpTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.cboPrio);
            this.grpAdd.Controls.Add(this.btnClear);
            this.grpAdd.Controls.Add(this.btnAdd);
            this.grpAdd.Controls.Add(this.txtTask);
            this.grpAdd.Controls.Add(this.lblPrio);
            this.grpAdd.Controls.Add(this.lblTask);
            this.grpAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdd.Location = new System.Drawing.Point(12, 70);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(270, 180);
            this.grpAdd.TabIndex = 0;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Add Task";
            // 
            // grpTasks
            // 
            this.grpTasks.BackColor = System.Drawing.SystemColors.Control;
            this.grpTasks.Controls.Add(this.lstLowPrio);
            this.grpTasks.Controls.Add(this.lstMedPrio);
            this.grpTasks.Controls.Add(this.btnRemove);
            this.grpTasks.Controls.Add(this.lstHighPrio);
            this.grpTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTasks.Location = new System.Drawing.Point(288, 70);
            this.grpTasks.Name = "grpTasks";
            this.grpTasks.Size = new System.Drawing.Size(760, 345);
            this.grpTasks.TabIndex = 1;
            this.grpTasks.TabStop = false;
            this.grpTasks.Text = "Tasks";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(340, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(372, 43);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "DAILY PLANNER";
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask.Location = new System.Drawing.Point(14, 29);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(81, 16);
            this.lblTask.TabIndex = 3;
            this.lblTask.Text = "Task Name:";
            // 
            // txtTask
            // 
            this.txtTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTask.Location = new System.Drawing.Point(101, 23);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(150, 22);
            this.txtTask.TabIndex = 4;
            // 
            // lblPrio
            // 
            this.lblPrio.AutoSize = true;
            this.lblPrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrio.Location = new System.Drawing.Point(14, 59);
            this.lblPrio.Name = "lblPrio";
            this.lblPrio.Size = new System.Drawing.Size(51, 16);
            this.lblPrio.TabIndex = 5;
            this.lblPrio.Text = "Priority:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(60, 94);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Task";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(60, 130);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 30);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstHighPrio
            // 
            this.lstHighPrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHighPrio.FormattingEnabled = true;
            this.lstHighPrio.ItemHeight = 16;
            this.lstHighPrio.Location = new System.Drawing.Point(15, 26);
            this.lstHighPrio.Name = "lstHighPrio";
            this.lstHighPrio.Size = new System.Drawing.Size(240, 260);
            this.lstHighPrio.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Plum;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(335, 300);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(95, 30);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cboPrio
            // 
            this.cboPrio.FormattingEnabled = true;
            this.cboPrio.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.cboPrio.Location = new System.Drawing.Point(101, 51);
            this.cboPrio.Name = "cboPrio";
            this.cboPrio.Size = new System.Drawing.Size(150, 24);
            this.cboPrio.TabIndex = 6;
            // 
            // lstMedPrio
            // 
            this.lstMedPrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMedPrio.FormattingEnabled = true;
            this.lstMedPrio.ItemHeight = 16;
            this.lstMedPrio.Location = new System.Drawing.Point(261, 26);
            this.lstMedPrio.Name = "lstMedPrio";
            this.lstMedPrio.Size = new System.Drawing.Size(240, 260);
            this.lstMedPrio.TabIndex = 9;
            // 
            // lstLowPrio
            // 
            this.lstLowPrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLowPrio.FormattingEnabled = true;
            this.lstLowPrio.ItemHeight = 16;
            this.lstLowPrio.Location = new System.Drawing.Point(507, 26);
            this.lstLowPrio.Name = "lstLowPrio";
            this.lstLowPrio.Size = new System.Drawing.Size(240, 260);
            this.lstLowPrio.TabIndex = 10;
            // 
            // DailyPlannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpTasks);
            this.Controls.Add(this.grpAdd);
            this.Name = "DailyPlannerForm";
            this.Text = "DailyPlannerForm";
            this.Load += new System.EventHandler(this.DailyPlannerForm_Load);
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.grpTasks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Label lblPrio;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.GroupBox grpTasks;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstHighPrio;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cboPrio;
        private System.Windows.Forms.ListBox lstLowPrio;
        private System.Windows.Forms.ListBox lstMedPrio;
    }
}