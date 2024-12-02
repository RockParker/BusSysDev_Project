using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Alerts;
namespace MauiApp1.SetupPages;

public partial class GenderPage : ContentPage
{
    private static Color PrimaryColor => (Color)Application.Current.Resources["Primary"];
    private bool? IsMale = null;
    private UserDetails _details;
    public GenderPage()
    {
        InitializeComponent();
        _details = UserDetails.Instance;
        
        IsMale = _details.IsMale;
        if(IsMale == true)
        {
            MaleButton.BorderColor = PrimaryColor;
            IsMale = true;
        }
        else if (IsMale == false)
        {
            FemaleButton.BorderColor = PrimaryColor;
            IsMale = false;
        }
    }
    
    private void Male_Clicked(object? sender, EventArgs e)
    {
        MaleButton.BorderColor = PrimaryColor;
        FemaleButton.BorderColor = Colors.Transparent;
        IsMale = true;
    }

    private void Female_Clicked(object? sender, EventArgs e)
    {
        FemaleButton.BorderColor = PrimaryColor;
        MaleButton.BorderColor = Colors.Transparent;
        IsMale = false;
    }

    private void Next_Clicked(object? sender, EventArgs e)
    {
        if (IsMale == null)
        {
            Toast toast = new Toast()
            {
                Text = "Please select gender"
            };
            toast.Show();
            
            return;
        }
        
        _details.IsMale = IsMale.Value;
        Navigation.PushAsync(new WeightPage());
        
        Navigation.RemovePage(this);
    }
}