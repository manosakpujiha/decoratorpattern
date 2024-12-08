namespace DecoratorPatternExample
{
    public class ConcreteComponent : IComponent<string>
    {
        public string GetText()
        {
            return "Why did the Decorator Pattern break up with the Singleton Pattern?";
        }
        public string GetAnswer()
        {
            return "Because the Singleton couldn’t handle all the layers of commitment! 😄";
        }
    }
}
