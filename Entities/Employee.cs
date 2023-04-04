﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiredBrainCoffee.StorageApp.Entities
{
    public class Employee:EntityBase
    {
        public string? FirstName { get; set; }
        public override string ToString() => $"id: {Id}, FirstName: {FirstName}";


    }
}