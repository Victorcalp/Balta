
namespace Balta.NotificationContext
{
    public sealed class Notification
    {
        public Notification(string proprerty, string message)
        {
            Proprerty = proprerty;
            Message = message;
        }

        public string Proprerty { get; set; }
        public string Message { get; set; }
    }
}