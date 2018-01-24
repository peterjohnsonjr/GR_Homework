using System;
using System.Runtime.Serialization;

namespace People.Client.Models
{
    [DataContract]
    public class Record
    {
        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string Gender { get; set; }

        [DataMember]
        public string FavoriteColor { get; set; }

        [DataMember]
        public DateTime DateOfBirth { get; set; }
    }
}
