using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_stuff
{
    class KattChef : KittyChef
    {
        public override void MakeKittyDish()
        {
            Console.WriteLine("The kitty makes limsa meatballs");
        }
        public virtual void MakeKittyPasta()
        {
            Console.Write("The katt makes kitty noodles");
        }
    }
}
