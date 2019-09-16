using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    delegate void Spell(Entity target);

    class SpellBook
    {
        public Spell[] book;

        public Spell Page1;
        public Spell Page2;

        public SpellBook(int pages)
        {
            Page1 = BlankPage;
            Page2 = BlankPage;

            book = new Spell[pages];
            for (int i =0; i < pages; i++)
            {
                book[i] = BlankPage;

            }

        }

        public void BlankPage(Entity target)
        {


        }

        //Create a method and assign it to Page 1
        public static void Flare(Entity target)
        {
            target.Health -= 30;
            Console.WriteLine("Flare does 30 dmg to " + target.GetName() + "!");
        }

        public static void Healing(Entity target)
        {
            target.Health += 10;
            Console.WriteLine("Healing does 10 healing to " + target.GetName() + "!");
        }


    }

}
