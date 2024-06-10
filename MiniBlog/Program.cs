
using Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

DatabaseManager db = new DatabaseManager();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
