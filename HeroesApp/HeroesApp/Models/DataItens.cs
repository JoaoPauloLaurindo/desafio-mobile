﻿using System.Collections.Generic;

namespace HeroesApp.Models
{
    public class DataItens<T>
    {
        public int Offset { get; set; }
        public int Limit { get; set; }
        public int Total { get; set; }
        public int Count { get; set; }
        public List<T> Results { get; set; }
    }
}