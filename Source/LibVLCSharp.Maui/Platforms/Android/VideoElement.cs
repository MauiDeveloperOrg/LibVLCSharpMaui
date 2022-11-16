using Android.Content;
using Android.Runtime;
using Android.Util;
using LibVLCSharp.Platforms.Android;

namespace LibVLCSharp.Maui.Platforms.Android;

public class VideoElement : VideoView
{
    public VideoElement(Context context) : base(context)
    {
    }

    public VideoElement(nint javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
    {
    }

    public VideoElement(Context context, IAttributeSet attrs) : base(context, attrs)
    {
    }

    public VideoElement(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
    {
    }

    public VideoElement(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
    {
    }
}
