using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiContainer.Models.Api;
using DiContainer.Services;
using Ninject;

namespace DiContainer.Decorator
{
    class ApiAuthDecorator : DecoratorBase<IApiService>, IApiService
    {
        public UserResponse GetUser(int Id)
        {
            return (UserResponse)Invoke(nameof(GetUser), Id);
        }

        public UsersResponse GetUsers()
        {
            return (UsersResponse)Invoke(nameof(GetUsers));
        }
    }
}
