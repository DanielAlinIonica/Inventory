﻿namespace InventoryModels.Dtos
{
    public class ItemsWithGenresDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;

        public int? GenreId { get; set; }
        public string Genre { get; set; } = "";
        public bool? GenreIsActive { get; set; } = true;
        public bool? GenreIsDeleted { get; set; } = false;

    }
}
