namespace HORDONEZ_IT201NS_ASSIGNMENT2_MIDTERM
{
    partial class HabitTrackerForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpHabits = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.lstHabits = new System.Windows.Forms.ListBox();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtHabitTitle = new System.Windows.Forms.TextBox();
            this.lblHabitTitle = new System.Windows.Forms.Label();
            this.grpHabits.SuspendLayout();
            this.grpAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(135, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(377, 43);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "HABIT TRACKER";
            // 
            // grpHabits
            // 
            this.grpHabits.Controls.Add(this.btnRemove);
            this.grpHabits.Controls.Add(this.btnDone);
            this.grpHabits.Controls.Add(this.lstHabits);
            this.grpHabits.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpHabits.Location = new System.Drawing.Point(313, 70);
            this.grpHabits.Name = "grpHabits";
            this.grpHabits.Size = new System.Drawing.Size(320, 345);
            this.grpHabits.TabIndex = 4;
            this.grpHabits.TabStop = false;
            this.grpHabits.Text = "Habits";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Plum;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(180, 300);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(95, 30);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(39, 300);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(115, 30);
            this.btnDone.TabIndex = 7;
            this.btnDone.Text = "Mark as Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lstHabits
            // 
            this.lstHabits.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHabits.FormattingEnabled = true;
            this.lstHabits.ItemHeight = 16;
            this.lstHabits.Location = new System.Drawing.Point(15, 26);
            this.lstHabits.Name = "lstHabits";
            this.lstHabits.Size = new System.Drawing.Size(290, 260);
            this.lstHabits.TabIndex = 0;
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.btnClear);
            this.grpAdd.Controls.Add(this.btnAdd);
            this.grpAdd.Controls.Add(this.txtHabitTitle);
            this.grpAdd.Controls.Add(this.lblHabitTitle);
            this.grpAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdd.Location = new System.Drawing.Point(12, 70);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(295, 145);
            this.grpAdd.TabIndex = 3;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Add Habit";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(75, 99);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 30);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(75, 61);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Habit";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtHabitTitle
            // 
            this.txtHabitTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHabitTitle.Location = new System.Drawing.Point(93, 23);
            this.txtHabitTitle.Name = "txtHabitTitle";
            this.txtHabitTitle.Size = new System.Drawing.Size(180, 22);
            this.txtHabitTitle.TabIndex = 4;
            // 
            // lblHabitTitle
            // 
            this.lblHabitTitle.AutoSize = true;
            this.lblHabitTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitTitle.Location = new System.Drawing.Point(14, 29);
            this.lblHabitTitle.Name = "lblHabitTitle";
            this.lblHabitTitle.Size = new System.Drawing.Size(71, 16);
            this.lblHabitTitle.TabIndex = 3;
            this.lblHabitTitle.Text = "Habit Title:";
            // 
            // HabitTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 438);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpHabits);
            this.Controls.Add(this.grpAdd);
            this.Name = "HabitTrackerForm";
            this.Text = "HabitTrackerForm";
            this.Load += new System.EventHandler(this.HabitTrackerForm_Load);
            this.grpHabits.ResumeLayout(false);
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpHabits;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ListBox lstHabits;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtHabitTitle;
        private System.Windows.Forms.Label lblHabitTitle;
    }
}