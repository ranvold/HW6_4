using System;
namespace Decorator.Examples
{
    class MainApp
    {
        static void Main()
        {
            // Create ConcreteComponent and three Decorators
            FirTree firTree = new FirTree();
            ChristmasTree christmasTree = new GarlandOnDecoration(new GarlandDecoration(new StarDecoration(new FirTree())));
            Console.WriteLine(christmasTree.GetDescription()); 

            // Wait for user
            Console.Read();
        }
    }
    // "Component"
    abstract class ChristmasTree
    {
        protected string Description = "";
        public string GetDescription()
        {
            return Description;
        }
    }

    // "ConcreteComponent"
    class FirTree : ChristmasTree
    {
        public FirTree()
        {
            Description = "FirTree";
        }
    }
    // "Decorator"
    abstract class DecoratorBase : ChristmasTree
    {
        protected ChristmasTree christmasTree;

    }

    // "ConcreteDecoratorA"
    class StarDecoration: DecoratorBase
    {
        private ChristmasTree _christmasTree;

        public StarDecoration(ChristmasTree christmasTree)
        {
            _christmasTree = christmasTree;
            Description = _christmasTree.GetDescription() + " +Star";
        }
    }

    // "ConcreteDecoratorB" 
    class GarlandDecoration : DecoratorBase
    {
        private ChristmasTree _christmasTree;

        public GarlandDecoration(ChristmasTree christmasTree)
        {
            _christmasTree = christmasTree;
            Description = _christmasTree.GetDescription() + " +Garland";
        }
    }
    class GarlandOnDecoration : DecoratorBase
    {
        private ChristmasTree _christmasTree;

        public GarlandOnDecoration(ChristmasTree christmasTree)
        {
            _christmasTree = christmasTree;
            Description = _christmasTree.GetDescription() + " +GarlandOn";
        }
    }
}
