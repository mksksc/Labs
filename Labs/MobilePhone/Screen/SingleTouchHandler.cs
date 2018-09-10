using System;

namespace MobilePhone.Screen
{
    internal class SingleTouchHandler : ITouchHandler
    {
        private BaseTouch touch;
        public void AddScreenTouch(BaseTouch touch)
        {
            if (this.touch == null)
            {
                this.touch = touch;
                Console.Write($"Foud screen touch: ({touch.Position.X};{touch.Position.Y})");
                var touch3D = touch as Touch3D;
                if (touch3D != null)
                {
                    Console.Write($"With touch force: {touch3D.TouchForce}");
                }
            }    
        }

        public void RemoveScreenTouch(BaseTouch touch)
        {
            if (this.touch == touch)
            {
                this.touch = null;
            }
        }
    }
}