namespace MauiApp1;

public class FoodItem
{
    public int CalorieCount { get; set; }
    public string Name { get; set; }

    private FoodItem(string calorieCount, string name)
    {
        Name = name;
        CalorieCount = int.Parse(calorieCount);
    }

    private static List<FoodItem>? _list;
    public static List<FoodItem> ItemsList => _list ??= LoadData();
    private static List<FoodItem> LoadData()
    {
        List<FoodItem> list = new();
        
        list.Add(new FoodItem("95", "Apple"));
        list.Add(new FoodItem("89", "Banana"));
        list.Add(new FoodItem("105", "Orange"));
        list.Add(new FoodItem("62", "Grapes"));
        list.Add(new FoodItem("50", "Strawberry"));
        list.Add(new FoodItem("150", "Bagel"));
        list.Add(new FoodItem("250", "Croissant"));
        list.Add(new FoodItem("95", "Brown Bread Slice"));
        list.Add(new FoodItem("150", "White Bread Slice"));
        list.Add(new FoodItem("285", "Hamburger"));
        list.Add(new FoodItem("450", "Cheeseburger"));
        list.Add(new FoodItem("290", "French Fries (Medium)"));
        list.Add(new FoodItem("140", "Potato Chips (1 oz)"));
        list.Add(new FoodItem("85", "Carrot (Medium)"));
        list.Add(new FoodItem("55", "Cucumber (Medium)"));
        list.Add(new FoodItem("240", "Avocado"));
        list.Add(new FoodItem("100", "Boiled Egg"));
        list.Add(new FoodItem("155", "Fried Egg"));
        list.Add(new FoodItem("70", "Scrambled Eggs (1 Egg)"));
        list.Add(new FoodItem("250", "Chicken Breast (Grilled, 4 oz)"));
        list.Add(new FoodItem("350", "Fried Chicken Drumstick"));
        list.Add(new FoodItem("210", "Salmon Fillet (4 oz)"));
        list.Add(new FoodItem("190", "Tuna (Canned in Water, 3 oz)"));
        list.Add(new FoodItem("240", "Pork Chop (4 oz)"));
        list.Add(new FoodItem("220", "Steak (4 oz)"));
        list.Add(new FoodItem("50", "Spinach (Boiled, 1 cup)"));
        list.Add(new FoodItem("80", "Broccoli (Steamed, 1 cup)"));
        list.Add(new FoodItem("130", "Sweet Corn (1 cup)"));
        list.Add(new FoodItem("20", "Zucchini (Raw, 1 cup)"));
        list.Add(new FoodItem("95", "Rice (White, 1/2 cup)"));
        list.Add(new FoodItem("110", "Rice (Brown, 1/2 cup)"));
        list.Add(new FoodItem("160", "Pasta (Cooked, 1 cup)"));
        list.Add(new FoodItem("220", "Lasagna"));
        list.Add(new FoodItem("300", "Macaroni and Cheese"));
        list.Add(new FoodItem("150", "Pizza Slice (Cheese)"));
        list.Add(new FoodItem("280", "Pizza Slice (Pepperoni)"));
        list.Add(new FoodItem("90", "Milk (1 cup, whole)"));
        list.Add(new FoodItem("45", "Milk (1 cup, skimmed)"));
        list.Add(new FoodItem("120", "Orange Juice (1 cup)"));
        list.Add(new FoodItem("140", "Apple Juice (1 cup)"));
        list.Add(new FoodItem("50", "Green Tea (No Sugar)"));
        list.Add(new FoodItem("100", "Coffee (With Sugar and Milk)"));
        list.Add(new FoodItem("90", "Latte (Small)"));
        list.Add(new FoodItem("120", "Cheddar Cheese (1 oz)"));
        list.Add(new FoodItem("60", "Mozzarella Cheese (1 oz)"));
        list.Add(new FoodItem("150", "Ice Cream (Vanilla, 1/2 cup)"));
        list.Add(new FoodItem("200", "Ice Cream (Chocolate, 1/2 cup)"));
        list.Add(new FoodItem("95", "Chocolate Chip Cookie (1)"));
        list.Add(new FoodItem("80", "Oatmeal Cookie (1)"));
        list.Add(new FoodItem("240", "Doughnut (Glazed)"));
        
        return list;
    }
}