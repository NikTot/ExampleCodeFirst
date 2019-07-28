using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
    public class ArticleFirstTypeTable
    {
        [Key]
        [ForeignKey("ArticleCommonTable")]
        public int Id { get; set; }
        public string ArticleFirstTypeProperty { get; set; }
        public ArticleCommonTable ArticleCommonTable { get; set; }
    }
}
