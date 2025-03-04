﻿using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using ToDoApp.Models;

namespace ToDoApp.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
