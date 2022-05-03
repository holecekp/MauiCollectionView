namespace MauiCollectionView;

public partial class NewPage1 : ContentPage
{
    public List<SampleItem> Items { get; set; } = null;

    public NewPage1()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        Items = await Repository.LoadDataFromDatabaseAsync();
        OnPropertyChanged(nameof(Items));
    }
}