﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();

        
        public Customer(int id)
        {
            Id = id;
        }

        public Customer(int id, string name)
             :this(id)
        {
            
            Name = name;
        }

        public void Promote()
        {

        }
        


    }
}
