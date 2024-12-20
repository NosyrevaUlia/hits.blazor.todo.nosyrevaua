﻿using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
    public class MemoryDataService : IDataService
    {
        private static IEnumerable<TaskItem> Tasks { get; } =
        [
            new () {Id = 1, Title="Task", Description = "Task 1 Description", CreatedDate=DateTime.Now},
            new () {Id = 2, Title="Task", Description = "Task 2 Description", CreatedDate=DateTime.Now},
            new () {Id = 3, Title="Task", Description = "Task 3 Description", CreatedDate=DateTime.Now},
        ];

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TaskItem>> GetAllAsync()
        {
            await Task.Delay(1000);
            return await Task.FromResult(Tasks);
        }

        public Task<TaskItem> GetTaskAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(TaskItem item)
        {
            throw new NotImplementedException();
        }
    }
}
