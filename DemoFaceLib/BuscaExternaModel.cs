using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFaceLib
{
    
        public class Address
        {
            public string Typology { get; set; }
            public string AddressCore { get; set; }
            public string Number { get; set; }
            public string Complement { get; set; }
            public string Neighborhood { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string ZipCode { get; set; }
            public string Country { get; set; }
        }

        public class Phone
        {
            public string CountryCode { get; set; }
            public string AreaCode { get; set; }
            public string Number { get; set; }
            public string Complement { get; set; }
        }

        public class ExtraInformation
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        public class Contact
        {
            public Address Address { get; set; }
            public Phone Phone { get; set; }
            public List<ExtraInformation> ExtraInformation { get; set; }
            public string ContactType { get; set; }
        }

        public class RelatedPeoples
        {
            public string IdNumber { get; set; }
            public string Name { get; set; }
            public string Birthdate { get; set; }
            public string Gender { get; set; }
            public string Key { get; set; }
            public string EntityType { get; set; }
            public string RelationshipType { get; set; }
            public List<object> Contacts { get; set; }
            public List<object> Emails { get; set; }
            public List<object> Websites { get; set; }
            public List<object> RelatedPeople { get; set; }
            public List<object> RelatedCompanies { get; set; }
            public List<object> DetailedEmails { get; set; }
            public List<object> ExtraInformation { get; set; }
            public List<object> CreditData { get; set; }
            public int NameMatch { get; set; }
        }

        public class ExtraInformation2
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        public class RelatedCompany
        {
            public string IdNumber { get; set; }
            public string OfficialName { get; set; }
            public string BusinessName { get; set; }
            public string FoundingDate { get; set; }
            public string Key { get; set; }
            public string EntityType { get; set; }
            public string RelationshipType { get; set; }
            public List<object> Contacts { get; set; }
            public List<object> Emails { get; set; }
            public List<object> Websites { get; set; }
            public List<object> RelatedPeople { get; set; }
            public List<object> RelatedCompanies { get; set; }
            public List<object> DetailedEmails { get; set; }
            public List<ExtraInformation2> ExtraInformation { get; set; }
            public List<object> CreditData { get; set; }
            public int NameMatch { get; set; }
        }

        public class ExtraInformation3
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        public class DetailedEmail
        {
            public string Email { get; set; }
            public List<ExtraInformation3> ExtraInformation { get; set; }
        }

        public class ExtraInformation4
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        public class Person
        {
            public string IdNumber { get; set; }
            public string Name { get; set; }
            public string Birthdate { get; set; }
            public string Gender { get; set; }
            public string Key { get; set; }
            public string EntityType { get; set; }
            public string RelationshipType { get; set; }
            public List<Contact> Contacts { get; set; }
            public List<string> Emails { get; set; }
            public List<object> Websites { get; set; }
            public List<RelatedPeoples> RelatedPeople { get; set; }
            public List<RelatedCompany> RelatedCompanies { get; set; }
            public List<DetailedEmail> DetailedEmails { get; set; }
            public List<ExtraInformation4> ExtraInformation { get; set; }
            public List<object> CreditData { get; set; }
            public int NameMatch { get; set; }
        }

        public class Entity
        {
            public string SourceName { get; set; }
            public List<Person> People { get; set; }
            public List<object> Companies { get; set; }
            public List<object> PublicEntities { get; set; }
            public List<object> Content { get; set; }
            public List<object> ExtraEntities { get; set; }
        }

        public class BuscaExterna
        {
            public List<Entity> Entities { get; set; }
        }

        public class ResultBigData
        {
            public bool ExecutionError { get; set; }
            public string ErrorMessage { get; set; }

            public string QueryId { get; set; }

            public string OperationResult { get; set; }
        }
    }
