using System;
using System.Xml;

namespace MainView.Models
{
    public enum Type
    {
        WaterSports,BallSports, Clothes,Accesories,Others
    }

    public class Equipment
    {
        private string name;
        private Type type;
        private int quantity;
        private DateOnly createdOn;
        private string createdBy;
        private DateOnly lastModifiedOn;

        public string Id { get; set; }
        public string Name { get => name; set => name = value; }
        public Type Type { get => type; set => type = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public DateOnly CreatedOn { get => createdOn; set => createdOn = value; }
        public string CreatedBy { get => createdBy; set => createdBy = value; }
        public DateOnly LastModifiedOn { get => lastModifiedOn; set => lastModifiedOn = value; }

        public Equipment()
        {
            this.createdOn = DateOnly.MaxValue;
            this.quantity = 0;
            this.createdBy = "new";
            this.lastModifiedOn = DateOnly.MinValue;
            this.name = "new entry";
            this.type = Type.Accesories;
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
