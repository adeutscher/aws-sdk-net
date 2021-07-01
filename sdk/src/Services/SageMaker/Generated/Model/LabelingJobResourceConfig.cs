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
    /// Configure encryption on the storage volume attached to the ML compute instance used
    /// to run automated data labeling model training and inference.
    /// </summary>
    public partial class LabelingJobResourceConfig
    {
        private string _volumeKmsKeyId;

        /// <summary>
        /// Gets and sets the property VolumeKmsKeyId. 
        /// <para>
        /// The Amazon Web Services Key Management Service (Amazon Web Services KMS) key that
        /// Amazon SageMaker uses to encrypt data on the storage volume attached to the ML compute
        /// instance(s) that run the training and inference jobs used for automated data labeling.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can only specify a <code>VolumeKmsKeyId</code> when you create a labeling job
        /// with automated data labeling enabled using the API operation <code>CreateLabelingJob</code>.
        /// You cannot specify an Amazon Web Services KMS customer managed CMK to encrypt the
        /// storage volume used for automated data labeling model training and inference when
        /// you create a labeling job using the console. To learn more, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-security.html">Output
        /// Data and Storage Volume Encryption</a>.
        /// </para>
        ///  
        /// <para>
        /// The <code>VolumeKmsKeyId</code> can be any of the following formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// KMS Key ID
        /// </para>
        ///  
        /// <para>
        ///  <code>"1234abcd-12ab-34cd-56ef-1234567890ab"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Resource Name (ARN) of a KMS Key
        /// </para>
        ///  
        /// <para>
        ///  <code>"arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab"</code>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string VolumeKmsKeyId
        {
            get { return this._volumeKmsKeyId; }
            set { this._volumeKmsKeyId = value; }
        }

        // Check to see if VolumeKmsKeyId property is set
        internal bool IsSetVolumeKmsKeyId()
        {
            return this._volumeKmsKeyId != null;
        }

    }
}