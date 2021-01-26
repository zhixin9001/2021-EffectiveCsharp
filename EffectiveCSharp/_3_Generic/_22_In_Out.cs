namespace EffectiveCSharp._3_Generic
{
  using System;
  using System.Collections.Generic;
  using System.Diagnostics;
  using System.Linq;

  public class _22_In_Out
  {
    private static Animal[] data = new Animal[]
    {
      new Dog(), new Cat(), new Moncky(),
    };
    
    public static void Entry()
    {
      // Covariant(data);
      // UnsafeVariantArray(data);
      Covariant1();
    }

    private static void Covariant1()
    {
      var dog =new Dog();
      Animal animal = dog;
      
      var dogList=new List<Dog>();
      // List<Animal> animals = dogs;
      List<Animal> animals = dogList.Select(a => a as Animal).ToList();
      
      var dogArray=new Dog[3];
      Animal[] animalArray = dogArray;
      
      IEnumerable<Dog> dogEnumberable=new List<Dog>();
      IEnumerable<Animal> animalEnumerable = dogEnumberable;
      IEnumerator<Dog> dogEnumerator =new List<Dog>().GetEnumerator();
      IEnumerator<Animal> animalEnumerator = dogEnumerator;
      
      Func<Dog> funcDog = ()=>new Dog();
      Func<Animal> funcAnimal = funcDog;
      
      Action<Animal> actionAnimal = a => Console.WriteLine(a.Name);
      Action<Dog> actionDog = actionAnimal;
      actionAnimal(new Cat());
      actionDog(new Dog());
      
      Func<Animal,Dog> func1 = a=>a as Dog;
      Func<Dog, Animal> func2 = func1;
      Console.WriteLine(func1(new Dog()).Name);
      // Console.WriteLine(func1(new Cat()).Name);
      Console.WriteLine(func2(new Dog()).Name);
      
      Func<Animal,Cat> func3 = a=>a as Cat;
      Func<Dog, Animal> func4 = func3;
      // Console.WriteLine(func4(new Dog()).Name);
      
      IMyList<Dog> myListDog=new MyList<Dog>();
      IMyList<Animal> myListAnimal = myListDog;
      
      // IMyList<Animal> myListAnimal1 = new MyList<Animal>();
      // IMyList<Dog> myListDog1 = myListAnimal1;
    }
    
    // https://www.cnblogs.com/qixuejia/p/4383068.html
    public interface IMyList<out T>
    {
      T GetEmelent();
      // void Change(T t);
    }
    
    public class MyList<T>: IMyList<T>
    {
      public T GetEmelent()
      {
        throw new NotImplementedException();
      }

      public void Change(T t)
      {
        throw new NotImplementedException();
      }
    }

    private static void Covariant(Animal[] baseItems)
    {
      foreach (var item in baseItems)
      {
        Console.WriteLine($"name: {item.Name}, age: {item.Age}");
      }
    }
    
    private static void UnsafeVariantArray(Animal[] baseItems)
    {
      baseItems[0] = new Moncky();
      
      Animal[] c = new Dog[3];
      c[0] = new Moncky();
    }
    
    
  }

  public abstract class Animal 
  {
    public double Age { get; set; } = new Random().Next(10);
    public virtual string Name { get; set; }
  }

  public class Dog : Animal
  {
    public override string Name { get; set; } = nameof(Dog);
  }

  public class Cat : Animal
  {
    public override string Name { get; set; } = nameof(Cat);
  }

  public class Moncky : Animal
  {
    public override string Name { get; set; } = nameof(Moncky);
  }
}