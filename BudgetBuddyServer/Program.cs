


// client_id = 679702ce486f1b002290da9a 
// sandbox = 3b3bde1c081314023b8f53ebf4df19

//Server=tcp:budgetbuddyserver.database.windows.net,1433;Initial Catalog=BudgetBuddyDev;Persist Security Info=False;User ID=SuchySilvio;Password=Silvio09.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;

using BudgetBuddy.DataModel;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<BudgetBuddyDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();