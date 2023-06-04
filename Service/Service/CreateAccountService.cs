using Dapper;
using Helper.Dapper;
using Models.Model;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class CreateAccountService:ICreateAccount
    {
        public async Task<dynamic> CreateAcc(CreateAccount a)
        {
            var res = new ResValues();
            if (a.Status != "")
            {
                res.Values = null;
                res.StatusCode = 400;
                res.Message = " a is empty";
            }
            else
            {
                var sql = "sp_tbl_dr_cr";
                var parameters = new DynamicParameters();
                parameters.Add("@comid", a.ComID);
                parameters.Add("@userid", a.UserID);
                parameters.Add("@flag", a.Flag);
                parameters.Add("@date", a.Date);
                parameters.Add("@particulars", a.Particulars);
                parameters.Add("@dramt", a.DrAmt);
                parameters.Add("@cramt", a.CrAmt);
                parameters.Add("@status", a.Status);

                var data = await DbHelper.RunProc<dynamic>(sql, parameters); // it run the stored procedure with the help of DbHelper and pass result to the data.
                if (data.Count() != 0 && data.FirstOrDefault().Message == null) //yei condition true since data contain (sql and parameter) 
                {
                    res.Values = data.ToList();
                    res.StatusCode = 200;
                    res.Message = "Success";

                }
                else if (data.Count() == 1 && data.FirstOrDefault().Message != null)
                {
                    res.Values = null;
                    res.StatusCode = data.FirstOrDefault().Message.StatusCode;
                    res.Message = data.FirstOrDefault().Message;

                }
                else
                {
                    res.Values = null;
                    res.StatusCode = 400;
                    res.Message = "no data";

                }
            }
            return res;
        }

    }
}
