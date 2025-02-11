DEV_DB = 'Server=tcp:budgetbuddyserver.database.windows.net,1433;Initial Catalog=BudgetBuddyDev;Persist Security Info=False;User ID=SuchySilvio;Password=Silvio09.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;'

db-model:
	rm -f ./BudgetBuddy.DataModel/*.cs
	dotnet tool restore
	dotnet ef dbcontext scaffold \
	--context BudgetBuddyDbContext \
	--startup-project BudgetBuddy.DataModel \
	--no-onconfiguring \
	--schema "dbo" \
	--project BudgetBuddy.DataModel \
	--force \
	--no-build \
	--verbose \
	$(DEV_DB) \
	Microsoft.EntityFrameworkCore.SqlServer

