using Service.Service;
using Service.Interface;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Service;



namespace Service
{
    public class UnitOfWork:IUnitOfWork
    {
        //for jwt token
        //private readonly ITokenInterface _tokenInterface;

        //for email
        //private readonly SmtpSetting _settings;

        //initialise configuration in constructor
        public UnitOfWork(IConfiguration config)
        {
            Configuration = config;
        }
        // for getting value from appsetting.json
        private IConfiguration Configuration { get; }
        //initialize service to get access method
        // yei blogservice property lai controller ma use garne.
        public ChangePasswordService changepassservice => new ChangePasswordService();// BlogCategoryService() obj blogservice ma pass so blogservice controller ma use gare paxi BlogCategoryService() sab method controller le access garna pauxa
        public CreateCompanyService createcomservice => new CreateCompanyService();
        public CreateAccountService createaccservice => new CreateAccountService();
    }
}
    
