using HelloASPNETCoreDeveloper.Generic.Domain.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPNETCoreDeveloper.Generic.Interfaces.REST.Controllers;

[ApiController]
[Route("[controller]")]
public class WelcomeController : ControllerBase
{
    [HttpGet]
    public string Welcome()
    {
        return WelcomeBuilder.Build(null);
    }

    [HttpGet("{name}")]
    public string Welcome(string name)
    {
        return WelcomeBuilder.Build(name);
    }
    
    
}