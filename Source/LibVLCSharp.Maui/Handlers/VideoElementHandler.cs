using LibVLCSharp.Maui.Controls;
using Microsoft.Maui.Handlers;
#if ANDROID
using PartialElement = LibVLCSharp.Maui.Platforms.Android.VideoElement;
#elif IOS
using PartialElement = LibVLCSharp.Maui.Platforms.iOS.VideoElement;
#elif MACCATALYST
using PartialElement = LibVLCSharp.Maui.Platforms.MacCatalyst.VideoElement;
#else
using PartialElement = LibVLCSharp.Maui.Platforms.Windows.VideoElement;
#endif

namespace LibVLCSharp.Maui.Handlers;

public class VideoElementHandler : ViewHandler<VideoElement, PartialElement>
{
    public static IPropertyMapper<VideoElement, VideoElementHandler> Mapper { get; set; } = new PropertyMapper<VideoElement, VideoElementHandler>(ViewMapper)
    {
        [nameof(VideoElement.MediaPlayer)] = MapMediaPlayer,
    };

    public VideoElementHandler() : base(Mapper)
    {

    }

    public VideoElementHandler(IPropertyMapper mapper, CommandMapper commandMapper = null) : base(mapper, commandMapper)
    {
    }

    protected override PartialElement CreatePlatformView()
    {
#if ANDROID
        return new PartialElement(Context);
#else
        return new PartialElement();
#endif
    }

    public static void MapMediaPlayer(VideoElementHandler handler, VideoElement view)
    {
        handler.PlatformView.MediaPlayer = view.MediaPlayer;
    }
}
