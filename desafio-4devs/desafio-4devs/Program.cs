using desafio_4devs.UseCasses.Users;
using desafio_4devs_entity.Context;
using desafio_4devs_entity.Ioc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Configure CORS
var AllowLocalhost = "AllowLocalhost";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: AllowLocalhost,
        policy => policy
            //.WithOrigins("http://localhost:4200", "https://localhost:4200")
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod());
});

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEntityConfiguration(builder.Configuration);


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(c => c.RegisterServicesFromAssembly(typeof(UsersBaseHandler).Assembly));





var app = builder.Build();

// migrate any database changes on startup (includes initial db creation)
using (var scope = app.Services.CreateScope())
{
    var dataContext = scope.ServiceProvider.GetRequiredService<App4DevsContext>();
    dataContext.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseCors(AllowLocalhost);

app.UseAuthorization();

app.MapControllers();

app.Run();
