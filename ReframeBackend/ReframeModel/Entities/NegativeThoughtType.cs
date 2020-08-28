using System;
using System.Collections.Generic;
using System.Text;

namespace ReframeModel.Entities
{
    public class NegativeThoughtType
    {
        public int CognitiveDistortionId { get; set; }

        public virtual CognitiveDistortion CognitiveDistortion { get; set; }

        public int ThoguhtLogId { get; set; }

        public virtual ThoughtLog ThoughtLog { get; set; }
    }
}
