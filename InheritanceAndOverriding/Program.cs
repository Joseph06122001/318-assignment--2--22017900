Animal animal = new Animal();
Animal dog = new Dog();
Animal cat = new Cat();

animal.MakeSound();
dog.MakeSound();
cat.MakeSound();

class Animal
{
	public virtual void MakeSound()
	{
		Console.WriteLine("Some generic sound");
	}
}

class Dog : Animal
{
	public override void MakeSound()
	{
		Console.WriteLine("Bark");
	}
}

class Cat : Animal
{
	public override void MakeSound()
	{
		Console.WriteLine("Meow");
	}
}
