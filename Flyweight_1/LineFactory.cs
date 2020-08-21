using System.Collections.Generic;


namespace Flyweight_1
{
    //Далее, «Фабрика» для создания отрезков (RedLine и GreenLine).
    //Внутри «Фабрики» содержится словарь (Dictionary), который реализует пул доступных линий.
    //При первом вызове GetLine в фабрике происходит создание подходящего объекта,
    //и он помещается в пул объектов. При последующих обращениях к «Фабрике»,
    //метод GetLine возвращает уже существующий объект.

    public class LineFactory
    {
        static Dictionary<string, IDrawLineAPI> lines = new Dictionary<string, IDrawLineAPI>();

        public static IDrawLineAPI GetLine(string lineType)
        {
            switch (lineType)
            {
                case "Red":
                    if (!lines.ContainsKey("Red"))
                    {
                        lines["Red"] = new RedLine();
                    }
                    return lines["Red"];
                case "Green":
                    if (!lines.ContainsKey("Green"))
                    {
                        lines["Green"] = new GreenLine();
                    }
                    return lines["Green"];
                default:
                    break;
            }
            return null;
        }
    }
}