using TodoApi.Models;
using System.Collections.Concurrent;

namespace TodoApi.Services
{
    public class TodoService : ITodoService
    {
        private readonly ConcurrentDictionary<int, TodoItem> _todos = new();
        private int _nextId = 1;

        public TodoService()
        {
            SeedData();
        }

        public Task<IEnumerable<TodoItem>> GetAllAsync()
        {
            var todos = _todos.Values.OrderBy(t => t.CreatedAt).AsEnumerable();
            return Task.FromResult(todos);
        }

        public Task<TodoItem?> GetByIdAsync(int id)
        {
            _todos.TryGetValue(id, out var todo);
            return Task.FromResult(todo);
        }

        public Task<TodoItem> CreateAsync(CreateTodoRequest request)
        {
            var todo = new TodoItem
            {
                Id = Interlocked.Increment(ref _nextId),
                Title = request.Title,
                Description = request.Description,
                IsCompleted = false,
                CreatedAt = DateTime.UtcNow
            };

            _todos.TryAdd(todo.Id, todo);
            return Task.FromResult(todo);
        }

        public Task<TodoItem?> UpdateAsync(int id, UpdateTodoRequest request)
        {
            if (!_todos.TryGetValue(id, out var existingTodo))
            {
                return Task.FromResult<TodoItem?>(null);
            }

            existingTodo.Title = request.Title;
            existingTodo.Description = request.Description;

            if (request.IsCompleted && !existingTodo.IsCompleted)
            {
                existingTodo.CompletedAt = DateTime.UtcNow;
            }
            else if (!request.IsCompleted && existingTodo.IsCompleted)
            {
                existingTodo.CompletedAt = null;
            }

            existingTodo.IsCompleted = request.IsCompleted;

            return Task.FromResult<TodoItem?>(existingTodo);
        }

        public Task<bool> DeleteAsync(int id)
        {
            var removed = _todos.TryRemove(id, out _);
            return Task.FromResult(removed);
        }

        private void SeedData()
        {
            var sampleTodos = new[]
            {
                new TodoItem { Id = 1, Title = "Grocery", Description = "Oats, Rice, OIl", IsCompleted = false, CreatedAt = DateTime.UtcNow.AddDays(-2) },
                new TodoItem { Id = 2, Title = "Laundry", Description = "at 4pm", IsCompleted = true, CreatedAt = DateTime.UtcNow.AddDays(-1), CompletedAt = DateTime.UtcNow.AddHours(-2) },
                new TodoItem { Id = 3, Title = "Doctor's Appointment", Description = "at 7pm", IsCompleted = false, CreatedAt = DateTime.UtcNow }
            };

            foreach (var todo in sampleTodos)
            {
                _todos.TryAdd(todo.Id, todo);
            }

            _nextId = 4;
        }
    }
}