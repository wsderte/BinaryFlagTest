using System;
using Xunit;
using IIG.BinaryFlag;


namespace XUnitTestProject1{
    public class UnitTest1 {
        
        [Fact]
        public void TestInitializeLengthMoreThan1_2()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2);
            Assert.NotNull(Flag);

        }

        [Fact]
        public void TestInitializeLengthMoreThan1_1()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(1);
            Assert.NotNull(Flag);

        }

        [Fact]
        public void TestInitializeLengthMoreThan1_3()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(3);
            Assert.NotNull(Flag);

        }


        
        [Fact]
        public void TestInitializeMaxLenth_17179868704()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(17179868704);
            Assert.NotNull(Flag);

        }

        [Fact]
        public void TestInitializeMaxLenth_17179868703()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(17179868703);
            Assert.NotNull(Flag);

        }

        [Fact]
        public void TestInitializeMaxLenth_17179868705()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(17179868705);
            Assert.NotNull(Flag);

        }

        [Fact]
        public void TestInitializeInRange_10()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(10);
            Assert.NotNull(Flag);

        }

        [Fact]
        public void TestInitializeInRange_9()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(9);
            Assert.NotNull(Flag);

        }

        [Fact]
        public void TestInitializeInRange_22()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(22);
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
