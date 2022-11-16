using LibVLCSharp.Shared;
using MediaPlayerX = LibVLCSharp.Shared.MediaPlayer;

namespace VLCSharp.Maui.Sample;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            string url = Source.Text;
            if (!string.IsNullOrEmpty(url))
            {
                MediaDraw.MediaPlayer?.Stop();

                LibVLC lib = new();
                Media media = new(lib, new Uri(url));
                MediaDraw.MediaPlayer = new MediaPlayerX(media);
                MediaDraw.MediaPlayer.Play();

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

