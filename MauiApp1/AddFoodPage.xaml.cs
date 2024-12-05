namespace MauiApp1;

public partial class AddFoodPage : ContentPage
{
    FoodViewModel _foodViewModel;
    public AddFoodPage(ref FoodViewModel model)
    {
        InitializeComponent();
        _foodViewModel = model;
        BindingContext = _foodViewModel;
    }

    private void Button_OnClicked(object? sender, EventArgs e)
    {
        var foodItem = (sender as Button)?.BindingContext as FoodItem;
        _foodViewModel.DailyItems.Add(foodItem!);
        Navigation.RemovePage(this);
    }
}