using Microsoft.EntityFrameworkCore;
using RecruitCatGirgastj.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// ✅ Add DbContext with SQLite
builder.Services.AddDbContext<RecruitCatGirgastjContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("RecruitCatGirgastjContext")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.Run();
