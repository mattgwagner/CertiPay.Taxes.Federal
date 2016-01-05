using CertiPay.Payroll.Common;
using System;
using System.Collections.Generic;

namespace CertiPay.Taxes.Federal
{
    public sealed class TaxTable2016 : TaxTable
    {
        public int Year { get { return 2016; } }

        public Decimal SocialSecurityWageBase { get { return 118500; } }

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
                    // FIXME: These have not been updated for 2016 yet and reflect 2015 numbers

                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.Single, Minimum = 0, Maximum = 2300, Base = 0, Percentage = 0},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.Single, Minimum = 2300, Maximum = 11525, Base = 0, Percentage = 10},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.Single, Minimum = 11525, Maximum = 39750, Base = 922.50m, Percentage = 15},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.Single, Minimum = 39750, Maximum = 93050, Base = 5156.25m, Percentage = 25},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.Single, Minimum = 93050, Maximum = 191600, Base = 18481.25m, Percentage = 28},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.Single, Minimum = 191600, Maximum = 413800, Base = 46075.25m, Percentage = 33},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.Single, Minimum = 413800, Maximum = 415500, Base = 119401.25m, Percentage = 35},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.Single, Minimum = 415500, Maximum = decimal.MaxValue, Base = 119996.25m, Percentage = 39.6m},

                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingJointly, Minimum = 0, Maximum = 8600, Base = 0, Percentage = 0},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingJointly, Minimum = 8600, Maximum = 27050, Base = 0, Percentage = 10},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingJointly, Minimum = 27050, Maximum = 83500, Base = 1845.00m, Percentage = 15},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingJointly, Minimum = 83500, Maximum = 159800, Base = 10312.50m, Percentage = 25},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingJointly, Minimum = 159800, Maximum = 239050, Base = 29387.50m, Percentage = 28},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingJointly, Minimum = 239050, Maximum = 420100, Base = 51577.50m, Percentage = 33},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingJointly, Minimum = 420100, Maximum = 473450, Base = 111324.00m, Percentage = 35},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingJointly, Minimum = 473450, Maximum = decimal.MaxValue, Base = 129996.50m, Percentage = 39.6m},

                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.WidowerWithDependentChild, Minimum = 0, Maximum = 8600, Base = 0, Percentage = 0},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.WidowerWithDependentChild, Minimum = 8600, Maximum = 27050, Base = 0, Percentage = 10},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.WidowerWithDependentChild, Minimum = 27050, Maximum = 83500, Base = 1845.00m, Percentage = 15},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.WidowerWithDependentChild, Minimum = 83500, Maximum = 159800, Base = 10312.50m, Percentage = 25},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.WidowerWithDependentChild, Minimum = 159800, Maximum = 239050, Base = 29387.50m, Percentage = 28},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.WidowerWithDependentChild, Minimum = 239050, Maximum = 420100, Base = 51577.50m, Percentage = 33},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.WidowerWithDependentChild, Minimum = 420100, Maximum = 473450, Base = 111324.00m, Percentage = 35},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.WidowerWithDependentChild, Minimum = 473450, Maximum = decimal.MaxValue, Base = 129996.50m, Percentage = 39.6m},

                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingSeparately, Minimum = 0, Maximum = 2300, Base = 0, Percentage = 0},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingSeparately, Minimum = 2300, Maximum = 11525, Base = 0, Percentage = 10},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingSeparately, Minimum = 11525, Maximum = 39750, Base = 922.50m, Percentage = 15},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingSeparately, Minimum = 39750, Maximum = 93050, Base = 5156.25m, Percentage = 25},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingSeparately, Minimum = 93050, Maximum = 191600, Base = 18481.25m, Percentage = 28},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingSeparately, Minimum = 191600, Maximum = 413800, Base = 46075.25m, Percentage = 33},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingSeparately, Minimum = 413800, Maximum = 415500, Base = 119401.25m, Percentage = 35},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.MarriedFilingSeparately, Minimum = 415500, Maximum = decimal.MaxValue, Base = 119996.25m, Percentage = 39.6m},

                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.HeadOfHousehold, Minimum = 0, Maximum = 2300, Base = 0, Percentage = 0},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.HeadOfHousehold, Minimum = 2300, Maximum = 11525, Base = 0, Percentage = 10},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.HeadOfHousehold, Minimum = 11525, Maximum = 39750, Base = 922.50m, Percentage = 15},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.HeadOfHousehold, Minimum = 39750, Maximum = 93050, Base = 5156.25m, Percentage = 25},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.HeadOfHousehold, Minimum = 93050, Maximum = 191600, Base = 18481.25m, Percentage = 28},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.HeadOfHousehold, Minimum = 191600, Maximum = 413800, Base = 46075.25m, Percentage = 33},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.HeadOfHousehold, Minimum = 413800, Maximum = 415500, Base = 119401.25m, Percentage = 35},
                    new TaxTableEntry{ TaxFilingStatus = EmployeeTaxFilingStatus.HeadOfHousehold, Minimum = 415500, Maximum = decimal.MaxValue, Base = 119996.25m, Percentage = 39.6m},
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