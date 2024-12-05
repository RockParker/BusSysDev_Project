
namespace MauiApp1;

public partial class MainPage : ContentPage
{
    private UserDetails _userDetails;
    private AddFoodPage _addFoodPage;
    private FoodViewModel _foodViewModel;
    private int _exerciseCalories = 0;
    
    public MainPage()
    {
        InitializeComponent();
        
        _userDetails = UserDetails.Instance;
        _foodViewModel = new FoodViewModel();
        _addFoodPage = new AddFoodPage(ref _foodViewModel);
        BindingContext = _foodViewModel;
    }

    protected override void OnAppearing()
    {
        if (_userDetails.IsMale == null)
            Navigation.PushAsync(new WelcomePage());

        else
            UpdateLabels();
        base.OnAppearing();
    }

    private void UpdateLabels()
    {
        WelcomeLabel.Text = $"Welcome back, {_userDetails.FirstName}!";
       
        FoodCalories.Text = _foodViewModel.ConsumedCalories.ToString();
        
        ExerciseCalories.Text = _exerciseCalories.ToString();
        RemainingCalories.Text = _userDetails.DailyCalories - _foodViewModel.ConsumedCalories + _exerciseCalories + " kcal";
    }
    
    private void AddFood_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(_addFoodPage);
    }

    private void FoodList_OnChildAdded(object? sender, ElementEventArgs e)
    {
        if(EmptyFood.IsVisible)
            EmptyFood.IsVisible = false;
    }
}