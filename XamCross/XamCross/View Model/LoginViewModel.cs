using System;
using System.Collections.Generic;
using System.Text;
using XamCross.Model;

namespace XamCross.View_Model
{
    public class LoginViewModel
    {
        private LoginPageModel loginPageModel;

        public LoginPageModel LoginPageModel { get
            {
                return loginPageModel;
            }
            set
            {
                loginPageModel = value;
            }
        }


        public LoginViewModel()
        {
            LoginPageModel = new LoginPageModel { UserName = "Vikas" , Password = "123456" };

        }
    }
}
