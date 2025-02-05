using WineCellarAPI.Data;
using WineCellarAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi();
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//add db as data source
builder.Services.AddSqlite<WineCellarContext>("Data Source=WineCellar.db");
builder.Services.AddScoped<WineCellarContext>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.CreateDBIfNotExist();//Extensions.cs
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

//go to /swagger to test api
app.MapGet("/", () => @"Wine Cellar management API. Navigate to /swagger to open the Swagger test UI.");

app.Run();

