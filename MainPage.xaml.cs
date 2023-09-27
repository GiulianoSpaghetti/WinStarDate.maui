namespace WinStarDate.maui;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        while (true)
            try
            {
                data.Date = DateTime.Parse(Preferences.Get("Data", "1968-09-08"));
                break;
            }
            catch (FormatException e)
            {
                Preferences.Clear();
            }
    }
    private void calcola_Click(object sender, EventArgs e)
    {
        int i = int.Parse(data.Date.Date.ToUniversalTime().ToString("dd")) + 1;
        String s = "" + i;
        if (s.Length == 1)
            s = "0" + s;
        risultato.Text =$"La data è: {data.Date.Date.ToUniversalTime().ToString("yy")}{data.Date.Date.ToUniversalTime().ToString("MM")}.{s}";
        Preferences.Set("Data", data.Date.ToString());
    }
}
