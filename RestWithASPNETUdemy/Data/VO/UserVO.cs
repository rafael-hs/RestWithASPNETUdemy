using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Tapioca.HATEOAS;


namespace RestWithASPNETUdemy.VO
{ 
    public class UserVO
    {
        public string Login { get; set; }
        public string AccessKey { get; set; }
    }
}
