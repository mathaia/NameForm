using Microsoft.AspNetCore.Mvc;
using NameForm.Models;
using System.Diagnostics;
using Newtonsoft.Json;
using System.IO;
using System.Text.Json;

namespace NameForm.Controllers
{
    public class NameController : Controller
    {

        public NameController()
        {
        }

        public IActionResult GenerateFile(NameViewModel nameObject)
        {

            if(nameObject.FirstName != null && nameObject.LastName != null)
            {
                string firstName = nameObject.FirstName;
                string lastName = nameObject.LastName;
            }

            string fileName = "nameOutput.json";

            string jsonString = JsonConvert.SerializeObject(nameObject, Formatting.Indented);

            using (TextWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(jsonString);
                writer.Close();
            }

            return View("~/Views/Home/Index.cshtml");
        }
    }
}