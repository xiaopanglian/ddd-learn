namespace ddd_learn_dto.CouponIssue
{
    public class CreateCouponIssueInDto
    {
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
    }
}
