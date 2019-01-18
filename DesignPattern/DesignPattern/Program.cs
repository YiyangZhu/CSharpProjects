using System;
using DesignPattern.ObserverPattern;
using DesignPattern.ObserverPatternPractice;
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

            CompanyData Data = new CompanyData();
            CurrentConditionsDisplayTwo currentConditionsDisplayTwo = new CurrentConditionsDisplayTwo(Data);
            StatisticsDisplayTwo statisticsDisplayTwo = new StatisticsDisplayTwo(Data);

            Data.setData(11, 1);
            Data.setData(23, 3);
            Data.setData(19, 3);

        }
    }
}
