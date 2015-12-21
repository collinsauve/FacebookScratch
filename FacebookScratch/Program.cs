using System;
using Facebook;
using NUnit.Framework;

namespace FacebookScratch
{
    [TestFixture]
    public class Program
    {

        public class Person
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public override bool Equals(object obj)
            {
                var cast = obj as Person;
                if (cast == null)
                {
                    return false;
                }
                return cast.FirstName.Equals(FirstName) &&
                       cast.LastName.Equals(LastName);
            }
        }



        public static void Main(string[] args)
        {

        }

        [Test]
        public void Test() { 

            var p1 = new Person
            {
                FirstName = "Collin",
                LastName = "Sauve"
            };
            var p2 = new Person
            {
                FirstName = "Collin",
                LastName = "Sauve2"
            };

            Assert.AreEqual(p1, p2);
        }
    }
}
