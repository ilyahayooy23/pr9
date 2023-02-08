using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Exception : ApplicationException
    {
        public Exception(string massage) : base(massage)
        {

        }
    }
}