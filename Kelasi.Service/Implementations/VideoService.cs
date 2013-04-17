using Kelasi.DAL.Contracts;
using Kelasi.Model;
//using Kelasi.Model.DTO;
using Kelasi.Repository;
using Kelasi.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
//using System.Web.Security;

namespace Kelasi.Service.Implementations
{
    public class VideoService : IVideoService
    {
        IUnitOfWork _unitOfWork;
        IVideoRepository _videoRepository;
        

        public VideoService(
            IUnitOfWork unitOfWork,
            IVideoRepository videoRepository)
        {
            this._unitOfWork = unitOfWork;
            this._videoRepository = videoRepository;
            
        }
               
    }
}
