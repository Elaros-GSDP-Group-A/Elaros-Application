using ElarosApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElarosApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<PatientModel> Patients { get; set; }
        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<Activities> Activities { get; set; }
        public DbSet<Breathlessness> Breathlessness { get; set; }
        public DbSet<Anxiety> Anxiety { get; set; }
        public DbSet<Cognition> Cognition { get; set; }
        public DbSet<Continence> Continence { get; set; }
        public DbSet<Communication> Communication { get; set; }
        public DbSet<Consumption> Consumption { get; set; }
        public DbSet<Depression> Depression { get; set; }
        public DbSet<Employment> Employment { get; set; }
        public DbSet<Fatigue> Fatigue { get; set; }
        public DbSet<Mobility> Mobility { get; set; }
        public DbSet<OverallHealth> OverallHealth { get; set; }
        public DbSet<Pain> Pain { get; set; }
        public DbSet<PersonalCare> PersonalCare { get; set; }
        public DbSet<Ptsd> Ptsd { get; set; }
        public DbSet<SocialRole> SocialRole { get; set; }
        public DbSet<Voice> Voice { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PatientModel>().HasOne(q => q.Question);
        }
    }
}
