using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.Data.IDAO;
using NAA.Data.Models.Domain;
using NAA.Data.Repository;


namespace NAA.Data.IDAO
{
    public interface IUniversityDAO
    {
        IList<University> GetUniversities(NAAContext context);
    }
}
