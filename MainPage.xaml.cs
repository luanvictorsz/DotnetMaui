using System.Globalization;

namespace CursoMaui;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
    private void OnClickButton(object sender, EventArgs e)
    {
        OnGenerateDialogBox();
    }

    private void OnGenerateDialogBox()
	{
		LuckAppTitle.IsVisible = false;
		ContainerLuckNumber.IsVisible = true;
		var set = OnClickGenerateLuckNumber();
		LuckNumber01.Text = set.ElementAt(0).ToString("D2", CultureInfo.InvariantCulture);
		LuckNumber02.Text = set.ElementAt(1).ToString("D2", CultureInfo.InvariantCulture);
		LuckNumber03.Text = set.ElementAt(2).ToString("D2", CultureInfo.InvariantCulture);
		LuckNumber04.Text = set.ElementAt(3).ToString("D2", CultureInfo.InvariantCulture);
		LuckNumber05.Text = set.ElementAt(4).ToString("D2", CultureInfo.InvariantCulture);
		LuckNumber06.Text = set.ElementAt(5).ToString("D2", CultureInfo.InvariantCulture);	
    }

	private SortedSet<int> OnClickGenerateLuckNumber()
	{
		var set = new SortedSet<int>();

		while (set.Count < 6)
        {
            Random random = new Random();
            int luckNumber = random.Next(1, 60);
            set.Add(luckNumber);
        }
		
		return set;
    }
}