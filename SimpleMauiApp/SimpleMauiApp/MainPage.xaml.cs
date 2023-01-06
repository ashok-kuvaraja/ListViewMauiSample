namespace SimpleMauiApp
{

	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
	}

	class ViewModel
	{
		List<String> names = new List<string>();

		public List<String> Names
		{
			get
			{
				return names;
			}
		}

		public ViewModel()
		{
			GenerateNames(100);
		}

		void GenerateNames(int count)
		{
			for (int i = 0; i < count; i++)
				names.Add("Label " + i.ToString());
		}
	}
}

