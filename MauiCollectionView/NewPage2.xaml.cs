namespace MauiCollectionView;

public partial class NewPage2 : ContentPage
{
    public List<SampleItem> Items { get; set; } = null;

    public NewPage2()
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