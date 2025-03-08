namespace CursoMaui;

public partial class NewPage1 : ContentPage
{
	int count = 0;
	public NewPage1()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		count++;
		counterLabel.Text = $"Clicked: {count}";
		SemanticScreenReader.Announce(counterLabel.Text);
	}
}