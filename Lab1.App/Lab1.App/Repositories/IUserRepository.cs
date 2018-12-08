using Lab1.App.Models.Requests;
using Lab1.App.Models.Responses;
using System.Threading.Tasks;

namespace Lab1.App.Repositories
{
    public interface IUserRepository
    {
        Task<UserFullDto> Login(UserDto user);
    }
}
