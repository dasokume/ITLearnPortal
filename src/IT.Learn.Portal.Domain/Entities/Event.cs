using IT.Learn.Portal.Domain.Common;

namespace IT.Learn.Portal.Domain.Entities
{
    public class Event : AuditableEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Source { get; set; }
    }
}