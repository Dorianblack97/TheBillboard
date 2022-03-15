using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBillboard.Abstract
{
    public interface IStudentGateway
    {
        IEnumerable<string> GetStudents();
    }
}
