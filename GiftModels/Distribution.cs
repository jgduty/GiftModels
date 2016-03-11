using System.Collections;
using System.Collections.Generic;

namespace GiftModels
{
    public class Distribution
    {
        public Distribution()
        {
            Premiums = new List<PremiumDetails>();
        }

        /// <summary>
        /// Valid Values: Null/Empty, Existing, New, NewWithPayment
        /// </summary>
        public string TransactionType { get; set; }

        public AllocationDetail AllocationDetail { get; set; }

        public Pledge Pledge { get; set; }

        public IList<PremiumDetails> Premiums { get; set; }

        public decimal Amount { get; set; }

        /// <summary>
        /// Gift Fee Type Description
        /// </summary>
        public string GiftFeeType { get; set; }

        /// <summary>
        /// Gift Fee Type Lookup Code
        /// </summary>
        public string GiftFeeTypeCode { get; set; }

        /// <summary>
        /// Sub Account for money movement
        /// </summary>
        public string SubAccount { get; set; }
    }
}