using LoginJWT.Models;

namespace LoginJWT.Repository.Interfaces
{
    public interface ICountryRepository
    {
        public List<CountryModel> GetAllCounties();
    }
}
