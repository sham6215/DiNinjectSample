using DiContainer.Models.Api;

namespace DiContainer.Services
{
    interface IApiResource
    {
        string RootUrl { get; }
        string GetUser(int Id);
        string GetUsers();
    }
}