
namespace MauiApp1;

public partial class MainPage : ContentPage
{
    private UserDetails _details;
    private DailyData _dailyData;
    private AddFoodPage _addFoodPage;

    private DailyFoodViewModel _dailyModel;
    public MainPage()
    {
        InitializeComponent();
        _details = UserDetails.Instance;
        _dailyData = DailyData.Instance;
        _dailyModel = new DailyFoodViewModel();
        BindingContext = _dailyModel;
        _addFoodPage = new AddFoodPage(_dailyModel);
    }

    protected override void OnAppearing()
    {
        if (_details.IsMale == null)
            Navigation.PushAsync(new WelcomePage());

        else
            UpdateLabels();
        
        base.OnAppearing();
    }

    private void UpdateLabels()
    {
        WelcomeLabel.Text = $"Welcome back, {_details.FirstName}!";
        
        FoodCalories.Text = _dailyData.ConsumedCalories.ToString();
        ExerciseCalories.Text = _dailyData.ExerciseCalories.ToString();
        RemainingCalories.Text = _dailyData.RemainingCalories.ToString();
    }
    
    private void AddFood_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(_addFoodPage);
    }
}