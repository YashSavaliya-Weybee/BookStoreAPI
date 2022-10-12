using BookStore.Model;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);
        Task<string> LoginAsync(SignInModel signInModel);
    }
}