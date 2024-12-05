using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Alerts;

namespace MauiApp1.SetupPages;

public partial class GoalPage : ContentPage
{

    private Color Primary => (Color)Application.Current.Resources["Primary"];
    public GoalPage()
    {
        InitializeComponent();
    }

    private void Next_Clicked(object? sender, EventArgs e)
    {
        if (UserDetails.Instance.PoundsPerWeek == null)
        {
            var toast = new Toast()
            {
                Text = "Please select a goal"
            };
            toast.Show();
            return;
        }
        Navigation.RemovePage(this);
        Navigation.PopToRootAsync();
    }

    private void ClearColor()
    {
        OnePound.BorderColor = Colors.Transparent;
        TwoPound.BorderColor = Colors.Transparent;
        ThreePound.BorderColor = Colors.Transparent;
    }

    private void OnePound_Clicked(object? sender, EventArgs e)
    {
        ClearColor();
        OnePound.BorderColor = Primary;
        UserDetails.Instance.PoundsPerWeek = 1;
    }

    private void TwoPound_Clicked(object? sender, EventArgs e)
    {        
        ClearColor();
        TwoPound.BorderColor = Primary;
        UserDetails.Instance.PoundsPerWeek = 2;
    }

    private void ThreePound_Clicked(object? sender, EventArgs e)
    {        
        ClearColor();
        ThreePound.BorderColor = Primary;
        UserDetails.Instance.PoundsPerWeek = 3;
    }
}