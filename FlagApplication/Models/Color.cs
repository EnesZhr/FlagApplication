using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlagApplication.Models
{
    public class Color
    {
        public int Id { get; set; }

        public string ColorName { get; set; }

        public ICollection<Flag> Flags { get; set; }
    }
}
