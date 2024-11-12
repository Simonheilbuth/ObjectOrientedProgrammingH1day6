using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingH1day6.Files;

internal class User
{
    public string firstName { get; set; }

    public string lastName { get; set; }

    public int age { get; set; }

    public string email { get; set; }


    public User(string firstName, string lastName, int age, string email)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.email = email;
    }
}



