using LinkedList;

namespace LinkedListTest
{
    public class Tests
    {
        private SinglyLinkedList sll;

        [SetUp]
        public void Setup()
        {
            // Create your concrete linked list class and assign to to singlyLinkedList.
            sll = new SinglyLinkedList();
        }
        [TearDown]
        public void TearDown()
        {
            sll.Clear();
        }

        //Test the linked list is empty.
        [Test]
        public void TestIsEmpty1()
        {
            Assert.True(sll.IsEmpty());
        }

        //Test the linked list is empty.
        [Test]
        public void TestIsEmpty2()
        {
            Assert.AreEqual(0, sll.Size());
        }


        //Test to check the size.
        [Test]
        public void TestSzie()
        {
            sll.AddLast(4);
            sll.AddLast(10);
            sll.AddLast(60);
            sll.AddLast(5);

            Assert.AreEqual(4, sll.Size());
        }
    }
}