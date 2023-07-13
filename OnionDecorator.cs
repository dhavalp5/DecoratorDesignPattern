namespace DecoratorDesignPattern
{
    public class OnionDecorator : PizzaDecorator
    {
        public OnionDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\r\n extra Onions";
            return type;
        }
    }
}
