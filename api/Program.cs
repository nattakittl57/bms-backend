using System.Text;
using api.Data;
using api.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Add Controllers
builder.Services.AddControllers();

// Add DbContext with SQL Server
builder.Services.AddDbContext<BmsDataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BmsConnection")));

// Register Services
builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<SearchService>();

// Configure JWT Authentication
var jwtSettings = builder.Configuration.GetSection("JwtSettings");
var secretKey = jwtSettings["SecretKey"];

builder.Services.AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtSettings["Issuer"],
            ValidAudience = jwtSettings["Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey!))
        };
    });

builder.Services.AddAuthorization();

// Add CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    
    app.MapGet("/", (HttpContext context) =>
    {
        var request = context.Request;

        var scheme = request.Scheme;          // http หรือ https
        var host = request.Host.Host;         // localhost
        var port = request.Host.Port;         // 5000 / 5001 ฯลฯ

        var baseUrl = $"{scheme}://{host}:{port}";

        return $"Base URL: {baseUrl}";
    });
}

app.UseHttpsRedirection();
app.UseDefaultFiles();  // Enable default file handling
app.UseStaticFiles();   // Serve static files from wwwroot

// Use CORS
app.UseCors("AllowAll");

// Use Authentication & Authorization
app.UseAuthentication();
app.UseAuthorization();



app.MapControllers();

// Catch-all route for React SPA
app.MapFallbackToFile("/index.html");
app.Run();
