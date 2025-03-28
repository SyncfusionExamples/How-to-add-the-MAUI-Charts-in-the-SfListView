namespace ChartListView
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NAaF1cXmhNYVJ2WmFZfVpgcV9EZFZRQWYuP1ZhSXxXdkZiWH9bcnBVQWBaVkQ=");
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
