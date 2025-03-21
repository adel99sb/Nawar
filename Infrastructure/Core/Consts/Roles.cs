using System.Runtime.Serialization;

namespace Infrastructure.Core.Consts
{
    public enum Roles
    {
        [EnumMember(Value = "Student")]
        Student,
        [EnumMember(Value = "Admin")]
        Admin,
        [EnumMember(Value = "Professor")]
        Professor,
        [EnumMember(Value = "HeadOfDepartment")]
        HeadOfDepartment,
        [EnumMember(Value = "Dean")]
        Dean,
        [EnumMember(Value = "ExamOfficer")]
        ExamOfficer,
        [EnumMember(Value = "YearSupervisor")]
        YearSupervisor
    }
}
