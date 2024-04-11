using Program;
 

namespace DAL
{
    public class DataAccess : DBContext
    {
        public DataAccess(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
