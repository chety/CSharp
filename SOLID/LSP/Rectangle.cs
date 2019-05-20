using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.SOLID.LSP
{
    public class Rectangle : IShape
    {
        private double _height;
        private double _width;
        public double GetHeight()
        {
            return _height;
        }
        public double GetWidth()
        {
            return _width;
        }

        public virtual void SetHeight(double value)
        {
            _height = value;
        }
        public virtual void SetWidth(double value)
        {
            _width = value;
        }
        public virtual double Area()
        {
            return GetHeight() * GetWidth();
        }

        public virtual double Square()
        {
            return 2 * (GetWidth() + GetHeight());
        }
    }
}
