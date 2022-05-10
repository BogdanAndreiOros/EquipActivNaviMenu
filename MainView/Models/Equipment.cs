﻿using System;
using System.Xml;

namespace MainView.Models
{
    public enum Type
    {
        WaterSports,BallSports, Clothes,Accesories,Others
    }

    public class Equipment : ICategory
    {
        private string name;
        private Type type;
        private int quantity;
        private DateOnly createdOn;
        private string createdBy;
        private DateOnly lastModifiedOn;

        public UniqueId Id { get; set; }
        public string Name { get => name; set => name = value; }
        public Type Type { get => type; set => type = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public DateOnly CreatedOn { get => createdOn; set => createdOn = value; }
        public string CreatedBy { get => createdBy; set => createdBy = value; }
        public DateOnly LastModifiedOn { get => lastModifiedOn; set => lastModifiedOn = value; }
    }
}