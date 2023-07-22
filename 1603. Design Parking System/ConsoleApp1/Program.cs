using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class ParkingSystem
    {
        int biglength;
        int bigavailable;
        int mediumlength;
        int mediumavailable;
        int smalllength;
        int smallavailable;

        public ParkingSystem(int big, int medium, int small)
        {
            biglength = big;
            bigavailable = 0;
            mediumlength = medium;
            mediumavailable = 0;
            smalllength = small;
            smallavailable = 0;
        }

        public bool AddCar(int carType)
        {
            if (carType == 1 && bigavailable < biglength)
            {
                bigavailable++;
            }
            else if (carType == 2 && mediumavailable < mediumlength)
            {
                mediumavailable++;
            }
            else if (carType == 3 && smallavailable < smalllength)
            {
                smallavailable++;
            }
            else
            {
                return false;
            }
            return true;
        }
    }//Runtime:189 ms Beats:35.38% Memory:59.4 MB Beats:36.76%
}
/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */