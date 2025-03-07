namespace CursoMaui;

public class HomePage : ContentPage
{
	int count = 0;
	Label counterLabel;
	public HomePage()
	{
		var scrollView = new ScrollView();
		var stackLayout = new StackLayout();
		scrollView.Content = stackLayout;

		counterLabel = new Label
		{
			Text = "Count: 0",
			FontSize = 22,
			FontAttributes = FontAttributes.Bold,
			HorizontalOptions = LayoutOptions.Center
		};

		stackLayout.Children.Add(counterLabel);

		var counterButton = new Button
		{
			Text = "clique aqui",
			HorizontalOptions = LayoutOptions.Center
		};

		stackLayout.Children.Add(counterButton);
		counterButton.Clicked += ClickedAddButton;

		this.Content = scrollView;

	}

	private void ClickedAddButton(object sender, EventArgs e)
	{
		count++;
		counterLabel.Text = $"clicked: {count}";
	}
}