using Cantracts;
using Library.EntityMaps;
using Library.Persistence;
using Library.Persistence.EFAuthorRepository;
using Library.Persistence.EFBookReposittory;
using Library.Persistence.EFCategoryRepository;
using Library.Persistence.Users;
using Library.Services;
using Library.Services.Author.Cantract;
using Library.Services.Book.Cantract;
using Library.Services.Categories.Cantract;
using Library.Services.User.Cantract;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EfDataContext>();
builder.Services.AddScoped<AuthorService, AuthorAppService>();
builder.Services.AddScoped<AuthorRespository, EFAuthorRepository>();
builder.Services.AddScoped<BookService, BookAppService>();
builder.Services.AddScoped<BookRepository,EFBookRepository>();
builder.Services.AddScoped<CategoryRepository,EFCategoryRepository>();
builder.Services.AddScoped<CaregoryService,CategoryAppService>();
builder.Services.AddScoped<UserRepository, EFUserRepository>();
builder.Services.AddScoped<UserService,UserAppService>();
builder.Services.AddScoped<UnitOfWork, EFUnitOfWork>();



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
