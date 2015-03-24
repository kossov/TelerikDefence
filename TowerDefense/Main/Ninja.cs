﻿using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using TowerDefense.Interfaces;
using TowerDefense.Utils;

namespace TowerDefense.Main
{
    public class Ninja : Monster
    {
        public Ninja(Point position)
            : base(position)
        {
            AsyncTimer.DelayedCall(5000, () =>
            {
                this.Position = new Point(this.Position.X + 100, this.Position.Y + 100);
            });
        }

        public override void Update()
        {
            // Example
            this.Position = new Point(this.Position.X + 1, this.Position.Y + 1);
        }

        public override ImageSource ImageSource
        {
            get
            {
                // Example
                return new BitmapImage(new Uri(@"http://www.dekoracia.net/Resource/storage/product/2884/thumb_a140_nindja.png"));
                //return new BitmapImage(new Uri(@"/TowerDefense.Main;component/images/download.jpg"));
            }
        }
    }
}