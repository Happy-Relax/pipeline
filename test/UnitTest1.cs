﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void should_failed()
        {
            Assert.IsFalse(true);
        }
    }
}