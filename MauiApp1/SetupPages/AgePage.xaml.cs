using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Alerts;

namespace MauiApp1.SetupPages;

public partial class AgePage : ContentPage
{
    private UserDetails _details;
    public AgePage()
    {
        InitializeComponent();
        _details = UserDetails.Instance;
        
        AgeEntry.Text = _details.Age.ToString() ?? string.Empty;
    }

    private void Next_Clicked(object? sender, EventArgs e)
    {
        int age;

        if (Int32.TryParse(AgeEntry.Text, out age ) == false)
        {
            Toast toast = new Toast()
            {
                Text = "Please enter a valid age",
            };
            toast.Show();
            return;
        }
        
        _details.Age = age;
        Navigation.PushAsync(new GenderPage());
        
        Navigation.RemovePage(this);
    }
}