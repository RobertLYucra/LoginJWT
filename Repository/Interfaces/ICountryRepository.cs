using LoginJWT.Models;

namespace LoginJWT.Repository.Interfaces
{
    public interface ICountryRepository
    {
        Task<List<CountryModel>> GetAllCounties()
;
    }
}
