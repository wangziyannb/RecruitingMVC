using Microsoft.EntityFrameworkCore;
using RecCore.Contracts.Repositories;
using RecInfrastructure.Data;
using RecInfrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMvc();
builder.Services.AddDbContext<RecDbContext>(options =>
{
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    options.UseSqlServer(builder.Configuration.GetConnectionString("RecDb"));
});
builder.Services.AddScoped<ICandidateRepository, CandidateRepository>();
builder.Services.AddScoped<IEmployeeTypeRepository, EmployeeTypeRepository>();
builder.Services.AddScoped<IJobCategoryRepository, JobCategoryRepository>();
builder.Services.AddScoped<IJobRequirementRepository, JobRequirementRepository>();
builder.Services.AddScoped<IStatusRepository, StatusRepository>();
builder.Services.AddScoped<ISubmissionRepository, SubmissionRepository>();
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

app.MapControllerRoute(
    name: "index", pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
