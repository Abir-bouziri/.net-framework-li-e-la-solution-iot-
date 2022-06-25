using System;
using MySql.Data.MySqlClient;
using WindowsFormsApplication1;
namespace administrateur
{
    class admi
    {
        public string[] split(String str)
        {
            String[] spearator = { " " };
            Int32 count = 6;

            // using the method
            String[] strlist = str.Split(spearator, count,
                   StringSplitOptions.RemoveEmptyEntries);
  
            
            return strlist; }

        public string month(string a)
        {
            switch (a)
            {

                case "janvier":
                  return  a = "01";
                case "féverier":
                  return a = "02";
                case "mars":
                  return a = "03";
                case "mai":
                  return a = "05";
                case "juin":
                  return a = "06";     
                case "Juillet":
                  return a = "07";
                case "août":
                  return a = "08";
                case "september":
                  return a = "09";
                case "october":
                  return a = "10";
               case "novembre":
                  return a="11";
               case "décembre":
                   return a="12";
                default :
                    return a="04";
            }            
        }
        public double distance(double lattmin ,double lattmax ,double longtimax,double longtimin)
        { /* double d = 0;
            double x = (longtimax - longtimin) * Math.Cos((lattmax + lattmin) / 2);
            double y = lattmax - lattmin;
            double z = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            d= 60*z*1.852; 
           
            return d;*/
            double r = 6371;
            double p = 2*r*Math.PI ;
            double degrés = p/ 360;
            double x = lattmax-lattmin;
            double y = longtimax-longtimin;
            double d = Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2))*degrés;
            return d;
        }

        public double consommation (double d)
        {
           double c = (d * 7) / 100;
            return c;
        }
    }

}
