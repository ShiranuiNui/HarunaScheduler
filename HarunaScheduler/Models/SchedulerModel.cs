using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HarunaScheduler.Models
{
    public class SchedulerModel:DbContext
    {
        DbSet<Schedule> Schedules { get; set; }
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=scheduler.db");
        }
    }
    public class Schedule
    {
        public int Id { get; set; }
        public int Title { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime StopTime { get; set; }
    }
}
