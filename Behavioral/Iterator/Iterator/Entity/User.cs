﻿namespace Iterator.Entity
{
    internal class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Name : {Name}";
        }
    }
}
