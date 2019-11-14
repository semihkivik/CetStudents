using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CetStudents
{
    /// <summary>
    /// Interaction logic for CourseWindow.xaml
    /// </summary>
    public partial class CourseWindow : Window
    {
        public CourseWindow()
        {
            InitializeComponent();
        }

        private void btnCourseInsert_Click(object sender, RoutedEventArgs e)
        {
            Course course = new Course();
            course.Name = txtCourseName.Text;
            course.Code = txtCourseCode.Text;
            course.Credit = Int32.Parse(txtCourseCredit.Text);
            course.MaxStudent = Int32.Parse(txtMaxStudents.Text);
            CetDb db = new CetDb();
            db.Courses.Add(course);

            db.SaveChanges();
            MessageBox.Show("Ders Kaydedildi");
            LoadCourses();
            txtCourseCode.Text = "";
            txtCourseCredit.Text = "";
            txtCourseName.Text = "";
            txtMaxStudents.Text = "";

        }
        

        private void btnCourseUpdate_Click(object sender, RoutedEventArgs e)
        {
            Course course = grdCourse.SelectedItem as Course;
            if (course != null)
            {
                CetDb db = new CetDb();
                var coursenew = db.Courses.Find(course.Id);
                coursenew.Name = txtCourseName.Text;
                coursenew.Code = txtCourseCode.Text;
                coursenew.Credit = Int32.Parse(txtCourseCredit.Text);
                coursenew.MaxStudent = Int32.Parse(txtMaxStudents.Text);
                db.SaveChanges();
                LoadCourses();
                MessageBox.Show(coursenew.Id+"Id'li ders güncellendi.");
                txtCourseCode.Text = "";
                txtCourseCredit.Text = "";
                txtCourseName.Text = "";
                txtMaxStudents.Text = "";
            }
            else
            {
                MessageBox.Show("Güncellemek için Ders seçmelisin!");
            }
        }

        private void btnCourseDelete_Click(object sender, RoutedEventArgs e)
        {
            Course course = grdCourse.SelectedItem as Course;
            if (course != null)
            {
                CetDb db = new CetDb();
                db.Courses.Remove(course);
                db.SaveChanges();
                MessageBox.Show(course.Id+"Id'li Ders Silindi!");
                LoadCourses();
                txtCourseCode.Text = "";
                txtCourseCredit.Text = "";
                txtCourseName.Text = "";
                txtMaxStudents.Text = "";

            }
            else
            {
                MessageBox.Show("Silmek için Ders seçmelisin!");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadCourses(); 
        }
        private void LoadCourses()
        {
            CetDb db = new CetDb();
            List<Course> courses = db.Courses.ToList();
            grdCourse.ItemsSource = courses;
        }

        private void grdCourse_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            Course course = grdCourse.SelectedItem as Course;
            if (course != null)
            {
                txtCourseName.Text = course.Name;
                txtCourseCode.Text = course.Code;
                txtCourseCredit.Text = course.Credit.ToString();
                txtMaxStudents.Text = course.MaxStudent.ToString();
            }
        }

    }
}
