namespace MauiCollectionView
{
    public static class Repository
    {
        public static async Task<List<SampleItem>> LoadDataFromDatabaseAsync()
        {
            var items = new List<SampleItem>();
            for (int i = 1; i <= 100; i++)
            {
                items.Add(new SampleItem
                {
                    FirstProperty = $"A{i}",
                    SecondProperty = $"B{i}",
                    ThirdProperty = $"C{i}",
                });
            }

            // Simulate a delay when loading data from a database
            await Task.Delay(100);
            return items;
        }
    }
}