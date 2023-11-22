using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace pz_013
{
    internal class Student : IDataErrorInfo
    {
		private string login = "";
        private string email = "";
        private string password = "";
        private string password2 = "";

        public string Error => throw new System.NotImplementedException();
        public string this[string columnName]
        {
            get
            {
                string er = "";
                string regPattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,3}";

                switch (columnName)
                {
                    case "Login":
                        if (Login == "" | Login.Length < 1 | Login.Length > 10) er = "login fake";
                        break;
                    case "Email":
                        if (Email == "" | Regex.IsMatch(Email, regPattern)) er = "email fake";
                        break;
                    case "Password":
                        if (Password == "" | Password.Length < 10 | Password.Length > 100) er = "pswd fake";
                        break;
                    case "Password2":
                        if (Password2 != Password) er = "pswrd2 fake";
                        break;
                }

                return er; 
            }
        }

        #region QuestionsAboutValidation

        [Required(ErrorMessage = "empty field")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "incorrect length")]
        public string Login
		{
			get { return login; }
			set { login = value; }
		}

        [Required(ErrorMessage = "empty field")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,3}", ErrorMessage = "incorrect email")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [Required(ErrorMessage = "empty field")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "incorrect length")]
		public string Password
		{
			get { return password; }
			set { password = value; }
		}

        [Compare("Password", ErrorMessage = "password 2 eror")]
        public string Password2
		{
			get { return password2; }
			set { password2 = value; }
		}
        #endregion

    }
}
