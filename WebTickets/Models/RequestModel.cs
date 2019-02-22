﻿using System.Collections.Generic;
namespace WebTickets
{
    using SquirrelFramework.Domain.Model;
    using System.ComponentModel;

    [Collection("Request")]
    public class RequestModel : DomainModel
    {
        [DisplayName("报修人")]
        public string UserName { set; get; }
        [DisplayName("问题描述")]
        public string ProblemTitle { set; get; }
        [DisplayName("锐捷提示截图")]
        public List<string> Screenshots { set; get; }//string类型的
        [DisplayName("紧急情况")]
        public string Level { set; get; }           //类型
        [DisplayName("联系电话")]
        public string Telephone { set; get; }
        [DisplayName("所在位置")]
        public string Location { set; get; }
        [DisplayName("期待处理时间")]
        public string ExpectTime { set; get; }
        [DisplayName("处理状态")]
        public int Condition { set; get; }       //处理状态

    }
}
