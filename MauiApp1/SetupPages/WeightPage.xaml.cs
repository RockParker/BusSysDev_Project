using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Alerts;

namespace MauiApp1.SetupPages;

public partial class WeightPage : ContentPage
{
    private UserDetails _details;
    public WeightPage()
    {
        InitializeComponent();
        _details = UserDetails.Instance;
        
        WeightEntry.Text = _details.WeightPounds.ToString() ?? string.Empty;
        HeightEntry.Text = _details.HeightCm.ToString() ?? string.Empty;
    }

    private void Next_Clicked(object? sender, EventArgs e)
    {
        int weight, height;
        if (Int32.TryParse(WeightEntry.Text, out weight) == false||
            Int32.TryParse(HeightEntry.Text, out height) == false )
        {
            Toast toast = new Toast()
            {
                Text = "Invalid Entry"
            };
            toast.Show();
            return;
        }

        _details.WeightPounds = weight;
        _details.HeightCm = height;

        Navigation.PushAsync(new DesiredWeight());
        Navigation.RemovePage(this);

    }
}