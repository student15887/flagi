using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<Country> countryList;
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

            Loaded += new RoutedEventHandler(MainPage_Loaded);

            this.DataContext = this;
        }

        public async void MainPage_Loaded(object sender, RoutedEventArgs e)
        {

            string[,] countries = new string[,]
            {
                {"Albania", "Tirana", "lek", "albania.png"},
                {"Andora", "Andora", "euro", "andora.png"},
                {"Austria", "Wiedeń", "euro", "austria.png"},
                {"Belgia", "Bruksela", "euro", "belgia.png"},
                {"Białoruś", "Mińsk", "rubel", "bialorus.png"},
                {"Bośnia i Hercegowina", "Sarajewo", "marka transferowa", "bosnia.png"},
                {"Bułgaria", "Sofia", "lew", "bulgaria.png"},
                {"Chorwacja", "Zagrzeb", "kuna", "chorwacja.png"},
                {"Czarnogóra", "Podgorica", "euro", "czarnogora.png"},
                {"Czechy", "Praga", "korona czeska", "czechy.png"},
                {"Dania", "Kopenhaga", "korona duńska", "dania.png"},
                {"Estonia", "Tallin", "euro", "estonia.png"},
                {"Finlandia", "Helsinki", "euro", "finlandia.png"},
                {"Francja", "Paryż", "euro", "francja.png"},
                {"Grecja", "Ateny", "euro", "grecja.png"},
                {"Hiszpania", "Madryt", "euro", "hiszpania.png"},
                {"Holandia", "Amsterdam", "euro", "holandia.png"},
                {"Irlandia", "Dublin", "euro", "irlandia.png"},
                {"Islandia", "Rejkiawik", "korona islandzka", "islandia.png"},
                {"Kosowo", "Prisztina", "euro", "kosowo.png"},
                {"Liechtenstein", "Vaduz", "frank szwajcarski", "lichtenstein.png"},
                {"Litwa", "Wilno", "euro", "litwa.png"},
                {"Luksemburg", "Luksemburg", "euro", "lotwa.png"},
                {"Łotwa", "Ryga", "łat", "luksemburg.png"},
                {"Macedonia", "Skopie", "denar macedoński", "macedonia.png"},
                {"Malta", "Vallletta", "euro", "malta.png"},
                {"Mołdawia", "Kiszyniów", "lej mołdawski", "moldawia.png"},
                {"Monako", "Monako", "euro", "monako.png"},
                {"Niemcy", "Berlin", "euro", "niemcy.png"},
                {"Norwegia", "Oslo", "korona norweska", "norwegia.png"},
                {"Polska", "Warszawa", "złoty", "polska.png"},
                {"Portugalia", "Lizbona", "euro", "portugalia.png"},
                {"Rosja", "Moskwa", "rubel", "rosja.png"},
                {"Rumunia", "Bukareszt", "lej", "rumunia.png"},
                {"San Marino", "San Marino", "euro", "san marino.png"},
                {"Serbia", "Belgrad", "dinar serbski", "serbia.png"},
                {"Słowacja", "Bratysława", "euro", "slowacja.png"},
                {"Słowenia", "Lublana", "euro", "slowenia.png"},
                {"Szwajcaria", "Berno", "frank szwajcarski ", "szwajcaria.png"},
                {"Szwecja", "Sztokholm", "korona szwedzka", "szwecja.png"},
                {"Ukraina", "Kijów", "hrywna", "ukraina.png"},
                {"Watykan", "Watykan", "euro", "watykan.png"},
                {"Węgry", "Budapeszt", "forint", "wegry.png"},
                {"Wielka Brytania", "Londyn", "funt", "wielka brytania.png"},
                {"Włochy", "Rzym", "euro", "wlochy.png"}
            };
            countryList = new List<Country>();
            for (int i = 1; i < countries.GetLength(0); i++)
            {
                countryList.Add(new Country(countries[i,0], countries[i, 1], countries[i, 2], "Assets/flagi/" + countries[i, 3]));
            }
            flagList.ItemsSource = countryList;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private async void StackPanel_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await new MessageDialog(countryList[flagList.SelectedIndex].ToString()).ShowAsync();
        }
    }
}
