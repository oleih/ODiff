﻿using ODiff.Interceptors;

namespace ODiff
{
    public class Diff
    {
        /// <summary>
        /// Compares public members (fields and properties) on two object
        /// graphs.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="config"></param>
        /// <returns>Diff report with detailed info about differences.</returns>
        public static DiffReport ObjectValues(object left, object right, DiffConfig config = null)
        {
            return new ObjectGraphDiff(left, right, config).Diff();
        }

        /// <summary>
        /// Compares public members (fields and properties) on two object
        /// graphs.
        /// 
        /// This function lets you "rewrite" nodes in object graph. 
        /// It's done by intercepting each node before they are compared. 
        /// This can be used to make sure two lists have same sorting.
        /// Look in the Interceptor namespace for default implementations. 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="interceptors"></param>
        /// <returns></returns>
        public static DiffReport ObjectValues(object left, object right, params INodeInterceptor[] interceptors)
        {
            return new ObjectGraphDiff(left, right, null, interceptors).Diff();
        }

        /// <summary>
        /// Compares public members (fields and properties) on two object
        /// graphs.
        /// 
        /// This function lets you "rewrite" nodes in object graph. 
        /// It's done by intercepting each node before they are compared. 
        /// This can be used to make sure two lists have same sorting.
        /// Look in the Interceptor namespace for default implementations. 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="config"></param>
        /// <param name="interceptors"></param>
        /// <returns></returns>
        public static DiffReport ObjectValues(object left, object right, DiffConfig config, params INodeInterceptor[] interceptors)
        {
            return new ObjectGraphDiff(left, right, config, interceptors).Diff();
        }
    }
}
