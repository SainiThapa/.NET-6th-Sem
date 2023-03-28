using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saini_dotNET
{
    class Player
    {
        private string name1;
        public string name = "Saini";
        public int id = 44;
        public void SetId(int a)
        {
            id = a;
        }
        
        //CONSTRUCTOR
        /*public Player() {
            Console.WriteLine("THIS IS AN EXAMPLE OF CONSTRUCTOR IN C#");
            Console.WriteLine("New player is added ! ");
        }*/
        //GET SET Properties
        public string Name
        {
            get { return name1; }
            set { name1 = value; }
        }
        public string version = "Comfort 2.0";

    }
    class Car : Player
    {
        public string modelName = "FORD";
    }
}
