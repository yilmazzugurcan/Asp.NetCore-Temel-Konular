namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();

        static Repository()
        {
            _courses = new List<Course>()
            {
            new Course() {
                Id=1,
                Title="Aspnet Kursu",
                Description="Katılımınızı Bekliyoruz",
                Image="1.png",
                Tags = new string[] {"aspnet","web geliştirme"},
                isActive=true,
                isHome=true
                },
            new Course() {
                Id=2, Title="Php Kursu",
                Description="Katılımınızı Bekliyoruz",
                Image="2.png",
                Tags = new string[] {"Laravel","web geliştirme"},
                isActive=false,
                isHome=true
                },
            new Course() {
                Id=3,
                Title="Django Kursu",
                Description="Katılımınızı Bekliyoruz",
                Image="3.png",
                Tags = new string[] {"Phyton","web geliştirme"},
                isActive=true,
                isHome=false
                },
            new Course() {
                Id=4,
                 Title="Java Kursu",
                 Description="Katılımınızı Bekliyoruz",
                 Image="3.png",
                 Tags = new string[] {"Spring","web geliştirme"},
                 isActive=true,
                isHome=true}
            };
        }

        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }

        public static Course? GetById(int id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }

    }
}