using System;

namespace Card
{
    public class DebitCard
    {
        public string _cardNumber;
        public string CardNumber
        {
            get { return _cardNumber; }
            set
            {
                if (value.Length != 19)
                {
                    Console.WriteLine("Invalid value");
                    return;
                }
                _cardNumber = value;
            }
        }
        public int CVV { get; set; }
        public string ExpiryDate { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CompanyName { get; set; }
        public decimal Balance { get; set; }
        public decimal Amount { get; set; }
        public decimal Withdraw { get; set; }

        public DebitCard(string cardNumber, int cvv, string expiryDate, string name, string surname, string companyName, decimal balance)
        {
            CardNumber = cardNumber;
            CVV = cvv;
            ExpiryDate = expiryDate;
            Name = name;
            Surname = surname;
            CompanyName = companyName;
            Balance = balance;
        }

        public void DisplayCardInformation()
        {
            Console.WriteLine("Debit Card Information:");
            Console.WriteLine("Card Number: " + CardNumber);
            Console.WriteLine("CVV: " + CVV);
            Console.WriteLine("Expiry Date: " + ExpiryDate);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Surname: " + Surname);
            Console.WriteLine("Company: " + CompanyName);
            Console.WriteLine("Balance: " + Balance);
        }

        public void DepositAmount()
        {
            Balance += Amount;
        }

        public void WithdrawAmount()
        {
            if (Withdraw > Balance)
            {
                Console.WriteLine("Insufficient funds");
            }
            else
            {
                Balance -= Withdraw;
                Console.WriteLine("Remaining balance: " + Balance);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DebitCard debitCard = new DebitCard("1234 5678 9012 3456", 123, "23.03.2033", "Ali", "Salmanov", "ABB", 1313);
            debitCard.Withdraw = 400;
            debitCard.DepositAmount();
            debitCard.WithdrawAmount();
            debitCard.DisplayCardInformation();
        }
    }
}
