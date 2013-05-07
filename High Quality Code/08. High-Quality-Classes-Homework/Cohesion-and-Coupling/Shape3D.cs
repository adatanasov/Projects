namespace CohesionAndCoupling
{
    using System;

    public class Shape3D
    {
        private double width;
        private double height;
        private double depth;

        public Shape3D(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Depth
        {
            get 
            { 
                return this.depth; 
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Depth must be positive!");
                }
                else
                {
                    this.depth = value; 
                }
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height must be positive!");
                }
                else
                {
                    this.height = value;
                }
            }
        }       

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be positive!");
                }
                else
                {
                    this.width = value;
                }
            }
        }        

        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }        
    }
}
