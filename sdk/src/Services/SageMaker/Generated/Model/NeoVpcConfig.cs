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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The <a>VpcConfig</a> configuration object that specifies the VPC that you want the
    /// compilation jobs to connect to. For more information on controlling access to your
    /// Amazon S3 buckets used for compilation job, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/neo-vpc.html">Give
    /// Amazon SageMaker Compilation Jobs Access to Resources in Your Amazon VPC</a>.
    /// </summary>
    public partial class NeoVpcConfig
    {
        private List<string> _securityGroupIds = new List<string>();
        private List<string> _subnets = new List<string>();

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The VPC security group IDs. IDs have the form of <code>sg-xxxxxxxx</code>. Specify
        /// the security groups for the VPC that is specified in the <code>Subnets</code> field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// The ID of the subnets in the VPC that you want to connect the compilation job to for
        /// accessing the model in Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=16)]
        public List<string> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && this._subnets.Count > 0; 
        }

    }
}