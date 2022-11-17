using Android.Content;
using Android.Runtime;
using Android.Util;
using LibVLCSharp.Platforms.Android;

namespace LibVLCSharp.Maui.Platforms.Android;

public class VideoFrame : VideoView
{
    public VideoFrame(Context context) : base(context)
    {
    }

    public VideoFrame(nint javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
    {
    }

    public VideoFrame(Context context, IAttributeSet attrs) : base(context, attrs)
    {
    }

    public VideoFrame(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
    {
    }

    public VideoFrame(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
    {
    }
}
