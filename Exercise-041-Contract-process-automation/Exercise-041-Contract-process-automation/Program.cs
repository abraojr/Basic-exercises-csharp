using Exercise_041_Contract_process_automation.Entities;
using Exercise_041_Contract_process_automation.Services;
using System;
using System.Globalization;

namespace Exercise_041_Contract_process_automation
{
    class Program
    {
        static void Main(string[] args)
        {
            /* A company wants to automate the processing of its contracts. The processing of a contract consists in generating the installments to be paid 
             *for that contract, based on the number of months desired.
             * The company uses an online payment service to pay the installments. Online payment services typically charge a monthly interest as well as a 
             *fee per payment.For now, the service hired by the company is Paypal, which applies simple interest of 1% to each installment, plus a payment 
             *rate of 2%.
             * Make a program to read the data of a contract (contract number, contract date, and total value of the contract).Then, the program must read 
             *the number of months for contract installment, and then generate the records of installments to be paid (date and value), being the first 
             *installment to be paid one month after the contract date, the second installment two months after the contract and so on. Do show the data of 
             *the installments on the screen.*/

            Console.WriteLine("Enter contract data:");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract myContract = new Contract(contractNumber, contractDate, totalValue);

            ContractService contractService = new ContractService(new PayPalService());
            contractService.processContract(myContract, months);

            Console.WriteLine("Installments:");
            foreach (Installment installment in myContract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
