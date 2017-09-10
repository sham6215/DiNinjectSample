using DiContainer.Models.Api;

namespace DiContainer.Services
{
    interface IApiService
    {
        UserResponse GetUser(int Id);
        UsersResponse GetUsers();
    }
}