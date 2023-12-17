using Google.Cloud.Storage.V1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickTix.Controller
{
    public class FirebaseStorageManager
    {
        private readonly StorageClient _storageClient;

        public FirebaseStorageManager()
        {
            _storageClient = StorageClient.Create();
        }

        public async Task<string> SubirImagenAsync(string rutaLocal, string nombreArchivoEnStorage)
        {
            try
            {
                using (var fileStream = File.OpenRead(rutaLocal))
                {
                    var objectName = $"portada/{nombreArchivoEnStorage}";


                    var uploadObject = await _storageClient.UploadObjectAsync(
                        "clicktixmobile.appspot.com",
                        objectName,
                        "image / jpeg",
                        fileStream
                    );

                    var urlDescarga = $"https://firebasestorage.googleapis.com/v0/b/clicktixmobile.appspot.com/o/portada%2F{nombreArchivoEnStorage}?alt=media";

                    return urlDescarga;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al subir la imagen a Firebase Storage: {ex.Message}");
                return "";
            }
        }
    }
}
