using Microsoft.EntityFrameworkCore;
using NotesManagement.DAL.DbContexts;
using NotesManagement.DAL.Users;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<NoteDbContext>(c => c.UseInMemoryDatabase("Server=.; Initial Catalog=NotesManagement; Integrated Security = SSPI; TrustServerCertificate=True"));
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
