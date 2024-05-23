using FinalProject2.Models;

namespace FinalProject2;

public partial class EntrollPage : ContentPage
{
	public EntrollPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        lstStudents.ItemsSource = App.DBTrans.GetAllStudents();
        lstCourses.ItemsSource = App.DBTrans.GetAllCourses();
        
    }

    private void Enrollment_Add(object sender, EventArgs e)
    {
        var student = lstStudents.SelectedItem as Student;
        var course = lstCourses.SelectedItem as Course;

        if (student != null && course != null)
        {
            var enroll = new Enrollment
            {
                Stu_ID = student.ID,
                Crs_Code = course.Code
            };

            App.DBTrans.AddEnrollment(enroll);
            Enrollment_Show(sender, e);
        }
        else
        {
            DisplayAlert("Error", "Please select both a student and a course.", "OK");
        }
    }

    private void Enrollment_Show(object sender, EventArgs e)
    {
        var enrollments = App.DBTrans.GetAllEnrollment();
        lstEnrollments.ItemsSource = enrollments;
    }

    private void Enrollment_Delete_Button(object sender, EventArgs e)
    {
        var selectedEnrollment = lstEnrollments.SelectedItem as Enrollment;
        if (selectedEnrollment != null)
        {
            App.DBTrans.DeleteEnrollment(selectedEnrollment.Enroll_ID);
            Enrollment_Show(sender, e);
        }
        else
        {
            DisplayAlert("Error", "Please select an enrollment to delete.", "OK");
        }
    }
}
