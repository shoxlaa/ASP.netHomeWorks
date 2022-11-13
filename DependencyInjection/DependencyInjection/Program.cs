using DependencyInjection.Services.Classes;
using DependencyInjection.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddTransient<IShow, AspNet>();
//builder.Services.AddTransient<IShow, TextFile>();
builder.Services.AddTransient<IDevice, PC>();
//builder.Services.AddTransient<IDevice, Phone>();
//builder.Services.AddTransient<IFileType, JsonFileType>();
//builder.Services.AddTransient<IFileType, TxtFileType>();
var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
