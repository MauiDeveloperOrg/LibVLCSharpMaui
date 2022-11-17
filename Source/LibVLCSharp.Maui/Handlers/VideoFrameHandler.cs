using LibVLCSharp.Maui.Views;
using Microsoft.Maui.Handlers;
#if ANDROID
using PartialFrame = LibVLCSharp.Maui.Platforms.Android.VideoFrame;
#elif IOS
using PartialFrame = LibVLCSharp.Maui.Platforms.iOS.VideoFrame;
#elif MACCATALYST
using PartialFrame = LibVLCSharp.Maui.Platforms.MacCatalyst.VideoFrame;
#else
using PartialFrame = LibVLCSharp.Maui.Platforms.Windows.VideoFrame;
#endif

namespace LibVLCSharp.Maui.Handlers;

public class VideoFrameHandler : ViewHandler<VideoFrame, PartialFrame>
{
    public static IPropertyMapper<VideoFrame, VideoFrameHandler> Mapper { get; set; } = new PropertyMapper<VideoFrame, VideoFrameHandler>(ViewMapper)
    {
        [nameof(VideoFrame.MediaPlayer)] = MapMediaPlayer,
    };

    public VideoFrameHandler() : base(Mapper)
    {

    }

    public VideoFrameHandler(IPropertyMapper mapper, CommandMapper commandMapper = null) : base(mapper, commandMapper)
    {
    }

    protected override PartialFrame CreatePlatformView()
    {
#if ANDROID
        return new PartialFrame(Context);
#else
        return new PartialFrame();
#endif
    }

    public static void MapMediaPlayer(VideoFrameHandler handler, VideoFrame view)
    {
        handler.PlatformView.MediaPlayer = view.MediaPlayer;
    }
}
