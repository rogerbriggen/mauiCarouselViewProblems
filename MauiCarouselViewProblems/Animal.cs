using CommunityToolkit.Mvvm.ComponentModel;


namespace MauiCarouselViewProblems;

public partial class Animal : ObservableObject
{
    [ObservableProperty]
    private string _name;

    [ObservableProperty]
    private string _birthday;

    [ObservableProperty]
    private string color;
}
