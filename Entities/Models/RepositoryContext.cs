using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options)
        : base(options) {}

}