using TestTask;

namespace TestTaskTest
{
    [TestFixture]
    public class SmartClassTest
    {
        /// <summary>
        /// ���� ��������, ���� ���� ����������� ������� � ������, ������ � ����� �������
        /// </summary>
        [Test]
        public void SumTwoMinElements_ElementsInBeginAndEnd()
        {
            SmartClass smartClass = new SmartClass();
            int[] arr = [4, 0, 3, 19, 492, -10, 1];
            int? expected = -10;
            int? result = smartClass.SumTwoMinElements(arr);
            Assert.That(result, Is.EqualTo(expected));
        }
        /// <summary>
        /// ���� ��������, ���� ���� ����������� ������� � ��������, ������ � ����� �������
        /// </summary>
        [Test]
        public void SumTwoMinElements_ElementsInMiddleAndEnd()
        {
            SmartClass smartClass = new SmartClass();
            int[] arr = [7, 8, 5, 9, 6];
            int? expected = 11;
            int? result = smartClass.SumTwoMinElements(arr);
            Assert.That(result, Is.EqualTo(expected));
        }
        /// <summary>
        /// ���� ��������, ���� ��� ����������� �������� � ����� �������
        /// </summary>
        [Test]
        public void SumTwoMinElements_BothElementsInEnd()
        {
            SmartClass smartClass = new SmartClass();
            int[] arr = [5, 7, 4, 3];
            int? expected = 7;
            int? result = smartClass.SumTwoMinElements(arr);
            Assert.That(result, Is.EqualTo(expected));
        }     
        /// <summary>
        /// ���� ��������, ��� ������� ���������� null, ���� ������� null
        /// </summary>
        [Test]
        public void SumTwoMinElements_ReturnNull_IfNullArray()
        {
            SmartClass smartClass = new SmartClass();
            int? expected = null;
            int? result = smartClass.SumTwoMinElements(null);           
            Assert.That(result, Is.EqualTo(expected));
        }
        /// <summary>
        /// ���� ��������, ��� ������� ���������� null, ���� ������� ������ � ����� ���������
        /// </summary>
        [Test]
        public void SumTwoMinElements_ReturnNull_IfOneElementInArray()
        {
            SmartClass smartClass = new SmartClass();
            int[] arr = [5];
            int? expected = null;
            int? result = smartClass.SumTwoMinElements(arr);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}