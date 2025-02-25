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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteInvitations operation.
    /// Deletes invitations received by the Amazon Web Services account to become a member
    /// account.
    /// 
    ///  
    /// <para>
    /// This operation is only used by accounts that are not part of an organization. Organization
    /// accounts do not receive invitations.
    /// </para>
    /// </summary>
    public partial class DeleteInvitationsRequest : AmazonSecurityHubRequest
    {
        private List<string> _accountIds = new List<string>();

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// The list of the account IDs that sent the invitations to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && this._accountIds.Count > 0; 
        }

    }
}