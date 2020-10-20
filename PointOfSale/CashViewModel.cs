/*
 * Author: Laura Legg
 * Class name: CashViewModel.cs
 * Purpose: View Model portion of the MVVM architecture.
 */
using RoundRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PointOfSale
{
    public class CashViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        //Properties to represent the quantity of each kind of currency in the drawer
        public int HundredsInDrawer
        {
            get => CashDrawer.Hundreds;
            set
            {
                if (CashDrawer.Hundreds != value)
                {
                    CashDrawer.Hundreds = value;
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("HundredsInDrawer"));
                }
            }
        }

        public int FiftiesInDrawer
        {
            get => CashDrawer.Fifties;
            set
            {
                if (CashDrawer.Fifties != value)
                {
                    CashDrawer.Fifties = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftiesInDrawer"));
                }
            }
        }

        public int TwentiesInDrawer
        {
            get => CashDrawer.Twenties;
            set
            {
                if (CashDrawer.Twenties != value)
                {
                    CashDrawer.Twenties = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentiesInDrawer"));
                }
            }
        }

        public int TensInDrawer
        {
            get => CashDrawer.Tens;
            set
            {
                if (CashDrawer.Tens != value)
                {
                    CashDrawer.Tens = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TensInDrawer"));
                }
            }
        }

        public int FivesInDrawer
        {
            get => CashDrawer.Fives;
            set
            {
                if (CashDrawer.Fives != value)
                {
                    CashDrawer.Fives = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FivesInDrawer"));
                }
            }
        }

        public int TwosInDrawer
        {
            get => CashDrawer.Twos;
            set
            {
                if (CashDrawer.Twos != value)
                {
                    CashDrawer.Twos = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwosInDrawer"));
                }
            }
        }

        public int OnesInDrawer
        {
            get => CashDrawer.Ones;
            set
            {
                if (CashDrawer.Ones != value)
                {
                    CashDrawer.Ones = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OnesInDrawer"));
                }
            }
        }

        public int DollarsInDrawer
        {
            get => CashDrawer.Dollars;
            set
            {
                if (CashDrawer.Dollars != value)
                {
                    CashDrawer.Dollars = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DollarsInDrawer"));
                }
            }
        }

        public int HalfDollarsInDrawer
        {
            get => CashDrawer.HalfDollars;
            set
            {
                if (CashDrawer.HalfDollars != value)
                {
                    CashDrawer.HalfDollars = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollarsInDrawer"));
                }
            }
        }

        public int QuartersInDrawer
        {
            get => CashDrawer.Quarters;
            set
            {
                if (CashDrawer.Quarters != value)
                {
                    CashDrawer.Quarters = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuartersInDrawer"));
                }
            }
        }

        public int DimesInDrawer
        {
            get => CashDrawer.Dimes;
            set
            {
                if (CashDrawer.Dimes != value)
                {
                    CashDrawer.Dimes = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DimesInDrawer"));
                }
            }
        }

        public int NicklesInDrawer
        {
            get => CashDrawer.Nickels;
            set
            {
                if (CashDrawer.Nickels != value)
                {
                    CashDrawer.Nickels = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NicklesInDrawer"));
                }
            }
        }

        public int PenniesInDrawer
        {
            get => CashDrawer.Pennies;
            set 
            {
                if (CashDrawer.Pennies != value)
                {
                    CashDrawer.Pennies = value;
                    PropertyChanged?.Invoke(this , new PropertyChangedEventArgs("PenniesInDrawer"));
                }
            }
        }

        //Properties to represent the quantity of each kind of currency the customer is using to pay

        private int hundreds = 0;
        public int Hundreds
        {
            get => hundreds;
            set
            {
                if (hundreds != value)
                {
                    hundreds = value;
                    HundredsInDrawer += hundreds;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hundreds"));
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HundredsInDrawer"));
                }
            }
        }

        private int fifties = 0;
        public int Fifties
        {
            get => fifties;
            set
            {
                if (fifties != value)
                {
                    fifties = value;
                    FiftiesInDrawer += fifties;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fifties"));
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftiesInDrawer"));
                }
            }
        }

        private int twenties = 0;
        public int Twenties
        {
            get => twenties;
            set
            {
                if (twenties != value)
                {
                    twenties = value;
                    TwentiesInDrawer += twenties;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Twenties"));
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentiesInDrawer"));
                }
            }
        }

        private int tens = 0;
        public int Tens
        {
            get => tens;
            set
            {
                if (tens != value)
                {
                    tens = value;
                    TensInDrawer += tens;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tens"));
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TensInDrawer"));
                }
            }
        }

        private int fives = 0;
        public int Fives
        {
            get => fives;
            set
            {
                if (fives != value)
                {
                    fives = value;
                    FivesInDrawer += fives;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fives"));
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FivesInDrawer"));
                }
            }
        }

        private int twos = 0;
        public int Twos
        {
            get => twos;
            set
            {
                if (twos != value)
                {
                    twos = value;
                    TwosInDrawer += twos;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Twos"));
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwosInDrawer"));
                }
            }
        }

        private int ones = 0;
        public int Ones
        {
            get => ones;
            set
            {
                if (ones != value)
                {
                    ones = value;
                    OnesInDrawer += ones;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ones"));
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OnesInDrawer"));
                }
            }
        }

        private int dollars = 0;
        public int Dollars
        {
            get => dollars;
            set
            {
                if (dollars != value)
                {
                    dollars = value;
                    DollarsInDrawer += dollars;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dollars"));
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DollarsInDrawer"));
                }
            }
        }

        private int halfDollars = 0;
        public int HalfDollars
        {
            get => halfDollars;
            set
            {
                if (halfDollars != value)
                {
                    halfDollars = value;
                    HalfDollarsInDrawer += halfDollars;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollars"));
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollarsInDrawer"));
                }
            }
        }

        private int quarters = 0;
        public int Quarters
        {
            get => quarters;
            set
            {
                if (quarters != value)
                {
                    quarters = value;
                    QuartersInDrawer += quarters;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quarters"));
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuartersInDrawer"));
                }
            }
        }

        private int dimes = 0;
        public int Dimes
        {
            get => dimes;
            set
            {
                if (dimes != value)
                {
                    dimes = value;
                    DimesInDrawer += dimes;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dimes"));
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DimesInDrawer"));
                }
            }
        }

        private int nickles = 0;
        public int Nickles
        {
            get => nickles;
            set
            {
                if (nickles != value)
                {
                    nickles = value;
                    NicklesInDrawer += nickles;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Nickles"));
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NicklesInDrawer"));
                }
            }
        }

        private int pennies = 0;
        public int Pennies
        {
            get => pennies;
            set
            {
                if (pennies != value)
                {
                    pennies = value;
                    PenniesInDrawer += pennies;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pennies"));
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PenniesInDrawer"));
                }
            }
        }

        //Properties to represent the quantity of each kind of currency that should be provided to the customer as change for the transaction.
        
        public double Total
        {
            get => CashDrawer.Total;
        }

        private double TotalRecieved()
        {
            double r = 0;

            if (Hundreds > 0)
                r += (Hundreds * 100);
            if (Fifties > 0)
                r += (Fifties * 50);
            if (Twenties > 0)
                r += (Twenties * 20);
            if (Tens > 0)
                r += (Tens * 10);
            if (Fives > 0)
                r += (Fives * 5);
            if (Twos > 0)
                r += (Twos * 2);
            if (Ones > 0)
                r += Ones;
            if (Dollars > 0)
                r += Dollars;
            if (HalfDollars > 0)
                r += (HalfDollars * 0.5);
            if (Quarters > 0)
                r += (Quarters * 0.25);
            if (Dimes > 0)
                r += (Dimes * 0.1);
            if (Nickles > 0)
                r += (Nickles * 0.05);
            if (Pennies > 0)
                r += (Pennies * 0.01);

            return r;
        }
    }
}
