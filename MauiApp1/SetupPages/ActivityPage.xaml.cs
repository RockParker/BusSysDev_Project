using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Alerts;

namespace MauiApp1.SetupPages;

public partial class ActivityPage : ContentPage
{
    List<Button> _activityButtons = new();
    private static Color PrimaryColor => (Color)Application.Current.Resources["Primary"];
    public ActivityPage()
    {
        InitializeComponent();
        _activityButtons.Add(Sedentary);
        _activityButtons.Add(LightlyActive);
        _activityButtons.Add(ModeratelyActive);
        _activityButtons.Add(VeryActive);
    }

    private void Activity_OnClicked(object? sender, EventArgs e)
    {
        sender = sender as Button;
        
        foreach (var button in _activityButtons)
        {
            if (button == sender)
            {
                button.BorderColor = PrimaryColor;
                UserDetails.Instance.Activity = (UserDetails.ActivityLevel) _activityButtons.IndexOf(button);
            }
            else
            {
                button.BorderColor = Colors.Transparent;
            }
        }
    }
    
    private void Next_Clicked(object? sender, EventArgs e)
    {
        if(UserDetails.Instance.LosingWeight ||
           UserDetails.Instance.GainingWeight )
            Navigation.PushAsync(new GoalPage());
        
        Navigation.RemovePage(this);
    }


}