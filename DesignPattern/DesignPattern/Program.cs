using System;
using DesignPattern.DecoratePattern;
using DesignPattern.DecoratorPatternPractice;
using DesignPattern.ObserverPattern;
using DesignPattern.ObserverPatternPractice;
using DesignPattern.SingletonPattern;
using DesignPattern.StrategyPattern;
using DesignPattern.StrategyPatternPractice;

namespace DesignPattern
{
    class Program
    {
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

            SingletonThreadSafeOne singletonThreadSafeOne = SingletonThreadSafeOne.GetInstance();
            Console.WriteLine(singletonThreadSafeOne.GetDescription());

        }
    }
}
