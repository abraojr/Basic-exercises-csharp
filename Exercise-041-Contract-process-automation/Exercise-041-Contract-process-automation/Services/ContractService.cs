using Exercise_041_Contract_process_automation.Entities;
using System;

namespace Exercise_041_Contract_process_automation.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            this._onlinePaymentService = onlinePaymentService;
        }
        public void processContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updateQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updateQuota + _onlinePaymentService.PaymentFee(updateQuota);

                contract.AddInstallments(new Installment(date, fullQuota));
            }
        }
    }
}
