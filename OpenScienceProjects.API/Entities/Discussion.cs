namespace OpenScienceProjects.API.Entities;

public class Discussion
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int ProjectId { get; set; }
    public virtual Project Project { get; set; }
    public virtual IList<Comment> DiscussionComments { get; set; }
}