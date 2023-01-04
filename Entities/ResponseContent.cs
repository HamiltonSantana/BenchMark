using System;

namespace Entities
{
    public class ResponseContent
    {
        public Customer Customer { get; set; }
        public int Id { get; set; }
        public int Status { get; set; }
        public bool IsCanceled { get; set; }
        public bool IsCompleted { get; set; }
        public bool isCompletedSuccessfully { get; set; }
        public int CreationOptions { get; set; }
        public bool? AsyncState { get; set; }
        public bool IsFaulted { get; set; }
    }
}