using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Character
    {
        private int _health = 100;
        public void Hit(int damage)
        {
            if (damage >=_health)
            {
                _health = 0;
            }
            else
            {
                _health -= damage;
            }
            
        }
        public void ShowInfo()
        {
            Console.WriteLine(_health);
        }
    }
}
