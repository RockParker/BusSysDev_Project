namespace MauiApp1;

public partial class AppShell : Shell
{
    private static bool IsFirstLaunch => true;
    public AppShell()
    {
        InitializeComponent();
        
        HomeContent.ContentTemplate =  new DataTemplate(()=> new WelcomePage());
        HomeContent.Route = "WelcomePage";
    }

    private void OnLaunch()
    {
        DataTemplate launchPage;
        string route;
        if (IsFirstLaunch)
        {
            launchPage = new DataTemplate(()=> new WelcomePage());
            route = "WelcomePage";
        }
        else
        {
            launchPage = new DataTemplate(()=> new MainPage());
            route = "MainPage";
        }

        HomeContent.ContentTemplate =  launchPage;
        HomeContent.Route = route;
    }
}