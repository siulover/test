using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebApplication9.Models
{
   
    public class Move
    {
        public int Id { get; set; }
        //通过DataAnnotations来对model属性进行规范。同时也提供了在服务端对数据的验证。如果不符合规范则会被打回客户端。
        //拉在Move的控制器中Create默认创建时就创建有两个方法， public ActionResult Create（） 和pblic ActionResult Create([Bind(Include = "Id,Title,ReleaseDate,Genre,Price")] Move move)
        //其中第一个就是在创建之前，如果客户端的验证被禁止，那么传到服务端的数据会先给public ActionResult Create（）按照Mode的DataAnnotations的配置进行验证，如果通过才会
        //传递给pblic ActionResult Create([Bind(Include = "Id,Title,ReleaseDate,Genre,Price")] Move move)，否则就会直接返回错误信息给客户端。
        [StringLength(80, MinimumLength = 5)]
        public string Title { get; set; }


        [Display(Name = "上映时间")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        [Required]
        public DateTime ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string Genre { set; get; }

        public decimal Price { get; set; }
    }
}