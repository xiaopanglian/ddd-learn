using System.Linq.Expressions;

namespace ddd_learn_coupon.CouponIssue.Repository
{
    public interface ICouponIssueRepository
    {
        Task<Entity.CouponIssue> GetAsync(Expression<Func<CouponIssue.Entity.CouponIssue, bool>> expression);

        Task<bool> InsertAsync(Entity.CouponIssue couponIssue);
        Task<bool> UpdateAsync(Entity.CouponIssue couponIssue);
    }
}
