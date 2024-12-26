using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTORY
{

	class Program
	{
		static void Main(string[] args)
		{
			AnimalFactory dogfactory = new DogFactory();
			IAnimal dog1 = dogfactory.CreateAnimal();
			dog1.Speak();
			AnimalFactory catFactory = new CatFactory();
			IAnimal cat1 = catFactory.CreateAnimal();
			cat1.Speak();
		}
	}
	interface IAnimal
	{
		void Speak();
	}
	abstract class AnimalFactory
	{
		public abstract IAnimal CreateAnimal();
	}
	class DogFactory : AnimalFactory
	{
		public override IAnimal CreateAnimal()
		{
			return new Dog();
		}
	}
	class CatFactory : AnimalFactory
	{
		public override IAnimal CreateAnimal()
		{
			return new Cat();
		}
	}
	class Dog : IAnimal
	{
		public void Speak()
		{
			Console.WriteLine("Dog Speak");
		}
	}
	class Cat : IAnimal
	{

		public void Speak()
		{
			Console.WriteLine("Cat Speak");
		}
	}
}
