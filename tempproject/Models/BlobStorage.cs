using System.ComponentModel.DataAnnotations;

namespace tempproject.Models
{
    public class BlobStorage
    {
        [Display(Name = "File Name")]
        public string FileName
        {
            get;
            set;
        }
        [Display(Name = "File Size")]
        public string FileSize
        {
            get;
            set;
        }
        public string Modified
        {
            get;
            set;
        }
    }
}
