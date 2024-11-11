using BookManagementDomain.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookManagement.Services.Interfaces
{
    public interface IUserServices
    {
        Task<IEnumerable<User>> GetUsersAsync();      // 获取所有用户
        Task<User> GetUserByIdAsync(int id);         // 根据ID获取单个用户
        Task AddUserAsync(User user);                // 添加用户
        Task UpdateUserAsync(User user);             // 更新用户
        Task RemoveUserAsync(int id);                // 根据ID删除用户
    }
}
