using System;

namespace DecoratorPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the base component
            IComponent<string> baseComponent = new ConcreteComponent();
            // ConcreteComponent baseComponents = new ConcreteComponent();

            // Create decorators
            IComponent<string> plainDecorator = new PlainDecorator(baseComponent);
            IComponent<string> upperCaseDecorator = new UpperCaseDecorator(baseComponent);
            IComponent<string> colorDecorator = new ColorDecorator(baseComponent);

            // Call GetText() on each and print the results
            Console.WriteLine("Base Component:");
            Console.WriteLine(baseComponent.GetText());

            Console.WriteLine("\nPlain Decorator:");
            Console.WriteLine(plainDecorator.GetText());

            Console.WriteLine("\nUpperCase Decorator:");
            Console.WriteLine(upperCaseDecorator.GetText());

            Console.WriteLine("\nColor Decorator:");
            Console.WriteLine(colorDecorator.GetText());

            Console.WriteLine("\nResponse:");
            Console.WriteLine(new ConcreteComponent().GetAnswer());
        }
    }
}
