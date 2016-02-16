using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExpressinBodyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] companies = { "Consolidated Messenger", "Alpine Ski House", "Southridge Video", "City Power & Light",
                   "Coho Winery", "Wide World Importers", "Graphic Design Institute", "Adventure Works",
                   "Humongous Insurance", "Woodgrove Bank", "Margie's Travel", "Northwind Traders",
                   "Blue Yonder Airlines", "Trey Research", "The Phone Company",
                   "Wingtip Toys", "Lucerne Publishing", "Fourth Coffee" };
            IQueryable<String> queryableData = companies.AsQueryable<string>();

            // Let's try to genarate:
            // companies.Where(company => (company.ToLower() == "coho winery" || company.Length > 16)).OrderBy(company => company)

            ParameterExpression pe = Expression.Parameter(typeof (string), "company");

            // 'company.ToLower() == "coho winery"'
            Expression left = Expression.Call(pe, typeof (string).GetMethod("ToLower", System.Type.EmptyTypes));
            Expression right = Expression.Constant("coho winery");
            Expression e1 = Expression.Equal(left, right);

            // 'company.Length > 16'
            left = Expression.Property(pe, typeof(string).GetProperty("Length"));
            right = Expression.Constant(30, typeof (int));
            Expression e2 = Expression.GreaterThan(left,right);

            // '(company.ToLower() == "coho winery" || company.Length > 16)'
            Expression predicateBody = Expression.OrElse(e1,e2);

            // 'queryableData.Where(company => (company.ToLower() == "coho winery" || company.Length > 16))'
            MethodCallExpression whereCallExpression = Expression.Call(
                typeof (Queryable),
                "Where",
                new Type[] {queryableData.ElementType},
                queryableData.Expression,
                Expression.Lambda<Func<string, bool>>(predicateBody, pe));
            // ***** End Where *****

            // ***** OrderBy(company => company) *****
            // Create an expression tree that represents the expression
            // 'whereCallExpression.OrderBy(company => company)'
            MethodCallExpression orderByCallExpression = Expression.Call(
                typeof (Queryable),
                "OrderBy",
                new Type[] {queryableData.ElementType, queryableData.ElementType},
                whereCallExpression,
                Expression.Lambda<Func<string, string>>(pe, pe));

            // Create an executable query from the expression tree.
            var result = queryableData.Provider.CreateQuery<string>(orderByCallExpression);
            foreach (var company in result)
            {
                Console.WriteLine(company);
            }

            Console.ReadLine();
        }
    }
}
