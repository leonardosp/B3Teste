using B3.CdbCalc.Application;

namespace Test
{
    public class CdbCalcTest
    {
        [Fact]
        public void CdbCalc_Return6()
        {
            var service = new CdbCalc();

            var result = service.DenominateValue(1000, 6);

            Assert.NotNull(result);
            Assert.Equal(6, result.Count());
        }

        [Fact]
        public void CdbCalc_Return8()
        {
            var service = new CdbCalc();

            var result = service.DenominateValue(1000, 8);

            Assert.NotNull(result);
            Assert.Equal(8, result.Count());
        }

        [Fact]
        public void CdbCalc_Return12()
        {
            var service = new CdbCalc();

            var result = service.DenominateValue(1000, 12);

            Assert.NotNull(result);
            Assert.Equal(12, result.Count());
        }

        [Fact]
        public void CdbCalc_Return26()
        {
            var service = new CdbCalc();

            var result = service.DenominateValue(1000, 26);

            Assert.NotNull(result);
            Assert.Equal(26, result.Count());
        }
    }
}