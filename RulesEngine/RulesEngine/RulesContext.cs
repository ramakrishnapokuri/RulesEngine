using RulesEngine.Interfaces;

namespace RulesEngine
{
    /// <summary>
    /// Rules Context to Process the diffrent payment methods
    /// </summary>
   public class RulesContext
    {
        #region Varibles       
        private IRulesContext _rulesContext;
        #endregion

        /// <summary>
        /// Rules Constructor 
        /// </summary>
        /// <param name="rulesContext"></param>
        public RulesContext(IRulesContext rulesContext)
        {
            _rulesContext = rulesContext;
        }

        /// <summary>
        /// Process diffrent Payment Types
        /// </summary>
        public void Process()
        {
            _rulesContext.Process();
        }
    }
}
