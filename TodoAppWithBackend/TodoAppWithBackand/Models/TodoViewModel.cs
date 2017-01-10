using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoAppWithBackand.Models
{
    public class TodoViewModel
    {
        public string Name { get; set; }

        public bool IsCompleted { get; set; }
    }
}