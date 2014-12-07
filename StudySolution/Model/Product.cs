using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Product
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime CreateTime { get; set; }

        public int TypeId { get; set; }

        public int ClickCount { get; set; }

        public string MConent { get; set; }

        public string SmallType { get; set; }
    }
}
