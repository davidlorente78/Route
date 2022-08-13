namespace RouteDataManager.Models
{
    public class FileLocation<T>
    {
        public string ClassName { get; protected set; }

        public FileLocation() {

            ClassName = nameof(T);
        }

        public string FileUploadFolder
        {
            get
            {
                return ClassName + "Uploads";
            }
        }


        public string RetriveFileFromFolderget
        {
            get
            {
                return "~/" + ClassName + "Uploads/";
            }
        }


    public string DeleteFileFromFolder
        {
            get
            {
                return "wwwroot\\" + ClassName + "Uploads\\";
            }
        }
}
}