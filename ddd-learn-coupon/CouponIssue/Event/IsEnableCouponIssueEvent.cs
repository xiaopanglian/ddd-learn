using ddd_learn_coupon.core;

namespace ddd_learn_coupon.CouponIssue.Event
{
    public class IsEnableCouponIssueEvent : IEvent
    {
        public IsEnableCouponIssueEvent(long id, bool isEnable)
        {
            Id = id;
            IsEnable = isEnable;
        }
        public long Id { get; set; }
        public bool IsEnable { get; set; }
    }
}
