using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okr2
{
    internal class DigitalCamera:Camera
    {
        private double megapixels;

        public double Megapixels
        {
            get { return megapixels; }
            set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Неверное значение");
                else
                    megapixels = value;
            }
        }

        public DigitalCamera(string model, double zoom, string material, double megapixels) : base(model, zoom, material)
        {
            Megapixels = megapixels;
        }

        public override double Price()
        {
            return base.Price() * Megapixels;
        }

        public void UpdateModel()
        {
            Megapixels = Megapixels + 2;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nКоличество мегапикселей - {Megapixels}";
        }
    }
}
