namespace CIS285Project
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.dgvStudents = new System.Windows.Forms.DataGridView();

            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colG1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colG2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colG3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colG4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colG5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colG6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colG7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colG8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();

            this.lblName = new System.Windows.Forms.Label();
            this.lblClassAverageLabel = new System.Windows.Forms.Label();
            this.lblClassAverage = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();

            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGrade1 = new System.Windows.Forms.TextBox();
            this.txtGrade2 = new System.Windows.Forms.TextBox();
            this.txtGrade3 = new System.Windows.Forms.TextBox();
            this.txtGrade4 = new System.Windows.Forms.TextBox();
            this.txtGrade5 = new System.Windows.Forms.TextBox();
            this.txtGrade6 = new System.Windows.Forms.TextBox();
            this.txtGrade7 = new System.Windows.Forms.TextBox();
            this.txtGrade8 = new System.Windows.Forms.TextBox();

            this.panelSummary = new System.Windows.Forms.Panel();
            this.lblSummaryTitle = new System.Windows.Forms.Label();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.lblSummaryClassAvg = new System.Windows.Forms.Label();
            this.lblHighestAvg = new System.Windows.Forms.Label();
            this.lblLowestAvg = new System.Windows.Forms.Label();
            this.lblPassingCount = new System.Windows.Forms.Label();

            this.lblNotesTitle = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnSaveNotes = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();

            // FORM
            this.ClientSize = new System.Drawing.Size(1100, 900);
            this.BackColor = System.Drawing.Color.FromArgb(0xF7, 0xF4, 0xFB);
            this.Text = "Student Grade Book";

            // DATAGRIDVIEW
            this.dgvStudents.Location = new System.Drawing.Point(25, 25);
            this.dgvStudents.Size = new System.Drawing.Size(800, 350);
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dgvStudents.EnableHeadersVisualStyles = false;
            this.dgvStudents.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(0xBF, 0xA7, 0xE2);
            this.dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.White;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.White;

            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colName, this.colG1, this.colG2, this.colG3, this.colG4,
                this.colG5, this.colG6, this.colG7, this.colG8, this.colAvg
            });

            this.dgvStudents.SelectionChanged += new System.EventHandler(this.dgvStudents_SelectionChanged);

            // Column bindings
            this.colName.DataPropertyName = "Name";
            this.colG1.DataPropertyName = "Grade1";
            this.colG2.DataPropertyName = "Grade2";
            this.colG3.DataPropertyName = "Grade3";
            this.colG4.DataPropertyName = "Grade4";
            this.colG5.DataPropertyName = "Grade5";
            this.colG6.DataPropertyName = "Grade6";
            this.colG7.DataPropertyName = "Grade7";
            this.colG8.DataPropertyName = "Grade8";
            this.colAvg.DataPropertyName = "Average";

            // Column headers
            this.colName.HeaderText = "Student Name";
            this.colName.Width = 140;

            this.colG1.HeaderText = "Grade 1"; this.colG1.Width = 60;
            this.colG2.HeaderText = "Grade 2"; this.colG2.Width = 60;
            this.colG3.HeaderText = "Grade 3"; this.colG3.Width = 60;
            this.colG4.HeaderText = "Grade 4"; this.colG4.Width = 60;
            this.colG5.HeaderText = "Grade 5"; this.colG5.Width = 60;
            this.colG6.HeaderText = "Grade 6"; this.colG6.Width = 60;
            this.colG7.HeaderText = "Grade 7"; this.colG7.Width = 60;
            this.colG8.HeaderText = "Grade 8"; this.colG8.Width = 60;

            this.colAvg.HeaderText = "Average";
            this.colAvg.Width = 80;

            // BUTTONS
            this.btnAdd.Location = new System.Drawing.Point(850, 25);
            this.btnAdd.Size = new System.Drawing.Size(220, 40);
            this.btnAdd.Text = "Add Student";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.Button_MouseLeave);

            this.btnEdit.Location = new System.Drawing.Point(850, 75);
            this.btnEdit.Size = new System.Drawing.Size(220, 40);
            this.btnEdit.Text = "Edit Student";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnEdit.MouseLeave += new System.EventHandler(this.Button_MouseLeave);

            this.btnDelete.Location = new System.Drawing.Point(850, 125);
            this.btnDelete.Size = new System.Drawing.Size(220, 40);
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.Button_MouseLeave);

            this.btnAverage.Location = new System.Drawing.Point(850, 175);
            this.btnAverage.Size = new System.Drawing.Size(220, 40);
            this.btnAverage.Text = "Calculate Average";
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            this.btnAverage.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnAverage.MouseLeave += new System.EventHandler(this.Button_MouseLeave);

            this.btnSaveFile.Location = new System.Drawing.Point(850, 225);
            this.btnSaveFile.Size = new System.Drawing.Size(220, 40);
            this.btnSaveFile.Text = "Save to File";
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            this.btnSaveFile.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnSaveFile.MouseLeave += new System.EventHandler(this.Button_MouseLeave);

            this.btnLoadFile.Location = new System.Drawing.Point(850, 275);
            this.btnLoadFile.Size = new System.Drawing.Size(220, 40);
            this.btnLoadFile.Text = "Load from File";
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            this.btnLoadFile.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnLoadFile.MouseLeave += new System.EventHandler(this.Button_MouseLeave);

            // INPUT FIELDS
            this.lblName.Text = "Name:";
            this.lblName.Location = new System.Drawing.Point(25, 400);
            this.lblName.AutoSize = true;

            this.txtName.Location = new System.Drawing.Point(80, 398);
            this.txtName.Size = new System.Drawing.Size(300, 27);

            int gx = 400;
            int gy = 398;

            this.txtGrade1.Location = new System.Drawing.Point(gx, gy);
            this.txtGrade1.Size = new System.Drawing.Size(50, 27);
            this.txtGrade1.TextChanged += new System.EventHandler(this.GradeTextBox_TextChanged);

            this.txtGrade2.Location = new System.Drawing.Point(gx + 60, gy);
            this.txtGrade2.Size = new System.Drawing.Size(50, 27);
            this.txtGrade2.TextChanged += new System.EventHandler(this.GradeTextBox_TextChanged);

            this.txtGrade3.Location = new System.Drawing.Point(gx + 120, gy);
            this.txtGrade3.Size = new System.Drawing.Size(50, 27);
            this.txtGrade3.TextChanged += new System.EventHandler(this.GradeTextBox_TextChanged);

            this.txtGrade4.Location = new System.Drawing.Point(gx + 180, gy);
            this.txtGrade4.Size = new System.Drawing.Size(50, 27);
            this.txtGrade4.TextChanged += new System.EventHandler(this.GradeTextBox_TextChanged);

            this.txtGrade5.Location = new System.Drawing.Point(gx + 240, gy);
            this.txtGrade5.Size = new System.Drawing.Size(50, 27);
            this.txtGrade5.TextChanged += new System.EventHandler(this.GradeTextBox_TextChanged);

            this.txtGrade6.Location = new System.Drawing.Point(gx + 300, gy);
            this.txtGrade6.Size = new System.Drawing.Size(50, 27);
            this.txtGrade6.TextChanged += new System.EventHandler(this.GradeTextBox_TextChanged);

            this.txtGrade7.Location = new System.Drawing.Point(gx + 360, gy);
            this.txtGrade7.Size = new System.Drawing.Size(50, 27);
            this.txtGrade7.TextChanged += new System.EventHandler(this.GradeTextBox_TextChanged);

            this.txtGrade8.Location = new System.Drawing.Point(gx + 420, gy);
            this.txtGrade8.Size = new System.Drawing.Size(50, 27);
            this.txtGrade8.TextChanged += new System.EventHandler(this.GradeTextBox_TextChanged);

            this.btnSaveChanges.Location = new System.Drawing.Point(780, 435);
            this.btnSaveChanges.Size = new System.Drawing.Size(150, 32);
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            this.btnSaveChanges.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnSaveChanges.MouseLeave += new System.EventHandler(this.Button_MouseLeave);

            // CLASS AVERAGE + STATUS
            this.lblClassAverageLabel.Text = "Class Average:";
            this.lblClassAverageLabel.Location = new System.Drawing.Point(25, 450);
            this.lblClassAverageLabel.AutoSize = true;

            this.lblClassAverage.Text = "0.00";
            this.lblClassAverage.Location = new System.Drawing.Point(140, 450);
            this.lblClassAverage.AutoSize = true;
            this.lblClassAverage.Font =
                new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.lblStatus.Text = "Ready";
            this.lblStatus.Location = new System.Drawing.Point(25, 475);
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.MediumPurple;

            // SUMMARY PANEL
            this.panelSummary.Location = new System.Drawing.Point(25, 510);
            this.panelSummary.Size = new System.Drawing.Size(350, 200);
            this.panelSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSummary.BackColor = System.Drawing.Color.White;

            this.lblSummaryTitle.Text = "Class Summary";
            this.lblSummaryTitle.Font =
                new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTitle.Location = new System.Drawing.Point(120, 10);
            this.lblSummaryTitle.AutoSize = true;

            this.lblTotalStudents.Location = new System.Drawing.Point(10, 40);
            this.lblTotalStudents.AutoSize = true;

            this.lblSummaryClassAvg.Location = new System.Drawing.Point(10, 65);
            this.lblSummaryClassAvg.AutoSize = true;

            this.lblHighestAvg.Location = new System.Drawing.Point(10, 90);
            this.lblHighestAvg.AutoSize = true;

            this.lblLowestAvg.Location = new System.Drawing.Point(10, 115);
            this.lblLowestAvg.AutoSize = true;

            this.lblPassingCount.Location = new System.Drawing.Point(10, 140);
            this.lblPassingCount.AutoSize = true;

            this.panelSummary.Controls.Add(this.lblSummaryTitle);
            this.panelSummary.Controls.Add(this.lblTotalStudents);
            this.panelSummary.Controls.Add(this.lblSummaryClassAvg);
            this.panelSummary.Controls.Add(this.lblHighestAvg);
            this.panelSummary.Controls.Add(this.lblLowestAvg);
            this.panelSummary.Controls.Add(this.lblPassingCount);

            // NOTES PANEL
            this.lblNotesTitle.Text = "Notes for Selected Student:";
            this.lblNotesTitle.Location = new System.Drawing.Point(400, 510);
            this.lblNotesTitle.AutoSize = true;
            this.lblNotesTitle.Font =
                new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.txtNotes.Location = new System.Drawing.Point(400, 535);
            this.txtNotes.Size = new System.Drawing.Size(350, 150);
            this.txtNotes.Multiline = true;
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.BackColor = System.Drawing.Color.White;

            this.btnSaveNotes.Location = new System.Drawing.Point(400, 695);
            this.btnSaveNotes.Size = new System.Drawing.Size(350, 35);
            this.btnSaveNotes.Text = "Save Notes";
            this.btnSaveNotes.BackColor =
                System.Drawing.Color.FromArgb(0xBF, 0xA7, 0xE2);
            this.btnSaveNotes.ForeColor = System.Drawing.Color.White;
            this.btnSaveNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNotes.FlatAppearance.BorderSize = 0;
            this.btnSaveNotes.Click += new System.EventHandler(this.btnSaveNotes_Click);
            this.btnSaveNotes.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnSaveNotes.MouseLeave += new System.EventHandler(this.Button_MouseLeave);

            // ADD CONTROLS
            this.Controls.Add(this.dgvStudents);

            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnLoadFile);

            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);

            this.Controls.Add(this.txtGrade1);
            this.Controls.Add(this.txtGrade2);
            this.Controls.Add(this.txtGrade3);
            this.Controls.Add(this.txtGrade4);
            this.Controls.Add(this.txtGrade5);
            this.Controls.Add(this.txtGrade6);
            this.Controls.Add(this.txtGrade7);
            this.Controls.Add(this.txtGrade8);

            this.Controls.Add(this.btnSaveChanges);

            this.Controls.Add(this.lblClassAverageLabel);
            this.Controls.Add(this.lblClassAverage);
            this.Controls.Add(this.lblStatus);

            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.lblNotesTitle);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.btnSaveNotes);

            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colG1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colG2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colG3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colG4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colG5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colG6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colG7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colG8;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvg;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnSaveChanges;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblClassAverageLabel;
        private System.Windows.Forms.Label lblClassAverage;
        private System.Windows.Forms.Label lblStatus;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGrade1;
        private System.Windows.Forms.TextBox txtGrade2;
        private System.Windows.Forms.TextBox txtGrade3;
        private System.Windows.Forms.TextBox txtGrade4;
        private System.Windows.Forms.TextBox txtGrade5;
        private System.Windows.Forms.TextBox txtGrade6;
        private System.Windows.Forms.TextBox txtGrade7;
        private System.Windows.Forms.TextBox txtGrade8;

        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Label lblSummaryTitle;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Label lblSummaryClassAvg;
        private System.Windows.Forms.Label lblHighestAvg;
        private System.Windows.Forms.Label lblLowestAvg;
        private System.Windows.Forms.Label lblPassingCount;

        private System.Windows.Forms.Label lblNotesTitle;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnSaveNotes;
    }
}
