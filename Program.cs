using EF.Models;
using System;
using System.Collections.Generic;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DBContext db = new DBContext())
            {
                ArticleCommonTable articleCommon1 = new ArticleCommonTable { ArticleTitle = "ACT1" };
                ArticleCommonTable articleCommon2 = new ArticleCommonTable { ArticleTitle = "ACT2" };
                db.ArticleCommonTables.AddRange(new List<ArticleCommonTable> { articleCommon1, articleCommon2 });
                db.SaveChanges();

                ArticleFirstTypeTable articleFirstType1 = new ArticleFirstTypeTable { Id = articleCommon1.id, ArticleFirstTypeProperty = "AFTT1" };
                ArticleFirstTypeTable articleFirstType2 = new ArticleFirstTypeTable { Id = articleCommon2.id, ArticleFirstTypeProperty = "AFTT2" };
                db.ArticleFirstTypeTables.AddRange(new List<ArticleFirstTypeTable> { articleFirstType1, articleFirstType2 });
                db.SaveChanges();

                ArticleSecondTypeTable articleSecondType1 = new ArticleSecondTypeTable { Id = articleCommon1.id, ArticleSecondTypeProperty = "ASTT1" };
                ArticleSecondTypeTable articleSecondType2 = new ArticleSecondTypeTable { Id = articleCommon2.id, ArticleSecondTypeProperty = "ASTT2" };
                db.ArticleSecondTypeTables.AddRange(new List<ArticleSecondTypeTable> { articleSecondType1, articleSecondType2 });
                db.SaveChanges();

                foreach (ArticleCommonTable articleCommon in db.ArticleCommonTables.Include("ArticleFirstTypeTable"))
                    Console.WriteLine("Title: {0}", articleCommon.ArticleTitle);
            }
        }
    }
}
