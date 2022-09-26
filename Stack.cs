using System.Collections.Generic;
using System.Linq;

namespace Csharp_Intermediate_Udemy
{
    class Stack
    {
        private List <object> List = new List <object> ();
        private int index = 0;

        public void Push(object obj)
        {
            List.Add (obj);
            index++;
        }

        public void display()
        {
            System.Console.WriteLine(List[0]);
        }

        public object Pop()
        {
            
            if (List.ElementAt(List.Count -1) != null)
            {
                object obj = List.ElementAt(List.Count-1);
                List.RemoveAt(List.Count -1);
                
                return obj;
            }    
            return null;
        }

        public void Clear()
        {
            List.Clear ();

        }
    }
}
