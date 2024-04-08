namespace Blog_Application.Models
{
    public class BlogPosts
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string  Content { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }


    }
}
