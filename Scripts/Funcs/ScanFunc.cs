using nobnak.Gist.Extensions.Int;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ParallelPrefixSum.Funcs {

	public static class ScanFunc {

		public static T[] Prescan<T>(this T[] input, System.Func<T, T, T> addop) {
			var n = input.Length.Po2();
			var tmp0 = new T[n];
			var tmp1 = new T[n];
			System.Array.Copy(input, tmp0, input.Length);

			return null;
		}
	}
}