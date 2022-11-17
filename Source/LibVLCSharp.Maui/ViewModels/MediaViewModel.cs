using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace LibVLCSharp.Maui.ViewModels;

internal partial class MediaViewModel : ObservableObject
{
    [ObservableProperty]
    private MediaPlayerX mediaPlayer;

    /// <summary>
    /// Judge whether there is a media control subject
    /// </summary>
    public bool ExistPlayer => mediaPlayer != null;

    /// <summary>
    /// Toggles the playback state
    /// </summary>
    [RelayCommand]
    private void PlaySwitch()
    {
        if (ExistPlayer)
        {
            if (mediaPlayer.CanPause)
            {
                mediaPlayer.Pause();
            }
            else
            {
                mediaPlayer.Play();
            }
        }
    }
}
