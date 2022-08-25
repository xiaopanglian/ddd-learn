using ddd_learn_coupon.core;

namespace ddd_learn_coupon.CouponIssue.Entity
{
    public class CouponIssue : IAggregateRoot
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 发行名称
        /// </summary>
        public string Name { get; set; } = default!;

        /// <summary>
        /// 发行数量
        /// </summary>
        public int IssueNumber { set; get; }

        /// <summary>
        /// 抵扣方式
        /// </summary>
        public int DeductionType { set; get; }

        /// <summary>
        /// 抵扣值
        /// </summary>
        public decimal DeductionValue { set; get; }

        /// <summary>
        /// 最低使用金额
        /// </summary>
        public decimal LowestAmount { set; get; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnable { get; set; }

        /// <summary>
        /// 创建券发行
        /// </summary>
        /// <param name="name"></param>
        /// <param name="issueNumber"></param>
        /// <param name="deductionType"></param>
        /// <param name="deductionValue"></param>
        /// <param name="lowestAmount"></param>
        /// <returns></returns>
        public static CouponIssue CreateCouponIssue(string name, int issueNumber, int deductionType, decimal deductionValue, decimal lowestAmount)
        {
            return new CouponIssue
            {
                Id = new Random(Guid.NewGuid().GetHashCode()).Next(10000, 99999),
                Name = name,
                IssueNumber = issueNumber,
                DeductionType = deductionType,
                DeductionValue = deductionValue,
                LowestAmount = lowestAmount,
                IsEnable = false
            };
        }

        public void IsEnableCouponIssue(bool isEnable)
        {
            IsEnable = isEnable;
        }
    }
}