using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class AttackItem : Item                                                         // It will also have what Item will have. (Inherited)
    {
        private int _damage;
        public int Damage
        {
            get
            {
                return _damage;
            }
           

        }
        public AttackItem(string newName, int newDamage, int newWeight)
        {
            _name = newName;
            _damage = newDamage;
            _weight = newWeight;


        }


    }

}
