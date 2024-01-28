using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Weller2
{
    internal class DeskQuote
    {
        public string CustomerName { get; set; }
        public Desk Desk { get; set; }
        public int RushDays { get; set; }

        public DeskQuote(string customerName, Desk desk, int rushDays)
        {
            CustomerName = customerName;
            Desk = desk;
            RushDays = rushDays;
        }

        public decimal CalculateQuote()
        {
            decimal basePrice = 200;
            decimal areaPrice = 0;
            decimal rushOrderPrice = 0;

            int deskArea = Desk.Width * Desk.Depth;

            if (deskArea < 1000)
            {
                areaPrice = 0;
            }
            else if (deskArea >= 1000 && deskArea <= 2000)
            {
                areaPrice = 50;
            }
            else
            {
                areaPrice = 100;
            }

            switch (RushDays)
            {
                case 3:
                    if (deskArea < 1000)
                    {
                        rushOrderPrice = 60;
                    }
                    else if (deskArea >= 1000 && deskArea <= 2000)
                    {
                        rushOrderPrice = 70;
                    }
                    else
                    {
                        rushOrderPrice = 80;
                    }
                    break;
                case 5:
                    if (deskArea < 1000)
                    {
                        rushOrderPrice = 40;
                    }
                    else if (deskArea >= 1000 && deskArea <= 2000)
                    {
                        rushOrderPrice = 50;
                    }
                    else
                    {
                        rushOrderPrice = 60;
                    }
                    break;
                case 7:
                    if (deskArea < 1000)
                    {
                        rushOrderPrice = 30;
                    }
                    else if (deskArea >= 1000 && deskArea <= 2000)
                    {
                        rushOrderPrice = 35;
                    }
                    else
                    {
                        rushOrderPrice = 40;
                    }
                    break;
                default:
                    rushOrderPrice = 0;
                    break;
            }

            decimal totalQuote = basePrice + areaPrice + rushOrderPrice;

            return totalQuote;
        }

    }
}
