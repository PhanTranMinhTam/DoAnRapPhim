using DAL;
using DTO;
using System.Data;

namespace BUL
{
    public class ConfigBUL
    {
        ConfigDAL dal = new ConfigDAL();

        public void SaveConfig(ConfigDTO config)
        {
            dal.SaveConfig(config);
        }

        public DataTable getDatabase(ConfigDTO config)
        {
            return dal.getDatabase(config);
        }
    }
}
