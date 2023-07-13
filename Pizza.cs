namespace DecoratorDesignPattern
{
    public class Pizza : IPizza
    {
        public string GetPizzaType()
        {
            return "This is a normal Pizza";
        }
    }
}
