using NotesTaker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NotesTaker
{
    public partial class Default : System.Web.UI.Page
    {
        public List<Note> Notes;
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new NoteContext())
            {
                Notes = db.Notes.ToList();
            }

        }
    }
}