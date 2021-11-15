using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlagApplication.Models
{
    public class Flag
    {
        public int Id { get; set; }

        public string Country { get; set; }

        public ICollection<Color> Colors { get; set; }
    }
}
