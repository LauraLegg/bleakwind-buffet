/*
 * Author: Laura Legg
 * Class name: PaymentOptionsControl.xaml.cs
 * Purpose: Partial Class for PaymentOptionsControl xaml class.
 */
using BleakwindBuffet.Data;
using RoundRegister;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{

    /// <summary>
    /// Interaction logic for PaymentOptionsControl.xaml
    /// </summary>
    public partial class PaymentOptionsControl : UserControl
    {
       /// <summary>
       /// 
       /// </summary>
        Border border;

        /// <summary>
        /// Contructor for PaymentOptionsControl partial class
        /// </summary>
        /// <param name="buttons"></param>
        public PaymentOptionsControl(Border border)
        {
            InitializeComponent();
            this.border = border;
        }

        /// <summary>
        /// When clicked, it will return the user back to the menu items screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void returnButton_Click(object sender, RoutedEventArgs e)
        {
            border.Child = null;
        }

        /// <summary>
        /// When clicked, it will run a card payment.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// If the card payment is approved it will print a recipt and start a new order.
        /// All outcomes will display a message in the messageBox textblock.
        /// </remarks>
        void DCButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
               CardTransactionResult result = CardReader.RunCard(order.Total);

                switch (result)
                {
                    case CardTransactionResult.Approved:
                        messageBox.Text = "Approved!";
                        //Print recipt -------------------------------------------------
                        // Create new order --------------------------------------------
                        //border.Child = null;
                        break;
                    case CardTransactionResult.Declined:
                        messageBox.Text = "Declined";
                        break;
                    case CardTransactionResult.ReadError:
                        messageBox.Text = "Read Error";
                        break;
                    case CardTransactionResult.InsufficientFunds:
                        messageBox.Text = "Insufficient Funds";
                        break;
                    case CardTransactionResult.IncorrectPin:
                        messageBox.Text = "Incorrect Pin";
                        break;
                }
            }
        }

        /// <summary>
        /// When clicked, it will take the user to a cash payment screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CashButton_Click(object sender, RoutedEventArgs e)
        {
            border.Child = new CashPaymentControl(border);
        }
    }
}
