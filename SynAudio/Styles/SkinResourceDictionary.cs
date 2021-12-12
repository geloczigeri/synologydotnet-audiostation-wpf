﻿using System;
using System.Windows;

namespace SynAudio.Styles
{
    public class SkinResourceDictionary : ResourceDictionary
    {
        public Uri LightSource
        {
            get => Source;
            set => UpdateSource(value);
        }
        public Uri DarkSource
        {
            get => Source;
            set => UpdateSource(value);
        }

        private void UpdateSource(Uri value)
        {
            if (value.OriginalString.EndsWith($"{App.Skin}.xaml"))
                Source = value;
        }
    }
}
