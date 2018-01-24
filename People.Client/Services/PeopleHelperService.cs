using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using People.Client.Models;

namespace People.Client.Services
{
    public static class PeopleHelperService
    {
        private static List<Record> _records;

        private static List<Record> ReadDataFromFiles()
        {
            _records = new List<Record>();

            var path = Path.GetDirectoryName(Assembly.GetAssembly(typeof(PeopleHelperService)).EscapedCodeBase);
            if (path == null) return _records;

            var directoryPath = $@"{path.Substring(path.IndexOf(@"\", StringComparison.Ordinal) + 1)}\delimitedFiles";
            if (!Directory.Exists(directoryPath)) return _records;

            var files = Directory.GetFiles(directoryPath);
            foreach (var file in files)
            {
                _records.AddRange(File.ReadAllLines(file).Select(ProcessDelimitedStringRecord));
            }
            return _records;
        }

        public static Record ProcessDelimitedStringRecord(string delimitedStringRecord)
        {
            var values = delimitedStringRecord.Split(',', '|', '\t');
            var record = new Record
            {
                LastName = values[0],
                FirstName = values[1],
                Gender = values[2],
                FavoriteColor = values[3],
                DateOfBirth = DateTime.Parse(values[4])
            };
            return record;
        }

        public static List<Record> Records => _records ?? ReadDataFromFiles();

        public static List<Record> RecordsByGender =>
            Records.OrderBy(rec => rec.Gender).ThenBy(rec => rec.LastName).ToList();

        public static List<Record> RecordsByBirthday => Records.OrderBy(rec => rec.DateOfBirth).ToList();

        public static List<Record> RecordsByName =>
            Records.OrderBy(rec => rec.LastName).ThenBy(rec => rec.FirstName).ToList();
    }
}
