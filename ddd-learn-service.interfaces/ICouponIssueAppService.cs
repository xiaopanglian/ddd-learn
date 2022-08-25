using ddd_learn_service.domain_object.CouponIssue;

namespace ddd_learn_service.interfaces
{
    public interface ICouponIssueAppService
    {
        Task<long> CreateCouponIssueAsync(CreateCouponIssueDo param);

        Task<bool> IsEnableCouponIssueAsync(IsEnableCouponIssueDo param);
    }
}
