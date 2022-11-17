using LibVLCSharp.Maui.ViewModels;
using LibVLCSharp.Shared;

namespace LibVLCSharp.Maui.Views;

public partial class MediaView : ContentView
{
    public static readonly BindableProperty SourceProperty = BindableProperty.Create(nameof(Source), typeof(Uri), typeof(MediaView), default, propertyChanged: SourceChanged);

    public Uri Source
    {
        get { return (Uri)GetValue(SourceProperty); }
        set { SetValue(SourceProperty, value); }
    }

    public MediaView()
    {
        InitializeComponent();
    }

    private static void SourceChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable.BindingContext is MediaViewModel model)
        {
            model.MediaPlayer?.Stop();

            if (newValue != null)
            {
                LibVLC lib = new();
                Media media = new(lib, (Uri)newValue);
                model.MediaPlayer = new MediaPlayerX(media);
                model.MediaPlayer.Play();
            }
        }
    }
}