﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AlgClass
{
    [TestFixture]
    public class TwoSumAlgTests
    {
        [Test]
        public void TwoSumMedian3060()
        {
            var numbers = new HashSet<int>
                {
                   42,200,16,480,536,598,145,190,573,180,484,114,558,465,115,148,378,37 ,156,125,57 ,201,316,74 ,533,356,392,158,149,386,582,114,153,43 ,546,108,351,262,533,362,507,360,271,593,254,589,277,566,270,162,542,320,91 ,436,503,472,577,56 ,406,359,545,312,36 ,282,74 ,495,244,28 ,445,305,440,281,30 ,26 ,42 ,266,438,170,352,577,277,537,401,346,117,204,348,189,234,116,95 ,444,550,344,365,349,305,199,281,277
                };
            
            Assert.AreEqual(9, TwoSumAlg.Calculate(30, 60, numbers));
        }

        [Test]
        public void TwoSumMedian60100()
        {
            var numbers = new HashSet<int>
                {
                    42,200,16,480,536,598,145,190,573,180,484,114,558,465,115,148,378,37 ,156,125,57 ,201,316,74 ,533,356,392,158,149,386,582,114,153,43 ,546,108,351,262,533,362,507,360,271,593,254,589,277,566,270,162,542,320,91 ,436,503,472,577,56 ,406,359,545,312,36 ,282,74 ,495,244,28 ,445,305,440,281,30 ,26 ,42 ,266,438,170,352,577,277,537,401,346,117,204,348,189,234,116,95 ,444,550,344,365,349,305,199,281,277
                };

            Assert.AreEqual(28, TwoSumAlg.Calculate(60, 100, numbers));
        }
    }
}