using System.Collections.Generic;
using System;
namespace AnimalShelter.Models
{

  public class Animal
  {
    public int AnimalId {get; set;}
    public string Name {get;set;}
    public string Gender {get;set;}
    public string Breed {get;set;}
    public DateTime DateAdmitted {get;set;}
    //
    //public static List<Animal> ourAnimals = new List<Animal>{};

    
    //
    public string Type {get;set;} // not sure if it goes here or needs to be own class

    public Animal()
    {
      
    }
    public Animal(int animalId, string name, string gender, string breed, DateTime dateAdmitted, string type)
    {
      AnimalId = animalId;
      Name = name;
      Gender = gender;
      Breed = breed;
      DateAdmitted = dateAdmitted;
      Type = type;
      
      //
      //ourAnimals.Add(this);
      //
    }
    public static void FeedAllAnimals()
    {
      //this feeds all animals
    }
    public void FeedThisAnimal()
    {
      //this feeds this one animal
    }
      
  }
}