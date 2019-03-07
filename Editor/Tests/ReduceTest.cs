using NUnit.Framework;
using ParallelPrefixSum.Funcs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ParallelPrefixSum.Tests {

	public class ReduceTest {

		[Test]
		public void TestReduce() {
			var input = new int[] { 3, 1, 7, 0, 4, 1, 6, 3, 1 };
			var output = input.Reduce((a, b) => a + b);
			Assert.AreEqual(26, output);
		}
	}
}
