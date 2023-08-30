using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Example
{
    internal class Cylinder
    {
        private double Radius { get; set; }
        private double Height { get; set; }
        public void Process()
        {
            Console.WriteLine("Nhap ban kinh cua xi lanh: ");
            Radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap chieu cao cua xi lanh: ");
            Height = Convert.ToDouble(Console.ReadLine());
        }

        public void Result()
        {
            double BaseArea = Radius * Radius * Math.PI;
            double LateralArea = 2 * Math.PI * Radius * Height;
            double TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            double Volume = Math.PI * Radius * Radius * Height;

            Console.WriteLine("ket qua tinh toan:");
            Console.WriteLine($"Dien tich day: {BaseArea}");
            Console.WriteLine($"Dien tich be mat xung quanh: {LateralArea}");
            Console.WriteLine($"Tong dien tich be mat: {TotalArea}");
            Console.WriteLine($"The tich: {Volume}");
        }
    }
}
