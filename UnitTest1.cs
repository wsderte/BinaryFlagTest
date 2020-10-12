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
        public void TestDispose()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2);
            
            Flag.SetFlag(1);
            bool a = Flag.GetFlag();

            Flag.Dispose();

            Flag.SetFlag(1);
            bool b = Flag.GetFlag();

            Assert.Equal(a, b);

        }


    }
}
