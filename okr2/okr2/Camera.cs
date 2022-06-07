using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okr2
{
    internal class Camera
    {
        private string model;
        private double zoom;
        private string material;
        public string Model
        {
            get { return model; }
            set { 
                if (value == String.Empty)
                    throw new ArgumentNullException("Пустое значение");
                else
                    model = value;
            }
        }

        public double Zoom
        {
            get { return zoom; }
            set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Неверное значение");
                else
                    zoom = value;
            }
        }

        public string Material
        {
            get { return material; }
            set {
                if (value == "металл" | value == "пластик")
                    material = value;
                else
                    throw new ArgumentException("Неверное значение");

            }
        }

        public Camera(string model,double zoom,string material)
        {
            Model= model;
            Zoom = zoom;
            Material = material;
        }

        public virtual double Price()
        {
            return Material == "пластик" ? ((Zoom + 2) * 10) : ((Zoom + 2) * 15);
        }

        public override string ToString()
        {
            return $"---Фотоаппарат---\nМодель - {Model}\nОптическое увеличение - {Zoom}\n Цена - {this.Price()}$";
        }

        public virtual bool Expensive()
        {
            return (this.Price() > 200 ? true : false);
        }
    }
}
