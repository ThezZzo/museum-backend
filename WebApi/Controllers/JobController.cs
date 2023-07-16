using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApi.Services.Job;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JobController : ControllerBase
{
    private readonly IJobService _service;

    public JobController(IJobService jobService)
    {
        _service = jobService;
    }

    [HttpGet]
    public async Task<IEnumerable<Job>> Get(CancellationToken cancellationToken) =>
        await _service.GetAllJob(cancellationToken);

    [HttpPost]
    public async Task<bool> Post(Job job, CancellationToken cancellationToken) =>
        await _service.AddJob(job, cancellationToken);

    
}