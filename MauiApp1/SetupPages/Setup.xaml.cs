using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1;

public partial class Setup : ContentPage
{
    private static Color PrimaryColor => (Color)Application.Current.Resources["Primary"];
    private bool? IsMale = null;
    public Setup()
    {
        InitializeComponent();
    }

    private void Male_Clicked(object? sender, EventArgs e)
    {
        MaleButton.BorderColor = PrimaryColor;
        FemaleButton.BorderColor = Colors.Black;
        IsMale = true;
    }

    private void Female_Clicked(object? sender, EventArgs e)
    {
        FemaleButton.BorderColor = PrimaryColor;
        MaleButton.BorderColor = Colors.Black;
        IsMale = false;
    }
}