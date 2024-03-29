using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using todoApi.Data;

var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);


builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.MapControllers();

app.Run();