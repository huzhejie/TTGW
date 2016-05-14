using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TTG.Web
{
    /// <summary>
    /// communityBase 的摘要说明
    /// </summary>
    public class communityBase : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            String p = context.Request["province"];
            String c = context.Request["county"];
            String comm = context.Request["community"];
            json1.communityToJson comm2j;
            json1.countyToJson c2j;
            json1.provinceToJson p2j;

            if (isPrivacy())
            {
                //权限测试默认通过,待完成,需前端配合传输用户信息,暂时未接收
                if (p != null && p != "")
                {
                    if (c != null && c != "")
                    {
                        if (comm != null && comm != "")
                        {
                            comm2j = new json1.communityToJson(p, c, comm);
                            context.Response.Write(comm2j.getResult());
                        }
                        else
                        {
                            c2j = new json1.countyToJson(c, p);
                            context.Response.Write(c2j.getResult());
                        }
                    }
                    else
                    {
                        p2j = new json1.provinceToJson(p);
                        context.Response.Write(p2j.getResult());
                    }                   
                }
                else
                {
                    context.Response.Write("缺少province");
                }
            }
        }
        /// <summary>
        /// 判断用户权限,需先获取用户信息
        /// </summary>
        /// <returns></returns>
        private bool isPrivacy()
        {

            return true;
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}