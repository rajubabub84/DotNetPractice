using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPDemo
{
    interface IUser
    {
        bool Login(string username, string passowrd);
        bool Register(string username, string passowrd, string email);       
    }

    interface ILogger
    {
        void LogError(string error);
    }

    interface IEmail
    {
        bool SendMail(string email);
    }
}
