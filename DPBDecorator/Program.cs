using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPBDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent component = new Component();
            IComponent decoratorA = new DecoratorA(component)                   ;
            IComponent decoratorB = new DecoratorB(component)                   ;
            IComponent decAB =      new DecoratorA(new DecoratorB(component));
            IComponent decBA =      new DecoratorB(new DecoratorA(component));
            Display("1. Basic component: ", component);
            Display("2. Basic DecoratorA: ", decoratorA);
            Display("3. Basic DecoratorB: ", decoratorB);
            Display("5. Additional DecoratorA: ", decoratorA);
            Display("6. Additional DecoratorB: ", decoratorB);
            Display("7. Additional DecoratorA: ", decAB);
            Display("8. Additional DecoratorA: ", decBA);
            DisplayAdditionalBehavior("9. Additional DecoratorA: ", new DecoratorA(component)                );
            DisplayAdditionalBehavior("10. Additional DecoratorB: ",new DecoratorB(component)                );
            DisplayAdditionalBehavior("11. Additional DecoratorA: ",new DecoratorA(new DecoratorB(component)));
            DisplayAdditionalBehavior("12. Additional DecoratorA: ", new DecoratorB(new DecoratorA(component)));
            Console.ReadKey();
        }

        private static void Display(string v, IComponent component)
        {
            Console.WriteLine($"{v} {component.Operation()}");
        }
        private static void Display(string v, IAdditionalBehaviorA component)
        {
            Console.WriteLine($"{v} {component.AdditionalBehaviorA()}");
        }
        private static void Display(string v, IAdditionalBehaviorB component)
        {
            Console.WriteLine($"{v} {component.AdditionalBehaviorB()}");
        }

        private static void DisplayAdditionalBehavior(string v, IAdditionalBehaviorA component)
        {
            Console.WriteLine($"{v} {component.AdditionalBehaviorA()}");
        }
        private static void DisplayAdditionalBehavior(string v, IAdditionalBehaviorB component)
        {
            Console.WriteLine($"{v} {component.AdditionalBehaviorB()}");
        }
    }
}
