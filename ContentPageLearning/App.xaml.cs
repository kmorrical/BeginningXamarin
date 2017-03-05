using Xamarin.Forms;

namespace ContentPageLearning
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new Page1();
			//changing newPage1 makes it the starting point for doing any of the work
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
