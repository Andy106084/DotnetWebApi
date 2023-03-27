using System.ComponentModel.DataAnnotations;

namespace DotnetWebApi.Dto
{
    public class LoginDto
    {
        /// <example>0xEFa4Abac7FedB8F0514beE7212dc19D523DD3089</example>
        public string address { get; set; }
        /// <example>0xee285f7ee0d69071cb1ca4a8f92013d47164393ee8c2337bd1e5b5cf5e476232709e5d32932fe5f5749a5d41f518cd50bd1dd7dd967c8355c8666b39b93033fb1c</example>
        public string signature { get; set; }
    }
    public class LoginDto200
    {
        /// <example>200</example>
        public string StatusCode { get; set; }

        /// <example>3fa85f64-5717-4562-b3fc-2c963f66afa6</example>
        public string Nonce { get; set; }

    }
    public class LoginDto404
    {
        /// <example>404</example>
        public string StatusCode { get; set; }

        /// <example>登入驗證失敗</example>
        public string Title { get; set; }

    }
}