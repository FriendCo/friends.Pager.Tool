using System.Collections.Generic;

namespace Pager
{

    /// <summary>
    /// Paging Result
    /// </summary>
    /// <typeparam name="T">Your List Type</typeparam>
    public class Result<T>
    {
        /// <summary>
        /// Page Count For Show To User not Zero Base
        /// </summary>
        public double PageCount { get; set; }

        /// <summary>
        /// Your List Type Result
        /// </summary>
        public List<T> List { get; set; }

    }
}
