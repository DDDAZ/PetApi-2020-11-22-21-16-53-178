﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Xml;

namespace PetApi.Models
{
    public class Pet
    {
        public Pet()
        {
        }

        public Pet(string name, string type, string color, int price)
        {
            Name = name;
            Type = type;
            Color = color;
            Price = price;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }

        public override bool Equals(object obj)
        {
            var pet = (Pet)obj;

            return pet != null && Name == pet.Name && Type == pet.Type && Color == pet.Color && Price == pet.Price;
        }
    }
}
