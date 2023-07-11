using Application.Interfaces;
using Domain.Enteties;
using Microsoft.AspNetCore.Mvc;
using WebApi.Services.Job;

namespace WebApi.Controllers;

[ApiController]
public class JobController
{
    private readonly IJobService _service;

    public JobController(IJobService jobService)
    {
        _service = jobService;
    }

    [HttpPost]
    [Route("/api/job")]
    public async Task<IEnumerable<Job>> Jobs(CancellationToken cancellationToken)
    {
        return await _service.GetAllJob(cancellationToken);
    }
}