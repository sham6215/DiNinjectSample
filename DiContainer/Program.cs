using DiContainer.Di;
using DiContainer.Models.Api;
using DiContainer.Services;
using DiContainer.Services.Resources;
using Ninject;
using Ninject.Parameters;
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
            IKernel container = new StandardKernel(new DiModuleHttp());
            ApiService api = container.Get<ApiService>();
            UserResponse u = api.GetUser(5);
            UsersResponse us = api.GetUsers();

            Console.ReadLine();
        }
    }
}
