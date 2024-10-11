using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Budget.Models;

namespace Budget.Data
{
    public class BudgetContext : DbContext
    {
        public BudgetContext (DbContextOptions<BudgetContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; } = default!;
        public DbSet<Income> Income { get; set; } = default!;
        public DbSet<Expense> Expense { get; set; } = default!;
        public DbSet<Transaction> Transaction { get; set; } = default!;
        public DbSet<Category> Category { get; set; } = default!;
    }
}
