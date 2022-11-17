using LibVLCSharp.Maui.Handlers;
using LibVLCSharp.Maui.Views;
using LibVLCSharp.Shared;

namespace LibVLCSharp.Maui;

public static class AppBuilderExtensions
{
    public static MauiAppBuilder UseMauiLibVLCSharp(this MauiAppBuilder builder)
    {
        builder.ConfigureMauiHandlers(h =>
        {
            h.AddHandler<VideoFrame, VideoFrameHandler>();
        });

        Core.Initialize();

        return builder;
    }
}
