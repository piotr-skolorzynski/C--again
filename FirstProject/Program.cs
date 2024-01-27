﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstProject
{
    internal class Program
    {
      static List<Person> GetEmployees()
      {
        List<Person> employees = new List<Person>()
        {
          new Person(new DateTime(1990, 2, 2), "Bill", "Wick"),
          new Person(new DateTime(1995, 6, 3), "John", "Wick"),
          new Person(new DateTime(1996, 4, 3), "Bob", "Wick"),
          new Person(new DateTime(2001, 2, 2), "Bill", "Smith"),
          new Person(new DateTime(2000, 2, 2), "John", "Smith"),
          new Person(new DateTime(2005, 2, 2), "Bob", "Smith"),
          new Person(new DateTime(2003, 2, 2), "Ed", "Smith"),
        };

        return employees;
      }

      private static void Main(string[] args)
      {
        List<Person> employees = GetEmployees();
        //predykat do wyselekcjonowania pracowników w metodzie where
        bool EmployeeIsYoung(Person employee)
        {
          return employee.DateOfBirth > new DateTime(2000, 1, 1);
        }
        List<Person> youngEmployees = employees.Where(EmployeeIsYoung).ToList(); //zwraca nową listę z wyselekcjonowanych pracowników
        //predykat do wyszukania pracownika o imieniu Bob
        bool EmployeeIsBob(Person employee)
        {
          return employee.FirstName == "Bob";
        }
        Person bob = youngEmployees.FirstOrDefault(EmployeeIsBob);
        if (bob != null)
        {
          bob.SayHi();
        }
        else
        {
          Console.WriteLine("Bob not found");
        }

      }
    }
}
