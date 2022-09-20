using PhotoSharingApplication.Shared.Entities;
using PhotoSharingApplication.Shared.Interfaces;

namespace PhotoSharingApplication.WebServices.REST.Photos.Core.Services
{
    public class PhotoService : IPhotosService
    {
        private readonly IPhotosRepository _photosRepository;
        public PhotoService(IPhotosRepository photosRepository) => this._photosRepository = photosRepository;
        public async Task<Photo?> FindAsync(int id) => await _photosRepository.FindAsync(id);
        public async Task<List<Photo>> GetPhotosAsync(int amount = 10) => await _photosRepository.GetPhotosAsync(amount);
        public async Task<Photo?> RemoveAsync(int id) => await _photosRepository.RemoveAsync(id);
        public async Task<Photo?> UpdateAsync(Photo photo) => await _photosRepository.UpdateAsync(photo);
        public async Task<Photo?> UploadAsync(Photo photo)
        {
            photo.CreatedDate = DateTime.Now;
            return await _photosRepository.CreateAsync(photo);
        }
    }
}
