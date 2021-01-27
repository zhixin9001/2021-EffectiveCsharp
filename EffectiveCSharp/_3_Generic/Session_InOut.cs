namespace EffectiveCSharp._3_Generic
{
  using System;
  using System.Collections.Generic;

  public class Session_InOut
  {
    public static void Entry()
    {
      CoVariant();
      ContraVariant();
    }

    private static void CoVariant()
    {
      var dog = new Dog();
      Animal animal = dog;

      // var dogs=new List<Dog>();
      // List<Animal> animals = dogs;

      IEnumerable<Dog> enumDog = new List<Dog>();
      IEnumerable<Animal> enumAnimal = enumDog;

      Func<Dog> funcDog = () => new Dog();
      Func<Animal> funcAnimal = funcDog;

      // var dogTest1=new Test1<Dog>();
      // ITest1<Animal> animalTest1 = dogTest1;
    }

    private static void ContraVariant()
    {
      var dog = new Dog();
      Animal animal = dog;

      // var animals = new List<Animal>();
      // List<Dog> dogs = animals;

      Action<Animal> actAnimal = a => _ = animal.Name;
      Action<Dog> actDog = actAnimal;

      // var animalTest1=new Test1<Animal>();
      // ITest1<Dog> dogTest1 = animalTest1;
    }
  }

  public interface ITest1<T>
  {
  }

  public class Test1<T> : ITest1<T>
  {
  }
}