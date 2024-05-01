using ForumManagementService;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ForumTopicDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/forumTopic", async (ForumTopicDbContext db, ForumTopic forumTopic) =>
{
    db.ForumTopics.Add(forumTopic);
    await db.SaveChangesAsync();

    return Results.NoContent();
}).WithName("CreateForumTopic").WithOpenApi();

app.MapGet("/forumTopic", (ForumTopicDbContext db) =>
{
    return Results.Ok(db.ForumTopics);
}).WithName("GetAllForumTopicS").WithOpenApi();

app.Run();
