using ddd_learn_dto.CouponIssue;
using ddd_learn_service.domain_object.CouponIssue;
using ddd_learn_service.interfaces;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace ddd_learn_facade.Controllers
{
    /// <summary>
    /// 券发行 控制器
    /// </summary>
    [ApiController]
    [Route("api/coupon-issue")]
    public class CouponIssueController : ControllerBase
    {
        private readonly ICouponIssueAppService _couponIssueAppService;

        public CouponIssueController(ICouponIssueAppService couponIssueAppService)
        {
            _couponIssueAppService = couponIssueAppService;
        }

        /// <summary>
        /// 创建券发行
        /// </summary>
        /// <param name="param"></param>
        /// <returns>返回创建券发行的Id</returns>
        [HttpPost]
        public async Task<long> CreateCouponIssueAsync([FromBody] CreateCouponIssueInDto param)
        {
            return await _couponIssueAppService.CreateCouponIssueAsync(param.Adapt<CreateCouponIssueDo>());
        }

        /// <summary>
        /// 启用券发行
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        [HttpPut("is-enable")]
        public async Task<bool> IsEnableCouponIssueAsync([FromBody] IsEnableCouponIssueInDto param)
        {
            return await _couponIssueAppService.IsEnableCouponIssueAsync(param.Adapt<IsEnableCouponIssueDo>());
        }
    }
}
