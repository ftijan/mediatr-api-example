using Example.MediatR.Api.Context.Models;
using Microsoft.EntityFrameworkCore;

namespace Example.MediatR.Api.Context
{
    public class ApiContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {
        }
    }
}
