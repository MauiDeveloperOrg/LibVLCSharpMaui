namespace LibVLCSharp.Maui.Views;

public class VideoFrame : View
{
    public static readonly BindableProperty MediaPlayerProperty = BindableProperty.Create(nameof(MediaPlayer), typeof(MediaPlayerX), typeof(VideoFrame), default);

    public MediaPlayerX MediaPlayer
    {
        get { return (MediaPlayerX)GetValue(MediaPlayerProperty); }
        set { SetValue(MediaPlayerProperty, value); }
    }
}