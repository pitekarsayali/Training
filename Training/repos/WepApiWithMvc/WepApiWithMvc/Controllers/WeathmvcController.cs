using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using WepApiWithMvc.Models;

namespace WepApiWithMvc.Controllers
{
    public class WeathmvcController : Controller
    {
        // GET: Weathmvc
        string Baseurl = "http://localhost:50492/api/WeathReports1/";
        public async Task<ActionResult> Index()
        {
            List<WeathReports> WeathInfo = new List<WeathReports>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync(Baseurl);

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    WeathInfo = JsonConvert.DeserializeObject<List<WeathReports>>(EmpResponse);

                }
                //returning the employee list to view  
                return View(WeathInfo);
            }
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(WeathReports Weath)
        {
            try
            {
                // TODO: Add insert logic here

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Baseurl + "PostWeathReports");

                    //HTTP POST
                    var postTask = client.PostAsJsonAsync<WeathReports>("WeathReports", Weath);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }

                ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

                return View(Weath);
            }
            catch
            {
                return View();
            }
        }


        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            WeathReports Weath = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                //HTTP GET
                var responseTask = client.GetAsync("GetWeathReports?id=" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<WeathReports>();
                    readTask.Wait();

                    Weath = readTask.Result;
                }
            }

            return View(Weath);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, WeathReports Weath)
        {
            try
            {

                using (var httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var uri = new Uri(Baseurl + "PutWeathReports?id=" + id + "");
                    using (var formData = new MultipartFormDataContent())
                    {
                        //add content to form data                       
                        string contents = JsonConvert.SerializeObject(Weath);
                        var response = httpClient.PutAsync(uri, new StringContent(contents, Encoding.UTF8, "application/json")).Result;
                        string res = "";
                        using (HttpContent content = response.Content)
                        {
                            // ... Read the string.
                            Task<string> result = content.ReadAsStringAsync();
                            res = result.Result;
                        }
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);

                //HTTP DELETE
                var deleteTask = client.DeleteAsync("DeleteWeathReports?id=" + id);
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Index");
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}