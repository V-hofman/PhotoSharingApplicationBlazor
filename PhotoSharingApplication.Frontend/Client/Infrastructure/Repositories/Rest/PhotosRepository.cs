using PhotoSharingApplication.Shared.Entities;
using PhotoSharingApplication.Shared.Interfaces;
using System.Net.Http.Json;

namespace PhotoSharingApplication.Frontend.Client.Infrastructure.Repositories.Rest;

public class PhotosRepository : IPhotosRepository
{
    private readonly HttpClient http;

    public PhotosRepository(HttpClient http) => this.http = http;

    public async Task<Photo?> CreateAsync(Photo photo)
    {
        HttpResponseMessage response = await http.PostAsJsonAsync("/Photos", photo);
        return await response.Content.ReadFromJsonAsync<Photo>();
    }

    public async Task<Photo?> FindAsync(int id)
    {
        return await http.GetFromJsonAsync<Photo>($"/Photos/{id}");
    }

    public async Task<List<Photo>> GetPhotosAsync(int amount = 10) => await http.GetFromJsonAsync<List<Photo>>($"/Photos");


    public async Task<Photo?> RemoveAsync(int id)
    {
        HttpResponseMessage response = await http.DeleteAsync($"/Photos/{id}");
        return await response.Content.ReadFromJsonAsync<Photo>();
    }

    public async Task<Photo?> UpdateAsync(Photo photo)
    {
        HttpResponseMessage response = await http.PutAsJsonAsync($"/Photos/{photo.Id}", photo);
        return await response.Content.ReadFromJsonAsync<Photo>();
    }
}