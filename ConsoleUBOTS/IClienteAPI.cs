using System;
using Refit;
using System.Threading.Tasks;

namespace ConsoleUBOTS
{
    
    public interface IClienteAPI
    {
        //[Get("/ws/{cpf}/json")]
        [Get("")]
        Task<Rootobject> GetAddressAsync(string cpf);

    }

}
