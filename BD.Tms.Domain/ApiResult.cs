using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Tms.Domain
{
    /// <summary>
    /// 统一返回API结果
    /// </summary>
    public class ApiResult
    {
        /// <summary>
        /// 状态码
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// 状态信息
        /// </summary>
        public string Msg { get; set; }
        /// <summary>
        /// 数据
        /// </summary>
        public object Data { get; set; }

        public ApiResult()
        {
            Code = ErrorCode.Success;
            Msg = "Success";
            Data = null;
        }

        public ApiResult(int code, string msg, object data)
        {
            Code = code;
            Msg = msg;
            Data = data;
        }

        public ApiResult Success(object data=null)
        {
            Code = ErrorCode.Success;
            Msg = "Success";
            Data = data;
            return default;
        }

        public ApiResult Error(int code, string msg)
        {
            Code = code;
            Msg = msg;
            Data = null;
            return default;
        }
    }

    /// <summary>
    /// 错误码
    /// </summary>
    public class ErrorCode
    {
        /// <summary>
        /// 成功
        /// </summary>
        [Description("成功")]
        public const int Success = 200;
        /// <summary>
        /// 失败
        /// </summary>
        public const int Error = 500;
        /// <summary>
        /// 未找到
        /// </summary>
        public const int NotFound = 404;
        /// <summary>
        /// 未授权
        /// </summary>
        public const int Unauthorized = 401;
        /// <summary>
        /// 参数错误
        /// </summary>
        public const int BadRequest = 400;
    }

   
}
