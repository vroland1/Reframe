﻿using ReframeModel.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReframeModel.Entities
{
    public class CognitiveDistortion : IEntityBase
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
