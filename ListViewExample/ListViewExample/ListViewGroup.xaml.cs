using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        ObservableCollection<Contact> people = new ObservableCollection<Contact>();

        public ObservableCollection<Contact> People { get { return people; } }
        public ListViewGroup()
        {
            InitializeComponent();
            GroupView.ItemsSource = people;
            people.Add(new Contact("Angel", "A")
            {
                new Employee{ DisplayName = "Antonio"}
            });
            people.Add(new Contact("Banderas", "B")
            {
                new Employee { DisplayName = "Bill Gath" },
                new Employee { DisplayName = "Bruno Mars" }
            });
            people.Add(new Contact("Charlie", "C")
            {
                new Employee { DisplayName = "Cecilia" },
                new Employee { DisplayName = "Christopher"}
            });
            people.Add(new Contact("Romeo", "R")
            {
                new Employee { DisplayName = "Roberto Gomez" }
            });
            people.Add(new Contact("Sesar", "S")
            {
                new Employee { DisplayName = "Sharlie" }
            });
        }

        
    }
}