namespace ForumManagementService;
public class ForumTopic
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string Author { get; set; }
    public bool Active { get; set; }
}
