using System;
using DesignPattern.DecoratePattern;
using DesignPattern.DecoratorPatternPractice;
using DesignPattern.IteratorPattern;
using DesignPattern.IteratorPatternPractice;
using DesignPattern.ObserverPattern;
using DesignPattern.ObserverPatternPractice;
using DesignPattern.SingletonPattern;
using DesignPattern.StatePattern;
using DesignPattern.StatePatternPractice;
using DesignPattern.StrategyPattern;
using DesignPattern.StrategyPatternPractice;

namespace DesignPattern
{
    class Program
    {
        private static void PrintMenu(Iterator iterator)
        {
            while (iterator.HasNext())
            {
                string menuItem = iterator.Next();
                Console.WriteLine(menuItem);
            }
        }

        private static void PrintInventory(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }

        }

        static void Main(string[] args)
        {
            //MallardDuck mallard = new MallardDuck();
            //RubberDuck rubberDuck = new RubberDuck();
            //DecoyDuck decoyDuck = new DecoyDuck();

            //mallard.Display();
            //mallard.PerformFly();
            //mallard.PerformQuack();

            //rubberDuck.Display();
            //rubberDuck.PerformFly();
            //rubberDuck.PerformQuack();

            //decoyDuck.Display();
            //decoyDuck.PerformFly();
            //decoyDuck.PerformQuack();

            //ModelDuck modelDuck = new ModelDuck();
            //modelDuck.SetFlyBehavior(new FlyWithRocketPower());
            //modelDuck.SetQuackBehavior(new Mute());
            //modelDuck.PerformFly();
            //modelDuck.PerformQuack();

            //Bat bat = new Bat();
            //bat.Display();
            //bat.PerformSleep();
            //bat.PerformEat();

            //Giraffe giraffe = new Giraffe();
            //giraffe.Display();
            //giraffe.PerformSleep();
            //giraffe.PerformEat();

            //Elephant elephant = new Elephant();
            //elephant.Display();
            //elephant.PerformSleep();
            //elephant.PerformEat();

            //Sloth sloth = new Sloth();
            //sloth.SetSleepBehavior(new SleepNormalDuration());
            //sloth.SetEatingBehavior(new EatPlant());
            //sloth.Display();
            //sloth.PerformSleep();
            //sloth.PerformEat();



            ////Weather Station
            //WeatherData weatherData = new WeatherData();

            //CurrentConditonsDisplay currentConditonsDisplay = new CurrentConditonsDisplay(weatherData);
            //StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);

            //weatherData.SetMeasurements(80, 65, 30.4f);
            //weatherData.SetMeasurements(82, 70, 29.2f);
            //weatherData.SetMeasurements(78, 90, 29.2f);

            //CompanyData Data = new CompanyData();
            //CurrentConditionsDisplayTwo currentConditionsDisplayTwo = new CurrentConditionsDisplayTwo(Data);
            //StatisticsDisplayTwo statisticsDisplayTwo = new StatisticsDisplayTwo(Data);

            //Data.setData(11, 1);
            //Data.setData(23, 3);
            //Data.setData(19, 3);



            //Beverage beverage = new Espresso();
            //Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

            //Beverage beverage2 = new HouseBlend();
            //CondimentDecorator beverage3 = new Soy(beverage2);
            //beverage3 = new Mocha(beverage3);
            //Console.WriteLine(beverage3.GetDescription() + " $" + beverage3.Cost());

            //Meal meal = new ChickenMeal();
            //Console.WriteLine(meal.GetDescription() + " $" + meal.GetCost());
            //VegetableDecorator vegMeal1 = new Carrot(meal);
            //Console.WriteLine(vegMeal1.GetDescription() + " $" + vegMeal1.GetCost());

            //Meal meal2 = new BeefMeal();
            //Console.WriteLine(meal2.GetDescription() + " $" + meal2.GetCost());
            //VegetableDecorator vegMeal2 = new Carrot(meal2);
            //Console.WriteLine(vegMeal2.GetDescription() + " $" + vegMeal2.GetCost());
            //VegetableDecorator vegMeal3 = new Mushroom(vegMeal2);
            //Console.WriteLine(vegMeal3.GetDescription() + " $" + vegMeal3.GetCost());



            //Singleton singleton = Singleton.GetInstance();
            //Console.WriteLine(singleton.GetDescription());

            //SingletonThreadSafeOne singletonThreadSafeOne = SingletonThreadSafeOne.GetInstance();
            //Console.WriteLine(singletonThreadSafeOne.GetDescription());

            //SingletonThreadSafeTwo singletonThreadSafeTwo = SingletonThreadSafeTwo.Instance;
            //Console.WriteLine(singletonThreadSafeTwo.GetDescription());

            //SingletonThreadSafeThree singletonThreadSafeThree = SingletonThreadSafeThree.Instance();
            //Console.WriteLine(singletonThreadSafeThree.GetDescription());

            //SingletonThreadSafeFour singletonThreadSafeFour = SingletonThreadSafeFour.Instance;
            //Console.WriteLine(singletonThreadSafeFour.GetDescription());

            //SingltonThreadSafeFive singletonThreadSafeFive = SingltonThreadSafeFive.Instance;
            //Console.WriteLine(singletonThreadSafeFive.GetDescription());



            //GumballMachine gumballMachine = new GumballMachine(5);
            //Console.WriteLine(gumballMachine);
            //gumballMachine.InsertQuarter();
            //gumballMachine.TurnCrank();
            //Console.WriteLine(gumballMachine);

            //Car car1 = new Car();
            //car1.SetState(new ParkState(car1));
            //Console.WriteLine(car1.GetState());
            //car1.Accelerate();
            //car1.Decelerate();
            //car1.Stop();
            //car1.Start();
            //Console.WriteLine(car1.GetState());
            //car1.Accelerate();
            //car1.Decelerate();
            //car1.Start();
            //car1.Stop();
            //Console.WriteLine(car1.GetState());



            //DinerMenu dinerMenu = new DinerMenu();
            //dinerMenu.AddItem("Cake");
            //PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            //pancakeHouseMenu.AddItem("Strawberry Pancakes");

            //Iterator pancakeIterator = pancakeHouseMenu.CreateIterator();
            //Iterator dinerIterator = dinerMenu.CreateIterator();

            //Console.WriteLine("\nMenu (with iterators)\n---\nBREAKFAST");
            //PrintMenu(pancakeIterator);
            //Console.WriteLine("\nLUNCH");
            //PrintMenu(dinerIterator);

            ClothesInventory clothesInventory = new ClothesInventory();
            IIterator clothesIterator = clothesInventory.CreateInventory();

            Console.WriteLine("\nInventory (with iterators)\n---\nCLOTHES");
            PrintInventory(clothesIterator);

            FurnitureInventory furnitureInventory = new FurnitureInventory();
            IIterator furnitureIterator = furnitureInventory.CreateInventory();

            Console.WriteLine("\n---\nFURNITURES");
            PrintInventory(furnitureIterator);

        }

    }
}
