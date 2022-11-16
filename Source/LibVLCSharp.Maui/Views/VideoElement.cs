namespace LibVLCSharp.Maui.Controls;

public class VideoElement : View
{
    public static readonly BindableProperty MediaPlayerProperty = BindableProperty.Create(nameof(MediaPlayer), typeof(MediaPlayerX), typeof(VideoElement), default);

    public MediaPlayerX MediaPlayer
    {
        get { return (MediaPlayerX)GetValue(MediaPlayerProperty); }
        set { SetValue(MediaPlayerProperty, value); }
    }
}