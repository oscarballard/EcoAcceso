using EcoAccesso.Core.Domain.Entities;
using EcoAccesso.Infrastruture.Persistence.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EcoAccesso.Infrastruture.Persistence.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<PermissionRequest> PermissionRequests { get; set; }
        public DbSet<PermissionRequest> ProtectedAreas { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Weather> Weathers { get; set; }
        public DbSet<VisitHistory> VisitHistories { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<MaintenanceEvent> MaintenanceEvents { get; set; }
        public DbSet<IncidentReport> IncidentReports { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ProtectedAreaMap());
        }
    }
}
