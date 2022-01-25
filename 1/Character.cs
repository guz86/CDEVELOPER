﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Character
    {
        // private int _health = 100;

        //public int Health { get { return _health; } private set { _health = value; } }
        public int Health { get; private set; } = 100;
        public void Hit(int damage)
        {
            if (damage > Health)
            {
                Health = damage;
            }
            Health -= damage;

        }
        public void ShowInfo()
        {
            Console.WriteLine($"Health: {Health}");
        }


    }
}
