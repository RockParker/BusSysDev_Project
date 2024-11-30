using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1;

public partial class WelcomePage : ContentPage
{
    public WelcomePage()
    {
        InitializeComponent();
    }
    private void Setup_Clicked(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new Setup());
    }
}