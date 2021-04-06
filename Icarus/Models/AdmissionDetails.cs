﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Icarus.Models
{
    public class AdmissionDetails
    {
        public AdmissionNew Admissions { get; set; }
        public AdmissionBillingNew admissiongBillingNew { get; set; }
        public AssertionNew Assertion { get; set; }
        public IEnumerable<tblAdmissionVitalSign> VitalSigns { get; set; }
        public IEnumerable<tblAdmissionCommLog> CommLog { get; set; }
        public IEnumerable<tblAdmissionAttachment> Attachments { get; set; }
        public IEnumerable<tblPayment> Payments { get; set; }
        public tblRank Rank { get; set; }
        public IEnumerable<tblRank> rankLists { get; set; }
    }
}