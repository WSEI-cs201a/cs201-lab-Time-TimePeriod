// Konfiguracja VSCode z MSTest
// https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest

using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSLabs.TimeLib;
using System;


namespace CSlab_Time_TimePeriod_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(12, 13, 14)]
        [DataRow(0, 0, 0)]
        [DataRow(23, 59, 59)]
        public void Constructor_3args_ValidData_OK(int hh, int mm, int ss)
        {
            Time  t  = new Time((byte)hh, (byte)mm, (byte)ss);
            Assert.AreEqual(t.Hours, hh);
            Assert.AreEqual(t.Minutes, mm);
            Assert.AreEqual(t.Seconds, ss);
        }

        [DataTestMethod]
        [DataRow(-1, 13, 14)]
        [DataRow(1, -1, 0)]
        [DataRow(23, 59, -1)]
        [DataRow(24, 59, 0)]
        [DataRow(23, 60, 0)]
        [DataRow(23, 39, 60)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_3args_NotValidData_Exception(byte hh, byte mm, byte ss)
        {
            Time  t  = new Time(hh, mm, ss);
        }
    }
}
