using TodoApi.Models;

namespace TodoApi.Services
{
    public interface ITodoService
    {
        Task<IEnumerable<TodoItem>> GetAllAsync();
        Task<TodoItem?> GetByIdAsync(int id);
        Task<TodoItem> CreateAsync(CreateTodoRequest request);
        Task<TodoItem?> UpdateAsync(int id, UpdateTodoRequest request);
        Task<bool> DeleteAsync(int id);
    }
}