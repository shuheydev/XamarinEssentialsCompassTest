﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinEssentialsCompassTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //値を取得したときのイベントハンドラをセット
            Compass.ReadingChanged += Compass_ReadingChanged;

            //コンパス値の取得開始
            Compass.Start(SensorSpeed.UI);
        }

        //値を取得したときに実行される
        private void Compass_ReadingChanged(object sender, CompassChangedEventArgs e)
        {
            var data = e.Reading;
            //ラベルに表示
            LabelCompass.Text = data.HeadingMagneticNorth.ToString();
        }
    }

}
