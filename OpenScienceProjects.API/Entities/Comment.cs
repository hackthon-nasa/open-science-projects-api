namespace OpenScienceProjects.API.Entities;

public class Comment
{
    public int Id { get; set; }
    public string Description { get; set; }
    public int DiscussionId { get; set; }
    public virtual Discussion Discussion { get; set; }
}