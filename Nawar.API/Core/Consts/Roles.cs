using System.Runtime.Serialization;

namespace Nawar.API.Core.Consts
{
    public enum Roles
    {
        [EnumMember(Value = "Admin")]
        Admin,
        [EnumMember(Value = "User")]
        User
    }
}
