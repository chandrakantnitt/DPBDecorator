namespace DPBDecorator
{
    internal class DecoratorA : IComponent, IAdditionalBehaviorA
    {
        IComponent component;
        public DecoratorA(IComponent component)
        {
            this.component = component;
        }
        public string Operation()
        {
            return $"DecoratorA -> {component.Operation()} and walking";
        }

        public string AdditionalBehaviorA()
        {
            return $"DecoratorA Added Behavior";
        }
    }
}