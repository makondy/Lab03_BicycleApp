    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_BicycleApp
{
    public class Bicycle
    {
        // Поля класу Bicycle
        public string Brand { get; set; }           
        public string Model { get; set; }           
        public int Year { get; set; }               
        public string Type { get; set; }            
        public double Weight { get; set; }         
        public string FrameMaterial { get; set; }  
        public int GearCount { get; set; }         
        public double Mileage { get; set; }         
        public double Distance { get; set; }
        public double Time { get; set; }
        public double Speed { get; set; } 

        public double CalculateSpeed(double distance, double time)
        {
            if (time > 0)
            {
                return distance / time;
            }
            throw new ArgumentException("Час не може бути нульовим або від'ємним.");
        }

        
        public void DisplayInfo()
        {
            Console.WriteLine($"Марка: {Brand}, Модель: {Model}, Рік: {Year}, Вага: {Weight} кг, Кількість швидкостей: {GearCount}, Пробіг: {Mileage} км");
        }

        
    }

}
