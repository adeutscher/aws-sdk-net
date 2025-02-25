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
 * Do not modify this file. This file is generated from the codestar-notifications-2019-10-15.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CodeStarNotifications.Model;

namespace Amazon.CodeStarNotifications
{
    /// <summary>
    /// Interface for accessing CodeStarNotifications
    ///
    /// This AWS CodeStar Notifications API Reference provides descriptions and usage examples
    /// of the operations and data types for the AWS CodeStar Notifications API. You can use
    /// the AWS CodeStar Notifications API to work with the following objects:
    /// 
    ///  
    /// <para>
    /// Notification rules, by calling the following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateNotificationRule</a>, which creates a notification rule for a resource in
    /// your account. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteNotificationRule</a>, which deletes a notification rule. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeNotificationRule</a>, which provides information about a notification
    /// rule. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListNotificationRules</a>, which lists the notification rules associated with
    /// your account. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateNotificationRule</a>, which changes the name, events, or targets associated
    /// with a notification rule. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>Subscribe</a>, which subscribes a target to a notification rule. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>Unsubscribe</a>, which removes a target from a notification rule. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Targets, by calling the following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DeleteTarget</a>, which removes a notification rule target from a notification
    /// rule. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListTargets</a>, which lists the targets associated with a notification rule.
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Events, by calling the following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListEventTypes</a>, which lists the event types you can include in a notification
    /// rule. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Tags, by calling the following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListTagsForResource</a>, which lists the tags already associated with a notification
    /// rule in your account. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>TagResource</a>, which associates a tag you provide with a notification rule in
    /// your account. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UntagResource</a>, which removes a tag from a notification rule in your account.
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  For information about how to use AWS CodeStar Notifications, see the <a href="https://docs.aws.amazon.com/dtconsole/latest/userguide/what-is-dtconsole.html">Amazon
    /// Web Services Developer Tools Console User Guide</a>. 
    /// </para>
    /// </summary>
    public partial interface IAmazonCodeStarNotifications : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICodeStarNotificationsPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateNotificationRule


