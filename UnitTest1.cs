using System;
using Xunit;
using IIG.BinaryFlag;


namespace XUnitTestProject1{
    public class UnitTest1 {

        [Fact]
        public void TestGetFlag() {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
            bool a = Flag.GetFlag();
            Assert.Equal(true, a);
          
        }

        [Fact]
        public void TestGetFlagLengthZero()
        {
          
           Assert.ThrowsAny<Exception>(() => {
                IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(0);
           });

        }


        [Fact]
        public void TestSetFlag()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2);
            Flag.SetFlag(0);
            bool a = Flag.GetFlag();
            Assert.Equal(true, a);


        }

        [Fact]
        public void TestREsetFlag()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
            Flag.ResetFlag(1);
            bool a = Flag.GetFlag();
            Assert.Equal(false, a);


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
        public void TestREsetFlagAtZeroPosition()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
             Flag.ResetFlag(0);
            Assert.Equal(false, Flag.GetFlag());

        }


        [Fact]
        public void TestDispose()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2);
            
            Flag.SetFlag(1);
            bool a = Flag.GetFlag();

            Flag.Dispose();
    
            bool b = Flag.GetFlag();
        
            Assert.NotEqual(a, b);

        }


    }
}
