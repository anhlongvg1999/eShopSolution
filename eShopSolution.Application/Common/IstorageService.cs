using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Common
{
    /// <summary>
    /// save file và lưu thông tin file
    /// </summary>
    public interface IstorageService
    {
        string GetFileUrl(string fileName);

        Task SaveFileAsync(Stream mediaBinaryStream, string fileName);

        Task DeleteFileAsync(string fileName);
    }
}
