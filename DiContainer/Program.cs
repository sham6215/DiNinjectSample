using DiContainer.Models.Api;
using DiContainer.Services;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiContainer
{
    class Program
    {
        static void Main(string[] args)
        {
            ApiService api = new ApiService(Properties.Settings.ApiDomain);
            UserResponse u = api.GetUser(5);
            UsersResponse us = api.GetUsers();

            Console.ReadLine();
        }

        void Bind()
        {
            //IKernel kernel = new StandardKernel();
        }
    }
}
