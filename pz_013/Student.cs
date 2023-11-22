using System.ComponentModel.DataAnnotations;

namespace pz_013
{
    internal class Student
    {
		[Required(ErrorMessage = "empty field")]
		[StringLength(10, MinimumLength =1, ErrorMessage = "incorrect length")]
		private string login;
		public string Login
		{
			get { return login; }
			set { login = value; }
		}

        [Required(ErrorMessage = "empty field")]
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [Required(ErrorMessage = "empty field")]
        private string password;
		public string Password
		{
			get { return password; }
			set { password = value; }
		}


	}
}
