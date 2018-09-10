using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Screen
{
    public class TouchManager : ITouchManager
    {
        public event Action<BaseTouch> OnAddTouch;
        public event Action<BaseTouch> OnRemoveTouch;

        private List<BaseTouch> screenTouches;

        private void AnalyzeScreenTouches()
        {
            //TODO implementation
        }
    }
}
