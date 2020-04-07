using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mhmdkoeik_Assignment2.Models
{
    public class Customer
    {
        public int id { get; set; }

        public string Name { get; set; }

        internal static object SingleOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}