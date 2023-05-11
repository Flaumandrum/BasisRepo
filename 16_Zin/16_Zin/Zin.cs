using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Zin
{
    public class Zin
    {
        // velden 
        private string _inhoud = "";
        
        // properties
        public string PropInhoud
        {
            get { return _inhoud; }
            set { _inhoud = value; }
        }
        
        // methoden 

        // constructors
        public Zin()
        {

        }
        public Zin(string ontvInhoud)
        {
            _inhoud = ontvInhoud;
        }
        
    }
}
