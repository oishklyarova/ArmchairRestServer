using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armchair_rest_server.Models
{
    public interface IFeedbackRepository
    {
        IEnumerable<Feedback> GetAll();
        void Add(Feedback item);
    }
}
