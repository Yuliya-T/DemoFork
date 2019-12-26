﻿using System.Collections.Generic;

namespace BulbaCourses.Podcasts.Data.Models
{
    public class AudioDb
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public CourseDb Course { get; set; }
        public ICollection<CommentDb> Comments { get; set; }
    }
}