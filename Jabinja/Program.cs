//using Microsoft.EntityFrameworkCore;
//using Microsoft.IdentityModel.Tokens;
//using System.Text;

//var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddControllers();
//builder.Services.AddSwaggerGen();

////builder.Services.AddDbContext<ApplicationDbContext>(options =>
////    options.UseSqlServer(
////        builder.Configuration.GetConnectionString("DefaultConnection")
////    ));

////builder.Services.AddSingleton<IPasswordHasherService, PasswordHasherService>();
////builder.Services.AddSingleton<IJwtService, JwtService>();


////var jwtSecret = builder.Configuration.GetSection("Settings:JwtSecret").Value!;
////var issuer = builder.Configuration.GetSection("Settings:Issuer").Value!;
////var audience = builder.Configuration.GetSection("Settings:Audience").Value!;

////builder.Services.AddAuthentication()
////    .AddJwtBearer(opt =>
////    {
////        opt.TokenValidationParameters = new()
////        {
////            ValidIssuer = issuer,
////            ValidAudience = audience,
////            ClockSkew = TimeSpan.Zero,
////            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSecret)),
////            ValidateLifetime = true,
////            RequireExpirationTime = true,
////            ValidateIssuer = true,
////            ValidateAudience = true,
////            ValidateIssuerSigningKey = true
////        };
////    });

//var app = builder.Build();



//app.UseSwaggerUI();

//app.UseHttpsRedirection();
//app.UseAuthentication();
////app.UseAuthorization();
//app.MapControllers();
//app.Run();



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Swagger Gen
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger UI
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

