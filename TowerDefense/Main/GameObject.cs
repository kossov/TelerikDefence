﻿using System;
using System.Windows.Media;
using TowerDefense.Interfaces;

namespace TowerDefense.Main
{
    public abstract class GameObject : IGameObject
    {
        private static int nextId = 0;

        private readonly int id;
        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public Point Position
        {
            get;
            protected set;
        }

        public abstract ImageSource ImageSource
        {
            get;
        }

        public virtual int Depth
        {
            get
            {
                return 1;
            }
        }

        public bool IsDestroyed
        {
            get;
            protected set;
        }

        public GameObject(Point position)
        {
            this.id = GameObject.nextId++;
            this.Position = position;
            this.IsDestroyed = false;
        }

        public abstract void Update();
    }
}
