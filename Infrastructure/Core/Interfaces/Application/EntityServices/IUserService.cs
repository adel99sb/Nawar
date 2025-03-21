using Infrastructure.Core.DTOs.Requestes;
using Infrastructure.Core.DTOs.Responses;

namespace Infrastructure.Core.Interfaces.Application.EntityServices
{
    public interface IUserService
    {
        Task<GeneralResponse> RegisterAsync(RegisterRequestDto registerRequest);
        Task<GeneralResponse> LoginAsync(LoginRequestDto loginRequest);
        Task<GeneralResponse> VerifyEmailAsync(VerifyEmailRequestDto verifyEmailRequestDto);
        Task<GeneralResponse> SendPasswordResetCodeAsync(string email);
        Task<GeneralResponse> ResetPasswordAsync(ResetPasswordRequestDto resetPasswordRequestDto);
        Task<GeneralResponse> ApplyForJob(JobApplicationRequest request);
        Task<GeneralResponse> SetProjectsCount(ProjectsCountRequest request);
        Task<GeneralResponse> AssignHeadOfDepartment(AssignHeadRequest request);
        Task<GeneralResponse> ApproveTeacherApplication(ApproveApplicationRequest request);
        Task<GeneralResponse> CreateStudent(CreateStudentRequest request);
        Task<GeneralResponse> SetStudentStatus(StudentStatusRequest request);
    }
}
