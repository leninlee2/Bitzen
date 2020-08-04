using Bitzen_LeninAguiar_Domain.Repository;
using Bitzen_LeninAguiar_InfraStructure.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Bitzen_LeninAguiar_Domain.Interface;

namespace Bitzen_LeninAguiar_Domain.Service
{
    public class LoginService : ILoginService
    {
        LoginRepository loginRepository;

        public LoginService()
        {
            loginRepository = new LoginRepository();
        }

        public Login Authentication(String login, String password)
        {
            Login result = new Login();
            try {
                if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password))
                    throw new Exception("Favor preencher dados de login e senha");

                var tempt = loginRepository.find(new Login() { email = login, password = password });
                if (tempt.Count() > 0)
                    result = tempt.First();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
            return result;
        }

        public Login Create(Login login)
        {
            try {
                login = loginRepository.saveUpdate(login);
            }
            catch(Exception ex)
            {

            }
            return login;
        }

    }

}
