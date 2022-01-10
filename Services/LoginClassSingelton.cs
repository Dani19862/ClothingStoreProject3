using Microsoft.EntityFrameworkCore;
using Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataAccssesLayer;
using WindowsFormsApp1.Services;

namespace Services
{
    public class LoginClassSingelton : ILogin
    {
        //readonly User user = new User();
        readonly ClothingStoreDB db = new ClothingStoreDB();
        readonly private bool isExist = true;

        private static LoginClassSingelton instance;
      
        
        public static LoginClassSingelton GetSingelton()
        {
            if (instance == null)
            {
                instance = new LoginClassSingelton();
            }
            return instance;
        }

        //Method gor Get the user deatails
        public User Login (string inputUserName, string inputPass) 
        {
             var user = db.Users
             .Where(x => x.UserName == inputUserName && x.Password == inputPass).FirstOrDefault();
            foreach (var item in db.Users)
            {
                if (item.UserName == inputUserName && item.Password == inputPass)
                {
                    return user;
                }
                   
            }
            return null;

        }


        // Method for Changing The new Password In Database
        public User RecoverPassword(string userName,string newPass, string email)
        {

           User user = db.Users.Where(x => x.Email==email && x.UserName == userName).FirstOrDefault();

            user.UserName = userName;
            user.Password = newPass;
            user.Email = email;

            db.SaveChanges();
            return user;
            
        }
        // Method For check if user is exist in system
        public bool IsExist(string userName, string email)
        {
            User user = db.Users.Where(x => x.Email == email && x.UserName == userName).FirstOrDefault();
            if (isExist)
            {
                return true;
            }
            return false;
        }

    }
}
