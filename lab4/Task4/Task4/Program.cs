using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    public class Store
    {
        private  List<Product> products = new List<Product>();
        public List<Product> List => products;

        public void addProduct(Product product)
        {
            products.Add(product);
        }

        public List<Product> findProductsByFilter(double price = -1, int size = -1, DateTime dateTime = new DateTime())
        {
            return products
                .Where(product => product.Size == size || size == -1)
                .Where(product => product.Price <= price || price == -1)
                .Where(product => product.DateOfManuforing.CompareTo(dateTime) > 0)
                .ToList();
        }

        public void sortProducts(String typeOfSort)
        {
            switch (typeOfSort.ToLower())
            {
                case "manufactor":
                     products.Sort((product1, product2) => product1.Manufactor.CompareTo(product2.Manufactor));
                    break;
                case "price":
                    products.Sort((product1, product2) => product1.Price.CompareTo(product2.Price));
                    break;
                case "name":
                    products.Sort((product1, product2) => product1.Name.CompareTo(product2.Name));
                    break;
            }
        }
    }

    
    public class Program
    {
        private static void printList(List<Product> list)
        {
            Console.WriteLine("Result of select:");
            list.ForEach(product => Console.WriteLine(product.ToString()) );
        }
        public static void Main(string[] args)
        {
            Store store = new Store();
            for (int i = 1; i <= 8; i++)
            {
                store.addProduct(new Product(new DateTime(2020, i, i),
                    3, i * 5, "Manufactoringsssssssss".Substring(i, 10),
                    "Manufactoringsssssssss".Substring(i + 1, 10)));
            }

            List <Product> list = store.findProductsByFilter(30, 3, new DateTime(2020, 1, 1));
            printList(list);
            Console.WriteLine("Sorting");
            store.sortProducts("name");
            printList(store.List);
        }
    }
}