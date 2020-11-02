using System;
using System.Collections.Generic;

namespace Pager
{

    /// <summary>
    /// Paging Class
    /// </summary>
    /// <typeparam name="T">Your List Type For Paging</typeparam>
    public static class Pager<T>
    {

        /// <summary>
        /// Get Pages Result For Paging
        /// </summary>
        /// <param name="value">Your List</param>
        /// <param name="count">Page Count Items</param>
        /// <param name="index">Page Index zero base</param>
        /// <returns></returns>
        public static Result<T> Paging(List<T> value, int count = 10, int index = 0)
        {
            //===================================================================
            //Math Actions
            //pagecount = value / count 
            //pagecountRemaning = value % count 
            //Page Count = pagecount + pagecountRemaning
            //start = start * count
            int end = 10;
            int start = 0;

            int pagecount = value.Count / count;
            int remaning = value.Count % count;
            string strPageCount = pagecount.ToString() + "." + remaning.ToString();

            //Return Count 
            double pageCount = Convert.ToDouble(strPageCount);
            //===================================================================
            
            //===================================================================
            if (index != 0)
            {
                int st = index * count;
                int en = st + count;
                if (st == en)
                {
                    st = st - en;
                }

                List<T> lst0 = new List<T>();
                if (value.Count > en)
                {
                    for (int i = st; i < en; i++)
                    {
                        lst0.Add(value[i]);
                    }
                }
                else
                {
                    for (int i = st; i < value.Count; i++)
                    {
                        lst0.Add(value[i]);
                    }
                }

                var result0 = new Result<T>()
                {
                    List = lst0,
                    PageCount = pageCount
                };

                return result0;
            }
            //===================================================================

            //===================================================================
            //if Index is zero
            List<T> lst = new List<T>();
            if (value.Count > end)
            {
                for (int i = start; i < end; i++)
                {
                    lst.Add(value[i]);
                }
            }
            else
            {
                for (int i = start; i < value.Count; i++)
                {
                    lst.Add(value[i]);
                }
            }

            var result = new Result<T>()
            {
                List = lst,
                PageCount = pageCount
            };

            return result;
            //===================================================================

        }
    }
}

