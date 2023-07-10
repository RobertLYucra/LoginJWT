using LoginJWT.Constans;
using LoginJWT.Models;
using LoginJWT.Repository.Interfaces;

namespace LoginJWT.Repository
{
    public class CountryRepository : ICountryRepository
    {
        public List<CountryModel> GetAllCounties()
        {
            return CountryConstants.CountryList;
        }
    }
}
