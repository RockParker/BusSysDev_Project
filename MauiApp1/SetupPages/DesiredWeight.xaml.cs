using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Alerts;

namespace MauiApp1.SetupPages;

public partial class DesiredWeight : ContentPage
{
    public DesiredWeight()
    {
        InitializeComponent();
    }

    private void Next_Clicked(object? sender, EventArgs e)
    {
        int weight;
        if (Int32.TryParse(WeightEntry.Text, out weight) == false)
        {
            Toast toast = new Toast()
            {
                Text = "Please enter a valid weight"
            };
            toast.Show();
            return;
        }
        
        UserDetails.Instance.DesiredWeightPounds = weight;
        Navigation.PushAsync(new ActivityPage());
        Navigation.RemovePage(this);
    }
}