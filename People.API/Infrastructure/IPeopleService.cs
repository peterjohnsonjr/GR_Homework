using People.Client.Models;
using System.Collections.Generic;

namespace People.API.Infrastructure
{
    public interface IPeopleService
    {
        List<Record> GetPeopleList();

        List<Record> GetPeopleListByGender();

        List<Record> GetPeopleListByBirthdate();

        List<Record> GetPeopleListByName();

        List<Record> AddToPeopleList(string delimitedPersonRecord);
    }
}
