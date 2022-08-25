using ddd_learn_coupon.core;
using ddd_learn_coupon.CouponIssue.Event;

namespace ddd_learn_coupon.CouponIssue.Handler
{
    public class IsEnableCouponIssueHandler : IHandler<IsEnableCouponIssueEvent>
    {
        public void Handler(IsEnableCouponIssueEvent isEnableCouponIssueEvent)
        {
            //处理逻辑
        }
    }
}
