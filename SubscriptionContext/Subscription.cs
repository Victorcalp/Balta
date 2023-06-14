using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class Subscription : Base
    {
        public Plan? Plan { get; set; }
        public DateTime? EndDate { get; set; }

        //Verifica se a data final é maior que a data atual
        public bool IsInactive => EndDate >= DateTime.Now;
    }
}