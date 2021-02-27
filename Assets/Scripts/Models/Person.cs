using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person
{
    // Basic Facts
    public string first_name;
    public string last_name;
    public int age;
    public int birth_year;
    public int birth_month;
    public int birth_day;
    
    // Family
    public List<Person> children;

    // Job
    public Job current_job;
}
