using EntityLayer.Concrete;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal:IGenericDal<Blog>
    {
        List<Blog> GetListWithCategory();
    }
}