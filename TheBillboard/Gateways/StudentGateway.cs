using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheBillboard.Abstract;
using TheBillboard.Options;

namespace TheBillboard.Gateways
{
    public class StudentGateway : IStudentGateway
    {
        private readonly AppOptions _options; 
        private readonly ILogger<StudentGateway> _logger;
        public StudentGateway(IOptions<AppOptions> options, ILogger<StudentGateway> logger)
        {
            _options = options.Value;
            _logger = logger;

        }
        public IEnumerable<string> GetStudents()
        {
            _logger.LogInformation("GetStudents Called");
            return _options.Students;
        }
    }
}
