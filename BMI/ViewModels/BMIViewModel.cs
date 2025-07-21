using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Bmi = BMI.Models.BMI;

namespace BMI.ViewModels;

public partial class BMIViewModel
{
    public Bmi Bmi { get; set; } = new()
    {
        Height = 180,
        Weight = 73
    };
}
