using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Linq.Dynamic.Core;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your filter");
            
            List<string>  l = new List<string>(new string[]{"Mohamed", "Mihir", "Steve", "Madhavi", "Brian" , "Ted", "Pam", "Sneha"});
            string filter = Console.ReadLine();
            var p = Expression.Parameter(typeof(string),"filter");
            IQueryable q = l.AsQueryable();
            var f = q.Where(filter);
            //var e = DynamicExpression.p;
            
            var m =l.Where(i => i.StartsWith("M"));
            //Console.WriteLine("Hello World!");
            foreach (var v in f)
            {
                Console.WriteLine(v);
            }
            
        }
    }
}