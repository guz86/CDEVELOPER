using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Character
    {
        int _health = 100;
        public void Hit(int damage)
        {
            _health -= damage;
        }
        public void ShowInfo()
        {
            Console.WriteLine(_health);
        }
    }
}
