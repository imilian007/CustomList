using System;
using Xunit;
using CustomList;

namespace CustomListTestDocument
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            GenericList<int> items = new GenericList<int>();
            int firstValue = 1;

            //act
            items.Add(4);
            int actualResult = items.items[0];

            //assert
            Assert.Equal(firstValue, actualResult);
        }
        [Fact]
        public void Test2()
        {
            //arrange
            GenericList<string> items = new GenericList<string>();
            string firstValue = "helloWorld";

            //act
            items.Add("helloWorld");
            string actualResult = items.items[0];

            //assert
            Assert.Equal(firstValue, actualResult);
        }
        [Fact]
        public void Test3()
        {
            //arrange
            GenericList<double> items = new GenericList<double>();
            double firstValue = 1.2;

            //act
            items.Add(1.2);
            double actualResult = items.items[0];

            //assert
            Assert.Equal(firstValue, actualResult);
        }
        [Fact]
        public void Test4()
        {
            //arrange
            GenericList<bool> items = new GenericList<bool>();
            bool firstValue = false;

            //act
            items.Add(1 == 2);
            bool actualResult = items.items[0];

            //assert
            Assert.Equal(firstValue, actualResult);
        }
        [Fact]
        public void Test5()
        {
            //arrange
            GenericList<int> items = new GenericList<int>();
            int[] temp = { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };

            //act
            for (int i = 0; i < 10; i++)
            {
                items.Add(4);
            }

            //assert
            Assert.Equal(temp.Length, items.Count);
        }
    }

    public class UnitTest2
    {
        [Fact]
        public void Test1()
        {
            //arrange
            GenericList<int> items = new GenericList<int>();
            int count = 5;
            int realCount;
            int value = 3;
            for (int i = 0; i < 5; i++)
            {
                items.Add(value);
            }

            //act
            realCount = items.Count;

            //assert
            Assert.Equal(count, realCount);
        }
    }

    public class UnitTest3
    {
        [Fact]
        public void Test3()
        {
            //arrange
            GenericList<int> items = new GenericList<int>();
            int firstValue = 1;

            //act
            items.Add(4);
            int actualResult = items.items[0];

            //assert
            Assert.Equal(firstValue, actualResult);
        }
    }

    public class UnitTest4
    {
        [Fact]
        public void Test4()
        {
            //arrange
            GenericList<int> items = new GenericList<int>();
            int firstValue = 1;

            //act
            items.Add(4);
            int actualResult = items.items[0];

            //assert
            Assert.Equal(firstValue, actualResult);
        }
    }

    public class UnitTest5
    {
        [Fact]
        public void Test5()
        {
            //arrange
            GenericList<int> items = new GenericList<int>();
            int firstValue = 1;

            //act
            items.Add(4);
            int actualResult = items.items[0];

            //assert
            Assert.Equal(firstValue, actualResult);
        }
    }
}
