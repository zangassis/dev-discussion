using Microsoft.EntityFrameworkCore;
using UserManagementService;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DevDiscussionContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/user", async (DevDiscussionContext db, User user) =>
{
    db.Users.Add(user);
    await db.SaveChangesAsync();

    return Results.NoContent();
}).WithName("CreateUser").WithOpenApi();

app.MapGet("/user", (DevDiscussionContext db) =>
{
    return Results.Ok(db.Users);
}).WithName("GetAllUsers").WithOpenApi();

app.Run();
