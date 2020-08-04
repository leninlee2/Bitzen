using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bitzen_LeninAguiar.Models
{
    public class LoginViewModel
    {
        public String login { get; set; }
        public String password { get; set; }

        public String name { get; set; }

        public bool authenticated { get; set; }

        public String message { get; set; }
    }

}
