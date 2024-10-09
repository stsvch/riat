﻿namespace RatingService.Model
{
    public class Review
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; } // Например, от 1 до 5
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
