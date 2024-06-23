using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OrganicAtelier.BLL.Abstract;
using OrganicAtelier.BLL.Concrete;
using OrganicAtelier.DAL.Abstract;
using OrganicAtelier.DAL.Concrete.EfCore;
using OrganicAtelier.WEBUI.Identity;
using OrganicAtelier.WEBUI.Mapping;

namespace OrganicAtelier.WEBUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddAutoMapper(typeof(MapProfile));

            builder.Services.AddDbContext<AppIdentityDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("IdentityConnection")));

            builder.Services.AddIdentity<AppUser, IdentityRole>()
                .AddEntityFrameworkStores<AppIdentityDbContext>()
                .AddDefaultTokenProviders();

            //Configure Identity
            builder.Services.Configure<IdentityOptions>(options =>
            {
                //password
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = true;

                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.AllowedForNewUsers = true;


                //user
                options.User.RequireUniqueEmail = true;
                //options.User.AllowedUserNameCharacters = "";

                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;

            });


            //Configure Cookie
            builder.Services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/Login";
                options.LogoutPath = "/Account/Logout";
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.SlidingExpiration = true;
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = "Organic.Security.Cookie",
                    SameSite = SameSiteMode.Strict //Oturumu serverdan kullanýcý browserýna taþýdýk
                };
            });



            builder.Services.AddScoped<IProductService, ProductManager>();
            builder.Services.AddScoped<IProductDal, EfCoreProductDal>();

            builder.Services.AddScoped<IProductTypeService, ProductTypeManager>();
            builder.Services.AddScoped<IProductTypeDal, EfCoreProductTypeDal>();

            builder.Services.AddScoped<IProductDetailService, ProductDetailManager>();
            builder.Services.AddScoped<IProductDetailDal, EfCoreProductDetailDal>();

            builder.Services.AddScoped<ISliderService, SliderManager>();
            builder.Services.AddScoped<ISliderDal, EfCoreSliderDal>();

            builder.Services.AddScoped<IAboutService, AboutManager>();
            builder.Services.AddScoped<IAboutDal, EfCoreAboutDal>();

            builder.Services.AddScoped<IClientService, ClientManager>();
            builder.Services.AddScoped<IClientDal, EfCoreClientDal>();

            builder.Services.AddScoped<IFeatureService, FeatureManager>();
            builder.Services.AddScoped<IFeatureDal, EfCoreFeatureDal>();

            builder.Services.AddScoped<IBlogService, BlogManager>();
            builder.Services.AddScoped<IBlogDal, EfCoreBlogDal>();

            builder.Services.AddScoped<IContactService, ContactManager>();
            builder.Services.AddScoped<IContactDal, EfCoreContactDal>();

            builder.Services.AddScoped<IStatisticService, StatisticManager>();
            builder.Services.AddScoped<IStatisticDal, EfCoreStatisticDal>();

            builder.Services.AddScoped<IMailService, MailManager>();
            builder.Services.AddScoped<IMailDal, EfCoreMailDal>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication(); //Kimliklendirme
            app.UseRouting();

            app.UseAuthorization(); // Yetkilendirme

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


      

            app.Run();
        }
    }
}
