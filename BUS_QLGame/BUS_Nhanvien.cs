using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL_QLGame;
using DTO_QLGame;

namespace BUS_QLGame
{
    public class BUS_Nhanvien
    {
        DAL_NhanVien dalNhanvien = new DAL_NhanVien(); 
        public bool NhanVienDangNhap(DTO_NhanVien nv)
        {
            return dalNhanvien.NhanVienDangNhap(nv);
        }

        public string encryption(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }

        public bool NhanVienQuenMatKhau(string email)
        {
            return dalNhanvien.NhanVienQuenMatKhau(email);
        }

        public bool TaoMatKhau(string email, string password) 
        {
            return dalNhanvien.TaoMatKhau(email, password);
        }

    }
}
