namespace DecoratorPatternExample
{
    public class ConcreteComponent : IComponent<string>
    {
        public string GetText()
        {
            return "Hello, World!";
        }
    }
}
