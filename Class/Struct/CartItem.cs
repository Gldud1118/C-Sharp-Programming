using System;
using System.Collections.Generic;
using System.Text;

namespace Struct
{
    public struct CartItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public uint Quantity { get; set; }
    }
}
