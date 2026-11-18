using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class InvoiceNote
    {

        public InvoiceNote() { }

        

        public InvoiceNote( string noteId , string note , string action , string noteTime)
        {
            this.NoteId = noteId;
            this.Note = note;
            this.Action = action;
            this.NoteTime = noteTime;
        }

            public string NoteId { get; set; }
            public string Note { get; set; }
            public string Action { get; set; }
            public string NoteTime { get; set; }

        

    }

}
