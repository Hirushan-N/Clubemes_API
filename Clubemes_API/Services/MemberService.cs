using Clubemes_API.Models;

namespace Clubemes_API.Services
{
    public class MemberService
    {
        public Member Save(Member member)
        {
            return member;
        }

        private List<Member> getSampleMembers()
        {
            var members = new List<Member>();
            for (int i = 0; i < 50; i++)
            {
                Member member = new Member();
                member.Id = i;
                member.MembershipCode = "M0000000" + i;
                member.Name = "Nadeesh Hirushan";
                member.Age = "24";
                member.Addres = "Galle";
                member.TP = "0771234567";
                member.IsActive = true;
                member.IsDeleted = false;
                member.CreatedBy = "Creator";
                member.CreatedDate = DateTime.Now;
                member.UpdatedBy = "Editor";
                member.UpdatedDate = DateTime.Now;
                members.Add(member);
            }
            return members;
        }

        public Member[] Read(string MembershipCode)
        {
            var members = new List<Member>();
            if (String.IsNullOrEmpty(MembershipCode))
            {
                members = this.getSampleMembers();
            }
            else
            {
                Member member1 = new Member();
                foreach (var member in members)
                {
                    if (member.MembershipCode == MembershipCode)
                    {
                        member1 = member;
                    }
                }
                members.Add(member1);
            }
            return members.ToArray();
        }
    }
}
