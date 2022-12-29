﻿// <copyright file="ApplicationDbContext.cs" author="Beniamin Jitca">
// Copyright (c) Beniamin Jitca. All rights reserved.
// </copyright>

namespace BlazorShop.Infrastructure.Persistence
{
    /// <summary>
    /// The database context configurations and entities.
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<User, Role, int,
        UserClaim, UserRole, UserLogin,
        RoleClaim, UserToken>, IApplicationDbContext
    {
        /// <summary>
        /// .
        /// </summary>
        /// <param name="options"></param>
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        /// <summary>
        /// .
        /// </summary>
        public DbSet<Cart> Carts { get; set; }

        /// <summary>
        /// .
        /// </summary>
        public DbSet<Clothe> Clothes { get; set; }

        /// <summary>
        /// .
        /// </summary>
        public DbSet<Invoice> Invoices { get; set; }

        /// <summary>
        /// .
        /// </summary>
        public DbSet<Music> Musics { get; set; }

        /// <summary>
        /// .
        /// </summary>
        public DbSet<Order> Orders { get; set; }

        /// <summary>
        /// .
        /// </summary>
        public DbSet<Subscriber> Subscribers { get; set; }

        /// <summary>
        /// .
        /// </summary>
        public DbSet<Subscription> Subscriptions { get; set; }

        /// <summary>
        /// .
        /// </summary>
        public DbSet<Receipt> Receipts { get; set; }

        /// <summary>
        /// .
        /// </summary>
        public DbSet<TodoItem> TodoItems { get; set; }

        /// <summary>
        /// .
        /// </summary>
        public DbSet<TodoList> TodoLists { get; set; }

        /// <summary>
        /// .
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            var result = await base.SaveChangesAsync(cancellationToken);
            return result;
        }

        /// <summary>
        /// .
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.ApplyConfiguration(new RoleClaimConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserClaimConfiguration());
            builder.ApplyConfiguration(new UserLoginConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
            builder.ApplyConfiguration(new UserTokenConfiguration());

            builder.ApplyConfiguration(new CartConfiguration());
            builder.ApplyConfiguration(new ClotheConfiguration());
            builder.ApplyConfiguration(new InvoiceConfiguration());
            builder.ApplyConfiguration(new MusicConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new ReceiptConfiguration());
            builder.ApplyConfiguration(new SubscriberConfiguration());
            builder.ApplyConfiguration(new SubscriptionConfiguration());
            builder.ApplyConfiguration(new TodoItemConfiguration());
            builder.ApplyConfiguration(new TodoListConfiguration());
        }
    }
}
