

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
    public class ReferenceService : IReference
    {


        public async Task<dynamic> CreateReference(Reference r) // a request
        {
            var res = new ResValues(); //model class ko obj pass to res(response variable)
            if (r.Status != "")
            {
                res.Values = null;
                res.StatusCode = 400;
                res.Message = " r is empty";
            }
            else
            {
                var sql = "sp_user"; // var is data type not integer "sp_blog" is store procedure name.
                var parameters = new DynamicParameters(); // this is inbuilt class(Dapper ko class) yo class store procedure ma parameter pathauana use hunxa. so yasko obj refrence variable ma pathako
                parameters.Add("@flag", r.Flag); // model ma banako prop(req) lai service bata server ma pathauna @ use garne
                parameters.Add("@primary", r); // it add @primary property to the parameters
                parameters.Add("@IsActive", r.IsActive);
                parameters.Add("@UserID", r.UserID);
                parameters.Add("@Category", r.Category);





                var data = await DbHelper.RunProc<dynamic>(sql, parameters); // it run the stored procedure with the help of DbHelper and pass result to the data.
                if (data.Count() != 0 && data.FirstOrDefault().Message == null)
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

    public class IReference
    {
    }




}