using System;
using Xunit;
using IIG.BinaryFlag;


namespace XUnitTestProject1{
    public class UnitTest1 {
        [Fact]
        public void TestInitializeLengthMoreThan1()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2);
            Assert.NotNull(Flag);

        }

        [Fact]
        public void TestInitializeMaxLenth()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(17179868704);
            Assert.NotNull(Flag);

        }

        [Fact]
        public void TestInitializeTrue()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
            Assert.NotNull(Flag);

        }


        [Fact]
        public void TestInitializeFalse()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2, false);
            Assert.NotNull(Flag);

        }


        [Fact]
        public void TestGetFlagAtMinRangeTrue() {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2);
            Assert.Equal(true, Flag.GetFlag());
          
        }

      
        [Fact]
        public void TestGetFlagAtMinRangeFalse()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2, false);
            Assert.Equal(false, Flag.GetFlag());

        }

        [Fact]
        public void TestSetFlag()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2, false);
            Flag.SetFlag(0);
            Flag.SetFlag(1);
            Assert.Equal(true, Flag.GetFlag());

        }

        [Fact]
        public void TestSetFlagAtThePositionMoreThanItHas()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => {
                Flag.SetFlag(200);
            });

        }


        [Fact]
        public void TestREsetFlag()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
            Flag.ResetFlag(1);
            Assert.Equal(false, Flag.GetFlag());


        }

       [Fact]
        public void TestREsetFlagAtThePositionMoreThanItHas()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => {
                Flag.ResetFlag(200);
            });

        }


       [Fact]
        public void TestDispose()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2);
            
            Assert.Null(Flag);
        }


    }
}
