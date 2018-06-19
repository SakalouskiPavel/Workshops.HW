using System.Data.Entity.ModelConfiguration;
using Rocket.DAL.Common.DbModels.Notification;

namespace Rocket.DAL.Configurations.Notification
{
    public class NotificationsLogMap : EntityTypeConfiguration<NotificationsLogEntity>
    {
        public NotificationsLogMap()
        {
            ToTable("NotificationsLog")
                .HasKey(p => p.Id);

            Property(p => p.ReleaseId)
                .IsRequired();

            Property(p => p.CreationDate)
                .IsRequired();
        }
    }
}
