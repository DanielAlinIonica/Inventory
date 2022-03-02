﻿namespace InventoryModels.Dtos
{
    public class ItemDto
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Name,-25} | {Description}";
        }
    }
}
