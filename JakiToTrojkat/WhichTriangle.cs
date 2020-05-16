using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakiToTrojkat
{
    internal delegate void OnWrongSidesEventDelegate(WhichTriangle tr);
    class WhichTriangle
    {
        private double[] _sides;
        private bool isValid = true;

        public event OnWrongSidesEventDelegate OnWrongSides;

        public WhichTriangle() { }
        public WhichTriangle(double[] sides)
        {
            this.sides = sides;
        }
        public double[] sides
        {
            set
            {
                sortTabDouble(ref value);
                if (IsValid(value))
                {
                    _sides = value;
                }
                else
                {
                    isValid = false;
                    OnWrongSides?.Invoke(this);
                }
            }
            get
            {
                return _sides;
            }
        }
        /*
         * return: bool
         * this method verify that this sides are sides of triangle
         */
        public bool IsValid()
        {
            return IsValid(_sides);
        }
        private static bool IsValid(double[] sides)
        {
            if ((sides[0] + sides[1] > sides[2]) && sides[0] > 0 && sides[1] > 0 && sides[2] > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /**
         * param: array of double's items;
         * return: void;
         * this method can sort array, we can use it only in this class
         */
        private static void sortTabDouble(ref double[] tab)
        {
            bool czyKontynuujemy;
            do
            {
                czyKontynuujemy = false;
                int j = 0;
                for (int i = j; i < tab.Length - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        double roboczy = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = roboczy;
                        czyKontynuujemy = true;
                        j++;
                    }
                }
            }
            while (czyKontynuujemy);
        }
        /**
         * no param;
         * this method returns one of enum SideTriangle;
         * this method checks what kind of triangle we have (sides);
         */ 
        public SideTriangle WhichTriangleSide()
        {
            if(!this.isValid) { return SideTriangle.ERROR; }
            bool equalS0S1 = (sides[0].Equals(sides[1]));
            bool equalS1S2 = (sides[1].Equals(sides[2]));
            if (equalS0S1 && equalS1S2)
            {
                return SideTriangle.EQUILATERAL;
            }
            else if (equalS0S1 || equalS1S2)
            {
                return SideTriangle.ISOSCELES;
            }
            else
            {
                return SideTriangle.MULTILATERAL;
            }
        }
        /**
         * no param;
         * this method returns one of enum AngleTriangle
         * this method check what kind of triangle we have (angle);
         * 
         */
        public AngleTriangle WhichTriangleAngle()
        {
            if(!this.isValid) { return AngleTriangle.ERROR_A; }
            double difference = Math.Pow(_sides[2], 2) - (Math.Pow(_sides[0], 2) + Math.Pow(_sides[1], 2));
            if (difference < 0)
            {
                return AngleTriangle.ACUTE_A;
            }
            else if(difference > 0)
            {
                return AngleTriangle.OBTUSE_A;
            }
            else
            {
                return AngleTriangle.RIGHT_A;
            }
        }
    }
}
