namespace Infrastructure.Core.DTOs.Requestes
{
    public class StudentStatusRequest
    {
        public string StudentEmail { get; set; }
        public string Status { get; set; } // مثال: "ناجح", "راسب", "مفصول"
    }

}
