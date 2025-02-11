using Going.Plaid;
using Going.Plaid.Entity;
using Going.Plaid.Accounts;
using Going.Plaid.Transactions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace BudgetBuddyServer.Controllers.PlaidControllers;

[ApiController]
[Route("api/fetch-accounts")]
[Produces("application/json")]
public class FetchController : ControllerBase
{
    private readonly ILogger<FetchController> _logger;
    private readonly PlaidClient _client;
    private readonly BudgetBuddyDbContext _dbContext;

    public FetchController(ILogger<FetchController> logger, PlaidClient client, BudgetBuddyDbContext dbContext)
    {
        _logger = logger;
        _client = client;
        _client.AccessToken = credentials.Value.AccessToken;
        _dbContext = dbContext;
    }

    [HttpGet("balance")]
    public async Task<IActionResult> Balance()
    {
        var response = await _client.AccountsBalanceGetAsync(new AccountsBalanceGetRequest());
       

      

       

        return Ok(response);
    }

    [HttpGet("transactions")]
    public async Task<IActionResult> Transactions()
    {
        var response = await _client.TransactionsSyncAsync();
          
        

      
        return Ok(Response);
    }

}