using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Entity
    {
        protected int _health = 100;
        protected int _maxHealth = 100;


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

        public virtual int GetDefense()
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
        public virtual void Print()
        {



        }




}
}
