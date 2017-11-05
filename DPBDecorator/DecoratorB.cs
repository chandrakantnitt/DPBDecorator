namespace DPBDecorator
{
    internal class DecoratorB : IComponent, IAdditionalBehaviorB
    {
        IComponent component;
        public DecoratorB(IComponent component)
        {
            this.component = component;
        }
        public string Operation()
        {
            return $"DecoratorB -> {component.Operation()} and listening to music";
        }

        public string AdditionalBehaviorB()
        {
            return $"DecoratorB Added Behavior";
        }
    }
}