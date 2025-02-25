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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// Additional details about the data set. Different attributes correspond to different
    /// data set organizations. The values are populated based on datasetOrg, storageType
    /// and backend (Blu Age or Micro Focus).
    /// </summary>
    public partial class DatasetDetailOrgAttributes
    {
        private GdgDetailAttributes _gdg;
        private VsamDetailAttributes _vsam;

        /// <summary>
        /// Gets and sets the property Gdg. 
        /// <para>
        /// The generation data group of the data set.
        /// </para>
        /// </summary>
        public GdgDetailAttributes Gdg
        {
            get { return this._gdg; }
            set { this._gdg = value; }
        }

        // Check to see if Gdg property is set
        internal bool IsSetGdg()
        {
            return this._gdg != null;
        }

        /// <summary>
        /// Gets and sets the property Vsam. 
        /// <para>
        /// The details of a VSAM data set.
        /// </para>
        /// </summary>
        public VsamDetailAttributes Vsam
        {
            get { return this._vsam; }
            set { this._vsam = value; }
        }

        // Check to see if Vsam property is set
        internal bool IsSetVsam()
        {
            return this._vsam != null;
        }

    }
}