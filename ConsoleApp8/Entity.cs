using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Entity
    {
        protected int _health = 50;
        protected int _maxHealth = 50;


        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
                if (_health > _maxHealth)
                {
                    _health = _maxHealth;

                }
                else if (_health < 0)
                {
                    _health = 0;
                }
            }
        }

        public virtual int GetDamage()
        {
            return 0;

        }

        public virtual string GetName()
        {
            return "*Placeholder Boi";
        }

        public virtual void Fight(Entity target)
        {



        }

        public virtual void Fight(Entity[] targets)
        {




        }
        
        


        
    }
}
