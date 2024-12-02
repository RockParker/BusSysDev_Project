using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Platform;
using Toast = CommunityToolkit.Maui.Alerts.Toast;

namespace MauiApp1.SetupPages;

public partial class ProfilePage : ContentPage
{
    UserDetails _details;
    public ProfilePage()
    {
        InitializeComponent();
        _details = UserDetails.Instance;
        
        FirstNameEntry.Text = _details.FirstName ?? string.Empty;
        LastNameEntry.Text = _details.LastName ?? string.Empty;
        EmailEntry.Text = _details.Email ?? string.Empty;
    }

    private void Next_Clicked(object? sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(FirstNameEntry.Text) ||
            string.IsNullOrEmpty(LastNameEntry.Text) ||
            string.IsNullOrEmpty(EmailEntry.Text))
        {
            Toast toast = new Toast()
            {
                Text = "Please fill in all fields",
            };
            toast.Show();
            return;
        }
        
        _details.FirstName = FirstNameEntry.Text;
        _details.LastName = LastNameEntry.Text;
        _details.Email = EmailEntry.Text;
        
        
        Navigation.PushAsync(new AgePage());
        
        Navigation.RemovePage(this);
    }
}