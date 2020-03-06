using System;

namespace Task4
{
    public class Product
    {
        private DateTime dateOfManuforing;
        private int size;
        private double price;
        private String manufactor;
        private String name;

        public Product(DateTime dateOfManuforing, int size, double price, string manufactor, string name)
        {
            this.dateOfManuforing = dateOfManuforing;
            this.size = size;
            this.price = price;
            this.manufactor = manufactor;
            this.name = name;
        }

        public DateTime DateOfManuforing
        {
            get => dateOfManuforing;
            set => dateOfManuforing = value;
        }

        public int Size
        {
            get => size;
            set => size = value;
        }

        public double Price
        {
            get => price;
            set => price = value;
        }

        public string Manufactor
        {
            get => manufactor;
            set => manufactor = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }


        public override string ToString()
        {
            return $"{nameof(dateOfManuforing)}: {dateOfManuforing}, {nameof(size)}: {size}, {nameof(price)}: {price}, {nameof(manufactor)}: {manufactor}, {nameof(name)}: {name}";
        }
    }
}