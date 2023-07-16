using Infrasctructure.Persistance;
using Microsoft.EntityFrameworkCore;
using WebApi.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.ConfigureEndpoints();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});
var app = builder.Build();

app.UseSwagger();
app.UseRouting();
app.UseSwaggerUI();


app.MapGet("", context =>
{
    context.Response.Redirect("./swagger/index.html", permanent: false);
    return Task.FromResult(0);
});
app.UseEndpoints(p => p.MapControllers());
app.Run();