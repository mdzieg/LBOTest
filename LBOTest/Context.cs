using System;
using LBOTest.Model;
using LBOTest.Model.Configurations;
using Microsoft.EntityFrameworkCore;

namespace LBOTest;

public class Context : DbContext
{
    public DbSet<AttachmentData> AttachmentData { get; set; }

    public Context(string connectionString) : base(GetOptions(connectionString))
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new AttachmentDataConfiguration().Configure(modelBuilder.Entity<AttachmentData>());
    }

    private static DbContextOptions GetOptions(string connectionString)
    {
        var ob = new DbContextOptionsBuilder();
        ob.LogTo(Console.WriteLine);
        
        return SqlServerDbContextOptionsExtensions.UseSqlServer(ob, connectionString)
            .Options;
    }
}