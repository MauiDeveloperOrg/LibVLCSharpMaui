using LibVLCSharp.Shared;
using UIKit;

namespace LibVLCSharp.Maui.Platforms.MacCatalyst;

public class VideoFrame : UIView, IVideoView
{
    private MediaPlayerX mediaPlayer;

    public MediaPlayerX MediaPlayer
    {
        get => mediaPlayer;
        set
        {
            if (mediaPlayer != value)
            {
                Detach();
                mediaPlayer = value;

                if (mediaPlayer != null)
                {
                    Attach();
                }
            }

        }
    }

    void Attach()
    {
        if (MediaPlayer != null && MediaPlayer.NativeReference != IntPtr.Zero)
        {
            MediaPlayer.NsObject = Handle;
        }
    }

    void Detach()
    {
        if (MediaPlayer != null && MediaPlayer.NativeReference != IntPtr.Zero)
        {
            MediaPlayer.NsObject = IntPtr.Zero;
        }
    }
}
