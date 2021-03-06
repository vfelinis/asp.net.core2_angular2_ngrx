using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site.Data.Stores
{
    public interface ISettingStore
    {
        Task<Setting> GetFirstSettingAsync();
        Task<Setting> GetSettingByIdAsync(int settingId);
        Task UpdateSettingAsync(Setting setting);
    }
}