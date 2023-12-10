using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Tatli : Restaurant,IRestaurant
    {
       
        public double indirim(double fiyat)
        {
            return (fiyat*15)/100;
        }
   

    }
}
    