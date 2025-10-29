namespace DataBinding.XamlElement
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            EnteredTextLabel.Text = string.Empty;
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnteredTextLabel.Text = TextEntry.Text;
        }
    }
}
