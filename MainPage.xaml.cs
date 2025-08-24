namespace CursoMaui;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnGenerateLuckNumber()
	{
		LuckAppTitle.IsVisible = false;
		ContainerLuckNumber.IsVisible = true;
    }

	private void OnClickButton(object sender, EventArgs e)
	{
		OnGenerateLuckNumber();
    }


}