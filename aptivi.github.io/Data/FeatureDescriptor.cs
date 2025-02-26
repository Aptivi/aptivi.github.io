﻿using Microsoft.AspNetCore.Components;

namespace aptivi.github.io.Data
{
    public class FeatureDescriptor
    {
        public string IconClass { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public (EventCallback, string)[] Buttons { get; set; }
    }
}
