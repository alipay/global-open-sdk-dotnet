namespace com.alipay.ams.api.entities;

public class DisputeDefenseFile
{
    /// <summary>Name of the generated defense material.</summary>
    public string FileName { get; set; }
    /// <summary>Material format: PDF or WORD.</summary>
    public string FileFormat { get; set; }
    /// <summary>MD5 of the material body as 32 lowercase hexadecimal characters.</summary>
    public string FileMd5 { get; set; }
}
