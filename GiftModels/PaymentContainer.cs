﻿using System;
using System.ComponentModel.DataAnnotations;

namespace GiftModels
{
    public class PaymentContainer
    {
        public string Source { get; set; }

        public string SourceId { get; set; }

        [Required]
        public string Type { get; set; }

        public string TypeDescription { get; set; }

        public decimal Amount { get; set; }
        
        public string Comment { get; set; }

        /// <summary>
        /// Authorization or Acceptance Datetime
        /// </summary>
        public virtual DateTime? AuthorizedAt { get; set; }

        public virtual DateTime? ReceivedDate { get; set; }

        #region Check Properties
        public string CheckNumber { get; set; }
        #endregion

        #region Credit Card Properties
        /// <summary>
        /// 3 digit card type code (ex: visa == 001)
        /// </summary>
        public virtual string CardType { get; set; }

        /// <summary>
        /// Masked or Suffix of Account. May contain 'x's
        /// </summary>
        public virtual string CardNumber { get; set; }

        /// <summary>
        /// MM-YYYY
        /// </summary>
        public virtual DateTime? CardExpiration { get; set; }

        /// <summary>
        /// Short Reply Code returned by processor (Chase/Visa/Etc) authorizing payment
        /// </summary>
        public virtual string CardAuthorizationCode { get; set; }

        /// <summary>
        /// CyberSource Transaction Id
        /// Generated by CyberSource
        /// </summary>
        public virtual string CardTransactionId { get; set; }

        /// <summary>
        /// Payment Processor (Chase/Visa/Etc) Transaction Id
        /// Generated by Processor, passed through from CyberSource
        /// </summary>
        public virtual string CardTransactionReferenceNumber { get; set; }
        #endregion

        #region Securities Properties

        public string SecurityName { get; set; }
        public string SecurityCount { get; set; }
        #endregion

        #region Insurance Properties
        public string InsuranceVendor { get; set; }
        public string InsuranceCoverage { get; set; }
        public string InsuranceDeductable { get; set; }
        public string InsurancePolicyNumber { get; set; }
        public string InsurancePolicyType { get; set; }
        #endregion

        #region Physical Properties
        public string Appriaser { get; set; }
        public string AppraisalDate { get; set; }
        public string CamsNumber { get; set; }
        #endregion

        #region Wire Transfer Properties

        /// <summary>
        /// Wire Transfer Number
        /// </summary>
        public string WireTransferNumber { get; set; }

        #endregion

        #region CR Doc Transfer Properties (Cash Receipt Document)

        public string CashReceiptNumber { get; set; }
        public string KfsAccountNumber { get; set; }

        #endregion

    }
}