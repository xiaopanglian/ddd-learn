using ddd_learn_coupon.core;
using ddd_learn_coupon.CouponIssue.Event;
using ddd_learn_coupon.CouponIssue.Repository;

namespace ddd_learn_coupon.CouponIssue.Service
{
    public class CouponIssueDomainService
    {
        private readonly ICouponIssueRepository _couponIssueRepository;

        public CouponIssueDomainService(ICouponIssueRepository couponIssueRepository)
        {
            _couponIssueRepository = couponIssueRepository;
        }

        public async Task<Entity.CouponIssue> CreateCouponIssueAsync(Entity.CouponIssue couponIssue)
        {
            //couponIssue.Id = newId();

            //创建券发行
            await _couponIssueRepository.InsertAsync(couponIssue);

            return couponIssue;
        }

        public async Task<bool> IsEnableCouponIssueAsync(long id, bool isEnable)
        {
            var couponIssueData = await _couponIssueRepository.GetAsync(c => c.Id == id);

            couponIssueData.IsEnable = isEnable;

            var res = await _couponIssueRepository.UpdateAsync(couponIssueData);

            if (res)
            {
                //触发券发行启用停用领域事件
                Events.AddEvent(new IsEnableCouponIssueEvent(id, isEnable));
            }

            return res;
        }
    }
}
