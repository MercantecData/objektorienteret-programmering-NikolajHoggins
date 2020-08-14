using System;
using System.Collections.Generic;

namespace Computer_Library
{
    public interface ISale
    {
        public string GetSalesFeatures();

        public string GetDescription();

        public List<String> TargetAudience();
        
        
    }
}