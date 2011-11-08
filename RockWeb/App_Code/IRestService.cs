//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the T4\Model.tt template.
//
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RockWeb.WCF
{
    // Rest Verbs...
    // GET = Retrieve
    // PUT = Update
    // POST = Create/Insert
    // DELETE = Delete

    [ServiceContract( Namespace = "", Name = "RestService" )]
    public interface IRestService
    {
		#region Auth
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "auth/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Cms.Auth GetAuthJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "auth/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Cms.Auth GetAuthXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "auth/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdateAuth( string id, Rock.Models.Cms.Auth auth );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "auth", ResponseFormat = WebMessageFormat.Json )]
        void CreateAuth( Rock.Models.Cms.Auth auth );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "auth/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeleteAuth( string id );

		#endregion
		
		#region Block
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "block/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Cms.Block GetBlockJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "block/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Cms.Block GetBlockXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "block/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdateBlock( string id, Rock.Models.Cms.Block block );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "block", ResponseFormat = WebMessageFormat.Json )]
        void CreateBlock( Rock.Models.Cms.Block block );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "block/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeleteBlock( string id );

		#endregion
		
		#region BlockInstance
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "blockinstance/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Cms.BlockInstance GetBlockInstanceJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "blockinstance/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Cms.BlockInstance GetBlockInstanceXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "blockinstance/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdateBlockInstance( string id, Rock.Models.Cms.BlockInstance blockInstance );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "blockinstance", ResponseFormat = WebMessageFormat.Json )]
        void CreateBlockInstance( Rock.Models.Cms.BlockInstance blockInstance );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "blockinstance/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeleteBlockInstance( string id );

		#endregion
		
		#region Blog
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "blog/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Cms.Blog GetBlogJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "blog/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Cms.Blog GetBlogXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "blog/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdateBlog( string id, Rock.Models.Cms.Blog blog );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "blog", ResponseFormat = WebMessageFormat.Json )]
        void CreateBlog( Rock.Models.Cms.Blog blog );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "blog/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeleteBlog( string id );

		#endregion
		
		#region BlogCategory
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "blogcategory/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Cms.BlogCategory GetBlogCategoryJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "blogcategory/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Cms.BlogCategory GetBlogCategoryXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "blogcategory/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdateBlogCategory( string id, Rock.Models.Cms.BlogCategory blogCategory );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "blogcategory", ResponseFormat = WebMessageFormat.Json )]
        void CreateBlogCategory( Rock.Models.Cms.BlogCategory blogCategory );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "blogcategory/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeleteBlogCategory( string id );

		#endregion
		
		#region BlogPost
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "blogpost/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Cms.BlogPost GetBlogPostJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "blogpost/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Cms.BlogPost GetBlogPostXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "blogpost/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdateBlogPost( string id, Rock.Models.Cms.BlogPost blogPost );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "blogpost", ResponseFormat = WebMessageFormat.Json )]
        void CreateBlogPost( Rock.Models.Cms.BlogPost blogPost );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "blogpost/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeleteBlogPost( string id );

		#endregion
		
		#region BlogPostComment
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "blogpostcomment/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Cms.BlogPostComment GetBlogPostCommentJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "blogpostcomment/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Cms.BlogPostComment GetBlogPostCommentXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "blogpostcomment/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdateBlogPostComment( string id, Rock.Models.Cms.BlogPostComment blogPostComment );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "blogpostcomment", ResponseFormat = WebMessageFormat.Json )]
        void CreateBlogPostComment( Rock.Models.Cms.BlogPostComment blogPostComment );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "blogpostcomment/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeleteBlogPostComment( string id );

		#endregion
		
		#region BlogTag
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "blogtag/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Cms.BlogTag GetBlogTagJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "blogtag/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Cms.BlogTag GetBlogTagXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "blogtag/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdateBlogTag( string id, Rock.Models.Cms.BlogTag blogTag );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "blogtag", ResponseFormat = WebMessageFormat.Json )]
        void CreateBlogTag( Rock.Models.Cms.BlogTag blogTag );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "blogtag/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeleteBlogTag( string id );

		#endregion
		
		#region File
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "file/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Cms.File GetFileJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "file/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Cms.File GetFileXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "file/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdateFile( string id, Rock.Models.Cms.File file );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "file", ResponseFormat = WebMessageFormat.Json )]
        void CreateFile( Rock.Models.Cms.File file );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "file/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeleteFile( string id );

		#endregion
		
		#region HtmlContent
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "htmlcontent/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Cms.HtmlContent GetHtmlContentJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "htmlcontent/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Cms.HtmlContent GetHtmlContentXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "htmlcontent/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdateHtmlContent( string id, Rock.Models.Cms.HtmlContent htmlContent );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "htmlcontent", ResponseFormat = WebMessageFormat.Json )]
        void CreateHtmlContent( Rock.Models.Cms.HtmlContent htmlContent );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "htmlcontent/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeleteHtmlContent( string id );

		#endregion
		
		#region Page
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "page/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Cms.Page GetPageJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "page/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Cms.Page GetPageXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "page/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdatePage( string id, Rock.Models.Cms.Page page );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "page", ResponseFormat = WebMessageFormat.Json )]
        void CreatePage( Rock.Models.Cms.Page page );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "page/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeletePage( string id );

		#endregion
		
		#region PageRoute
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "pageroute/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Cms.PageRoute GetPageRouteJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "pageroute/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Cms.PageRoute GetPageRouteXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "pageroute/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdatePageRoute( string id, Rock.Models.Cms.PageRoute pageRoute );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "pageroute", ResponseFormat = WebMessageFormat.Json )]
        void CreatePageRoute( Rock.Models.Cms.PageRoute pageRoute );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "pageroute/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeletePageRoute( string id );

		#endregion
		
		#region Site
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "site/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Cms.Site GetSiteJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "site/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Cms.Site GetSiteXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "site/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdateSite( string id, Rock.Models.Cms.Site site );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "site", ResponseFormat = WebMessageFormat.Json )]
        void CreateSite( Rock.Models.Cms.Site site );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "site/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeleteSite( string id );

		#endregion
		
		#region SiteDomain
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "sitedomain/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Cms.SiteDomain GetSiteDomainJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "sitedomain/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Cms.SiteDomain GetSiteDomainXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "sitedomain/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdateSiteDomain( string id, Rock.Models.Cms.SiteDomain siteDomain );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "sitedomain", ResponseFormat = WebMessageFormat.Json )]
        void CreateSiteDomain( Rock.Models.Cms.SiteDomain siteDomain );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "sitedomain/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeleteSiteDomain( string id );

		#endregion
		
		#region User
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "user/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Cms.User GetUserJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "user/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Cms.User GetUserXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "user/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdateUser( string id, Rock.Models.Cms.User user );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "user", ResponseFormat = WebMessageFormat.Json )]
        void CreateUser( Rock.Models.Cms.User user );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "user/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeleteUser( string id );

		#endregion
		
		#region Attribute
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "attribute/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Core.Attribute GetAttributeJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "attribute/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Core.Attribute GetAttributeXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "attribute/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdateAttribute( string id, Rock.Models.Core.Attribute attribute );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "attribute", ResponseFormat = WebMessageFormat.Json )]
        void CreateAttribute( Rock.Models.Core.Attribute attribute );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "attribute/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeleteAttribute( string id );

		#endregion
		
		#region AttributeQualifier
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "attributequalifier/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Core.AttributeQualifier GetAttributeQualifierJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "attributequalifier/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Core.AttributeQualifier GetAttributeQualifierXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "attributequalifier/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdateAttributeQualifier( string id, Rock.Models.Core.AttributeQualifier attributeQualifier );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "attributequalifier", ResponseFormat = WebMessageFormat.Json )]
        void CreateAttributeQualifier( Rock.Models.Core.AttributeQualifier attributeQualifier );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "attributequalifier/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeleteAttributeQualifier( string id );

		#endregion
		
		#region AttributeValue
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "attributevalue/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Core.AttributeValue GetAttributeValueJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "attributevalue/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Core.AttributeValue GetAttributeValueXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "attributevalue/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdateAttributeValue( string id, Rock.Models.Core.AttributeValue attributeValue );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "attributevalue", ResponseFormat = WebMessageFormat.Json )]
        void CreateAttributeValue( Rock.Models.Core.AttributeValue attributeValue );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "attributevalue/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeleteAttributeValue( string id );

		#endregion
		
		#region DefinedType
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "definedtype/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Core.DefinedType GetDefinedTypeJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "definedtype/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Core.DefinedType GetDefinedTypeXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "definedtype/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdateDefinedType( string id, Rock.Models.Core.DefinedType definedType );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "definedtype", ResponseFormat = WebMessageFormat.Json )]
        void CreateDefinedType( Rock.Models.Core.DefinedType definedType );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "definedtype/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeleteDefinedType( string id );

		#endregion
		
		#region DefinedValue
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "definedvalue/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Core.DefinedValue GetDefinedValueJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "definedvalue/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Core.DefinedValue GetDefinedValueXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "definedvalue/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdateDefinedValue( string id, Rock.Models.Core.DefinedValue definedValue );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "definedvalue", ResponseFormat = WebMessageFormat.Json )]
        void CreateDefinedValue( Rock.Models.Core.DefinedValue definedValue );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "definedvalue/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeleteDefinedValue( string id );

		#endregion
		
		#region EntityChange
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "entitychange/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Core.EntityChange GetEntityChangeJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "entitychange/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Core.EntityChange GetEntityChangeXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "entitychange/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdateEntityChange( string id, Rock.Models.Core.EntityChange entityChange );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "entitychange", ResponseFormat = WebMessageFormat.Json )]
        void CreateEntityChange( Rock.Models.Core.EntityChange entityChange );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "entitychange/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeleteEntityChange( string id );

		#endregion
		
		#region FieldType
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "fieldtype/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Core.FieldType GetFieldTypeJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "fieldtype/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Core.FieldType GetFieldTypeXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "fieldtype/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdateFieldType( string id, Rock.Models.Core.FieldType fieldType );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "fieldtype", ResponseFormat = WebMessageFormat.Json )]
        void CreateFieldType( Rock.Models.Core.FieldType fieldType );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "fieldtype/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeleteFieldType( string id );

		#endregion
		
		#region Person
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "person/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Crm.Person GetPersonJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "person/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Crm.Person GetPersonXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "person/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdatePerson( string id, Rock.Models.Crm.Person person );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "person", ResponseFormat = WebMessageFormat.Json )]
        void CreatePerson( Rock.Models.Crm.Person person );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "person/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeletePerson( string id );

		#endregion
		
		#region PhoneNumber
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "phonenumber/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Crm.PhoneNumber GetPhoneNumberJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "phonenumber/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Crm.PhoneNumber GetPhoneNumberXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "phonenumber/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdatePhoneNumber( string id, Rock.Models.Crm.PhoneNumber phoneNumber );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "phonenumber", ResponseFormat = WebMessageFormat.Json )]
        void CreatePhoneNumber( Rock.Models.Crm.PhoneNumber phoneNumber );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "phonenumber/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeletePhoneNumber( string id );

		#endregion
		
		#region Group
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "group/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Groups.Group GetGroupJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "group/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Groups.Group GetGroupXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "group/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdateGroup( string id, Rock.Models.Groups.Group group );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "group", ResponseFormat = WebMessageFormat.Json )]
        void CreateGroup( Rock.Models.Groups.Group group );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "group/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeleteGroup( string id );

		#endregion
		
		#region GroupRole
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "grouprole/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Groups.GroupRole GetGroupRoleJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "grouprole/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Groups.GroupRole GetGroupRoleXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "grouprole/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdateGroupRole( string id, Rock.Models.Groups.GroupRole groupRole );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "grouprole", ResponseFormat = WebMessageFormat.Json )]
        void CreateGroupRole( Rock.Models.Groups.GroupRole groupRole );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "grouprole/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeleteGroupRole( string id );

		#endregion
		
		#region GroupType
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "grouptype/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Groups.GroupType GetGroupTypeJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "grouptype/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Groups.GroupType GetGroupTypeXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "grouptype/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdateGroupType( string id, Rock.Models.Groups.GroupType groupType );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "grouptype", ResponseFormat = WebMessageFormat.Json )]
        void CreateGroupType( Rock.Models.Groups.GroupType groupType );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "grouptype/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeleteGroupType( string id );

		#endregion
		
		#region Member
		
		[OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "member/{id}", ResponseFormat = WebMessageFormat.Json )]
        Rock.Models.Groups.Member GetMemberJson( string id );

        [OperationContract]
        [WebInvoke( Method = "GET", UriTemplate = "member/{id}/xml", ResponseFormat = WebMessageFormat.Xml )]
        Rock.Models.Groups.Member GetMemberXml( string id );
		
        [OperationContract]
        [WebInvoke( Method = "PUT", UriTemplate = "member/{id}", ResponseFormat = WebMessageFormat.Json )]
        void UpdateMember( string id, Rock.Models.Groups.Member member );

        [OperationContract]
        [WebInvoke( Method = "POST", UriTemplate = "member", ResponseFormat = WebMessageFormat.Json )]
        void CreateMember( Rock.Models.Groups.Member member );

        [OperationContract]
        [WebInvoke( Method = "DELETE", UriTemplate = "member/{id}", ResponseFormat = WebMessageFormat.Json )]
        void DeleteMember( string id );

		#endregion
		
    }
}
