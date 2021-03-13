using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Informational_system_Lib.Models
{
    public class CustomerContext : DbContext //Прави се клас наследник на DbContext който ще помогне за създаването на базата данни в MS Sql
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options) // Създава се конструктор използвайки настройките на DbContext
        {

        }
        public DbSet<Customer> Customer { get; set; } //създава се DbContext Configuration  и иметао на тази променлива ще бъде името на  нашета таблица.
    }
}
