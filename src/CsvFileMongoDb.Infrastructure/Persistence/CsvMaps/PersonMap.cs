using CsvFileMongoDb.Core.Domains.People.Entities;
using CsvHelper.Configuration;

namespace CsvFileMongoDb.Infrastructure.Persistence.CsvMaps;

public class PersonMap : ClassMap<Person>
{
    public PersonMap()
    {
        Map(m => m.FirstName).Index(0).Name("first_name");
        Map(m => m.LastName).Index(1).Name("lastname");
        Map(m => m.Email).Index(2).Name("email");
        Map(m => m.Cpf).Index(3).Name("cpf");
        Map(m => m.Phone).Index(4).Name("phone");
        Map(m => m.Gender).Index(5).Name("gender");
        Map(m => m.BirthDay).Index(6).Name("birthDay");
    }
}
