using System.Net;

namespace Application.Interfaces;

public interface IDepartmentService
{
    Task<HttpStatusCode> AddDepartment { get; }
    
    Task<HttpStatusCode> GetDepartment { get; }
    
    Task<HttpStatusCode> UpdateDepartment { get; }
    
    Task<HttpStatusCode> DeleteDepartment { get; }
    
    Task<HttpStatusCode> GetAllDepartment { get; }
    
}