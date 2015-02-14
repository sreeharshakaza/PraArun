using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace MVCClass.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string Company { get; set; }
        public int Age { get; set; }
    }

    public class Users
    {
        public List<UserModel> userList = new List<UserModel>();

        public Users()
        {
            userList.Add(new UserModel{
                Name = "Sree Harsha",
                Address = "Hyderabad",
                EmailAddress = "sriharsha.kaza@gmail.com",
                Company = "My Company",
                Age = 28
            });

            userList.Add(new UserModel{
                Name = "Prashant",
                Address = "Delhi",
                EmailAddress = "prashant@gmail.com",
                Company = "My Company",
                Age = 28
            });

            userList.Add(new UserModel{
                Name = "Arun",
                Address = "Pune",
                EmailAddress = "arun@gmail.com",
                Company = "My Company",
                Age = 28
            });
        }

        public void CreateUser(UserModel userModel)
        {
            userList.Add(userModel);
        }

    }
}