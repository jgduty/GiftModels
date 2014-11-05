﻿using System;

namespace GiftModels
{
    /// <summary>
    /// Base model for containing detail about a gift, including donor and allocation info 
    /// </summary>
    public class GiftDetails
    {
        public GiftDetails()
        {
            PrimaryDonor = new DonorContainer();
            AdditionalDonors = new DonorContainer[0];
            Allocations = new AllocationContainer[0];
        }

        public string Source { get; set; }
        public Guid? SourceId { get; set; }

        public DonorContainer PrimaryDonor { get; set; }

        public DonorContainer[] AdditionalDonors { get; set; }

        public AllocationContainer[] Allocations { get; set; }

        public PaymentContainer Payment { get; set; }

        public string SpecialInstructions { get; set; }

        public string AppealCode { get; set; }
        public string CampaignCode { get; set; }

        public decimal Amount { get; set; }

        public decimal CreditAmount { get; set; }

        #region Advance Properties
        public string AdvanceReceiptNumber { get; set; }
        public string AdvanceBatchNumber { get; set; }
        #endregion
    }
}