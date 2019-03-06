using System.Collections;
using System.Collections.Generic;

namespace ParallelPrefixSum.Common {

	public class Calc<T> : IList<T> {
		protected IList<T> input;
		protected System.Func<T, T> filter;

		public Calc(IList<T> input, System.Func<T, T> filter) {
			this.input = input;
			this.filter = filter;
		}
		public T this[int index] {
			get { return filter(input[index]); }
			set { throw new System.NotImplementedException(); }
		}

		public int Count { get { return input.Count; } }
		public bool IsReadOnly { get { throw new System.NotImplementedException(); } }

		public void Add(T item) {
			throw new System.NotImplementedException();
		}

		public void Clear() {
			throw new System.NotImplementedException();
		}

		public bool Contains(T item) {
			throw new System.NotImplementedException();
		}

		public void CopyTo(T[] array, int arrayIndex) {
			throw new System.NotImplementedException();
		}

		public IEnumerator<T> GetEnumerator() {
			throw new System.NotImplementedException();
		}

		public int IndexOf(T item) {
			throw new System.NotImplementedException();
		}

		public void Insert(int index, T item) {
			throw new System.NotImplementedException();
		}

		public bool Remove(T item) {
			throw new System.NotImplementedException();
		}

		public void RemoveAt(int index) {
			throw new System.NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator() {
			throw new System.NotImplementedException();
		}
	}
}
