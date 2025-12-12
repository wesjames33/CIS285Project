using CIS285Project.Models;
using CIS285Project.Services;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CIS285Project
{
    public partial class MainForm : Form
    {
        private GradeBook _gradeBook = new GradeBook();
        private BindingList<StudentRecord> _bindingList;
        private FileStorageService _fileStorage = new FileStorageService();
        private int _editingIndex = -1;

        private Color buttonNormalColor = Color.FromArgb(0xBF, 0xA7, 0xE2);
        private Color buttonHoverColor = Color.FromArgb(0xD4, 0xC7, 0xEE);

        public MainForm()
        {
            InitializeComponent();
            InitializeDataBinding();
            StyleButtons();
            LoadSampleStudents();
            UpdateSummary();
        }

        private void InitializeDataBinding()
        {
            _bindingList = new BindingList<StudentRecord>(_gradeBook.Students);
            dgvStudents.AutoGenerateColumns = false;
            dgvStudents.DataSource = _bindingList;
        }

        private void StyleButtons()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button btn)
                {
                    btn.BackColor = buttonNormalColor;
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                }
            }
        }

        // Hover effect for all buttons
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = buttonHoverColor;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = buttonNormalColor;
        }

        // Live validation for grade textboxes
        private void GradeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox tb)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.BackColor = Color.White;
                    return;
                }

                if (double.TryParse(tb.Text, out double value) && value >= 0 && value <= 100)
                    tb.BackColor = Color.White;
                else
                    tb.BackColor = Color.MistyRose;
            }
        }

        // ----------------------------
        // LOAD 15 SAMPLE STUDENTS (8 GRADES)
        // ----------------------------
        private void LoadSampleStudents()
        {
            _gradeBook.Students.Clear();

            _gradeBook.AddStudent(new StudentRecord
            {
                Name = "Jake Arrieta",
                Grade1 = 85,
                Grade2 = 92,
                Grade3 = 88,
                Grade4 = 91,
                Grade5 = 89,
                Grade6 = 94,
                Grade7 = 90,
                Grade8 = 93
            });

            _gradeBook.AddStudent(new StudentRecord
            {
                Name = "Anthony Rizzo",
                Grade1 = 78,
                Grade2 = 82,
                Grade3 = 80,
                Grade4 = 75,
                Grade5 = 79,
                Grade6 = 81,
                Grade7 = 77,
                Grade8 = 83
            });

            _gradeBook.AddStudent(new StudentRecord
            {
                Name = "Troy Polamalu",
                Grade1 = 94,
                Grade2 = 90,
                Grade3 = 96,
                Grade4 = 98,
                Grade5 = 99,
                Grade6 = 97,
                Grade7 = 95,
                Grade8 = 99
            });

            _gradeBook.AddStudent(new StudentRecord
            {
                Name = "Hines Ward",
                Grade1 = 67,
                Grade2 = 72,
                Grade3 = 70,
                Grade4 = 49,
                Grade5 = 71,
                Grade6 = 68,
                Grade7 = 73,
                Grade8 = 70
            });

            _gradeBook.AddStudent(new StudentRecord
            {
                Name = "Tracy Cortez",
                Grade1 = 58,
                Grade2 = 84,
                Grade3 = 87,
                Grade4 = 60,
                Grade5 = 86,
                Grade6 = 69,
                Grade7 = 75,
                Grade8 = 82
            });

            _gradeBook.AddStudent(new StudentRecord
            {
                Name = "Charles Oliveira",
                Grade1 = 99,
                Grade2 = 60,
                Grade3 = 88,
                Grade4 = 93,
                Grade5 = 59,
                Grade6 = 91,
                Grade7 = 85,
                Grade8 = 90
            });

            _gradeBook.AddStudent(new StudentRecord
            {
                Name = "Julio Jones",
                Grade1 = 99,
                Grade2 = 95,
                Grade3 = 100,
                Grade4 = 98,
                Grade5 = 97,
                Grade6 = 99,
                Grade7 = 96,
                Grade8 = 100
            });

            _gradeBook.AddStudent(new StudentRecord
            {
                Name = "Drake Maye",
                Grade1 = 73,
                Grade2 = 79,
                Grade3 = 77,
                Grade4 = 82,
                Grade5 = 80,
                Grade6 = 76,
                Grade7 = 81,
                Grade8 = 78
            });

            _gradeBook.AddStudent(new StudentRecord
            {
                Name = "T.J. Watt",
                Grade1 = 82,
                Grade2 = 85,
                Grade3 = 90,
                Grade4 = 87,
                Grade5 = 88,
                Grade6 = 91,
                Grade7 = 89,
                Grade8 = 92
            });

            _gradeBook.AddStudent(new StudentRecord
            {
                Name = "Sean O'Malley",
                Grade1 = 91,
                Grade2 = 89,
                Grade3 = 93,
                Grade4 = 90,
                Grade5 = 92,
                Grade6 = 94,
                Grade7 = 95,
                Grade8 = 96
            });

            _gradeBook.AddStudent(new StudentRecord
            {
                Name = "Liv Morgan",
                Grade1 = 76,
                Grade2 = 81,
                Grade3 = 79,
                Grade4 = 83,
                Grade5 = 80,
                Grade6 = 78,
                Grade7 = 82,
                Grade8 = 79
            });

            _gradeBook.AddStudent(new StudentRecord
            {
                Name = "Dave Bautista",
                Grade1 = 65,
                Grade2 = 70,
                Grade3 = 68,
                Grade4 = 62,
                Grade5 = 69,
                Grade6 = 71,
                Grade7 = 74,
                Grade8 = 73
            });

            _gradeBook.AddStudent(new StudentRecord
            {
                Name = "Lonzo Ball",
                Grade1 = 92,
                Grade2 = 94,
                Grade3 = 90,
                Grade4 = 93,
                Grade5 = 95,
                Grade6 = 91,
                Grade7 = 96,
                Grade8 = 94
            });

            _gradeBook.AddStudent(new StudentRecord
            {
                Name = "Emmanuel Mudiay",
                Grade1 = 81,
                Grade2 = 79,
                Grade3 = 85,
                Grade4 = 83,
                Grade5 = 82,
                Grade6 = 84,
                Grade7 = 80,
                Grade8 = 86
            });

            _gradeBook.AddStudent(new StudentRecord
            {
                Name = "Minkah Fitzpatrick",
                Grade1 = 89,
                Grade2 = 91,
                Grade3 = 92,
                Grade4 = 90,
                Grade5 = 93,
                Grade6 = 94,
                Grade7 = 95,
                Grade8 = 92
            });
            _gradeBook.AddStudent(new StudentRecord
            {

            Name = "Fernando Tatis Jr.",
                Grade1 = 100,
                Grade2 = 92,
                Grade3 = 67,
                Grade4 = 89,
                Grade5 = 91,
                Grade6 = 95,
                Grade7 = 75,
                Grade8 = 80,

            });
            _gradeBook.AddStudent(new StudentRecord
            {

                Name = "Pete Crow-Armstrong",
                Grade1 = 82,
                Grade2 = 50,
                Grade3 = 78,
                Grade4 = 59,
                Grade5 = 91,
                Grade6 = 95,
                Grade7 = 55,
                Grade8 = 80,

            });
            _gradeBook.AddStudent(new StudentRecord
            {

                Name = "Cam Skattebo",
                Grade1 = 22,
                Grade2 = 39,
                Grade3 = 95,
                Grade4 = 19,
                Grade5 = 41,
                Grade6 = 65,
                Grade7 = 79,
                Grade8 = 53,

            });

            _gradeBook.AddStudent(new StudentRecord
            {

                Name = "Ashton Jeanty",
                Grade1 = 97,
                Grade2 = 89,
                Grade3 = 88,
                Grade4 = 92,
                Grade5 = 71,
                Grade6 = 81,
                Grade7 = 87,
                Grade8 = 100,

            });

            _bindingList = new BindingList<StudentRecord>(_gradeBook.Students);
            dgvStudents.DataSource = _bindingList;

            lblStatus.Text = "Loaded 19 active students.";
        }

        // ----------------------------
        // SUMMARY UPDATE
        // ----------------------------
        private void UpdateSummary()
        {
            int count = _gradeBook.Students.Count;
            lblTotalStudents.Text = $"Total Students: {count}";
            lblSummaryClassAvg.Text = $"Class Avg: {_gradeBook.CalculateClassAverage():F2}";

            if (count > 0)
            {
                lblHighestAvg.Text = $"Highest Avg: {_gradeBook.Students.Max(s => s.Average):F2}";
                lblLowestAvg.Text = $"Lowest Avg: {_gradeBook.Students.Min(s => s.Average):F2}";
                lblPassingCount.Text = $"Passing (>=70): {_gradeBook.Students.Count(s => s.Average >= 70)}";
            }
            else
            {
                lblHighestAvg.Text = "Highest Avg: N/A";
                lblLowestAvg.Text = "Lowest Avg: N/A";
                lblPassingCount.Text = "Passing: 0";
            }
        }

        // ----------------------------
        // BUTTON CLICK EVENTS
        // ----------------------------

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearInputs();
            _editingIndex = -1;
            lblStatus.Text = "Adding new student...";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show("Select a student to edit.");
                return;
            }

            _editingIndex = dgvStudents.CurrentRow.Index;
            var s = _gradeBook.Students[_editingIndex];

            txtName.Text = s.Name;
            txtGrade1.Text = s.Grade1?.ToString();
            txtGrade2.Text = s.Grade2?.ToString();
            txtGrade3.Text = s.Grade3?.ToString();
            txtGrade4.Text = s.Grade4?.ToString();
            txtGrade5.Text = s.Grade5?.ToString();
            txtGrade6.Text = s.Grade6?.ToString();
            txtGrade7.Text = s.Grade7?.ToString();
            txtGrade8.Text = s.Grade8?.ToString();
            txtNotes.Text = s.Notes;

            lblStatus.Text = "Editing student...";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show("Select a student.");
                return;
            }

            int index = dgvStudents.CurrentRow.Index;

            if (MessageBox.Show("Delete this student?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _gradeBook.RemoveStudent(index);
                _bindingList.ResetBindings();
                UpdateSummary();
                lblStatus.Text = "Student deleted.";
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (!TryCreateStudent(out StudentRecord student))
                return;

            if (_editingIndex == -1)
            {
                _gradeBook.AddStudent(student);
                lblStatus.Text = "Student added.";
            }
            else
            {
                _gradeBook.UpdateStudent(_editingIndex, student);
                lblStatus.Text = "Student updated.";
            }

            _bindingList = new BindingList<StudentRecord>(_gradeBook.Students);
            dgvStudents.DataSource = _bindingList;

            ClearInputs();
            _editingIndex = -1;
            UpdateSummary();
        }

        private bool TryCreateStudent(out StudentRecord s)
        {
            s = null;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name required.");
                return false;
            }

            if (!ParseGrade(txtGrade1.Text, out double? g1) ||
                !ParseGrade(txtGrade2.Text, out double? g2) ||
                !ParseGrade(txtGrade3.Text, out double? g3) ||
                !ParseGrade(txtGrade4.Text, out double? g4) ||
                !ParseGrade(txtGrade5.Text, out double? g5) ||
                !ParseGrade(txtGrade6.Text, out double? g6) ||
                !ParseGrade(txtGrade7.Text, out double? g7) ||
                !ParseGrade(txtGrade8.Text, out double? g8))
            {
                MessageBox.Show("Grades must be numbers 0–100.");
                return false;
            }

            s = new StudentRecord
            {
                Name = txtName.Text.Trim(),
                Grade1 = g1,
                Grade2 = g2,
                Grade3 = g3,
                Grade4 = g4,
                Grade5 = g5,
                Grade6 = g6,
                Grade7 = g7,
                Grade8 = g8,
                Notes = txtNotes.Text
            };

            return true;
        }

        private bool ParseGrade(string text, out double? grade)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                grade = null;
                return true;
            }

            if (double.TryParse(text, out double g) && g >= 0 && g <= 100)
            {
                grade = g;
                return true;
            }

            grade = null;
            return false;
        }

        private void ClearInputs()
        {
            txtName.Clear();
            txtGrade1.Clear();
            txtGrade2.Clear();
            txtGrade3.Clear();
            txtGrade4.Clear();
            txtGrade5.Clear();
            txtGrade6.Clear();
            txtGrade7.Clear();
            txtGrade8.Clear();
            txtNotes.Clear();

            txtGrade1.BackColor = Color.White;
            txtGrade2.BackColor = Color.White;
            txtGrade3.BackColor = Color.White;
            txtGrade4.BackColor = Color.White;
            txtGrade5.BackColor = Color.White;
            txtGrade6.BackColor = Color.White;
            txtGrade7.BackColor = Color.White;
            txtGrade8.BackColor = Color.White;
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            lblClassAverage.Text = _gradeBook.CalculateClassAverage().ToString("F2");
            lblStatus.Text = "Class average updated.";
            UpdateSummary();
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "XML Files|*.xml";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _fileStorage.Save(dialog.FileName, _gradeBook.Students);
                lblStatus.Text = "File saved.";
            }
        }

        private void btnSaveNotes_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show("Select a student first.");
                return;
            }

            int index = dgvStudents.CurrentRow.Index;
            _gradeBook.Students[index].Notes = txtNotes.Text;

            lblStatus.Text = "Notes saved.";
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "XML Files|*.xml";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var list = _fileStorage.Load(dialog.FileName);

                _gradeBook.Students.Clear();
                _gradeBook.Students.AddRange(list);

                _bindingList = new BindingList<StudentRecord>(_gradeBook.Students);
                dgvStudents.DataSource = _bindingList;

                UpdateSummary();
                lblStatus.Text = "File loaded.";
            }
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null) return;

            int index = dgvStudents.CurrentRow.Index;
            if (index < 0 || index >= _gradeBook.Students.Count) return;

            txtNotes.Text = _gradeBook.Students[index].Notes;
        }
    }
}
