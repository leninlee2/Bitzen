using Bitzen_LeninAguiar_InfraStructure.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bitzen_LeninAguiar_Domain.Interface
{
    public interface ILoginService
    {
        Login Authentication(String login, String password);
        Login Create(Login login);

    }

}
