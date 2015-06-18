﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftModels
{
    public class FinancialDetails
    {
        public virtual string KfsKey { get; set; }

        public string AdvanceReceiptNumber { get; set; }

        public virtual string PrimaryDonor { get; set; }

        public virtual decimal TotalAmount { get; set; }

        public virtual decimal TotalPremiumAmount { get; set; }

        public virtual string Prem { get; set; } // Y/N

        public virtual decimal PremiumAdjustedGiftAmount { get; set; }

        public virtual string AllocationCode { get; set; }

        public virtual string AllocationName { get; set; }

        public virtual string Agency { get; set; }

        public virtual string FundType { get; set; }

        public virtual string FisAccount { get; set; }

        public virtual string FisSubAccount { get; set; }

        public virtual string GiftFeeCode { get; set; }

        public virtual string GiftFeeExceptionName { get; set; }

        public virtual string AfFee { get; set; } // Y/N

        public virtual string BenefitingUnitCode { get; set; }

        public virtual string BenefitingUnitName { get; set; }

        //public virtual DateTime JvBaDate { get; set; } //Great

        //public virtual string JvBaScrubberNumber { get; set; } //Great

        //public virtual string Comments { get; set; } //Great

        //public virtual string Status { get; set; } //Great

        //public virtual decimal GiftBalance { get; set; } //Great

        public virtual string UcFundChart { get; set; }

        public virtual string UcFundNumber { get; set; }

        public virtual string ScrubberChart { get; set; }

        public virtual string ScrubberAccount { get; set; }

        public virtual string RevenueChart { get; set; }

        public virtual string RevenueAccount { get; set; }

        public virtual string PremiumChart { get; set; }

        public virtual string PremiumAccount { get; set; }

        public virtual decimal PremiumAmount { get; set; }

        public virtual string ExpenseChart { get; set; }

        public virtual string ExpenseAccount { get; set; }

        public virtual string ExpenseSubAccount { get; set; }

        public virtual string GiftFeeChart { get; set; }

        public virtual string GiftFeeAccount { get; set; }

        public virtual DateTime CreationDate { get; set; } //Great?

        public virtual DateTime UpdateDate { get; set; } // Great?



    }
}