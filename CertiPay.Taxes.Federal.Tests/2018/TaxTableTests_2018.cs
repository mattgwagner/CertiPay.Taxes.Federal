using CertiPay.Payroll.Common;
using NUnit.Framework;
using System;
using System.Collections;

namespace CertiPay.Taxes.Federal.Tests._2018
{
    [Year(YEAR)]
    public class TaxTableTests_2018
    {
        private const int YEAR = 2018;

        private readonly IFederalWithholdingCalculator _calculator = new FederalWithholdingCalculator { };

        [Test]
        public void Verify_Valid_Year()
        {
            Assert.NotNull(_calculator.Calculate(YEAR, 1000));
        }

        [Test, TestCaseSource(typeof(TestCases), "Tests")]
        public void Verify_Withholding(int annualIncome, EmployeeTaxFilingStatus status, Decimal expected)
        {
            Assert.That(_calculator.Calculate(YEAR, annualIncome, status), Is.EqualTo(expected));
        }

        public class TestCases
        {
            public static IEnumerable Tests
            {
                get
                {
                    // Single

                    yield return new TestCaseData(9325, EmployeeTaxFilingStatus.Single, 702.50m);
                    yield return new TestCaseData(85000, EmployeeTaxFilingStatus.Single, 16413.75m);
                    yield return new TestCaseData(46585, EmployeeTaxFilingStatus.Single, 6810m);
                    yield return new TestCaseData(123456, EmployeeTaxFilingStatus.Single, 26905.43m);
                    yield return new TestCaseData(67598, EmployeeTaxFilingStatus.Single, 12063.25m);

                    // Married Filing Joint

                    yield return new TestCaseData(18650, EmployeeTaxFilingStatus.MarriedFilingJointly, 1000m);
                    yield return new TestCaseData(85000, EmployeeTaxFilingStatus.MarriedFilingJointly, 10565m);
                    yield return new TestCaseData(123456, EmployeeTaxFilingStatus.MarriedFilingJointly, 20179m);

                    // Married Filing Separate

                    yield return new TestCaseData(9325, EmployeeTaxFilingStatus.MarriedFilingSeparately, 702.50m);
                    yield return new TestCaseData(46585, EmployeeTaxFilingStatus.MarriedFilingSeparately, 6810m);
                    yield return new TestCaseData(123456, EmployeeTaxFilingStatus.MarriedFilingSeparately, 26905.43m);

                    // Head of Household

                    yield return new TestCaseData(13350, EmployeeTaxFilingStatus.HeadOfHousehold, 1191.25m);
                    yield return new TestCaseData(40198, EmployeeTaxFilingStatus.HeadOfHousehold, 5218.45m);
                    yield return new TestCaseData(123456, EmployeeTaxFilingStatus.HeadOfHousehold, 26905.43m);
                }
            }
        }
    }
}