using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheBillboard.Options
{
    public class AppOptions
    {
        [Required, MinLength(5)]
        public IEnumerable<string> Students { get; set; }
    }
}
