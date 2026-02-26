using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestService.Application.DTO
{
    public class EmiScheduleDto
    {
        public int Id { get; set; }

        public int DueDate { get; set; }

        public decimal EmiAmount { get; set; }

        public decimal PrincipalComponent { get; set; }

        public decimal InterestComponent { get; set; }

        public string Status { get; set; }
    }

}
