
namespace Balta.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url) : base(title, url)
        {
            CarrerItems = new List<CarrerItem>();
        }
        public IList<CarrerItem> CarrerItems { get; set; }
        public int TotalCourses => CarrerItems.Count;
    }
}