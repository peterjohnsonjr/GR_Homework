using People.Client.Models;
using System;
using System.Collections.Generic;
using People.Client.Services;

namespace People.API.Infrastructure
{
    public class PeopleService : IPeopleService
    {
        public List<Record> GetPeopleList()
        {
            return PeopleHelperService.Records;
        }

        public List<Record> GetPeopleListByGender()
        {
            return PeopleHelperService.RecordsByGender;
        }

        public List<Record> GetPeopleListByBirthdate()
        {
            return PeopleHelperService.RecordsByBirthday;
        }

        public List<Record> GetPeopleListByName()
        {
            return PeopleHelperService.RecordsByName;
        }

        public List<Record> AddToPeopleList(string delimitedPersonRecord)
        {
            PeopleHelperService.Records.Add(PeopleHelperService.ProcessDelimitedStringRecord(delimitedPersonRecord));
            return PeopleHelperService.Records;
        }
    }
}