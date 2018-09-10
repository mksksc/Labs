using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Screen
{
    public class TouchScreen : ScreenBase
    {
        private ITouchHandler iTouchHandler;
        private ITouchManager iTouchManager;
        private TouchScreenType touchScreenType;
        public TouchScreen(ITouchManager iTouchManager,double height, double width, uint pixelsH, uint pixelsW, TouchScreenType touchScreenType) : base(height, width, pixelsH, pixelsW)
        {
            this.iTouchManager = iTouchManager;
            iTouchManager.OnAddTouch += AddTouch;
            iTouchManager.OnRemoveTouch += RemoveTouch;

            SetTouchHandler();
        }

        public override void Show(IScreenImage screenImage)
        {
            throw new NotImplementedException();
        }

        public override string ToString() => "Touch screen";

        private void AddTouch(BaseTouch touch)
        {
            iTouchHandler.AddScreenTouch(touch);
        }

        private void RemoveTouch(BaseTouch touch)
        {
            iTouchHandler.RemoveScreenTouch(touch);
        }

        private void SetTouchHandler()
        {
            switch (touchScreenType)
            {
                case TouchScreenType.SingleTouch:
                    this.iTouchHandler = new SingleTouchHandler();
                    break;
                case TouchScreenType.MultiTouch:
                    this.iTouchHandler = new MultiTouchHandler();
                    break;
            }
        }

    }

    public enum TouchScreenType
    {
        SingleTouch, MultiTouch
    }
}
