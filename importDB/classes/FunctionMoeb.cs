using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sisBen
{
   public class FunctionMoeb
    {
        public string LeftZero(string value, int Quantity)
        {
            int Lenght;
            int result = -1;
            string tempValue;
            tempValue = value.Trim();
            Lenght = value.Trim().Length;
            value = string.Empty;
            try{
                result = int.Parse(tempValue.Trim().Substring(0, 1));
            }
            catch(Exception)
            {

            }
            if (result != -1)
            {
                for (int i = 0; i < (Quantity - Lenght); i++)
                    value += "0";
                tempValue = value + tempValue;
            }
            else
            {
                for (int i = 0; i < (Quantity - Lenght); i++)
                    value += " ";
                tempValue = value + tempValue;
            }
            
            return tempValue;
        }

        public string RightEspace(string Value, int Quantity)
        {
            int Lenght;
            string TempValue;

            TempValue = Value;
            Lenght = Value.Length;
            Value = string.Empty;
            for(int i = 0; i < (Quantity - Lenght); i++)
                Value += " ";
            TempValue += Value;
            return TempValue;

        }
        public string RemoveCommaDec(string Value, int Quantity)
        {
            int i;
            bool Dec = false;
            string result = string.Empty;
            if (!Value.Equals(string.Empty))
            {
                for (i = 0; i < Value.Length; i++)
                {
                    if (Dec)
                        Quantity--;

                    if (!Value[i].ToString().Equals(",") && !Value[i].ToString().Equals("."))
                        result += Value[i].ToString();
                    else
                    {
                        Dec = true;
                        result += ".";
                    }
                }
            }
            while (Quantity > 0)
            {
                if (!Dec)
                {
                    result += ".";
                    Dec = true;
                }
                Quantity--;
                result += "0";
            }

            return result;
        }
        public string FormataValue(string value)
        {
            value = filtraCampo(value);
            string vr = value;
            int tam = vr.Length;
            if (tam <= 2) { value = vr; }
            if (tam > 2 && tam <= 5) { value = vr.Substring(0, tam - 2) + ',' + vr.Substring(tam - 2, (tam - (tam - 2))); }
            if (tam >= 6 && tam <= 8) { value = vr.Substring(0, tam - 5) + '.' + vr.Substring(tam - 5, 3) + ',' + vr.Substring(tam - 2, (tam - (tam - 2))); }
            if ((tam >= 9) && (tam <= 11)) { value = vr.Substring(0, tam - 8) + '.' + vr.Substring(tam - 8, 3) + '.' + vr.Substring(tam - 5, 3) + ',' + vr.Substring(tam - 2, (tam - (tam - 2))); }
            if ((tam >= 12) && (tam <= 14)) { value = vr.Substring(0, tam - 11) + '.' + vr.Substring(tam - 11, 3) + '.' + vr.Substring(tam - 8, 3) + '.' + vr.Substring(tam - 5, 3) + ',' + vr.Substring(tam - 2, (tam - (tam - 2))); }
            if ((tam >= 15) && (tam <= 18)) { value = vr.Substring(0, tam - 14) + '.' + vr.Substring(tam - 14, 3) + '.' + vr.Substring(tam - 11, 3) + '.' + vr.Substring(tam - 8, 3) + '.' + vr.Substring(tam - 5, 3) + ',' + vr.Substring(tam - 2, (tam - (tam - 2))); }
            return value;

        }
        public string filtraCampo(string campo)
        {
            string x = "0123456789";
            string s = string.Empty;
            string cp = string.Empty;
            string vr = campo;
            int tam = vr.Length;
            for (int i = 0; i < tam; i++)
            {
                if (x.Contains(vr.Substring(i, 1)))

                //if (vr.Substring(i, 1) != "/" && vr.Substring(i, 1) != "-" && vr.Substring(i, 1) != "." && vr.Substring(i, 1) != ",")
                {
                    s = s + vr.Substring(i, 1);
                }
            }

            return s;

        }
        public string FormataValueToUSD(string value)
        {
            value = value.Replace(".", "");
            value = value.Replace(",", ".");
            return value;

        }
    }    
}
