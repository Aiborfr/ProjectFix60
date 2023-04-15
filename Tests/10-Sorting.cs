using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class Sorting_Tests
    {
        [TestMethod]
        public void Sorted_Test()
        {
            //Arrange
            List<int> list = new List<int>(100);
            for (int i = 0; i < 100; i++)
            {
                list.Add(Utils.random.Next());
            }

            //Act
            list = Sorting.Program.Sort(list);

            //Assert
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    throw new Exception("List is not sorted, element '" + list[i] + "' (" + i + ") is bigger than '" + list[i + 1] + "' (" + (i + 1) + ")");
                }
            }
        }
    }
}