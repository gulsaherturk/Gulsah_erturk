using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace dining_out.Models.DbModels
{
    public partial class diningoutContext : DbContext
    {
        public diningoutContext()
        {
        }

        public diningoutContext(DbContextOptions<diningoutContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BookTableAttendee> BookTableAttendees { get; set; }
        public virtual DbSet<BookTableOrderedItem> BookTableOrderedItems { get; set; }
        public virtual DbSet<BookTablePaymentTransaction> BookTablePaymentTransactions { get; set; }
        public virtual DbSet<BookTableRezervation> BookTableRezervations { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<MenuItemCategory> MenuItemCategories { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=127.0.0.1;port=3306;uid=root;pwd=password;database=dining-out");
                optionsBuilder.UseLazyLoadingProxies();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookTableAttendee>(entity =>
            {
                entity.ToTable("BookTableAttendee");

                entity.HasIndex(e => e.BooktableRezervationId, "BookTableAttendee_BookTableRezervation_id_fk");

                entity.HasIndex(e => e.UserId, "BookTableAttendee_User_id_fk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BooktableRezervationId).HasColumnName("booktable_rezervation_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.BooktableRezervation)
                    .WithMany(p => p.BookTableAttendees)
                    .HasForeignKey(d => d.BooktableRezervationId)
                    .HasConstraintName("BookTableAttendee_BookTableRezervation_id_fk");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BookTableAttendees)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("BookTableAttendee_User_id_fk");
            });

            modelBuilder.Entity<BookTableOrderedItem>(entity =>
            {
                entity.ToTable("BookTableOrderedItem");

                entity.HasIndex(e => e.RezervationId, "BookTableOrderedItem_BookTableRezervation_id_fk");

                entity.HasIndex(e => e.MenuItemId, "BookTableOrderedItem_MenuItem_id_fk");

                entity.HasIndex(e => e.MenuId, "BookTableOrderedItem_Menu_id_fk");

                entity.HasIndex(e => e.RestaurantId, "BookTableOrderedItem_Restaurant_id_fk");

                entity.HasIndex(e => e.UserId, "BookTableOrderedItem_User_id_fk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MenuId).HasColumnName("menu_id");

                entity.Property(e => e.MenuItemId).HasColumnName("menu_item_id");

                entity.Property(e => e.OrderedDate)
                    .HasColumnType("date")
                    .HasColumnName("ordered_date");

                entity.Property(e => e.RestaurantId).HasColumnName("restaurant_id");

                entity.Property(e => e.RezervationId).HasColumnName("rezervation_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .HasColumnName("status");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.BookTableOrderedItems)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("BookTableOrderedItem_Menu_id_fk");

                entity.HasOne(d => d.MenuItem)
                    .WithMany(p => p.BookTableOrderedItems)
                    .HasForeignKey(d => d.MenuItemId)
                    .HasConstraintName("BookTableOrderedItem_MenuItem_id_fk");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.BookTableOrderedItems)
                    .HasForeignKey(d => d.RestaurantId)
                    .HasConstraintName("BookTableOrderedItem_Restaurant_id_fk");

                entity.HasOne(d => d.Rezervation)
                    .WithMany(p => p.BookTableOrderedItems)
                    .HasForeignKey(d => d.RezervationId)
                    .HasConstraintName("BookTableOrderedItem_BookTableRezervation_id_fk");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BookTableOrderedItems)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("BookTableOrderedItem_User_id_fk");
            });

            modelBuilder.Entity<BookTablePaymentTransaction>(entity =>
            {
                entity.ToTable("BookTablePaymentTransaction");

                entity.HasIndex(e => e.MenuOrderedItemId, "BookTablePaymentTransaction_BookTableOrderedItem_id_fk");

                entity.HasIndex(e => e.RezervationId, "BookTablePaymentTransaction_BookTableRezervation_id_fk");

                entity.HasIndex(e => e.MenuId, "BookTablePaymentTransaction_Menu_id_fk");

                entity.HasIndex(e => e.PayerUserId, "BookTablePaymentTransaction_User_id_fk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CardHolder)
                    .HasMaxLength(200)
                    .HasColumnName("card_holder");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(200)
                    .HasColumnName("card_number");

                entity.Property(e => e.CardSecurityNumber)
                    .HasMaxLength(200)
                    .HasColumnName("card_security_number");

                entity.Property(e => e.CardValidDate)
                    .HasMaxLength(200)
                    .HasColumnName("card_valid_date");

                entity.Property(e => e.CartType)
                    .HasMaxLength(100)
                    .HasColumnName("cart_type");

                entity.Property(e => e.MenuId).HasColumnName("menu_id");

                entity.Property(e => e.MenuOrderedItemId).HasColumnName("menu_ordered_item_id");

                entity.Property(e => e.PayerUserId).HasColumnName("payer_user_id");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("payment_date");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(10,0)")
                    .HasColumnName("price");

                entity.Property(e => e.RezervationId).HasColumnName("rezervation_id");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.BookTablePaymentTransactions)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("BookTablePaymentTransaction_Menu_id_fk");

                entity.HasOne(d => d.MenuOrderedItem)
                    .WithMany(p => p.BookTablePaymentTransactions)
                    .HasForeignKey(d => d.MenuOrderedItemId)
                    .HasConstraintName("BookTablePaymentTransaction_BookTableOrderedItem_id_fk");

                entity.HasOne(d => d.PayerUser)
                    .WithMany(p => p.BookTablePaymentTransactions)
                    .HasForeignKey(d => d.PayerUserId)
                    .HasConstraintName("BookTablePaymentTransaction_User_id_fk");

                entity.HasOne(d => d.Rezervation)
                    .WithMany(p => p.BookTablePaymentTransactions)
                    .HasForeignKey(d => d.RezervationId)
                    .HasConstraintName("BookTablePaymentTransaction_BookTableRezervation_id_fk");
            });

            modelBuilder.Entity<BookTableRezervation>(entity =>
            {
                entity.ToTable("BookTableRezervation");

                entity.HasIndex(e => e.RestaurantId, "BookTableRezervation_Restaurant_id_fk");

                entity.HasIndex(e => e.RezervationUserId, "BookTableRezervation_User_id_fk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AttendeeNumber).HasColumnName("attendee_number");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .HasColumnName("description");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasColumnName("email");

                entity.Property(e => e.NameLastname)
                    .HasMaxLength(200)
                    .HasColumnName("name_lastname");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(200)
                    .HasColumnName("phone_number");

                entity.Property(e => e.RestaurantId).HasColumnName("restaurant_id");

                entity.Property(e => e.RezervationCreatedDatetime)
                    .HasColumnType("date")
                    .HasColumnName("rezervation_created_datetime");

                entity.Property(e => e.RezervationDate)
                    .HasColumnType("date")
                    .HasColumnName("rezervation_date");

                entity.Property(e => e.RezervationStatus)
                    .HasMaxLength(100)
                    .HasColumnName("rezervation_status");

                entity.Property(e => e.RezervationTime).HasColumnName("rezervation_time");

                entity.Property(e => e.RezervationUserId).HasColumnName("rezervation_user_id");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.BookTableRezervations)
                    .HasForeignKey(d => d.RestaurantId)
                    .HasConstraintName("BookTableRezervation_Restaurant_id_fk");

                entity.HasOne(d => d.RezervationUser)
                    .WithMany(p => p.BookTableRezervations)
                    .HasForeignKey(d => d.RezervationUserId)
                    .HasConstraintName("BookTableRezervation_User_id_fk");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("Menu");

                entity.HasIndex(e => e.RestaurantId, "Menu_Restaurant_id_fk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .HasColumnName("description");

                entity.Property(e => e.MenuName)
                    .HasMaxLength(2000)
                    .HasColumnName("menu_name");

                entity.Property(e => e.RestaurantId).HasColumnName("restaurant_id");

                entity.Property(e => e.Statu)
                    .HasMaxLength(20)
                    .HasColumnName("statu");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.Menus)
                    .HasForeignKey(d => d.RestaurantId)
                    .HasConstraintName("Menu_Restaurant_id_fk");
            });

            modelBuilder.Entity<MenuItem>(entity =>
            {
                entity.ToTable("MenuItem");

                entity.HasIndex(e => e.CategoryId, "MenuItem_MenuItemCategory_id_fk");

                entity.HasIndex(e => e.MenuId, "MenuItem_Menu_id_fk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.MenuId).HasColumnName("menu_id");

                entity.Property(e => e.MenuItemDescription)
                    .HasMaxLength(2000)
                    .HasColumnName("menu_item_description");

                entity.Property(e => e.MenuItemIngredients)
                    .HasMaxLength(2000)
                    .HasColumnName("menu_item_ingredients");

                entity.Property(e => e.MenuItemName)
                    .HasMaxLength(2000)
                    .HasColumnName("menu_item_name");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(10,0)")
                    .HasColumnName("price");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.MenuItems)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("MenuItem_MenuItemCategory_id_fk");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.MenuItems)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("MenuItem_Menu_id_fk");
            });

            modelBuilder.Entity<MenuItemCategory>(entity =>
            {
                entity.ToTable("MenuItemCategory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(200)
                    .HasColumnName("category_name");
            });

            modelBuilder.Entity<Restaurant>(entity =>
            {
                entity.ToTable("Restaurant");

                entity.HasIndex(e => e.UserId, "Restaurant_User_id_fk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(300)
                    .HasColumnName("address");

                entity.Property(e => e.Capacity).HasColumnName("capacity");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .HasColumnName("city");

                entity.Property(e => e.CityId).HasColumnName("cityId");

                entity.Property(e => e.CoverImg)
                    .HasMaxLength(1000)
                    .HasColumnName("cover_img");

                entity.Property(e => e.Desc)
                    .HasMaxLength(1000)
                    .HasColumnName("desc");

                entity.Property(e => e.District)
                    .HasMaxLength(200)
                    .HasColumnName("district");

                entity.Property(e => e.DistrictId).HasColumnName("districtId");

                entity.Property(e => e.Logo)
                    .HasMaxLength(300)
                    .HasColumnName("logo");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.SystemDefinitionName)
                    .HasMaxLength(200)
                    .HasColumnName("system_definition_name");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Restaurants)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("Restaurant_User_id_fk");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(300)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .HasColumnName("password");

                entity.Property(e => e.Surname)
                    .HasMaxLength(300)
                    .HasColumnName("surname");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .HasColumnName("user_name");

                entity.Property(e => e.UserType)
                    .HasMaxLength(100)
                    .HasColumnName("user_type");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
