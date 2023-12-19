using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomApp.myexceptions
{
    internal class OrderNotFoundException:ApplicationException
    {
        public OrderNotFoundException() { }
        public OrderNotFoundException(string message) : base(message) { }
    }
}
