﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.Dynamic;
using MobilePhone.Keyboard;
using MobilePhone.Microphone;
using MobilePhone.Screen;
using MobilePhone.Simcard;
using MobilePhone.Battery;

namespace MobilePhone.Phone
{
    public abstract class MobilePhone
    {
        public abstract BatteryBase Battery { get; protected set; }
        public abstract Speaker Speaker { get; protected set; }
        public abstract KeyboardBase Keyboard { get; protected set; }
        public abstract MicrophoneBase Microphone { get; protected set; }
        public abstract ScreenBase Screen { get; protected set; }
        public abstract SimcardBase Simcard { get; protected set; }

        public string GetDescription()
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Battery: {Battery.ToString()}");
            descriptionBuilder.AppendLine($"Speaker: {Speaker.ToString()}");
            descriptionBuilder.AppendLine($"Keyboard: {Keyboard.ToString()}");
            descriptionBuilder.AppendLine($"Microphone: {Microphone.ToString()}");
            descriptionBuilder.AppendLine($"Screen: {Screen.ToString()}");
            descriptionBuilder.AppendLine($"Simcard: {Simcard.ToString()}");
            return descriptionBuilder.ToString();
        }
    }
}
