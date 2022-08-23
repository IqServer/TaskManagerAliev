using Microsoft.EntityFrameworkCore;
using Serilog;
using services;
using testnet;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((ctx, lc) => lc
    .WriteTo.Console()
    .Enrich.WithProperty("Firma", "fir3")
    .WriteTo.Seq("http://localhost:5341")
    );
    
builder.Services.AddCors(options => options.AddPolicy("AllowAll",
    builder =>
    {
        builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    }));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<BoardService>();
builder.Services.AddScoped<ArchiveCardService>();
builder.Services.AddScoped<ChatUserService>();
builder.Services.AddScoped<TaskCardService>();
builder.Services.AddScoped<WorkSpaceService>();



ConfigurationManager configuration = builder.Configuration;

builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseNpgsql(configuration.GetConnectionString("Db"));
}
);
var app = builder.Build();



    app.UseSwagger();
    app.UseSwaggerUI();

    app.UseRouting();
    app.UseCors("AllowAll");


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
