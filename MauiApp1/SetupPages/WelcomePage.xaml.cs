using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp1.SetupPages;

namespace MauiApp1;

public partial class WelcomePage : ContentPage
{
    public WelcomePage()
    {
        InitializeComponent();
    }
    private void Setup_Clicked(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new ProfilePage());
        
        Navigation.RemovePage(this);
    }
}