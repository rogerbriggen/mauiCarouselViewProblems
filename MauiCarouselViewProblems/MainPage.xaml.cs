using System.Collections.ObjectModel;


namespace MauiCarouselViewProblems
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            animalsCollection = new ObservableCollection<Animal>();
            BindingContext = this;
            animalsCollection.Add(new Animal { Name = "Dog", Birthday = DateTime.Now.ToString(), Color="brown" });
            animalsCollection.Add(new Animal { Name = "Monkey", Birthday = DateTime.Now.ToString(), Color="black" });
            animalsCollection.Add(new Animal { Name = "Bird", Birthday = DateTime.Now.ToString(), Color = "white" });
        }

        public ObservableCollection<Animal> animalsCollection { get; set; } 

    }
}