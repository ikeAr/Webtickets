using System.Collections.Generic;
namespace WebTickets
{
    using SquirrelFramework.Domain.Model;
    using System.ComponentModel;
    using System.Web;
    [Collection("Request")]
    public class RequestModel : DomainModel
    {
        //public RequestModel()
        //{
        //    this.ImageList = new List<Image>();
        //}
        [DisplayName("报修人")]
        public string UserName { set; get; }
        [DisplayName("学号")]
        public string StudentId { get; set; }
        [DisplayName("问题描述")]
        public string ProblemTitle { set; get; }
        [DisplayName("锐捷提示截图")]
        public Image Image { set; get; }
        [DisplayName("紧急情况")]
        public string Level { set; get; }
        [DisplayName("联系电话")]
        public string Telephone { set; get; }
        [DisplayName("所在位置")]
        public string Location { set; get; }
        [DisplayName("期待处理时间")]
        public string ExpectTime { set; get; }
        [DisplayName("处理状态")]
        public int Condition { set; get; }//处理状态
        [DisplayName("处理人")]
        public string Maintainer { set; get; }
    }
    public class Image
    {
        public string ImagePath { get; set; }
        public HttpPostedFileBase ImageFile { get; set; }
    } 
}
