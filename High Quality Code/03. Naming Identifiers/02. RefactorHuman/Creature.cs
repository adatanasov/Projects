﻿/* Refactor the following examples to produce code with well-named identifiers in C#:
class Hauptklasse
{
  enum Пол { ултра_Батка, Яка_Мацка };

  class чуек
  {
    public Пол пол { get; set; }
    public string име_на_Чуека { get; set; }
    public int Възраст { get; set; }
  }
  public void Make_Чуек(int магическия_НомерНаЕДИНЧОВЕК)
  {
    чуек new_Чуек = new чуек();
    new_Чуек.Възраст = магическия_НомерНаЕДИНЧОВЕК;
    if (магическия_НомерНаЕДИНЧОВЕК%2 == 0)
    {
      new_Чуек.име_на_Чуека = "Батката";
      new_Чуек.пол = Пол.ултра_Батка;
    }
    else
    {
      new_Чуек.име_на_Чуека = "Мацето";
      new_Чуек.пол = Пол.Яка_Мацка;
    }
  }
} */

using System;

public class Creature
{
    public enum Sex 
    { 
        Male, 
        Female 
    }

    public void MakeHuman(int age)
    {
        Human human = new Human();
        human.Age = age;
        if (age % 2 == 0)
        {
            human.Name = "Male human";
            human.Sex = Sex.Male;
        }
        else
        {
            human.Name = "Female human";
            human.Sex = Sex.Female;
        }
    }

    public class Human
    {
        public Sex Sex { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}