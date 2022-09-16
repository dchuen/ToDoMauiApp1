using MauiApp1.ViewModels;

namespace MauiApp1;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainPageVm();
	}

    #region Handlers
    private void AddBtn_Clicked(object sender, EventArgs e)
	{
		SemanticScreenReader.Announce(AddBtn.Text);
	}

	private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
	{

	}

	private void IsCompletedCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{

	}
	#endregion

}

