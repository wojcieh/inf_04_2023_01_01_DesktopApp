
namespace MauiApp1;

    public partial class MainPage : ContentPage
    {
         public MainPage()
        {
            InitializeComponent();
        }
                
        
            private string GenHaslo(int dlugosc)
            {
                const string mLitery = "abcdefghijklmnoprstuwxyz";
                const string dLitery = "ABCDEFGHIJKLMNOPRSTUWXYZ";
        const string specjalne = "!@#$%^&*()?><";
        const string liczby = "0123456789";
        string znaki = mLitery;
                string haslo ="";

        if (chSpecjalne.IsChecked == true)
        {
            znaki += specjalne;
        }
        if (chLitery.IsChecked == true)
        {
            znaki += dLitery;
        }
        if (chCyfry.IsChecked == true)
        {
            znaki += liczby;
        }

        Random losowa = new Random();
                for (int i = 0; i < dlugosc; i++)
                {
                    int index = losowa.Next(0,znaki.Length);
                    haslo += znaki[index];
                }
                return haslo.ToString();
            }
        

        private async void Button_Clicked(object sender, EventArgs e)
        {
        
        string dl = dlugosc.Text;
            string haslo = GenHaslo(Convert.ToInt16(dl));
            await DisplayAlert("Wygenerowane hasło:", haslo, "OK");
        }


/* Niescalona zmiana z projektu „MauiApp1 (net8.0-maccatalyst)”
Przed:
    private void Button_Clicked_1(object sender, EventArgs e)
    {
Po:
    private void Button_Clicked_1Async(object sender, EventArgs e)
    {
*/
    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        string dl = dlugosc.Text;
        string imie = eImie.Text;
        string nazwisko = eNazwisko.Text;
        string stanowisko = pStanowisko.SelectedItem.ToString();
        string haslo = GenHaslo(Convert.ToInt16(dl));
        await DisplayAlert("Dane pracownika:", imie + " " + nazwisko + " " + stanowisko + " Hasło: " + haslo, "OK");
    }
}




