using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public static class PersonExstention
    {
        public enum InformationAmount
        {
            NoInfo,
            City,
            LastName,
            LastNameCity,
            MiddleName,
            MiddleNameCity,
            MiddleNameLastName,
            MiddleNameLastNameCity,
            FirstName,
            FirstNameCity,
            FirstNameLastName,
            FirstNameLastNameCity,
            FirstNameMiddleName,
            FirstNameMiddleNameCity,
            FirstNameMiddleNameLastName,
            FirstNameMiddleNameLastNameCity
        }

        public static InformationAmount GetInformationAmount(this Person person, string city)
        {
            if(person.FirstName == "" && person.MiddleName=="" && person.LastName=="" && city=="")
                return InformationAmount.NoInfo;
            if(person.FirstName == "" && person.MiddleName=="" && person.LastName=="")
                return InformationAmount.City;
            if(person.FirstName == "" && person.MiddleName=="" && city == "")
                return InformationAmount.LastName;
            if(person.FirstName == "" && person.MiddleName == "")
                return InformationAmount.LastNameCity;
            if(person.FirstName == "" && person.LastName == "" && city == "")
                return InformationAmount.MiddleName;
            if(person.FirstName == "" && person.LastName=="")
                return InformationAmount.MiddleNameCity;
            if(person.FirstName == "" && city == "")
                return InformationAmount.MiddleNameLastName;
            if(person.FirstName == "")
                return InformationAmount.MiddleNameLastNameCity;
            if(person.MiddleName=="" && person.LastName=="" && city == "")
                return InformationAmount.FirstName;
            if(person.MiddleName=="" && person.LastName=="")
                return InformationAmount.FirstNameCity;
            if(person.MiddleName=="" && city=="")
                return InformationAmount.FirstNameLastName;
            if(person.MiddleName=="")
                return InformationAmount.FirstNameLastNameCity;
            if(person.LastName=="" && city =="")
                return InformationAmount.FirstNameMiddleName;
            if(person.LastName=="")
                return InformationAmount.FirstNameMiddleNameCity;
            if(city=="")
                return InformationAmount.FirstNameMiddleNameLastName;
            return InformationAmount.FirstNameMiddleNameLastNameCity;
        }       
    }
}
