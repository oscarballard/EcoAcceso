using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAcceso.Core.Application.Dtos.News
{
    public class CreateNewsDto
    {
        public required string Title { get; set; }
        public required string Content { get; set; }
        public required DateTime Publish_Date { get; set; }
        public required string Publish_by { get; set; }
    }
}
