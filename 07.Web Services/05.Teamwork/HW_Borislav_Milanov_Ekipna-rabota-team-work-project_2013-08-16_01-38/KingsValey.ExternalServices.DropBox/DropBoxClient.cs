using Spring.IO;
using Spring.Social.Dropbox.Api;
using Spring.Social.Dropbox.Connect;
using Spring.Social.OAuth1;

namespace KingsValey.ExternalServices.DropBox
{
    public static class DropboxClient
    {
        // Register your own Dropbox app at https://www.dropbox.com/developers/apps
        // with "Full Dropbox" access level and set your app keys and app secret below
        private const string DropboxAppKey = "gdxe9mfugp5geqy";

        private const string DropboxAppSecret = "1boynshwybll3sw";

        public static string UploadAvatar(string fileName, string physicalPath)
        {
            DropboxServiceProvider dropboxServiceProvider =
                new DropboxServiceProvider(DropboxAppKey, DropboxAppSecret, AccessLevel.AppFolder);

            // Authenticate the application (if not authenticated) and load the OAuth token

            OAuthToken oauthAccessToken = LoadOAuthToken();

            // Login in Dropbox
            IDropbox dropbox = dropboxServiceProvider.GetApi(oauthAccessToken.Value, oauthAccessToken.Secret);

            // Display user name (from his profile)
            DropboxProfile profile = dropbox.GetUserProfileAsync().Result;

            // Upload a file
            Entry uploadFileEntry = dropbox.UploadFileAsync(
                new FileResource(physicalPath), string.Format(fileName)).Result;

            string avatar = (dropbox.GetMediaLinkAsync(uploadFileEntry.Path).Result).Url;

            return avatar;
        }

        private static OAuthToken LoadOAuthToken()
        {
            OAuthToken oauthAccessToken = new OAuthToken("w5or56g1r7ocl5hl", "98ll0sbo6ziu9ga");
            return oauthAccessToken;
        }
    }
}