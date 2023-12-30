﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronsNest.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Series { get; set; }
        public string Description { get; set; }
        public string[] Genres { get; set; }
        public string[] Awards { get; set; }
        public string[] Characters { get; set; }
        public string[] Places { get; set; }
        public string ISBN { get; set; }
        public string ISBN13 { get; set; }
        public string Language { get; set; }
        public DateTime FirstPublishDate { get; set; }
        public DateTime PublishDate { get; set; }
        public int NumPages { get; set; }
        public int NumRatings { get; set; }
        public int NumReviews { get; set; }
        public double AvgRating { get; set; }
        public int Rated1 { get; set; }
        public int Rated2 { get; set; }
        public int Rated3 { get; set; }
        public int Rated4 { get; set; }
        public int Rated5 { get; set; }
    }
}
