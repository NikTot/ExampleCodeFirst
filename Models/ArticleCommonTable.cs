namespace EF.Models
{
    public class ArticleCommonTable
    {
        public int id { get; set; }
        public string ArticleTitle { get; set; }
        public ArticleFirstTypeTable ArticleFirstTypeTable { get; set; }
        public ArticleSecondTypeTable ArticleSecondTypeTable { get; set; }
    }
}
