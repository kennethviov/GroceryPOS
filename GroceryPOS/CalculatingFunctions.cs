using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryPOS
{
    internal class CalculatingFunctions
    {
        //private double CalculateSubtotal(List<> cartItems)
        //{
        //    double subtotal = 0;
        //    foreach (var item in cartItems)
        //    {
        //        subtotal += item.Price * item.Quantity;
        //    }

        //    return subtotal;
        //}

        private int DetermineDiscountP(double subtotal)
        {
            if (subtotal >= 500)
                return 20;
            else if (subtotal >= 200)
                return 15;
            else if (subtotal >= 100)
                return 10;
            else
                return 0;
        }

        private double CalculateDiscount(double subtotal, int discountP)
        {
            return subtotal * discountP / 100;
        }

        private double CalculateTotal(double subtotal, double discount)
        {
            return subtotal - discount;
        }
    }
}
