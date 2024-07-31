
namespace EcoAcceso.Core.Application.Dtos.Notifications
{
    public class CreateNotificationDto
    {
        public int UserID { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }
    }
}
