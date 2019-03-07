using nobnak.Gist;
using nobnak.Gist.Extensions.Int;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ParallelPrefixSum.Funcs {

	public static class ReduceFunc {

		#region interface
		public static T Reduce<T>(this T[] input, System.Func<T,T,T> addop) {
			var n = input.Length.Po2();
			var tmp0 = new T[n];
			var tmp1 = new T[n];
			System.Array.Copy(input, tmp0, input.Length);

			var dlim = Mathf.RoundToInt(Mathf.Log(n, 2f));
			for (var d = 0; d < dlim; d++) {
				var j = n >> (d + 1);
				var arg = new DataForReduce<T>(tmp0, tmp1, d, addop);
				Parallel.For(0, j, ReduceEach, arg);
				Swap(ref tmp0, ref tmp1);
			}

			return tmp0[tmp0.Length - 1];
		}
		#endregion

		#region member
		private static void ReduceEach<T>(int j, DataForReduce<T> arg) {
			var k = 1 << arg.d;
			var i = 2 * j * k;

			var a0 = k * (2 * j + 1) - 1;
			var a1 = 2 * k * (j + 1) - 1;
			arg.tmp1[a1] = arg.addop(arg.tmp0[a0], arg.tmp0[a1]);
		}
		private static void Swap<T>(ref T[] tmp0, ref T[] tmp1) {
			var tt = tmp0;
			tmp0 = tmp1;
			tmp1 = tt;
		}
		#endregion

		#region classes
		public struct DataForReduce<T> {
			public readonly T[] tmp0;
			public readonly T[] tmp1;
			public readonly int d;
			public readonly System.Func<T, T, T> addop;

			public DataForReduce(T[] tmp0, T[] tmp1, int d, System.Func<T, T, T> addop) {
				this.tmp0 = tmp0;
				this.tmp1 = tmp1;
				this.d = d;
				this.addop = addop;
			}
		}
		#endregion
	}
}
