using System;
namespace WestCoastEducation.Models;

public class Person
{
//Properties
public string FirstName {get; set;}
public string LastName {get; set;}
public string PersonIdentityNumber {get; set;}
public string PhoneNumber {get; set;}
public string PostalCode {get; set;}
public string Address {get; set;}
public string City{get; set;}

//Our Person Constructor.....
public Person(string firstName, string lastName, string personIdentityNumber, string phoneNumber, string postalCode, string address, string city)
    {
        FirstName = firstName;
        LastName = lastName;
        PersonIdentityNumber = personIdentityNumber;
        PhoneNumber = phoneNumber;
        PostalCode = postalCode;
        Address = address;
        City = city;
    }

    public override string ToString()
    {
        return $"Name:{FirstName}\nLastname:{LastName}\nContact information: {PhoneNumber}";
    }

}
