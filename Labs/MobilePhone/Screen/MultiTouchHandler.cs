using System;
using System.Collections.Generic;

namespace MobilePhone.Screen
{
    internal class MultiTouchHandler : ITouchHandler
    {
        private List<BaseTouch> baseTouches;

        public MultiTouchHandler()
        {
            baseTouches = new List<BaseTouch>();
        }

        public void AddScreenTouch(BaseTouch touch)
        {
            baseTouches.Add(touch);
            Console.Write($"Foud screen touch: ({touch.Position.X};{touch.Position.Y})");
            var touch3D = touch as Touch3D;
            if (touch3D != null)
            {
                Console.Write($"With touch force: {touch3D.TouchForce}");
            }
        }

        public void RemoveScreenTouch(BaseTouch touch)
        {
            baseTouches.Remove(touch); ;
        }
    }
}