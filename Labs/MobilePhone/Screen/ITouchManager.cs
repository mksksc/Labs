using System;

namespace MobilePhone.Screen
{
    public interface ITouchManager
    {
        event Action<BaseTouch> OnAddTouch;
        event Action<BaseTouch> OnRemoveTouch;
    }
}