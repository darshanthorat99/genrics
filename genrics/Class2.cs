using System;
using System.Collections.Generic;
using System.Collections;

namespace genrics
{
    public class Product : IComparable
    {
        private int price;
        private string name;
        public Product(int price, string name)
        {
            this.price = price;
            this.name = name;
        }

        public int CompareTo(object obj) 
        {

            
            Product  P1= (Product)obj;  
            if (this.price> P1.price) 
            {
                return 1;
            }
            else if (this.price < P1.price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return "Player :" + name + "  " + price;
        }
    }
    public class Food:IEnumerable
    {
        private Product[] product;
        public Food()
        {
            product = new Product[2];
          
           product [0] = new Product(100,"ice cream");
            product[1] = new Product(200, "cake");

        }

        public IEnumerator GetEnumerator()
        {
            return product.GetEnumerator();
        }
    }





    public class Program
    {

        static void Main(string[] args)
        {

            Product a = new Product(100, "ice cream");
            Product b = new Product(200, "cake");
            

            int result = a.CompareTo(b);
            if (result == 1)
            {
                Console.WriteLine("icream price is more");
            }
            else if (result == -1)
            {
                Console.WriteLine("cake price is more");
            }
            else
            {
                Console.WriteLine("both have same price");
            }
        }


    }

}


