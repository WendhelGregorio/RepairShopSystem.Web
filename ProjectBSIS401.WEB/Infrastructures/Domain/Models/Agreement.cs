using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Infrastructures.Domain.Models
{
    public class Agreement : BaseModel
    {
        public Guid TermAndConditionId { get; set; }

        public List<TermAndCondition> TermAndConditions { get; set; }
    }
}
