using CertiPay.Payroll.Common;
using System;
using System.Collections.Generic;

namespace CertiPay.Taxes.Federal
{
    public static class TaxTables
    {
        public const int Minimum_Year = 2013;

        /// <summary>
        /// A list of configured tax tables in the library
        /// </summary>
        public static IEnumerable<TaxTable> Values
        {
            get
            {
                return new TaxTable[]
                {
                    new TaxTable2013(),
                    new TaxTable2014(),
                    new TaxTable2015(),
                    new TaxTable2016(),
                    new TaxTable2017(),
                    new TaxTable2018(),
                };
            }
        }
    }

    public interface TaxTable
    {
        /// <summary>
        /// The tax year the table is applicable for
        /// </summary>
        int Year { get; }

        /// <summary>
        /// A list of the table entries that form the income brackets
        /// </summary>
        IEnumerable<TaxTableEntry> Brackets { get; }

        /// <summary>
        /// A list of the value of allowances for different filing types
        /// </summary>
        IEnumerable<AllowanceValue> Allowances { get; }

        /// <summary>
        /// The max income that social security taxes are calculated against
        /// </summary>
        Decimal SocialSecurityWageBase { get; }

        /// <summary>
        /// The employee's percentage of the FICA taxes
        /// </summary>
        Decimal FICA_EmployeePercentage { get; }

        /// <summary>
        /// The employer's percentage of the FICA taxes
        /// </summary>
        Decimal FICA_EmployerPercentage { get; }

        /// <summary>
        /// The tax percentage charged for Medicare contributions
        /// </summary>
        Decimal MedicarePercentage { get; }

        /// <summary>
        /// The percentage of Federal Unemployment Insurance Tax charged to the employer, represents the
        /// rate after applying the credit for SUI taxes paid
        /// </summary>
        Decimal FUTA_EmployerPercentage { get; }

        /// <summary>
        /// The amount that the FUTA percentage is calculated off of, i.e. 6.0% of the first $7,000 wages
        /// </summary>
        Decimal FUTA_WageBase { get; }
    }

    /// <summary>
    /// Represents the value of an allowance for calculating adjusted gross income from a W-4
    /// for a given payroll frequency
    /// </summary>
    public class AllowanceValue
    {
        public PayrollFrequency PayrollFrequency { get; set; }

        public Decimal Value { get; set; }
    }
}