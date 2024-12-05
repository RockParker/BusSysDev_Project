using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiApp1;

public class FoodViewModel : INotifyPropertyChanged
{
    private ObservableCollection<FoodItem> _foodItems;
    private ObservableCollection<FoodItem> _dailyItems;
    public ObservableCollection<FoodItem> FoodItems
    {
        get => _foodItems;
        set
        {
            _foodItems = value;
            OnPropertyChanged();
        }
    }    
    public ObservableCollection<FoodItem> DailyItems
    {
        get => _dailyItems;
        set
        {
            _dailyItems = value;
            OnPropertyChanged();
        }
    }
    public int ConsumedCalories => _dailyItems.Sum(x => x.CalorieCount);

    public FoodViewModel()
    {
        FoodItems = new ObservableCollection<FoodItem>(FoodItem.ItemsList);
        DailyItems = new ObservableCollection<FoodItem>([]);
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    private void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
