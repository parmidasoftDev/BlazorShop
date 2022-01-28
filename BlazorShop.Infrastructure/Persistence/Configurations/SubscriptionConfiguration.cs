﻿namespace BlazorShop.Infrastructure.Persistence.Configurations
{
    public class SubscriptionConfiguration : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder.ToTable("Subscriptions");
            builder.HasKey(x => x.Id);

            builder.Property(t => t.StripeSubscriptionId)
                .IsRequired();
            builder.Property(t => t.Name)
                .HasMaxLength(200)
                .IsRequired();
            builder.Property(t => t.Price)
                .IsRequired();
            builder.Property(t => t.Currency)
                .HasMaxLength(25)
                .IsRequired();
            builder.Property(t => t.CurrencySymbol)
                .HasMaxLength(5)
                .IsRequired();
            builder.Property(t => t.ChargeType)
                .HasMaxLength(25)
                .IsRequired();
            builder.Property(t => t.Options)
                .HasMaxLength(1000)
                .IsRequired();
            builder.Property(t => t.ImageName)
                .HasMaxLength(200)
                .IsRequired();
            builder.Property(t => t.ImagePath)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
