namespace EffectiveCSharp._3_Generic
{
  using System;
  using System.Collections.Generic;

  public class Session_InOut
  {
    public Session_InOut()
    {
    }

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
      
      // var dogTest1=new Test1<Dog>();
      // ITest1<Animal> animalTest1 = dogTest1;

      Func<Dog> funcDog = () => new Dog();
      Func<Animal> funcAnimal = funcDog;
    }

    private static void ContraVariant()
    {
      var dog = new Dog();
      Animal animal = dog;

      // var animals = new List<Animal>();
      // List<Dog> dogs = animals;

      // var animalTest1=new Test1<Animal>();
      // ITest1<Dog> dogTest1 = animalTest1;

      Action<Animal> actAnimal = TestMethod1;
      Action<Dog> actDog = actAnimal;
    }

    public static void TestMethod1(Animal a)
    {
      Console.Write(a.Name);
    }
  }
  

  public interface ITest1<T>
  {
    void TestM2();
  }

  public class Test1<T> : ITest1<T> where T:new ()
  {
    public void TestM2()
    {
      var a= new T();
    }
  }
}