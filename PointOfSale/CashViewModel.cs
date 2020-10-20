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
        /// Handles when one of properties changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        //Properties to represent the quantity of each kind of currency in the drawer

        /// <summary>
        /// Represents how many hundred dollar bills are in the drawer
        /// </summary>
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

        /// <summary>
        /// Represents how many fifty dollar bills are in the drawer
        /// </summary>
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

        /// <summary>
        /// Represents how many twenty dollar bills are in the drawer
        /// </summary>
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

        /// <summary>
        /// Represents how many ten dollar bills are in the drawer
        /// </summary>
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

        /// <summary>
        /// Represents how many five dollar bills are in the drawer
        /// </summary>
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

        /// <summary>
        /// Represents how many two dollar bills are in the drawer
        /// </summary>
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

        /// <summary>
        /// Represents how many one dollar bills are in the drawer
        /// </summary>
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

        /// <summary>
        /// Represents how many dollar coins are in the drawer
        /// </summary>
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

        /// <summary>
        /// Represents how many half dollars are in the drawer
        /// </summary>
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

        /// <summary>
        /// Represents how many quarters are in the drawer
        /// </summary>
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

        /// <summary>
        /// Represents how many dimes are in the drawer
        /// </summary>
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

        /// <summary>
        /// Represents how many nickles are in the drawer
        /// </summary>
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

        /// <summary>
        /// Represents how many pennies are in the drawer
        /// </summary>
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

        /// <summary>
        /// Represents how many hundred dollar bills are recived from the custromer
        /// </summary>
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

        /// <summary>
        /// Represents how many fifty dollar bills are recived from the custromer
        /// </summary>
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

        /// <summary>
        /// Represents how many twenty dollar bills are recived from the custromer
        /// </summary>
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

        /// <summary>
        /// Represents how many ten dollar bills are recived from the custromer
        /// </summary>
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

        /// <summary>
        /// Represents how many five dollar bills are recived from the custromer
        /// </summary>
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

        /// <summary>
        /// Represents how many two dollar bills are recived from the custromer
        /// </summary>
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

        /// <summary>
        /// Represents how many one dollar bills are recived from the custromer
        /// </summary>
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

        /// <summary>
        /// Represents how many dollar coins are recived from the custromer
        /// </summary>
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

        /// <summary>
        /// Represents how many half dollars are recived from the custromer
        /// </summary>
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

        /// <summary>
        /// Represents how many quarters are recived from the custromer
        /// </summary>
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

        /// <summary>
        /// Represents how many dimes are recived from the custromer
        /// </summary>
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

        /// <summary>
        /// Represents how many nickles are recived from the custromer
        /// </summary>
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

        /// <summary>
        /// Represents how many pennies are recived from the custromer
        /// </summary>
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
        
        /// <summary>
        /// returns the total from the view model class
        /// </summary>
        public double Total
        {
            get => CashDrawer.Total;
        }

        /// <summary>
        /// method that totals how much was recieved from the customer
        /// </summary>
        /// <returns></returns>
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
