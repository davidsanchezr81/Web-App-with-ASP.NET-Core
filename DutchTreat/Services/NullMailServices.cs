using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace DutchTreat.Services
{
    public class NullMailServices
    {
        private readonly ILogger<NullMailServices> _logger;

        public NullMailServices(ILogger<NullMailServices> logger)
        {
            _logger = logger;
        }

        public void SendMessage(string to, string subject, string body)
        {


        }


    }
}
