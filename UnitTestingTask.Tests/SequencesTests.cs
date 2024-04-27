namespace UnitTestingTask.Tests
{
    public class SequencesTests
    {
#pragma warning disable

        [TestCase("", 0)]
        [TestCase("1", 0)]
        [TestCase("12", 2)]
        [TestCase("11", 0)]
        [TestCase("1234561111", 7)]
        [TestCase("1111123456", 6)]
        [TestCase("1234561111", 7)]
        [TestCase("123aaa2345", 5)]
        public void Sequence_EqualTest(string str, int result)
        {
            // act
            var actualRes = MaxNumberOF.Sequence(str);
            // assert
            Assert.AreEqual(result, actualRes);
        }

        [TestCase("", 0)]
        [TestCase("78876?:%:?¹¹¹¹¹3333", 0)]
        [TestCase("123aaaa2332", 4)]
        [TestCase("aaa232ssd", 3)]
        [TestCase("ssd23(sss", 3)]
        [TestCase("aa", 2)]
        [TestCase("as", 0)]
        public void SequenceOfLatin_EqualTest(string str, int result)
        {
            // act
            var actualRes = MaxNumberOF.SequenceOfLatin(str);
            // assert
            Assert.AreEqual(result, actualRes);
        }
        [TestCase("", 0)]
        [TestCase("asfds?:%:?12¹¹¹¹¹sff1s", 0)]
        [TestCase("222hgfs3333", 4)]
        [TestCase("111asdssd", 3)]
        [TestCase("ssd23(222", 3)]
        [TestCase("11", 2)]
        [TestCase("12", 0)]
        public void SequenceOfDigits_EqualTest(string str, int result)
        {
            // act
            var actualRes = MaxNumberOF.SequenceOfDigits(str);
            // assert
            Assert.AreEqual(result, actualRes);
        }
    }
}