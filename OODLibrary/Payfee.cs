using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODLibrary
{
    class Payfee
    {


        /// <summary>
        /// Method used for calculation of the fee that a user has to pay
        /// </summary>
        /// <param name="totalDays"></param>
        /// <param name="type"></param>
        /// <param name="age"></param>
        /// <returns> Double with the amount of money that you have to pay</returns>
        public double calculateFee(int totalDays, String type, int age)
        {
            if (type.Equals("Novel"))
            {
                if (totalDays > 21)
                {
                    return ((totalDays - 21) * 0.25);
                }
                else
                {
                    return 0;
                }
            }
            else if (type.Equals("Study Book"))
            {
                if (totalDays > 30)
                {
                    if (((totalDays - 30) % 7) > 0)
                    {
                        return (((totalDays - 30) / 7) + 1);
                    }
                    else
                    {
                        return ((totalDays - 30) / 7);
                    }
                }
                else
                {
                    return 0;
                }
            }
            else if (type.Equals("Classical"))
            {
                double totalCost = 0;

                if (totalDays > 10)
                {
                    if (((totalDays - 10) % 7) > 0)
                    {
                        totalCost = ((((totalDays - 10) / 7) + 1) * 1.50) + 2;
                    }
                    else
                    {
                        totalCost = (((totalDays - 10) / 7) * 1.50) + 2;
                    }
                }
                else
                {
                    totalCost = 2;
                }

                if (age > 1 && age < 5)
                {
                    return (totalCost * 0.90);
                }
                else if (age > 5)
                {
                    return (totalCost * 0.50);
                }
                else
                {
                    return totalCost;
                }
            }
            else if (type.Equals("Popular"))
            {
                double totalCost = 0;

                if (totalDays > 10)
                {
                    if (((totalDays - 10) % 7) > 0)
                    {
                        totalCost = ((((totalDays - 10) / 7) + 1) * 2) + 1;
                    }
                    else
                    {
                        totalCost = (((totalDays - 10) / 7) * 2) + 1;
                    }
                }
                else
                {
                    totalCost = 1;
                }

                if (age > 1 && age < 5)
                {
                    return (totalCost * 0.90);
                }
                else if (age > 5)
                {
                    return (totalCost * 0.50);
                }
                else
                {
                    return totalCost;
                }
            }
            else if (type.Equals("A"))
            {
                return (totalDays * 2);
            }
            else if (type.Equals("B"))
            {
                if (totalDays > 3)
                {
                    return ((totalDays - 3) + 2);
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return -1;
            }
        }
    }
}
