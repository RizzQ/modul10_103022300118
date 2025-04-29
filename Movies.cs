namespace modul10_103022300118
{
    public class Movies
    {
        public string Title { get; set; }

        public string Director { get; set; }
        public List<String> Stars { get; set; }

        public string Description { get; set; }
        
        public Movies(string title, string director, List<String> stars, string description)
        {
            Title = title;
            Director = director;
            Stars = stars;
            Description = description;
        }
    }
}
