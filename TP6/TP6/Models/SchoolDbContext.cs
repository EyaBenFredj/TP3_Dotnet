﻿using Microsoft.EntityFrameworkCore;

namespace SchoolAPI.Models
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
            : base(options)
        { }

        public DbSet<School> Schools { get; set; }
    }
}