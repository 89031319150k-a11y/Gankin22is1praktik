
using System;

namespace Lab1_Variant9
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Создаем объект класса Rectangle
            Rectangle rect = new Rectangle();

            // 2. Задаем значения полям объекта
            rect.height = 2;
            rect.width = 3;

            // 3. Выводим данные объекта на экран
            rect.Show();

            // 4. Рассчитываем и выводим периметр
            double p = rect.Perimetr();
            Console.WriteLine($"Периметр прямоугольника = {p}");

            Console.ReadKey();
        }
    }

    class Rectangle
    {
        // Открытые поля для хранения высоты и ширины
        public double height;
        public double width;

        // Метод для вывода данных о прямоугольнике
        public void Show()
        {
            Console.WriteLine($"Прямоугольник: высота = {height}, ширина = {width}");
        }

        // Метод расчета периметра: (2 * высота + 2 * ширина)
        public double Perimetr()
        {
            return 2 * height + 2 * width;
        }
    }
}