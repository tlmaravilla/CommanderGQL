using CommanderGQL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanderGQL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Platform> Platforms { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder
            //    .Entity<Attendee>()
            //    .HasIndex(a => a.UserName)
            //    .IsUnique();

            //// Many-to-many: Session <-> Attendee
            //modelBuilder
            //    .Entity<SessionAttendee>()
            //    .HasKey(ca => new { ca.SessionId, ca.AttendeeId });

            //// Many-to-many: Speaker <-> Session
            //modelBuilder
            //    .Entity<SessionSpeaker>()
            //    .HasKey(ss => new { ss.SessionId, ss.SpeakerId });
        }
    }
}
