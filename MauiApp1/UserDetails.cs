namespace MauiApp1;

public class UserDetails
{

    private static UserDetails? _instance;
    public static UserDetails Instance {
        get { return _instance ??= new UserDetails(); }
    }
    
    private UserDetails()
    {
    }
    
    public override string ToString()
    {
        return $"FirstName: {FirstName}\n" +
               $"lastName: {LastName}\n" +
               $"Email: ({Email})\n" +
               $"IsMale: {IsMale}\n" +
               $"Age: {Age}\n" +
               $"Weight: {WeightPounds}\n" +
               $"Height: {HeightCm}\n";
    }

    public int DailyCalories => CalculateIntake();
    
    public enum ActivityLevel
    {
        Sedentary = 0,
        LightlyActive = 1,
        ModeratelyActive = 2,
        VeryActive = 3
    }
    
    public bool? IsMale { get; set; }
    public int? Age { get; set; }
    public int? WeightPounds { get; set; }
    public int? DesiredWeightPounds { get; set; }
    public int? HeightCm { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public int? PoundsPerWeek { get; set; }
    public bool LosingWeight => DesiredWeightPounds < WeightPounds;
    public bool GainingWeight => DesiredWeightPounds > WeightPounds;
    
    public ActivityLevel? Activity { get; set; }


    private int CalculateIntake()
    {
        var intake = CalculateAMR();
        if(LosingWeight || GainingWeight)
            intake = FactorWeightChange(intake);
        return intake;
    }

    public int CalculateAMR()
    {
        if (IsMale == null) throw new Exception("Missing Gender");
        
        var weight = (WeightPounds / 2.2) * 10;
        var height = HeightCm * 6.25;
        var age = Age * 5;

        var cal = (int)(weight + height - age)!;

        if ((bool)IsMale) 
            cal += 5;
        else 
            cal -= 161;
        

        
        cal = FactorActivity(cal);
        return cal;
    }
    
    public int FactorWeightChange(int input)
    {
        var change = 500 * (int)PoundsPerWeek!;
        if (LosingWeight)
            input -= change;
        else if (GainingWeight)
            input += change;
        
        return input;
    }

    private int FactorActivity(int input)
    {
        switch (Activity)
        {
            case ActivityLevel.Sedentary:
            {
                input = (int)(input * 1.2)!;
                break;
            }
            case ActivityLevel.LightlyActive:
            {
                input = (int)(input * 1.375)!;
                break;
            }
            case ActivityLevel.ModeratelyActive:
            {
                input = (int)(input * 1.55)!;
                break;
            }
            case ActivityLevel.VeryActive:
            {
                input = (int)(input * 1.725)!;
                break;
            }
            default:
            {
                input = (int)(input * 1.375)!;
                break;
            }
        }

        return input;
    }
}