using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OUDAL.Model;
using OUDAL.ModelBase;

namespace OUDAL.BLL
{
    public static class BllExtension
    {
        public static SearchListResult<ShouKuanInfo> ToSearchShouKuanInfoList(this IQueryable<ShouKuanInfo> query, BaseSearchReq req)
        {
#if DEBUG
            //query.
            //            query.Database.Log = (log) => { System.Diagnostics.Debug.WriteLine(log); };
#endif

            query = query.OrderByDescending(d => d.JMSShouKuan.id);
            SearchListResult<ShouKuanInfo> retListResult = new SearchListResult<ShouKuanInfo>();
            retListResult.records = query.Count();
            retListResult.rows = query.Skip((req.page - 1) * req.rows).Take(req.rows).ToList();
            retListResult.page = req.page;
            retListResult.total = (retListResult.records - 1) / req.rows + 1;


            return retListResult;
        }
        public static SearchListResult<T> ToSearchList<T>(this IQueryable<T> query, BaseSearchReq req,bool isWithOrder=true)
        {
#if DEBUG
        
            //query.
            // query.Log = (log) => { System.Diagnostics.Debug.WriteLine(log); };
#endif
            if (req.rows == 0)
            {
                req.rows = 100000;
            }
            if (req.page <= 0)
            {
                req.page = 1;
            }
            if(isWithOrder)
            query = OrderingHelper<T>(query, req.sidx, req.sord == "desc", false); 

            SearchListResult<T> retListResult = new SearchListResult<T>();
            retListResult.records = query.Count(); 
            retListResult.rows = query.Skip((req.page - 1)*req.rows).Take(req.rows).ToList();
            retListResult.page = req.page;
            retListResult.total = (retListResult.records - 1)/req.rows + 1;


            return retListResult;
        }

        static IOrderedQueryable<T> OrderingHelper<T>(IQueryable<T> source, string propertyName, bool descending, bool anotherLevel)
        {
            ParameterExpression param = Expression.Parameter(typeof(T), string.Empty); // I don't care about some naming
            MemberExpression property = Expression.PropertyOrField(param, propertyName);
            LambdaExpression sort = Expression.Lambda(property, param);
            MethodCallExpression call = Expression.Call(
                typeof(Queryable),
                (!anotherLevel ? "OrderBy" : "ThenBy") + (descending ? "Descending" : string.Empty),
                new[] { typeof(T), property.Type },
                source.Expression,
                Expression.Quote(sort));
            return (IOrderedQueryable<T>)source.Provider.CreateQuery<T>(call);
        }
    }


    
}
