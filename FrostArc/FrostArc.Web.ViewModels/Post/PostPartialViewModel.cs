namespace FrostArc.Web.ViewModels.Post
{
    public class PostPartialViewModel : PostAllViewModel
    {
        public PostPartialViewModel(PostAllViewModel post)
        {
            Id = post.Id;
            Title = post.Title;
            Content = post.Content;
            ImageUrl = post.ImageUrl;
            Likes = post.Likes;
            Dislikes = post.Dislikes;
            User = post.User;
            UserId = post.UserId;
            Comments = post.Comments;
            Community = post.Community;
        }

        public string CommunityId { get; set; } = null!;
    }
}
