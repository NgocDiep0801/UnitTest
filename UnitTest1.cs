namespace sampleCode
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTotalSale()
        {
            var length = 7;
            var sales = new int[length];
            var total = 0;

            for (int i = 0; i < length; i++)
            {
                var sale = i;
                sales[0] = sale;
                total += sale;
            }
            Assert.AreEqual(21, total);
        }
        [TestMethod]
        public void TestlotteryNum() {
            var length = 7;
            var lotteryNum = new int[length];
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                lotteryNum[i] = rnd.Next(0, 10);
            }
            
            Assert.AreEqual(7, string.Join("", lotteryNum).Length); 

        }
        [TestMethod]
        public void TestRainfallStatistics() {
            var length = 12;
            var monthlyRainfall = new double[length];
            var total = 0.0;
            for (int i = 0; i < length; i++)
            {
                var month = i;
                monthlyRainfall[i] = month;
                total += month;
            }

            Assert.AreEqual(66, total);
            Assert.AreEqual(5.5, total / length);
            var highest = monthlyRainfall[0];
            var lowest = monthlyRainfall[0];
            for (int i = 1; i < length; i++)
            {
                if (highest < monthlyRainfall[i])
                {
                    highest = monthlyRainfall[i];
                }

                if (lowest > monthlyRainfall[i])
                {
                    highest = monthlyRainfall[i];
                }

            }
            Assert.AreEqual(11, highest);
            Assert.AreEqual(0, lowest);
        }
        [TestMethod]
        public void TestChargeAccount()
        {
            const int rows = 3;
            var cols = 6;
            long[][] accounts = new long[rows][]{new long[] { 5658845, 4520125, 7895122, 8777541, 8451277, 1302850 },
                new long[]{ 8080152, 4562555, 5552012, 5050552, 7825877, 1250255},
                new long[]{ 1005231, 6545231, 3852085, 7576651, 7881200, 4581002 } };

            Console.WriteLine("Please enter the account you're searcing for: ");
            var account = long.Parse(Console.ReadLine());
            var found = false;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (account == accounts[row][col])
                    {
                        found = true;
                    }
                }
            }

            if (found)
            {
                Assert.AreEqual(0, account);
            }
            else
            {
                Assert.AreEqual(0, account);
            }
        }
        [TestMethod]
        public void TestTo()
        {
           //Arrange
           //Act
           //Assert
        }
    }
    
    
}
        
    

    
