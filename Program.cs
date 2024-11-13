using PaparaIntegration.Interfaces;
using PaparaIntegration.Models.Endpoints;
using PaparaIntegration.Services;
using PaparaIntegration.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<HttpClient>();
builder.Services.AddSingleton<IRedisService, RedisService>();

// Register other services
builder.Services.AddScoped<IMassPaymentService, MassPaymentService>();
builder.Services.AddScoped<IHttpRequestService, HttpRequestService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<ICorporateCardService, CorporateCardService>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var redisService = scope.ServiceProvider.GetRequiredService<IRedisService>();
    try
    {
        ApiEndpoints.ConfigureBaseUrl(redisService);
        Console.WriteLine("Base URL başarıyla yapılandırıldı.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Base URL yapılandırması sırasında hata oluştu: {ex.Message}");
    }
}

app.UseMiddleware<ExceptionHandlingMiddleware>();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();