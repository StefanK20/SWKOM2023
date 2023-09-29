/*
 * Paperless Rest Server
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using Org.OpenAPITools.Attributes;
using Org.OpenAPITools.Models;

namespace Org.OpenAPITools.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class DocumentTypesApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="createCorrespondentRequest"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/api/document_types")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("CreateDocumentType")]
        [SwaggerResponse(statusCode: 200, type: typeof(CreateDocumentType200Response), description: "Success")]
        public virtual IActionResult CreateDocumentType([FromBody]CreateCorrespondentRequest createCorrespondentRequest)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(CreateDocumentType200Response));
            string exampleJson = null;
            exampleJson = "{\n  \"owner\" : 1,\n  \"matching_algorithm\" : 6,\n  \"user_can_change\" : true,\n  \"is_insensitive\" : true,\n  \"name\" : \"name\",\n  \"match\" : \"match\",\n  \"id\" : 0,\n  \"slug\" : \"slug\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CreateDocumentType200Response>(exampleJson)
            : default(CreateDocumentType200Response);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="204">Success</response>
        [HttpDelete]
        [Route("/api/document_types/{id}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteDocumentType")]
        public virtual IActionResult DeleteDocumentType([FromRoute (Name = "id")][Required]int id)
        {

            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="fullPerms"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/api/document_types")]
        [ValidateModelState]
        [SwaggerOperation("GetDocumentTypes")]
        [SwaggerResponse(statusCode: 200, type: typeof(GetDocumentTypes200Response), description: "Success")]
        public virtual IActionResult GetDocumentTypes([FromQuery (Name = "page")]int? page, [FromQuery (Name = "full_perms")]bool? fullPerms)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(GetDocumentTypes200Response));
            string exampleJson = null;
            exampleJson = "{\n  \"next\" : 6,\n  \"all\" : [ 5, 5 ],\n  \"previous\" : 1,\n  \"count\" : 0,\n  \"results\" : [ {\n    \"owner\" : 9,\n    \"matching_algorithm\" : 2,\n    \"document_count\" : 7,\n    \"is_insensitive\" : true,\n    \"permissions\" : {\n      \"view\" : {\n        \"groups\" : [ \"\", \"\" ],\n        \"users\" : [ \"\", \"\" ]\n      },\n      \"change\" : {\n        \"groups\" : [ \"\", \"\" ],\n        \"users\" : [ \"\", \"\" ]\n      }\n    },\n    \"name\" : \"name\",\n    \"match\" : \"match\",\n    \"id\" : 5,\n    \"slug\" : \"slug\"\n  }, {\n    \"owner\" : 9,\n    \"matching_algorithm\" : 2,\n    \"document_count\" : 7,\n    \"is_insensitive\" : true,\n    \"permissions\" : {\n      \"view\" : {\n        \"groups\" : [ \"\", \"\" ],\n        \"users\" : [ \"\", \"\" ]\n      },\n      \"change\" : {\n        \"groups\" : [ \"\", \"\" ],\n        \"users\" : [ \"\", \"\" ]\n      }\n    },\n    \"name\" : \"name\",\n    \"match\" : \"match\",\n    \"id\" : 5,\n    \"slug\" : \"slug\"\n  } ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<GetDocumentTypes200Response>(exampleJson)
            : default(GetDocumentTypes200Response);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updateDocumentTypeRequest"></param>
        /// <response code="200">Success</response>
        [HttpPut]
        [Route("/api/document_types/{id}")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("UpdateDocumentType")]
        [SwaggerResponse(statusCode: 200, type: typeof(UpdateDocumentType200Response), description: "Success")]
        public virtual IActionResult UpdateDocumentType([FromRoute (Name = "id")][Required]int id, [FromBody]UpdateDocumentTypeRequest updateDocumentTypeRequest)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(UpdateDocumentType200Response));
            string exampleJson = null;
            exampleJson = "{\n  \"owner\" : 5,\n  \"matching_algorithm\" : 6,\n  \"user_can_change\" : true,\n  \"document_count\" : 1,\n  \"is_insensitive\" : true,\n  \"name\" : \"name\",\n  \"match\" : \"match\",\n  \"id\" : 0,\n  \"slug\" : \"slug\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<UpdateDocumentType200Response>(exampleJson)
            : default(UpdateDocumentType200Response);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
