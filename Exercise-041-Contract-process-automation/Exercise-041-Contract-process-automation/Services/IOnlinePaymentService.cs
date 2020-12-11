namespace Exercise_041_Contract_process_automation.Services
{
    interface IOnlinePaymentService
    {
        double PaymentFee(double amount);
        public double Interest(double amount, int months);
    }
}
