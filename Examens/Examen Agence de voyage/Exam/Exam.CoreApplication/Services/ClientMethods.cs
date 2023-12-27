using Exam.CoreApplication.Domain;
using Exam.CoreApplication.Interfaces;

namespace Exam.CoreApplication.Services
{
    public class ClientMethods :Service<Client>, IClientMethods
    {
        private IUnitOfWork _unitOfWork;
        public ClientMethods(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public double totalPayements(Client client)
        {
            // Assuming Repository has a method 'GetById' to get a single entity by its key.
            var clientId = client.Identifiant;
            // Assuming that you have a Payment entity related to the Client which holds the actual payment amounts
            var totalPayments = _unitOfWork.Repository<Payment>()
                .GetMany(p => p.Client.Identifiant == clientId)
                .Sum(p => p.Amount);

            return totalPayments;

        }
    }
}
