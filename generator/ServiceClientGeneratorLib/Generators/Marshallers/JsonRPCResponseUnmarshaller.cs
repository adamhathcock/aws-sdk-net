﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.Marshallers
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class JsonRPCResponseUnmarshaller : BaseResponseUnmarshaller
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

    AddLicenseHeader();

    AddCommonUsingStatements();

            
            #line default
            #line hidden
            this.Write("using ThirdParty.Json.LitJson;\r\n\r\nnamespace ");
            
            #line 13 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model.Internal.MarshallTransformations\r\n{\r\n    /// <summary>\r\n    /// Response U" +
                    "nmarshaller for ");
            
            #line 16 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(" operation\r\n    /// </summary>  \r\n    public class ");
            
            #line 18 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(@"ResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name=""context""></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            ");
            
            #line 27 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write("Response response = new ");
            
            #line 27 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));
            
            #line default
            #line hidden
            this.Write("Response();\r\n\r\n");
            
            #line 29 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

    var payload = this.Operation.ResponsePayloadMember;
    var unmarshallPayload = payload != null && payload.IsStructure;
    var payloadIsStream= payload != null && !unmarshallPayload;
    if( this.Operation.ResponseHasBodyMembers || payload != null )
    {
        if (payloadIsStream)
        {
            if (payload.IsStreaming)
            {

            
            #line default
            #line hidden
            this.Write("            response.");
            
            #line 40 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(payload.PropertyName));
            
            #line default
            #line hidden
            this.Write(" = context.Stream;\r\n");
            
            #line 41 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

            }
            else
            {

            
            #line default
            #line hidden
            this.Write("            var ms = new MemoryStream();\r\n            Amazon.Util.AWSSDKUtils.Cop" +
                    "yStream(context.Stream, ms);\r\n            ms.Seek(0, SeekOrigin.Begin);\r\n       " +
                    "     response.");
            
            #line 49 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(payload.PropertyName));
            
            #line default
            #line hidden
            this.Write(" = ms;\r\n");
            
            #line 50 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

            }
        }
        else if (unmarshallPayload)
        {

            
            #line default
            #line hidden
            this.Write("            var unmarshaller = ");
            
            #line 56 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(payload.DetermineTypeUnmarshallerInstantiate()));
            
            #line default
            #line hidden
            this.Write(";\r\n            response.");
            
            #line 57 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(payload.PropertyName));
            
            #line default
            #line hidden
            this.Write(" = unmarshaller.Unmarshall(context);\r\n");
            
            #line 58 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

        }
		else if(this.IsWrapped)
		{

            
            #line default
            #line hidden
            this.Write("\t\t\tresponse.");
            
            #line 63 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.WrappedResultMember));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 63 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write("Unmarshaller.Instance.Unmarshall(context);\r\n");
            
            #line 64 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

		}
        else
        {

            
            #line default
            #line hidden
            this.Write("            context.Read();\r\n            int targetDepth = context.CurrentDepth;\r" +
                    "\n            while (context.ReadAtDepth(targetDepth))\r\n            {\r\n");
            
            #line 73 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

        
            foreach (var member in this.Operation.ResponseBodyMembers)
            {

            
            #line default
            #line hidden
            this.Write("                if (context.TestExpression(\"");
            
            #line 78 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallName));
            
            #line default
            #line hidden
            this.Write("\", targetDepth))\r\n                {\r\n                    var unmarshaller = ");
            
            #line 80 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.DetermineTypeUnmarshallerInstantiate()));
            
            #line default
            #line hidden
            this.Write(";\r\n                    response.");
            
            #line 81 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write(" = unmarshaller.Unmarshall(context);\r\n                    continue;\r\n            " +
                    "    }\r\n");
            
            #line 84 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

            }

            
            #line default
            #line hidden
            this.Write("            }\r\n");
            
            #line 88 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

        }
    }
	UnmarshallHeaders();
	ProcessStatusCode();

            
            #line default
            #line hidden
            this.Write(@"
            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name=""context""></param>
        /// <param name=""innerException""></param>
        /// <param name=""statusCode""></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
");
            
            #line 108 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

    foreach (var exception in this.Operation.Exceptions)
    {

            
            #line default
            #line hidden
            this.Write("            if (errorResponse.Code != null && errorResponse.Code.Equals(\"");
            
            #line 112 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(exception.Code));
            
            #line default
            #line hidden
            this.Write("\"))\r\n            {\r\n                return new ");
            
            #line 114 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(exception.Name));
            
            #line default
            #line hidden
            this.Write("(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, e" +
                    "rrorResponse.RequestId, statusCode);\r\n            }\r\n");
            
            #line 116 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

    }

            
            #line default
            #line hidden
            this.Write("            return new Amazon");
            
            #line 119 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Exception(errorResponse.Message, innerException, errorResponse.Type, errorRespons" +
                    "e.Code, errorResponse.RequestId, statusCode);\r\n        }\r\n\r\n");
            
            #line 122 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

    if (payload != null && payload.IsStreaming)
    {

            
            #line default
            #line hidden
            this.Write(@"        /// <summary>
        /// Overriden to return true indicating the response contains streaming data.
        /// </summary>
        public override bool HasStreamingProperty
        {
            get
            {
                return true;
            }
        }

");
            
            #line 137 "C:\codebase\V3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

	}
    this.AddResponseSingletonMethod();

            
            #line default
            #line hidden
            this.Write("    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
