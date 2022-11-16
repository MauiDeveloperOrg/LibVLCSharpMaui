using LibVLCSharp.Maui.Controls;
using LibVLCSharp.Maui.Handlers;
using LibVLCSharp.Shared;

namespace LibVLCSharp.Maui;

public static class AppBuilderExtensions
{
    public static MauiAppBuilder UseMauiLibVLCSharp(this MauiAppBuilder builder)
    {
        builder.ConfigureMauiHandlers(h =>
        {
            h.AddHandler<VideoElement, VideoElementHandler>();
        });

        Core.Initialize();

        return builder;
    }
}
