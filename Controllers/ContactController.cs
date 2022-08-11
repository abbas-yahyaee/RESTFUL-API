using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Project1.BusinessLayer;
using Project1.Models;

namespace Project1.Controllers
{

    public class ContactController : ApiController
    {
        private IContactBusinessLayer _obj;

        HttpResponseMessage response;


        public ContactController(IContactBusinessLayer obj)
        {
            _obj = obj;
        }

        ///<summary>  
        /// This method is used to get a contact  
        ///</summary>  
        ///<param name="contactId"></param> 
        ///<returns></returns>  
        [HttpGet, ActionName("GetContactById")]
        public HttpResponseMessage GetContactById(int contactId)
        {
            try
            {
                var contact = _obj.GetContact(contactId);
                if (!object.Equals(contact, null))
                {
                    response = Request.CreateResponse<Contact>(HttpStatusCode.OK, contact);
                }
            }
            catch (Exception ex)
            {
                var result = new ResponseResult();
                result.Status = 0;
                result.Message = ex.Message;
                response = Request.CreateResponse(HttpStatusCode.InternalServerError, result);
            }
            return response;
        }

        ///<summary>  
        /// This method is used to get contact list  
        ///</summary>  
        ///<returns></returns>  
        [HttpGet, ActionName("GetContactList")]
        public HttpResponseMessage GetContactList()
        {
            try
            {
                var contactList = _obj.GetContacts();
                if (!object.Equals(contactList, null))
                {
                    response = Request.CreateResponse<IEnumerable<Contact>>(HttpStatusCode.OK, contactList);
                }
            }
            catch (Exception ex)
            {
                var result = new ResponseResult();
                result.Status = 0;
                result.Message = ex.Message;
                response = Request.CreateResponse(HttpStatusCode.InternalServerError, result);
            }
            return response;
        }


        ///<summary>  
        /// This method is used to add a contact  
        ///</summary>  
        ///<param name="contact"></param>  
        ///<returns></returns>  
        [HttpPost, ActionName("AddContact")]
        public HttpResponseMessage AddContact(Contact contact)
        {
            try
            {
                byte insertResult = _obj.InsertContact(contact);
                if (insertResult > 0)
                {
                    var result = new ResponseResult();
                    result.Status = 0;
                    result.Message = "Record Inserted Successfully!";
                    response = Request.CreateResponse(HttpStatusCode.OK, result);
                }

            }
            catch (Exception ex)
            {
                var result = new ResponseResult();
                result.Status = 0;
                result.Message = ex.Message;
                response = Request.CreateResponse(HttpStatusCode.InternalServerError, result);
            }
            return response;
        }


        ///<summary>  
        /// This method is used to delete a contact  
        ///</summary>  
        ///<param name="id"></param>  
        ///<returns></returns>  
        [HttpDelete, ActionName("DeleteContact")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                byte deleteResult = _obj.DeleteContact(id);

                if (deleteResult > 0)
                {
                    var result = new ResponseResult();
                    result.Status = 0;
                    result.Message = "Record Deleted Successfully!";
                    response = Request.CreateResponse(HttpStatusCode.OK, result);
                }

            }
            catch (Exception ex)
            {
                var result = new ResponseResult();
                result.Status = 0;
                result.Message = ex.Message;
                response = Request.CreateResponse(HttpStatusCode.InternalServerError, result);
            }
            return response;


        }


        ///<summary>  
        /// This method is used to update contact info  
        ///</summary>  
        ///<param name="contact"></param>  
        ///<returns></returns>  
        [HttpPut, ActionName("UpdateContact")]
        public HttpResponseMessage UpdateContact(Contact contact)
        {
            try
            {
                byte updateResult = _obj.UpdateContact(contact);

                if (updateResult > 0)
                {
                    var result = new ResponseResult();
                    result.Status = 0;
                    result.Message = "Record Updated Successfully!";
                    response = Request.CreateResponse(HttpStatusCode.OK, result);
                }

            }
            catch (Exception ex)
            {
                var result = new ResponseResult();
                result.Status = 0;
                result.Message = ex.Message;
                response = Request.CreateResponse(HttpStatusCode.InternalServerError, result);
            }
            return response;
        }


        private class ResponseResult
        {

            public int Status { get; set; }
            public string Message { get; set; }

        }
    }

    
}
