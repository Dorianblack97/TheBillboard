using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBillboard.Models
{
    public record Message(string Body, string Title, string Author, DateTime Created, DateTime Updated, int? Id = default)
    {
    }
}
