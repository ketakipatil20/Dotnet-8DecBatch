using System;
using System.Collections.Generic;
using System.Text;
namespace Assignment_8_B



{
    class SoftwareAttribute : System.Attribute
    {
        /*private string ProjectName;
        private string Description;
        private string ClientName;
        private string StartedDate;
        private string EndDate;*/



        public string PROJECTNAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string CLIENTNAME { get; set; }
        public string STARTEDDATE { get; set; }
        public string ENDDATE { get; set; }
    }
}
