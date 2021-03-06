using System;

namespace MainView.Models
{
    public class Activity
    {
        private string id;
        private string name;
        private DateOnly createdOn;
        private string createdBy;
        private DateOnly lastModifiedOn;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string CreatedBy { get => createdBy; set => createdBy = value; }
        public DateOnly CreatedOn { get => createdOn; set => createdOn = value; }
        public DateOnly LastModifiedOn { get => lastModifiedOn; set => lastModifiedOn = value; }
    }
}
