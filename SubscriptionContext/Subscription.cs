using Balta.SharedContext;
namespace Balta.SubscriptionContext
{
    public class Subscription : Base
    {
        public Plan Plan { get; set; }

        public DateTime? EndDate { get; set; } //data final da assinatura, é nullable

        public bool IsInactive => EndDate <= DateTime.Now;
    }
}