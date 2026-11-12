using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class EvidenceFile
    {

        public EvidenceFile() { }

        

        public EvidenceFile( string fileName , string fileFormat , string fileContent)
        {
            this.FileName = fileName;
            this.FileFormat = fileFormat;
            this.FileContent = fileContent;
        }

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]

            public string FileName { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string FileFormat { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string FileContent { get; set; }

        

    }

}
