using BookManagement.Services.Interfaces;
using BookManagementDomain.Interfaces;
using BookManagementDomain.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookManagement.Services.Services
{
    public class UserServices : IUserServices
    {
        private readonly IRepository<User> _userRepository;

        // 构造函数注入
        public UserServices(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        // 获取所有用户
        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        // 根据ID获取单个用户
        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        // 添加用户
        public async Task AddUserAsync(User user)
        {
            // 添加业务逻辑，例如验证用户信息
            await _userRepository.AddAsync(user);
        }

        // 更新用户
        public async Task UpdateUserAsync(User user)
        {
            // 添加业务逻辑，例如验证更新信息
            await _userRepository.UpdateAsync(user);
        }

        // 根据ID删除用户
        public async Task RemoveUserAsync(int id)
        {
            // 添加业务逻辑，例如检查用户是否存在
            var user = await _userRepository.GetByIdAsync(id);
            if (user == null)
            {
                throw new KeyNotFoundException($"User with ID {id} not found.");
            }
            await _userRepository.DeleteAsync(id);
        }
    }
}
