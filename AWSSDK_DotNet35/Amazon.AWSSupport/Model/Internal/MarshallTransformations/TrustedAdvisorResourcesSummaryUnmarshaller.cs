/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
    using System;
    using System.Collections.Generic;
    using System.IO;
    using ThirdParty.Json.LitJson;
    using Amazon.AWSSupport.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.AWSSupport.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// TrustedAdvisorResourcesSummaryUnmarshaller
      /// </summary>
      internal class TrustedAdvisorResourcesSummaryUnmarshaller : IUnmarshaller<TrustedAdvisorResourcesSummary, XmlUnmarshallerContext>, IUnmarshaller<TrustedAdvisorResourcesSummary, JsonUnmarshallerContext>
      {
        TrustedAdvisorResourcesSummary IUnmarshaller<TrustedAdvisorResourcesSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public TrustedAdvisorResourcesSummary Unmarshall(JsonUnmarshallerContext context)
        {
            TrustedAdvisorResourcesSummary trustedAdvisorResourcesSummary = new TrustedAdvisorResourcesSummary();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("resourcesProcessed", targetDepth))
              {
                context.Read();
                trustedAdvisorResourcesSummary.ResourcesProcessed = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("resourcesFlagged", targetDepth))
              {
                context.Read();
                trustedAdvisorResourcesSummary.ResourcesFlagged = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("resourcesIgnored", targetDepth))
              {
                context.Read();
                trustedAdvisorResourcesSummary.ResourcesIgnored = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("resourcesSuppressed", targetDepth))
              {
                context.Read();
                trustedAdvisorResourcesSummary.ResourcesSuppressed = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return trustedAdvisorResourcesSummary;
                }
            }
          

            return trustedAdvisorResourcesSummary;
        }

        private static TrustedAdvisorResourcesSummaryUnmarshaller instance;
        public static TrustedAdvisorResourcesSummaryUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new TrustedAdvisorResourcesSummaryUnmarshaller();
            return instance;
        }
    }
}
  