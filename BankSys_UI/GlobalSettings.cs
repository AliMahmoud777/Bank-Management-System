using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Microsoft.Win32;
using System.Windows.Forms;
using BankSys_Business;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using DotNetEnv;

namespace BankSys_UI
{
    public static class GlobalSettings
    {
        public static UserBusiness CurrentUser;
        public static frmLogin LoginForm;

        [Flags]
        public enum enPermissions
        {
            Admin = -1,
            None = 0, Add = 1, Edit = 2, Delete = 4,
            Find = 8, ShowAll = 16, Email = 32,
            Users = 64, Accounts = 128,
            Deposit = 256, Withdraw = 512, Transfer = 1024,
            MemberFullAccess = Add | Edit | Delete | Find | ShowAll | Email,
            TransactionFullAccess = Deposit | Withdraw | Transfer
        };


        private static readonly string _keyPath = @"HKEY_CURRENT_USER\SOFTWARE\BankSys";

        private static readonly string cryptoKey = Environment.GetEnvironmentVariable("CRYPTO_KEY");

        public static string PasswordEncryption(string Password)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(cryptoKey);
                aes.GenerateIV();

                ICryptoTransform Encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                string cipherText = "";
                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    msEncrypt.Write(aes.IV, 0, aes.IV.Length);

                    using (var csEncrypt = new CryptoStream(msEncrypt, Encryptor, CryptoStreamMode.Write))
                    using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(Password);
                    }

                    cipherText = Convert.ToBase64String(msEncrypt.ToArray());
                }

                return cipherText;
            }
        }

        public static string PasswordDecryption(string cipherPassword)
        {
            using (Aes aes = Aes.Create())
            {
                byte[] fullcipherTextBytes = Convert.FromBase64String(cipherPassword);

                aes.Key = Encoding.UTF8.GetBytes(cryptoKey);

                byte[] IV = new byte[16];
                Array.Copy(fullcipherTextBytes, IV, IV.Length);
                aes.IV = IV;

                byte[] cipherTextBytes = new byte[fullcipherTextBytes.Length - 16];
                Array.Copy(fullcipherTextBytes, 16, cipherTextBytes, 0, cipherTextBytes.Length);

                ICryptoTransform Decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                string plainText = "";
                using (var msEncrypt = new System.IO.MemoryStream(cipherTextBytes))
                using (var csEncrypt = new CryptoStream(msEncrypt, Decryptor, CryptoStreamMode.Read))
                using (var swEncrypt = new System.IO.StreamReader(csEncrypt))
                {
                    plainText = swEncrypt.ReadToEnd();
                }

                return plainText;
            }
        }

        public static bool GetStoredCredentials(ref string Username, ref string Password)
        {
            try
            {
                Username = Registry.GetValue(_keyPath, "Username", null) as string;
                Password = Registry.GetValue(_keyPath, "Password", null) as string;

                if (Password != null)
                    Password = PasswordDecryption(Password);

                if (Username != null && Password != null)
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }

        public static bool RememberMe(string Username, string Password)
        {
            try
            {
                if (Username == "" && Password == "")
                {
                    using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                    {
                        using (RegistryKey subKey = key.OpenSubKey(@"SOFTWARE\BankSys", true))
                        {
                            if (subKey != null)
                                key.DeleteSubKey(@"SOFTWARE\BankSys");
                        }
                    }

                    return true;
                }

                Registry.SetValue(_keyPath, "Username", Username, RegistryValueKind.String);
                Registry.SetValue(_keyPath, "Password", PasswordEncryption(Password), RegistryValueKind.String);

                return true;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show($"UnauthorizedAccessException: Run the program with administrative privileges");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }

        public static void WriteToEventLog()
        {
            if (!EventLog.SourceExists("BankSys"))
            {
                EventLog.CreateEventSource("BankSys", "Application");
            }

            EventLog.WriteEntry("BankSys", $"User: {CurrentUser.Username}, has logged in the system");
        }

        public static bool LoginValidation(string Username, string Password)
        {
            string userPassword = UserBusiness.GetPasswordByUsername(Username);

            if (userPassword != null)
            {
                if (Password == PasswordDecryption(userPassword))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Invalid Password", "Incorrect Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Invalid Username", "Incorrect Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool AccessValidation(enPermissions requiredPermission)
        {
            enPermissions userPermissions = (enPermissions)CurrentUser.Permissions;

            if (userPermissions == enPermissions.None)
            {
                frmMain.openChildForm(new frmAccessDenied());
                return false;
            }

            if (userPermissions == enPermissions.Admin || userPermissions.HasFlag(requiredPermission))
            {
                return true;
            }
            else
            {
                frmMain.openChildForm(new frmAccessDenied());
                return false;
            }
        }

        public static string GenerateSerialNumber()
        {
            byte[] guidBytes = Guid.NewGuid().ToByteArray();

            ulong serialNumber = BitConverter.ToUInt64(guidBytes, 0) % 1_0000_0000_0000_0000UL;
            string strSerialNumber = serialNumber.ToString("D16");

            return string.Format("{0}-{1}-{2}-{3}", strSerialNumber.Substring(0, 4), strSerialNumber.Substring(4, 4),
                strSerialNumber.Substring(8, 4), strSerialNumber.Substring(12, 4));
        }

        public static bool AccountValidation(string SerialNumber, string Password)
        {
            string accountPassword = AccountBusiness.GetPasswordBySerialNumber(SerialNumber);

            if (accountPassword != null)
            {
                if (Password == PasswordDecryption(accountPassword))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Invalid Password", "Incorrect Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Invalid Serial Number", "Incorrect Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool AccountValidation(int AccountID, string Password)
        {
            string accountPassword = AccountBusiness.GetPasswordByID(AccountID);

            if (accountPassword != null)
            {
                if (Password == PasswordDecryption(accountPassword))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Invalid Password", "Incorrect Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Invalid Account ID", "Incorrect Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool SendEmail(MemberBusiness recipientMember, string title, string body)
        {
            try
            {
                var fromAddress = new MailAddress("banksys777@gmail.com", "Bank Management System");
                var toAddress = new MailAddress(recipientMember.Email);

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com", Port = 587, EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network, UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, "btitwjhvyuxthcev")
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = title,
                    Body = string.Format("Dear, {0}\n{1}\n\nSent by user: {2}", recipientMember.FullName, body, CurrentUser.Username)
                })
                {
                    smtp.Send(message);
                    return true;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}