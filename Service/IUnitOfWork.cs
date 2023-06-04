using Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class IUnitOfWork
    {
        public ChangePasswordService changepassservice { get; }
        public CreateCompanyService createcomservice { get; }
        public CreateAccountService createaccservice { get; }
    }
}