        /// <summary>
        /// Creates a notification rule for a resource. The rule specifies the events you want
        /// notifications about and the targets (such as Chatbot topics or Chatbot clients configured
        /// for Slack) where you want to receive them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotificationRule service method.</param>
        /// 
        /// <returns>The response from the CreateNotificationRule service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.AccessDeniedException">
        /// AWS CodeStar Notifications can't create the notification rule because you do not have
        /// sufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConcurrentModificationException">
        /// AWS CodeStar Notifications can't complete the request because the resource is being
        /// modified by another process. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConfigurationException">
        /// Some or all of the configuration is incomplete, missing, or not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.LimitExceededException">
        /// One of the AWS CodeStar Notifications limits has been exceeded. Limits apply to accounts,
        /// notification rules, notifications, resources, and targets. For more information, see
        /// Limits.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ResourceAlreadyExistsException">
        /// A resource with the same name or ID already exists. Notification rule names must be
        /// unique in your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/CreateNotificationRule">REST API Reference for CreateNotificationRule Operation</seealso>
        CreateNotificationRuleResponse CreateNotificationRule(CreateNotificationRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNotificationRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNotificationRule operation on AmazonCodeStarNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNotificationRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/CreateNotificationRule">REST API Reference for CreateNotificationRule Operation</seealso>
        IAsyncResult BeginCreateNotificationRule(CreateNotificationRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNotificationRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNotificationRule.</param>
        /// 
        /// <returns>Returns a  CreateNotificationRuleResult from CodeStarNotifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/CreateNotificationRule">REST API Reference for CreateNotificationRule Operation</seealso>
        CreateNotificationRuleResponse EndCreateNotificationRule(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteNotificationRule


        /// <summary>
        /// Deletes a notification rule for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationRule service method.</param>
        /// 
        /// <returns>The response from the DeleteNotificationRule service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConcurrentModificationException">
        /// AWS CodeStar Notifications can't complete the request because the resource is being
        /// modified by another process. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.LimitExceededException">
        /// One of the AWS CodeStar Notifications limits has been exceeded. Limits apply to accounts,
        /// notification rules, notifications, resources, and targets. For more information, see
        /// Limits.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/DeleteNotificationRule">REST API Reference for DeleteNotificationRule Operation</seealso>
        DeleteNotificationRuleResponse DeleteNotificationRule(DeleteNotificationRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNotificationRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationRule operation on AmazonCodeStarNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNotificationRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/DeleteNotificationRule">REST API Reference for DeleteNotificationRule Operation</seealso>
        IAsyncResult BeginDeleteNotificationRule(DeleteNotificationRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNotificationRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNotificationRule.</param>
        /// 
        /// <returns>Returns a  DeleteNotificationRuleResult from CodeStarNotifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/DeleteNotificationRule">REST API Reference for DeleteNotificationRule Operation</seealso>
        DeleteNotificationRuleResponse EndDeleteNotificationRule(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTarget


        /// <summary>
        /// Deletes a specified target for notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTarget service method.</param>
        /// 
        /// <returns>The response from the DeleteTarget service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/DeleteTarget">REST API Reference for DeleteTarget Operation</seealso>
        DeleteTargetResponse DeleteTarget(DeleteTargetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTarget operation on AmazonCodeStarNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/DeleteTarget">REST API Reference for DeleteTarget Operation</seealso>
        IAsyncResult BeginDeleteTarget(DeleteTargetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTarget.</param>
        /// 
        /// <returns>Returns a  DeleteTargetResult from CodeStarNotifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/DeleteTarget">REST API Reference for DeleteTarget Operation</seealso>
        DeleteTargetResponse EndDeleteTarget(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeNotificationRule


        /// <summary>
        /// Returns information about a specified notification rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationRule service method.</param>
        /// 
        /// <returns>The response from the DescribeNotificationRule service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ResourceNotFoundException">
        /// AWS CodeStar Notifications can't find a resource that matches the provided ARN.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/DescribeNotificationRule">REST API Reference for DescribeNotificationRule Operation</seealso>
        DescribeNotificationRuleResponse DescribeNotificationRule(DescribeNotificationRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNotificationRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationRule operation on AmazonCodeStarNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNotificationRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/DescribeNotificationRule">REST API Reference for DescribeNotificationRule Operation</seealso>
        IAsyncResult BeginDescribeNotificationRule(DescribeNotificationRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNotificationRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNotificationRule.</param>
        /// 
        /// <returns>Returns a  DescribeNotificationRuleResult from CodeStarNotifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/DescribeNotificationRule">REST API Reference for DescribeNotificationRule Operation</seealso>
        DescribeNotificationRuleResponse EndDescribeNotificationRule(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEventTypes


        /// <summary>
        /// Returns information about the event types available for configuring notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventTypes service method.</param>
        /// 
        /// <returns>The response from the ListEventTypes service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.InvalidNextTokenException">
        /// The value for the enumeration token used in the request to return the next batch of
        /// the results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListEventTypes">REST API Reference for ListEventTypes Operation</seealso>
        ListEventTypesResponse ListEventTypes(ListEventTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventTypes operation on AmazonCodeStarNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListEventTypes">REST API Reference for ListEventTypes Operation</seealso>
        IAsyncResult BeginListEventTypes(ListEventTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventTypes.</param>
        /// 
        /// <returns>Returns a  ListEventTypesResult from CodeStarNotifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListEventTypes">REST API Reference for ListEventTypes Operation</seealso>
        ListEventTypesResponse EndListEventTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListNotificationRules


        /// <summary>
        /// Returns a list of the notification rules for an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationRules service method.</param>
        /// 
        /// <returns>The response from the ListNotificationRules service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.InvalidNextTokenException">
        /// The value for the enumeration token used in the request to return the next batch of
        /// the results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListNotificationRules">REST API Reference for ListNotificationRules Operation</seealso>
        ListNotificationRulesResponse ListNotificationRules(ListNotificationRulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListNotificationRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationRules operation on AmazonCodeStarNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNotificationRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListNotificationRules">REST API Reference for ListNotificationRules Operation</seealso>
        IAsyncResult BeginListNotificationRules(ListNotificationRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListNotificationRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNotificationRules.</param>
        /// 
        /// <returns>Returns a  ListNotificationRulesResult from CodeStarNotifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListNotificationRules">REST API Reference for ListNotificationRules Operation</seealso>
        ListNotificationRulesResponse EndListNotificationRules(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of the tags associated with a notification rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ResourceNotFoundException">
        /// AWS CodeStar Notifications can't find a resource that matches the provided ARN.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCodeStarNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from CodeStarNotifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTargets


        /// <summary>
        /// Returns a list of the notification rule targets for an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargets service method.</param>
        /// 
        /// <returns>The response from the ListTargets service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.InvalidNextTokenException">
        /// The value for the enumeration token used in the request to return the next batch of
        /// the results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListTargets">REST API Reference for ListTargets Operation</seealso>
        ListTargetsResponse ListTargets(ListTargetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTargets operation on AmazonCodeStarNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListTargets">REST API Reference for ListTargets Operation</seealso>
        IAsyncResult BeginListTargets(ListTargetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTargets.</param>
        /// 
        /// <returns>Returns a  ListTargetsResult from CodeStarNotifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListTargets">REST API Reference for ListTargets Operation</seealso>
        ListTargetsResponse EndListTargets(IAsyncResult asyncResult);

        #endregion
        
        #region  Subscribe


        /// <summary>
        /// Creates an association between a notification rule and an Chatbot topic or Chatbot
        /// client so that the associated target can receive notifications when the events described
        /// in the rule are triggered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Subscribe service method.</param>
        /// 
        /// <returns>The response from the Subscribe service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConfigurationException">
        /// Some or all of the configuration is incomplete, missing, or not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ResourceNotFoundException">
        /// AWS CodeStar Notifications can't find a resource that matches the provided ARN.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/Subscribe">REST API Reference for Subscribe Operation</seealso>
        SubscribeResponse Subscribe(SubscribeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the Subscribe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Subscribe operation on AmazonCodeStarNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSubscribe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/Subscribe">REST API Reference for Subscribe Operation</seealso>
        IAsyncResult BeginSubscribe(SubscribeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  Subscribe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSubscribe.</param>
        /// 
        /// <returns>Returns a  SubscribeResult from CodeStarNotifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/Subscribe">REST API Reference for Subscribe Operation</seealso>
        SubscribeResponse EndSubscribe(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associates a set of provided tags with a notification rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConcurrentModificationException">
        /// AWS CodeStar Notifications can't complete the request because the resource is being
        /// modified by another process. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.LimitExceededException">
        /// One of the AWS CodeStar Notifications limits has been exceeded. Limits apply to accounts,
        /// notification rules, notifications, resources, and targets. For more information, see
        /// Limits.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ResourceNotFoundException">
        /// AWS CodeStar Notifications can't find a resource that matches the provided ARN.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCodeStarNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from CodeStarNotifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  Unsubscribe


        /// <summary>
        /// Removes an association between a notification rule and an Chatbot topic so that subscribers
        /// to that topic stop receiving notifications when the events described in the rule are
        /// triggered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Unsubscribe service method.</param>
        /// 
        /// <returns>The response from the Unsubscribe service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/Unsubscribe">REST API Reference for Unsubscribe Operation</seealso>
        UnsubscribeResponse Unsubscribe(UnsubscribeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the Unsubscribe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Unsubscribe operation on AmazonCodeStarNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnsubscribe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/Unsubscribe">REST API Reference for Unsubscribe Operation</seealso>
        IAsyncResult BeginUnsubscribe(UnsubscribeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  Unsubscribe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnsubscribe.</param>
        /// 
        /// <returns>Returns a  UnsubscribeResult from CodeStarNotifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/Unsubscribe">REST API Reference for Unsubscribe Operation</seealso>
        UnsubscribeResponse EndUnsubscribe(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the association between one or more provided tags and a notification rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConcurrentModificationException">
        /// AWS CodeStar Notifications can't complete the request because the resource is being
        /// modified by another process. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.LimitExceededException">
        /// One of the AWS CodeStar Notifications limits has been exceeded. Limits apply to accounts,
        /// notification rules, notifications, resources, and targets. For more information, see
        /// Limits.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ResourceNotFoundException">
        /// AWS CodeStar Notifications can't find a resource that matches the provided ARN.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCodeStarNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from CodeStarNotifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateNotificationRule


        /// <summary>
        /// Updates a notification rule for a resource. You can change the events that trigger
        /// the notification rule, the status of the rule, and the targets that receive the notifications.
        /// 
        ///  <note> 
        /// <para>
        /// To add or remove tags for a notification rule, you must use <a>TagResource</a> and
        /// <a>UntagResource</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotificationRule service method.</param>
        /// 
        /// <returns>The response from the UpdateNotificationRule service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConfigurationException">
        /// Some or all of the configuration is incomplete, missing, or not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ResourceNotFoundException">
        /// AWS CodeStar Notifications can't find a resource that matches the provided ARN.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/UpdateNotificationRule">REST API Reference for UpdateNotificationRule Operation</seealso>
        UpdateNotificationRuleResponse UpdateNotificationRule(UpdateNotificationRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNotificationRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotificationRule operation on AmazonCodeStarNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNotificationRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/UpdateNotificationRule">REST API Reference for UpdateNotificationRule Operation</seealso>
        IAsyncResult BeginUpdateNotificationRule(UpdateNotificationRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNotificationRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNotificationRule.</param>
        /// 
        /// <returns>Returns a  UpdateNotificationRuleResult from CodeStarNotifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/UpdateNotificationRule">REST API Reference for UpdateNotificationRule Operation</seealso>
        UpdateNotificationRuleResponse EndUpdateNotificationRule(IAsyncResult asyncResult);

        #endregion
        
    }
}