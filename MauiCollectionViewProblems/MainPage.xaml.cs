using System.Collections.ObjectModel;


namespace MauiCollectionViewProblems
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            animalsCollection = new ObservableCollection<Animal>();
            BindingContext = this;
            animalsCollection.Add(new Animal { Name = "Dog", Birthday = DateTime.Now.ToString() });
        }

        public ObservableCollection<Animal> animalsCollection { get; } 

        private void OnCreateNewListBtnClicked(object sender, EventArgs e)
        {
            animalsCollection.Clear();
            animalsCollection.Add(new Animal { Name = "Monkey", Birthday = DateTime.Now.ToString() });
        }
    }
}