using OfficeOpenXml;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.ViewModels;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace WindowsFormsApp
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }

        public void btnScores_Click(object sender, EventArgs e)
        {
            ScoresService.WebServiceSoapClient s = new ScoresService.WebServiceSoapClient();
            var studentList = s.GetStudents();
            var gradesList = s.GetGrades();
            

            //list creation for display
            List<ScoreTableViewModel> vm = new List<ScoreTableViewModel>();
            foreach (var student in studentList)
            {
                
                ScoreTableViewModel stvm = new ScoreTableViewModel();
                decimal scoreSum = 0;
                int count = 0;

                foreach (var score in gradesList)
                {
                    if(student.Id == score.Student_Id)
                    {
                        scoreSum += score.Grade;
                        count += 1;
                    }
                    

                }
                
                stvm.Name = student.Name;
                stvm.AvgScore = scoreSum / count;
                //add the object to the list we need to display
                vm.Add(stvm);



            }

            dgwScores.DataSource = vm;

            Button btnExport = new Button();
            
            btnExport.Text = "Export to Excel";

            btnExport.Location = new Point(btnScores.Location.X , btnScores.Location.Y+40);
            btnExport.AutoSize = true;
            this.Controls.Add(btnExport);
            btnExport.Click += new EventHandler(btnExport_Click);

        }

        public void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter="Excel | *.xlsx"})
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ExcelPackage.LicenseContext = LicenseContext.Commercial;
                        using (var package = new ExcelPackage(sfd.FileName))
                        {
                            
                            var sheet = package.Workbook.Worksheets.Add("AvgGrades");
                            sheet.Cells["A1"].LoadFromCollection((List<ScoreTableViewModel>)dgwScores.DataSource, true);
                            sheet.Cells.AutoFitColumns();

                            // Save to file
                            package.Save();
                        }
                        MessageBox.Show("Export successfull", "Message", MessageBoxButtons.OK);

                    }
                    catch(Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

        }
    }
}
