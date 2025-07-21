using CommunityToolkit.Mvvm.ComponentModel;

namespace BMI.Models;

public partial class BMI : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Result))]
    [NotifyPropertyChangedFor(nameof(ResultText))]
    private float height;
    
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Result))]
    [NotifyPropertyChangedFor(nameof(ResultText))]
    private float weight;

    public float Result => CalculateBmi();
    public string ResultText => GetResultText();

    private float CalculateBmi() => (Weight / Height / Height) * 10000;

    private string GetResultText()
    {
        float result = Result;
        return result switch
        {
            <= 16 => $"BMI ({result:N1}): Severe Thinness",
            > 16 and <= 17 => $"BMI ({result:N1}): Moderate Thinness",
            > 17 and <= 18.5f => $"BMI ({result:N1}): Mild Thinness",
            > 18.5f and <= 25 => $"BMI ({result:N1}): Normal",
            > 25 and <= 30 => $"BMI ({result:N1}): Overweight",
            > 30 and <= 35 => $"BMI ({result:N1}): Obese Class I",
            > 35 and <= 40 => $"BMI ({result:N1}): Obese Class II",
            _ => $"BMI ({result:N1}): Obese Class III"
        };
    }
}
