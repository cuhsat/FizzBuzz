using System.Text;

namespace FizzBuzz
{
    /// <summary>
    /// A simple FizzBuzz algorithm implementation.
    /// </summary>
    public sealed class FizzBuzz
    {
        /// <summary>
        /// Returns the counted results using the FizzBuzz algorithm.
        /// </summary>
        /// <param name="max">The max to count to (default 100).</param>
        /// <returns>The counted results.</returns>
        public static IEnumerable<string> Count(int max = 100)
        {
            foreach (var i in Enumerable.Range(1, max))
            {
                var result = new StringBuilder();

                if (i % 3 == 0) result.Append("Fizz");
                if (i % 5 == 0) result.Append("Buzz");
                if (result.Length == 0) result.Append(i);

                yield return result.ToString();
            }
        }
    }
}
