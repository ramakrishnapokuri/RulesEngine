using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine.Interfaces
{
    /// <summary>
    /// Base Interface for diffrent payment Methods
    /// </summary>
    public interface IRulesContext
    {
        /// <summary>
        /// Process the diffrent Paymnet Types
        /// </summary>   
        void Process();
    }
}
