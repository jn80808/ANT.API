namespace ANT.API.Models.Domain
{
    public class BlogPost
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string content { get; set; }

        public string MyProperty { get; set; }

        public string FeaturedImageUrl { get; set; }

        public string UrlGandle { get; set; }

        public DateTime PublishDate { get; set; }

        public string Author{ get; set; }

        public bool IsVisible { get; set; }


    }
}
