using CertiPay.Payroll.Common;
using System;
using System.Collections.Generic;

namespace CertiPay.Taxes.Federal
{
    public sealed class TaxTable2017 : TaxTable
    {
        public int Year { get { return 2017; } }

        public Decimal SocialSecurityWageBase { get { return 127200; } }

        public Decimal FICA_EmployeePercentage { get { return 6.2m; } }

        public Decimal FICA_EmployerPercentage { get { return FICA_EmployeePercentage; } }

        public Decimal MedicarePercentage { get { return 1.450m; } }

        public Decimal FUTA_EmployerPercentage { get { return 0.6m; } }

        public Decimal FUTA_WageBase { get { return 7000; } }

        public IEnumerable<TaxTableEntry> Brackets
        {
            get
            {
                return new[]
                {
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.Single, Minimum = 0, Maximum = 2300, Base = 0, Percentage = 0},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.Single, Minimum = 2300, Maximum = 11625, Base = 0, Percentage = 10},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.Single, Minimum = 11625, Maximum = 40250, Base = 932.50m, Percentage = 15},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.Single, Minimum = 40250, Maximum = 94200, Base = 5226.25m, Percentage = 25},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.Single, Minimum = 94200, Maximum = 193950, Base = 18713.75m, Percentage = 28},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.Single, Minimum = 193950, Maximum = 419000, Base = 46643.75m, Percentage = 33},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.Single, Minimum = 419000, Maximum = 420700, Base = 120910.25m, Percentage = 35},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.Single, Minimum = 420700, Maximum = decimal.MaxValue, Base = 121505.25m, Percentage = 39.6m},

                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingJointly, Minimum = 0, Maximum = 8650, Base = 0, Percentage = 0},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingJointly, Minimum = 8650, Maximum = 27300, Base = 0, Percentage = 10},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingJointly, Minimum = 27300, Maximum = 84550, Base = 1865m, Percentage = 15},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingJointly, Minimum = 84550, Maximum = 161750, Base = 10452.50m, Percentage = 25},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingJointly, Minimum = 161750, Maximum = 242000, Base = 29752.50m, Percentage = 28},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingJointly, Minimum = 242000, Maximum = 425350, Base = 52222.50m, Percentage = 33},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingJointly, Minimum = 425350, Maximum = 479350, Base = 112728m, Percentage = 35},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingJointly, Minimum = 479350, Maximum = decimal.MaxValue, Base = 131628m, Percentage = 39.6m},

                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.WidowerWithDependentChild, Minimum = 0, Maximum = 8650, Base = 0, Percentage = 0},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.WidowerWithDependentChild, Minimum = 8650, Maximum = 27300, Base = 0, Percentage = 10},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.WidowerWithDependentChild, Minimum = 27300, Maximum = 84550, Base = 1865m, Percentage = 15},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.WidowerWithDependentChild, Minimum = 84550, Maximum = 161750, Base = 10452.50m, Percentage = 25},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.WidowerWithDependentChild, Minimum = 161750, Maximum = 242000, Base = 29752.50m, Percentage = 28},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.WidowerWithDependentChild, Minimum = 242000, Maximum = 425350, Base = 52222.50m, Percentage = 33},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.WidowerWithDependentChild, Minimum = 425350, Maximum = 479350, Base = 112728m, Percentage = 35},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.WidowerWithDependentChild, Minimum = 479350, Maximum = decimal.MaxValue, Base = 131628m, Percentage = 39.6m},

                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingSeparately, Minimum = 0, Maximum = 2300, Base = 0, Percentage = 0},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingSeparately, Minimum = 2300, Maximum = 11625, Base = 0, Percentage = 10},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingSeparately, Minimum = 11625, Maximum = 40250, Base = 932.50m, Percentage = 15},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingSeparately, Minimum = 40250, Maximum = 94200, Base = 5226.25m, Percentage = 25},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingSeparately, Minimum = 94200, Maximum = 193950, Base = 18713.75m, Percentage = 28},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingSeparately, Minimum = 193950, Maximum = 419000, Base = 46643.75m, Percentage = 33},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingSeparately, Minimum = 419000, Maximum = 420700, Base = 120910.25m, Percentage = 35},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingSeparately, Minimum = 420700, Maximum = decimal.MaxValue, Base = 121505.25m, Percentage = 39.6m},

                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.HeadOfHousehold, Minimum = 0, Maximum = 2300, Base = 0, Percentage = 0},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.HeadOfHousehold, Minimum = 2300, Maximum = 11625, Base = 0, Percentage = 10},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.HeadOfHousehold, Minimum = 11625, Maximum = 40250, Base = 932.50m, Percentage = 15},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.HeadOfHousehold, Minimum = 40250, Maximum = 94200, Base = 5226.25m, Percentage = 25},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.HeadOfHousehold, Minimum = 94200, Maximum = 193950, Base = 18713.75m, Percentage = 28},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.HeadOfHousehold, Minimum = 193950, Maximum = 419000, Base = 46643.75m, Percentage = 33},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.HeadOfHousehold, Minimum = 419000, Maximum = 420700, Base = 120910.25m, Percentage = 35},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.HeadOfHousehold, Minimum = 420700, Maximum = decimal.MaxValue, Base = 121505.25m, Percentage = 39.6m},
                };
            }
        }

        public IEnumerable<AllowanceValue> Allowances
        {
            get
            {
                //From the IRS Circular E Employer's Tax Guide

                yield return new AllowanceValue { PayrollFrequency = PayrollFrequency.Weekly, Value = 77.90m };
                yield return new AllowanceValue { PayrollFrequency = PayrollFrequency.BiWeekly, Value = 155.80m };
                yield return new AllowanceValue { PayrollFrequency = PayrollFrequency.SemiMonthly, Value = 168.80m };
                yield return new AllowanceValue { PayrollFrequency = PayrollFrequency.Monthly, Value = 337.50m };
                yield return new AllowanceValue { PayrollFrequency = PayrollFrequency.Quarterly, Value = 1012.50m };
                //yield return new AllowanceValue { PayrollFrequency = PayrollFrequency.Semiannually, Value = 2025.00m };
                yield return new AllowanceValue { PayrollFrequency = PayrollFrequency.Annually, Value = 4050.00m };
                yield return new AllowanceValue { PayrollFrequency = PayrollFrequency.Daily, Value = 15.60m };
            }
        }
    }
}