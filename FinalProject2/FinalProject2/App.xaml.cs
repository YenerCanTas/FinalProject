using FinalProject2.DataTransactions;

namespace FinalProject2
{
    public partial class App : Application
    {
        public static DBTrans DBTrans { get; private set; }
       

        

        public App(DBTrans dbtrans)
        {
            InitializeComponent();

            MainPage = new AppShell();
            DBTrans = dbtrans;
           
        }
    }
}
