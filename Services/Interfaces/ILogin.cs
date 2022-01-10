using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Services
{
    public interface ILogin
    {
        //Input user and password from client
        User Login(string inputUserName, string InputPassWord);
        User RecoverPassword(string userName, string newPass, string email);
        bool IsExist(string userName, string email);
    }
}
