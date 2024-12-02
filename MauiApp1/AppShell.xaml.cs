using System.Runtime.CompilerServices;

namespace MauiApp1;

public partial class AppShell : Shell
{
    private MainPage MainPage { get; }

    public AppShell()
    {
        InitializeComponent();
        MainPage = new MainPage();
        HomeContent.ContentTemplate =  new DataTemplate(()=> MainPage);
        HomeContent.Route = "MainPage";

    }
}