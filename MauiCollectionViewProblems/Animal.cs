using CommunityToolkit.Mvvm.ComponentModel;


namespace MauiCollectionViewProblems;

public partial class Animal : ObservableObject
{
    [ObservableProperty]
    private string _name;

    [ObservableProperty]
    private string _birthday;
}
