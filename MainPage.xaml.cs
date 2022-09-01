using CommunityToolkit.Maui.Views;

namespace SpinnerPopup;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnBtnClicked(object sender, EventArgs e)
	{
		var popup = new SpinnerPopup();
		this.ShowPopup(popup);
	}
}

