using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;


namespace test.Models
{
    [DataContract]

    public class Calculator
    {
        [DataMember(Name = "location")]
        public string Location { get; set; }

        [DataMember(Name = "degree")]
        public float Degree { get; set; }

        [DataMember(Name = "datetime")]
        public DateTime DateTime { get; set; }
    }
}