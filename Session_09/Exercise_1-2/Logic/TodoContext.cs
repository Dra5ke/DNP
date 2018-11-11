using Microsoft.EntityFrameworkCore;

namespace Exercise_1_2
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }

        public DbSet<TodoItem> TodoItems {get; set;}
    }
}