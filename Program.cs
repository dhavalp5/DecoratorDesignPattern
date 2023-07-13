using DecoratorDesignPattern;

IPizza pizza = new Pizza();
IPizza cheseDecorator = new CheeseDecorator(pizza);
IPizza tomatoDecorator = new TomatoDecorator(cheseDecorator);
IPizza onionDecorator = new OnionDecorator(tomatoDecorator);
Console.WriteLine(onionDecorator.GetPizzaType());
