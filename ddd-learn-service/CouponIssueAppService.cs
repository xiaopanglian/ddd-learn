using ddd_learn_coupon.CouponIssue.Entity;
using ddd_learn_coupon.CouponIssue.Service;
using ddd_learn_service.domain_object.CouponIssue;
using ddd_learn_service.interfaces;

namespace ddd_learn_service
{
    internal class CouponIssueAppService : ICouponIssueAppService
    {
        private readonly CouponIssueDomainService _couponIssueDomainService;

        public CouponIssueAppService(CouponIssueDomainService couponIssueDomainService)
        {
            _couponIssueDomainService = couponIssueDomainService;
        }

        public async Task<long> CreateCouponIssueAsync(CreateCouponIssueDo param)
        {
            var couponIssue = CouponIssue.CreateCouponIssue(
                param.Name,
                param.IssueNumber,
                param.DeductionType,
                param.DeductionValue,
                param.LowestAmount);

            var res = await _couponIssueDomainService.CreateCouponIssueAsync(couponIssue);

            return res.Id;
        }

        public async Task<bool> IsEnableCouponIssueAsync(IsEnableCouponIssueDo param)
        {
            return await _couponIssueDomainService.IsEnableCouponIssueAsync(param.Id, param.IsEnable);
        }
    }
}
