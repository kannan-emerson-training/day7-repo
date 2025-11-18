using CollectionsAndGenericsApp.Domain;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsAndGenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();

            var orderBasket = new List<OrderItem>();
            orderBasket.Add(new OrderItem { Id = 1, Name = "books", Quantity = 3, UnitPrice = 100 });
            orderBasket.Add(new OrderItem { Id = 2, Name = "Amul Milk", Quantity = 2, UnitPrice = 65 });
            orderBasket.Add(new OrderItem { Id = 3, Name = "Bread", Quantity = 2, UnitPrice = 55 });

            double checkoutPrice = 0;
            foreach (OrderItem temp in orderBasket)
            {
               
                Console.WriteLine("id " + temp.Id + "name " + temp.Name + "unitprice" + temp.UnitPrice + "itemtotal" + temp.TotalCost());

            }

            Console.WriteLine("Checkout priceis " + checkoutPrice);

        }

        private static void CaseStudy1()
        {
            ArrayList orderBasket = new ArrayList();
            orderBasket.Add(new OrderItem { Id = 1, Name = "books", Quantity = 3, UnitPrice = 100 });
            orderBasket.Add(new OrderItem { Id = 2, Name = "Amul Milk", Quantity = 2, UnitPrice = 65 });
            orderBasket.Add(new OrderItem { Id = 3, Name = "Bread", Quantity = 2, UnitPrice = 55 });

            ///orderBasket.Add("Preeti");// collection not type safe
           // orderBasket.Add(100);

            double checkoutPrice = 0;
            foreach (object box in orderBasket)
            {

                OrderItem temp = box as OrderItem;
                checkoutPrice += temp.TotalCost();
                Console.WriteLine("id " + temp.Id + "name " + temp.Name + "unitprice" + temp.UnitPrice + "itemtotal" + temp.TotalCost());

            }

            Console.WriteLine("Checkout priceis " + checkoutPrice);
        }
    }
}
