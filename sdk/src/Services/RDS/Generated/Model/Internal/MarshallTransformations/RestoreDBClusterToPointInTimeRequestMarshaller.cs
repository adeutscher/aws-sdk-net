/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RestoreDBClusterToPointInTime Request Marshaller
    /// </summary>       
    public class RestoreDBClusterToPointInTimeRequestMarshaller : IMarshaller<IRequest, RestoreDBClusterToPointInTimeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RestoreDBClusterToPointInTimeRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RestoreDBClusterToPointInTimeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.Parameters.Add("Action", "RestoreDBClusterToPointInTime");
            request.Parameters.Add("Version", "2014-10-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetBacktrackWindow())
                {
                    request.Parameters.Add("BacktrackWindow", StringUtils.FromLong(publicRequest.BacktrackWindow));
                }
                if(publicRequest.IsSetCopyTagsToSnapshot())
                {
                    request.Parameters.Add("CopyTagsToSnapshot", StringUtils.FromBool(publicRequest.CopyTagsToSnapshot));
                }
                if(publicRequest.IsSetDBClusterIdentifier())
                {
                    request.Parameters.Add("DBClusterIdentifier", StringUtils.FromString(publicRequest.DBClusterIdentifier));
                }
                if(publicRequest.IsSetDBClusterInstanceClass())
                {
                    request.Parameters.Add("DBClusterInstanceClass", StringUtils.FromString(publicRequest.DBClusterInstanceClass));
                }
                if(publicRequest.IsSetDBClusterParameterGroupName())
                {
                    request.Parameters.Add("DBClusterParameterGroupName", StringUtils.FromString(publicRequest.DBClusterParameterGroupName));
                }
                if(publicRequest.IsSetDBSubnetGroupName())
                {
                    request.Parameters.Add("DBSubnetGroupName", StringUtils.FromString(publicRequest.DBSubnetGroupName));
                }
                if(publicRequest.IsSetDeletionProtection())
                {
                    request.Parameters.Add("DeletionProtection", StringUtils.FromBool(publicRequest.DeletionProtection));
                }
                if(publicRequest.IsSetDomain())
                {
                    request.Parameters.Add("Domain", StringUtils.FromString(publicRequest.Domain));
                }
                if(publicRequest.IsSetDomainIAMRoleName())
                {
                    request.Parameters.Add("DomainIAMRoleName", StringUtils.FromString(publicRequest.DomainIAMRoleName));
                }
                if(publicRequest.IsSetEnableCloudwatchLogsExports())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.EnableCloudwatchLogsExports)
                    {
                        request.Parameters.Add("EnableCloudwatchLogsExports" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetEnableIAMDatabaseAuthentication())
                {
                    request.Parameters.Add("EnableIAMDatabaseAuthentication", StringUtils.FromBool(publicRequest.EnableIAMDatabaseAuthentication));
                }
                if(publicRequest.IsSetEngineMode())
                {
                    request.Parameters.Add("EngineMode", StringUtils.FromString(publicRequest.EngineMode));
                }
                if(publicRequest.IsSetIops())
                {
                    request.Parameters.Add("Iops", StringUtils.FromInt(publicRequest.Iops));
                }
                if(publicRequest.IsSetKmsKeyId())
                {
                    request.Parameters.Add("KmsKeyId", StringUtils.FromString(publicRequest.KmsKeyId));
                }
                if(publicRequest.IsSetNetworkType())
                {
                    request.Parameters.Add("NetworkType", StringUtils.FromString(publicRequest.NetworkType));
                }
                if(publicRequest.IsSetOptionGroupName())
                {
                    request.Parameters.Add("OptionGroupName", StringUtils.FromString(publicRequest.OptionGroupName));
                }
                if(publicRequest.IsSetPort())
                {
                    request.Parameters.Add("Port", StringUtils.FromInt(publicRequest.Port));
                }
                if(publicRequest.IsSetPubliclyAccessible())
                {
                    request.Parameters.Add("PubliclyAccessible", StringUtils.FromBool(publicRequest.PubliclyAccessible));
                }
                if(publicRequest.IsSetRestoreToTimeUtc())
                {
                    request.Parameters.Add("RestoreToTime", StringUtils.FromDateTimeToISO8601(publicRequest.RestoreToTimeUtc));
                }
                if(publicRequest.IsSetRestoreType())
                {
                    request.Parameters.Add("RestoreType", StringUtils.FromString(publicRequest.RestoreType));
                }
                if(publicRequest.IsSetScalingConfiguration())
                {
                    if(publicRequest.ScalingConfiguration.IsSetAutoPause())
                    {
                        request.Parameters.Add("ScalingConfiguration" + "." + "AutoPause", StringUtils.FromBool(publicRequest.ScalingConfiguration.AutoPause));
                    }
                    if(publicRequest.ScalingConfiguration.IsSetMaxCapacity())
                    {
                        request.Parameters.Add("ScalingConfiguration" + "." + "MaxCapacity", StringUtils.FromInt(publicRequest.ScalingConfiguration.MaxCapacity));
                    }
                    if(publicRequest.ScalingConfiguration.IsSetMinCapacity())
                    {
                        request.Parameters.Add("ScalingConfiguration" + "." + "MinCapacity", StringUtils.FromInt(publicRequest.ScalingConfiguration.MinCapacity));
                    }
                    if(publicRequest.ScalingConfiguration.IsSetSecondsBeforeTimeout())
                    {
                        request.Parameters.Add("ScalingConfiguration" + "." + "SecondsBeforeTimeout", StringUtils.FromInt(publicRequest.ScalingConfiguration.SecondsBeforeTimeout));
                    }
                    if(publicRequest.ScalingConfiguration.IsSetSecondsUntilAutoPause())
                    {
                        request.Parameters.Add("ScalingConfiguration" + "." + "SecondsUntilAutoPause", StringUtils.FromInt(publicRequest.ScalingConfiguration.SecondsUntilAutoPause));
                    }
                    if(publicRequest.ScalingConfiguration.IsSetTimeoutAction())
                    {
                        request.Parameters.Add("ScalingConfiguration" + "." + "TimeoutAction", StringUtils.FromString(publicRequest.ScalingConfiguration.TimeoutAction));
                    }
                }
                if(publicRequest.IsSetServerlessV2ScalingConfiguration())
                {
                    if(publicRequest.ServerlessV2ScalingConfiguration.IsSetMaxCapacity())
                    {
                        request.Parameters.Add("ServerlessV2ScalingConfiguration" + "." + "MaxCapacity", StringUtils.FromDouble(publicRequest.ServerlessV2ScalingConfiguration.MaxCapacity));
                    }
                    if(publicRequest.ServerlessV2ScalingConfiguration.IsSetMinCapacity())
                    {
                        request.Parameters.Add("ServerlessV2ScalingConfiguration" + "." + "MinCapacity", StringUtils.FromDouble(publicRequest.ServerlessV2ScalingConfiguration.MinCapacity));
                    }
                }
                if(publicRequest.IsSetSourceDBClusterIdentifier())
                {
                    request.Parameters.Add("SourceDBClusterIdentifier", StringUtils.FromString(publicRequest.SourceDBClusterIdentifier));
                }
                if(publicRequest.IsSetStorageType())
                {
                    request.Parameters.Add("StorageType", StringUtils.FromString(publicRequest.StorageType));
                }
                if(publicRequest.IsSetTags())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Tags)
                    {
                        if(publicRequestlistValue.IsSetKey())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValue.Key));
                        }
                        if(publicRequestlistValue.IsSetValue())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetUseLatestRestorableTime())
                {
                    request.Parameters.Add("UseLatestRestorableTime", StringUtils.FromBool(publicRequest.UseLatestRestorableTime));
                }
                if(publicRequest.IsSetVpcSecurityGroupIds())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.VpcSecurityGroupIds)
                    {
                        request.Parameters.Add("VpcSecurityGroupIds" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
            }
            return request;
        }
                    private static RestoreDBClusterToPointInTimeRequestMarshaller _instance = new RestoreDBClusterToPointInTimeRequestMarshaller();        

        internal static RestoreDBClusterToPointInTimeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RestoreDBClusterToPointInTimeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}