using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cerchio_con_tostring_e_parse
{
    internal class Cerchio
    {
        public int raggio { get; set; }
        public Cerchio() { }
        public Cerchio(int r)
        {
            raggio = r; 
        }

        public override string ToString()
        {
            return String.Format("{0}", raggio); 
        }

        public static Cerchio Parse(string rag) {
            int a=int.Parse(rag);
            Cerchio e=new Cerchio(a);
            return e;
        }
    }
}
