using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExcelInterop.WebApi
{
    public class Todo
    {
        [DataMember(Name = "userId")]
        public int UserId { get; set; }

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "title")]
        public string Tittle { get; set; }

        [DataMember(Name = "completed")]
        public bool Completed { get; set; }
    }
}
