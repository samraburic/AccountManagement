using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.WebAPI.Helpers
{
    public class PasswordGenerator
    {

        public static string GenerateHash(string password)
        {
            byte[] arrPass = Encoding.Unicode.GetBytes(password);


            byte[] arr = new byte[arrPass.Length];

            System.Buffer.BlockCopy(arrPass, 0, arr, 0, arrPass.Length);


            HashAlgorithm alg = HashAlgorithm.Create("SHA1");

            return Convert.ToBase64String(alg.ComputeHash(arr));
        }
    }

}
