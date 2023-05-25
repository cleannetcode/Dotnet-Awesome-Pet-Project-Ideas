using System;
using Xunit;
using LinkedListNamespace;

namespace LinkedList.Test
{
    public class CollectionTests
    {
        [Fact]
        public void CreationTest()
        {
            //Arrange
            var list = new LinkedList<int>();

            //Assert
            Assert.Equal(0, list.Count);
            Assert.Null(list.Head);
            Assert.Null(list.Tail);
        }

        [Fact]
        public void AddToHeadTest()
        {
            //Arrange
            var list = new LinkedList<int>();
            int val = 10;

            //Act
            list.AddToHead(val);

            //Assert
            Assert.Equal(1, list.Count);
            Assert.Equal(val, list.Head.Value);
            Assert.Equal(val, list.Tail.Value);
        }

        [Fact]
        public void AddToHeadMultipleToHeadTest()
        {
            //Arrange
            var list = new LinkedList<int>();
            int maxVal = 10;

            //Act
            for (int i = 1; i <= maxVal; i++)
            {
                list.AddToHead(i);
            }

            //Assert
            Assert.Equal(maxVal, list.Count);
            Assert.Equal(maxVal, list.Head.Value);
            Assert.Equal(1, list.Tail.Value);
        }

        [Fact]
        public void AddToTailTest()
        {
            //Arrange
            var list = new LinkedList<int>();
            int val = 10;

            //Act
            list.AddToTail(val);

            //Assert
            Assert.Equal(1, list.Count);
            Assert.Equal(val, list.Head.Value);
            Assert.Equal(val, list.Tail.Value);
        }

        [Fact]
        public void AddToTailMultipleToHeadTest()
        {
            //Arrange
            var list = new LinkedList<int>();
            int maxVal = 10;

            //Act
            for (int i = 1; i <= maxVal; i++)
            {
                list.AddToTail(i);
            }

            //Assert
            Assert.Equal(maxVal, list.Count);
            Assert.Equal(1, list.Head.Value);
            Assert.Equal(maxVal, list.Tail.Value);
        }

        [Fact]
        public void AddTailTest()
        {
            //Arrange
            var list = new LinkedList<int>();
            int val = 10;

            //Act
            list.Add(val);

            //Assert
            Assert.Equal(1, list.Count);
            Assert.Equal(val, list.Head.Value);
            Assert.Equal(val, list.Tail.Value);
        }

        [Fact]
        public void AddTailMultipleToHeadTest()
        {
            //Arrange
            var list = new LinkedList<int>();
            int maxVal = 10;

            //Act
            for (int i = 1; i <= maxVal; i++)
            {
                list.Add(i);
            }

            //Assert
            Assert.Equal(maxVal, list.Count);
            Assert.Equal(1, list.Head.Value);
            Assert.Equal(maxVal, list.Tail.Value);
        }

        [Fact]
        public void ContainsTest()
        {
            //Arrange
            var list = new LinkedList<int>();
            int maxVal = 10;

            //Act
            for (int i = 1; i <= maxVal; i++)
            {
                list.Add(i);
            }

            //Assert
            for (int i = 1; i <= maxVal; i++)
            {
                Assert.True(list.Contains(i));
            }
        }

        [Fact]
        public void RemoveHeadTest()
        {
            //Arrange
            var list = new LinkedList<int>();
            int maxVal = 10;

            //Act
            for (int i = 1; i <= maxVal; i++)
            {
                list.Add(i);
            }
            var node = list.RemoveFromStart();

            //Assert
            Assert.Equal(maxVal - 1, list.Count);
            Assert.Equal(1, node.Value);
            int ind = 2;
            foreach (var val in list)
            {
                Assert.Equal(ind, val);
                ind++;
            }
        }

        [Fact]
        public void RemoveMultipleHeadTest()
        {
            //Arrange
            var list = new LinkedList<int>();
            int maxVal = 10;

            //Act
            for (int i = 1; i <= maxVal; i++)
            {
                list.Add(i);
            }

            //Assert
            for (int i = 1; i <= maxVal; i++)
            {
                var node = list.RemoveFromStart();
                Assert.Equal(maxVal - i, list.Count);
                Assert.Equal(i, node.Value);
            }
        }

        [Fact]
        public void RemoveHeadExceptionTest()
        {
            //Arrange
            var list = new LinkedList<int>();

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => list.RemoveFromStart());
        }

        [Fact]
        public void RemoveTailTest()
        {
            //Arrange
            var list = new LinkedList<int>();
            int maxVal = 10;

            //Act
            for (int i = 1; i <= maxVal; i++)
            {
                list.Add(i);
            }
            var node = list.RemoveFromEnd();

            //Assert
            Assert.Equal(maxVal - 1, list.Count);
            Assert.Equal(maxVal, node.Value);
            int ind = 1;
            foreach (var val in list)
            {
                Assert.Equal(ind, val);
                ind++;
            }
        }

        [Fact]
        public void RemoveMultipleTailTest()
        {
            //Arrange
            var list = new LinkedList<int>();
            int maxVal = 10;

            //Act
            for (int i = 1; i <= maxVal; i++)
            {
                list.Add(i);
            }

            //Assert
            for (int i = 1; i <= maxVal; i++)
            {
                var node = list.RemoveFromEnd();
                Assert.Equal(maxVal - i, list.Count);
                Assert.Equal(maxVal - i + 1, node.Value);
            }
        }

        [Fact]
        public void RemoveTailExceptionTest()
        {
            //Arrange
            var list = new LinkedList<int>();

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => list.RemoveFromEnd());
        }

        [Fact]
        public void ClearEmptyTest()
        {
            //Arrange
            var list = new LinkedList<int>();
            int maxVal = 10;

            //Act
            list.Clear();

            //Assert
            Assert.Equal(0, list.Count);
            Assert.Null(list.Head);
            Assert.Null(list.Tail);
        }

        [Fact]
        public void ClearTest()
        {
            //Arrange
            var list = new LinkedList<int>();
            int maxVal = 10;

            //Act
            for (int i = 1; i <= maxVal; i++)
            {
                list.Add(i);
            }

            list.Clear();

            //Assert
            Assert.Equal(0, list.Count);
            Assert.Null(list.Head);
            Assert.Null(list.Tail);
        }
    }
}
