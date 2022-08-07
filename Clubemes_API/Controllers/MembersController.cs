using Clubemes_API.Models;
using Clubemes_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Clubemes_API.Controllers
{
    [ApiController]
    [Route("api/MS/[Controller]")]
    public class MembersController : Controller
    {
        MemberService memberService;

        #region Constructor
        public MembersController()
        {
            memberService = new MemberService();
        }
        #endregion

        [HttpPost]
        public Member Create([FromBody]Member member)
        {
            return memberService.Save(member);
        }

        [HttpGet]
        public Member[] Get()
        {
            return memberService.Read(null);
        }

        [HttpGet]
        [Route("/{MembershipCode}")]
        public Member[] GetByCode([FromRoute]string MembershipCode)
        {
            return memberService.Read(MembershipCode);
        }

        [HttpPut]
        public Member Update([FromBody] Member member)
        {
            return memberService.Save(member);
        }

        [HttpPut]
        [Route("Delete")]
        public Member Delete([FromBody] Member member)
        {
            member.IsActive = false;
            member.IsDeleted = true;
            return memberService.Save(member);
        }

        [HttpPut]
        [Route("Deactivate")]
        public Member Deactivate([FromBody]Member member)
        {
            member.IsActive = false;
            member.IsDeleted = false;
            return memberService.Save(member);
        }
    }
}
