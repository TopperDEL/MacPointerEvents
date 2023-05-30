namespace MacPointerEvents
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void TextBlock_PointerEntered(object sender, Microsoft.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            throw new Exception("This time an exception is good as it shows that the PointerEntered-Event got raised!");
        }
    }
}