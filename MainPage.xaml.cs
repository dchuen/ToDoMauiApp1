using MauiApp1.ViewModels;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainPageVm();
	}

    #region Handlers
    private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
	{

	}

	private void IsCompletedCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{

	}
    #endregion

}

