﻿namespace AzureAIServicesDemo.Models.Vision
{
    public class ImagePeople : AIServicesResult
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
