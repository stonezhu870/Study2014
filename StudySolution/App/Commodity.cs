using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App
{
  public  class Commodity
    {
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string Originofgoods { get; set; }
        public int Commodityprice { get; set; }
        public string ProductUnit { get; set; }

        public Commodity(string productCode, string productDescription,
            string originofgoods, int commodityprice, string productUnit)
        {
            ProductCode = productCode;
            ProductDescription = productDescription;
            Originofgoods = originofgoods;
            Commodityprice = commodityprice;
            ProductUnit = productUnit;
        }
    }
}
