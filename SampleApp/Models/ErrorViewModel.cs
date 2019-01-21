// Comment added to feature1 branch.
// Comment added to development/test2 branch.
// Comment added to development/test3 branch.
// Comment added to development/feature3 branch. 
// Comment added to development/test3 and feature3 branches again.
using System;

namespace SampleApp.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}