﻿namespace WomanShop.Models
{
    public class Product
    {
        static private int counter=0;
        public int Id { get;  }
        public string Name { get; }
        public decimal Cost { get;}
        public string Description { get;}
        public string ImagePath { get; set; }

        public Product(string name, decimal cost, string description, string imagePath)
        {
            Id = counter;
            Name = name;
            Cost = cost;
            Description = description;
            ImagePath = imagePath;

            counter++;
        }
    }
}
