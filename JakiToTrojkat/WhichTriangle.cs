using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakiToTrojkat
{
    class WhichTriangle
    {
        private double[] sides;

        public WhichTriangle(double[] sides)
        {
            sortTabDouble(ref sides);
            if ((sides[0] + sides[1] > sides[2]) && sides[0] > 0 && sides[1] > 0 && sides[2] > 0)
            {
                this.sides = sides;
            }
            else
            {
                //throw new WhichTriangleException(); //I do this later
                this.sides = new double[] { 0.0, 0.0, 0.0 }; //only for few "minutes"
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
            double difference = Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2));
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
