using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformationLib
{
    public class Transformation
    {
        public static string Transform(string amountContent, string quantityContent)
        {
            var actual = "";
            foreach (var amountLine in amountContent.Split('\n'))
            {
                var amount = decimal.Parse(amountLine, CultureInfo.InvariantCulture);
                foreach (var quntityLine in quantityContent.Split('\n'))
                {
                    var quantity = int.Parse(quntityLine);
                    var product = amount * quantity;
                    actual += $"{amountLine}x{quntityLine} = {product.ToString(CultureInfo.InvariantCulture)}\n";
                }

            }
            actual = actual.Substring(0, actual.Length - 1);
            return actual;
        }
    }
}
