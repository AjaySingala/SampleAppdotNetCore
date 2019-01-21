// Comment added to feature1 branch.
// Comment added to development/test2 branch.
using System;

namespace SampleApp.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}