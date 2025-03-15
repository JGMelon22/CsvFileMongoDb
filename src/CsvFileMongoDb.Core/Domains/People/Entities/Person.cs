using CsvFileMongoDb.Core.Domains.People.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CsvFileMongoDb.Core.Domains.People.Entities;

public class Person
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public Gender Gender { get; set; }
    public string BirthDay { get; set; } = string.Empty;

    public Person()
    {
    }

    public Person(string? id, string firstName, string lastName, string email, string cpf, string phone, Gender gender, string birthDay)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Cpf = cpf;
        Phone = phone;
        Gender = gender;
        BirthDay = birthDay;
    }
}
