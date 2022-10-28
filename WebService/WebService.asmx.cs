using DataAcces.Data;
using DataAcces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Grades> GetGrades()
        {
            Access data = new Access();
            return data.GetGrades();
        }

        [WebMethod]
        public List<Students> GetStudents()
        {
            Access data = new Access();
            return data.GetStudents();
        }


    }
}
