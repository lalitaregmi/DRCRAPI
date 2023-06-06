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
    public class ChangePasswordService:IChangePassword
    {
        public async Task<dynamic> ChangePass(Password a) 
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
                var sql = "sp_tbl_user";
                var parameters = new DynamicParameters(); 
                parameters.Add("@userid", a.UserID);
                parameters.Add("@oldpwd", a.OldPwd);  
                parameters.Add("@newpwd", a.NewPwd);
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

