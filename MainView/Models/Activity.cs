using System;
using System.Xml;

namespace MainView.Models
{
    public class Activity : ICategory
    {
        private UniqueId? id;
        private string name;
        private DateOnly createdOn;
        private string? createdBy;
        private DateOnly lastModifiedOn;

        public UniqueId Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateOnly CreatedOn { get => createdOn; set => createdOn = value; }
        public string CreatedBy { get => createdBy; set => createdBy = value; }
        public DateOnly LastModifiedOn { get => lastModifiedOn; set => lastModifiedOn = value; }
    }
}
