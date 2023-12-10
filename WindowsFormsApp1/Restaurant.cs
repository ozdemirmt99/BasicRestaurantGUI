using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public abstract class Restaurant 
    {
        public static int mstrsayisi { get; set; }
        public string adi { get; set; }
        public static decimal hesapla(double toplamtutar)
        {
            return Convert.ToDecimal(mstrsayisi * toplamtutar);
        }

        public  double fiyat { get; set; }



    }



}
    


