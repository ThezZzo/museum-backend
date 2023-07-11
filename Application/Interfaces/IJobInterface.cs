using System.Net;

namespace Application.Interfaces;

public interface IJobInterface
{
    Task<HttpStatusCode> AddJob { get; }
    
    Task<HttpStatusCode> GetAllJob { get; }
    
    Task<HttpStatusCode> GetByIdJob { get; }
    
    Task<HttpStatusCode> UpdateJob { get; }
    
    Task<HttpStatusCode> DeleteJob { get; }
}