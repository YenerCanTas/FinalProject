namespace FinalProject2;

public partial class CoursePage : ContentPage
{
	public CoursePage()
	{
		InitializeComponent();
        Course_List_View.ItemsSource = App.DBTrans.GetAllCourses();


    }

    private void Button_CourseAdd_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.AddCourse(new Models.Course
        {
            CourseName = Course_Name.Text,
            


        }) ;
        
    }

    private void Button_CourseDelete_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DBTrans.DeleteCourse((int)button.BindingContext);
        Course_List_View.ItemsSource = App.DBTrans.GetAllCourses();
    }

    private void Button_CourseShow_Clicked(object sender, EventArgs e)
    {
        Course_List_View.ItemsSource = App.DBTrans.GetAllCourses();

    }
}