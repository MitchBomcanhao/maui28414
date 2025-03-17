namespace Maui28414.IssueRepro;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        this.OnAppearingLabel.Text = "";
        this.OnNavigatedToLabel.Text = "";
        Navigation.PushAsync(new ThirdPage());
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        this.OnAppearingLabel.Text = $"OnAppearing: stack has {Navigation.NavigationStack.Count().ToString()} pages - last is {Navigation.NavigationStack.Last().Title}";
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        this.OnNavigatedToLabel.Text = $"OnNavigatedTo: stack has {Navigation.NavigationStack.Count().ToString()} pages - last is {Navigation.NavigationStack.Last().Title}";
    }
}