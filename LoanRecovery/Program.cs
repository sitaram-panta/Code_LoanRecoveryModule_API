using LoanRecovery.AutoMigration;
using LoanRecovery.Data;
using LoanRecovery.Interfaces;
using LoanRecovery.Migrations.Models;
using LoanRecovery.Models;
using LoanRecovery.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Serilog;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("MyPolicy", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod();  //enabling cors 
    });
});

Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(builder.Configuration)
            .Enrich.FromLogContext()    
            .CreateLogger();

builder.Host.UseSerilog(Log.Logger);

Log.Information("Getting the motors running...");

try
{
    // Add services to the container.

    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddScoped<IAuctionableRepo, AuctionableLoanRepo>();
    builder.Services.AddScoped<IRemindableLoans, RemindableLoansRepo>();
    builder.Services.AddScoped<IAuctionBidder, AuctionBidderRepo>();
    builder.Services.AddScoped<IAuctionPaymentsRepo, AuctionPaymentRepo>();
    builder.Services.AddScoped<IBranchRepo, BranchRepo>();
    builder.Services.AddScoped<ICompanyInfoRepo, CompanyInfoRepo>();
    builder.Services.AddScoped<ICompanyShareholderRepo, CompanyShareholderRepo>();
    builder.Services.AddScoped<IDefaulter, DefaulterRepo>();
    builder.Services.AddScoped<IGeneralCompanyPersonEntity, GeneralCompanyPersonRepo>();
    builder.Services.AddScoped<ILegalNoticeableLoansRepo, LegalNoticeableLoanRepo>();
    builder.Services.AddScoped<ILegalNoticeSentLog, LegalNoticeSentLogRepo>();
    builder.Services.AddScoped<ILoanFacilitiesRepo, LoanFacilityRepo>();
    builder.Services.AddScoped<ILoanGuaranterRepo, LoanGuaranterRepo>();
    builder.Services.AddScoped<ILoanMemberRepo, LoanMemberRepo>();
    builder.Services.AddScoped<ILoanPaymentLog, LoanPaymentLogRepo>();
    builder.Services.AddScoped<ILoanReminderRepo, LoanReminderLogRepo>();
    builder.Services.AddScoped<ILoanSecuritiesRepo, LoanSecuritiesRepo>();
    builder.Services.AddScoped<IpersonalInfoRepo, PersonalInfoRepo>();
    builder.Services.AddScoped<IFollowUpRepo, FollowUpRepo>();
    builder.Services.AddScoped<DefaulterPageServiceRepo>();
    builder.Services.AddScoped<PaymentPageServiceRepo>();
    builder.Services.AddScoped<FollowUpPageServiceRepo>();
    builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
    builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

    // Adding Authentication
    builder.Services.AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;//this can be optional
    })
        // Adding Jwt Bearer
        .AddJwtBearer(options =>
        {
            options.SaveToken = true;//this can also be optional
            options.RequireHttpsMetadata = false;//this can also be optional
            options.TokenValidationParameters = new TokenValidationParameters()
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidAudience = builder.Configuration["JWT:ValidAudience"],
                ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
            };
        });

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(options =>
    {
        options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
            Description = "JWT Authorization header using the Bearer scheme. Example: 'Bearer {token}'",
            Name = "Authorization",
            In = ParameterLocation.Header,
            Type = SecuritySchemeType.Http,
            Scheme = "bearer",
            BearerFormat = "JWT"
        });

        options.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                },
                new string[] { }
            }
            });


    });

    var app = builder.Build();
    app.UseCors("MyPolicy");

    using (var scope = app.Services.CreateScope())//AutoMigration
    {
        var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        Auto_Mig.Initialize(dbContext);
    }

    // Configure the HTTP request pipeline.
    //if (app.Environment.IsDevelopment())
    //{
    app.UseSwagger();
        app.UseSwaggerUI();
    //}

    app.UseHttpsRedirection();
    app.UseAuthentication();
    app.UseAuthorization();
    app.UseStaticFiles();
    app.UseDefaultFiles();
    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Host terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}
