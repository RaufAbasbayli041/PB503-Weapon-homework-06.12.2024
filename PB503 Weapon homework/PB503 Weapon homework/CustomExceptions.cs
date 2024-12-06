using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_Weapon_homework
{
    public class CustomExceptions : Exception
    {
        public CustomExceptions()
        {

        }
        public CustomExceptions(string? message) : base(message)
        {

        }
    }
}
