namespace VLCSharp.Maui.Sample;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        Source.Text = @"C:\Users\13247\Downloads\Sony_4K_Camp.mp4";
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            string url = Source.Text;
            if (!string.IsNullOrEmpty(url))
            {
                Video.Source = new Uri(url);

                if (File.Exists(url) && new FileInfo(url) is FileInfo fileInfo)
                {
                    Title = fileInfo.Name;
                }
                else
                {
                    Title = url;
                }
            }
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", ex.Message, "OK");
        }
    }
}

