using _01;
using NUnit.Framework;

namespace NUnitTesting
{
    public class Class1
    {
        [TestFixture]
        class BankAccountTest
        {
            [Test]
            public void AccountInitializeWithPositiveValue()
            {
                BankAccount account = new BankAccount(2000);
                Assert.AreEqual(2000, account.Balance);
            }

            [Test]
            public void DepositAmountShouldIncreaseBalance()
            {
                //Arrange
                BankAccount account = new BankAccount(2000);
                
                //Act
                account.Deposit(200);

                //Assert
                Assert.AreEqual(2200, account.Balance);
            }
        }
    }
}