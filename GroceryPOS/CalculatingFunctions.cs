using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GroceryStroreDiscountGUI.Components;

namespace GroceryPOS
{
    internal class CalculatingFunctions
    {

        public double CalculateSubtotal(List<ProductInCart> cartItems)
        {
            double subtotal = 0;
            foreach (var item in cartItems)
            {
                subtotal += item.Price * item.Quantity;
            }

            return subtotal;
        }

        public int DetermineDiscountP(double subtotal)
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

        public double CalculateDiscount(double subtotal, int discountP)
        {
            return subtotal * discountP / 100;
        }

        public double CalculateTotal(double subtotal, double discount)
        {
            return subtotal - discount;
        }

    }
}
