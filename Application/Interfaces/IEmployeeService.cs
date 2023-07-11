using System.Net;

namespace Application.Interfaces;

public interface IEmployeeService
{
    Task<HttpStatusCode> GetAllEmployees { get; } 
    
    Task<HttpStatusCode> GetEmployeeById { get; } 
}