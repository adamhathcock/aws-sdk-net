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
using System.Threading;
using System.Threading.Tasks;

using Amazon.SimpleEmail.Model;

namespace Amazon.SimpleEmail
{
    /// <summary>
    /// Implementation for accessing SimpleEmailService
    /// 
    /// Amazon Simple Email Service
    /// <para>
    /// This is the API Reference for Amazon Simple Email Service (Amazon SES).
    /// This documentation is intended to be            used in conjunction with the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/Welcome.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// <note>For a list of Amazon SES endpoints to use in service requests, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/regions.html">Regions and
    /// Amazon SES</a>             in the Amazon SES Developer Guide.         </note>
    /// </summary>
	public partial interface IAmazonSimpleEmailService : IDisposable
    {
 
        /// <summary>
        /// Deletes the specified identity (email address or domain) from the list of verified
        /// identities.
        /// 
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentity service method.</param>
        /// 
        /// <returns>The response from the DeleteIdentity service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteIdentityResponse> DeleteIdentityAsync(DeleteIdentityRequest deleteIdentityRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Deletes the specified email address from the list of verified addresses.
        /// 
        /// <important>The DeleteVerifiedEmailAddress action is deprecated as of the May
        /// 15, 2012 release        of Domain Verification. The DeleteIdentity action is now preferred.</important>
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVerifiedEmailAddress service method.</param>
        /// 
        /// <returns>The response from the DeleteVerifiedEmailAddress service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteVerifiedEmailAddressResponse> DeleteVerifiedEmailAddressAsync(DeleteVerifiedEmailAddressRequest deleteVerifiedEmailAddressRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns the current status of Easy DKIM signing for an entity. For domain name
        /// identities, this action also returns the DKIM tokens that are required for
        /// Easy DKIM            signing, and whether Amazon SES has successfully verified that
        /// these tokens have been            published.
        /// 
        /// 
        /// <para>
        /// This action takes a list of identities as input and returns the following
        /// information for each:
        /// </para>
        /// <ul>            <li>Whether Easy DKIM signing is enabled or disabled.</li>
        /// <li>A set of DKIM tokens that represent the identity. If the identity is
        /// an email                address, the tokens represent the domain of that address.</li>
        /// <li>Whether Amazon SES has successfully verified the DKIM tokens published
        /// in the                domain's DNS.  This information is only returned for domain
        /// name identities, not for                email addresses.</li>        </ul>
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// 
        /// <para>
        /// For more information about creating DNS records using DKIM tokens, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim-dns-records.html">Amazon
        /// SES                Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityDkimAttributes service method.</param>
        /// 
        /// <returns>The response from the GetIdentityDkimAttributes service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetIdentityDkimAttributesResponse> GetIdentityDkimAttributesAsync(GetIdentityDkimAttributesRequest getIdentityDkimAttributesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Given a list of verified identities (email addresses and/or domains), returns a structure
        /// describing identity         notification attributes.
        /// 
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// 
        /// <para>
        /// For more information about using notifications with Amazon SES, see the
        /// <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/notifications.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityNotificationAttributes service method.</param>
        /// 
        /// <returns>The response from the GetIdentityNotificationAttributes service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetIdentityNotificationAttributesResponse> GetIdentityNotificationAttributesAsync(GetIdentityNotificationAttributesRequest getIdentityNotificationAttributesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Given a list of identities (email addresses and/or domains), returns the verification
        /// status and (for domain identities) the verification token for each identity.
        /// 
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityVerificationAttributes service method.</param>
        /// 
        /// <returns>The response from the GetIdentityVerificationAttributes service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetIdentityVerificationAttributesResponse> GetIdentityVerificationAttributesAsync(GetIdentityVerificationAttributesRequest getIdentityVerificationAttributesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns the user's current sending limits.
        /// 
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSendQuota service method.</param>
        /// 
        /// <returns>The response from the GetSendQuota service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetSendQuotaResponse> GetSendQuotaAsync(GetSendQuotaRequest getSendQuotaRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns the user's sending statistics. The result is a list of data points, representing
        /// the last two weeks of            sending activity.
        /// 
        /// 
        /// <para>
        /// Each data point in the list contains statistics for a 15-minute interval.
        /// </para>
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSendStatistics service method.</param>
        /// 
        /// <returns>The response from the GetSendStatistics service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetSendStatisticsResponse> GetSendStatisticsAsync(GetSendStatisticsRequest getSendStatisticsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns a list containing all of the identities (email addresses and domains) for
        /// a specific AWS Account, regardless of verification status.
        /// 
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentities service method.</param>
        /// 
        /// <returns>The response from the ListIdentities service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListIdentitiesResponse> ListIdentitiesAsync(ListIdentitiesRequest listIdentitiesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns a list containing all of the email addresses that have been verified.
        /// 
        /// <important>The ListVerifiedEmailAddresses action is deprecated as of the May
        /// 15, 2012 release of         Domain Verification. The ListIdentities action is now
        /// preferred.</important>
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVerifiedEmailAddresses service method.</param>
        /// 
        /// <returns>The response from the ListVerifiedEmailAddresses service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListVerifiedEmailAddressesResponse> ListVerifiedEmailAddressesAsync(ListVerifiedEmailAddressesRequest listVerifiedEmailAddressesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Composes an email message based on input data, and then immediately queues the message
        /// for sending.
        /// 
        /// <important>            You can only send email from verified email addresses
        /// and domains.             If you have not requested production access to Amazon SES,
        /// you must also             verify every recipient email address except for the recipients
        /// provided             by the Amazon SES mailbox simulator. For more information, go
        /// to the            <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-addresses-and-domains.html">Amazon
        /// SES                Developer Guide</a>.        </important>
        /// <para>
        /// The total size of the message cannot exceed 10 MB.
        /// </para>
        /// 
        /// <para>
        /// Amazon SES has a limit on the total number of recipients per message: The combined
        /// number            of To:, CC: and BCC: email addresses cannot exceed 50. If you need
        /// to send an email            message to a larger audience, you can divide your recipient
        /// list into groups of 50 or            fewer, and then call Amazon SES repeatedly to
        /// send the message to each group.
        /// </para>
        /// 
        /// <para>
        /// For every message that you send, the total number of recipients (To:, CC: and BCC:)
        /// is            counted against your            <i>sending quota</i>            - the
        /// maximum number of emails you can send in            a 24-hour period. For information
        /// about your sending quota, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/manage-sending-limits.html">Amazon
        /// SES                Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendEmail service method.</param>
        /// 
        /// <returns>The response from the SendEmail service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="T:Amazon.SimpleEmail.Model.MessageRejectedException">
        /// Indicates that the action failed, and the message could not be sent. Check the error
        /// stack for more        information about what caused the error.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SendEmailResponse> SendEmailAsync(SendEmailRequest sendEmailRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Sends an email message, with header and content specified by the client. The
        /// <code>SendRawEmail</code>            action is useful for sending multipart
        /// MIME emails. The raw text of the message must comply with Internet            email
        /// standards; otherwise, the message cannot be sent.
        /// 
        /// <important>            You can only send email from verified email addresses
        /// and domains.             If you have not requested production access to Amazon SES,
        /// you must also             verify every recipient email address except for the recipients
        /// provided             by the Amazon SES mailbox simulator. For more information, go
        /// to the            <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-addresses-and-domains.html">Amazon
        /// SES                Developer Guide</a>.        </important>
        /// <para>
        /// The total size of the message cannot exceed 10 MB. This includes any attachments that
        /// are part of the message.
        /// </para>
        /// 
        /// <para>
        /// Amazon SES has a limit on the total number of recipients per message: The combined
        /// number            of To:, CC: and BCC: email addresses cannot exceed 50. If you need
        /// to send an email            message to a larger audience, you can divide your recipient
        /// list into groups of 50 or            fewer, and then call Amazon SES repeatedly to
        /// send the message to each group.
        /// </para>
        /// 
        /// <para>
        /// The To:, CC:, and BCC: headers in the raw message can contain a group list. Note that
        /// each recipient in a group list         counts towards the 50-recipient limit.
        /// 
        /// </para>
        /// 
        /// <para>
        /// For every message that you send, the total number of recipients (To:, CC: and BCC:)
        /// is            counted against your            <i>sending quota</i>            - the
        /// maximum number of emails you can send in            a 24-hour period. For information
        /// about your sending quota, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/manage-sending-limits.html">Amazon
        /// SES                Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendRawEmail service method.</param>
        /// 
        /// <returns>The response from the SendRawEmail service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="T:Amazon.SimpleEmail.Model.MessageRejectedException">
        /// Indicates that the action failed, and the message could not be sent. Check the error
        /// stack for more        information about what caused the error.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SendRawEmailResponse> SendRawEmailAsync(SendRawEmailRequest sendRawEmailRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Enables or disables Easy DKIM signing of email sent from an identity:
        /// 
        /// <ul>                <li>If Easy DKIM            signing is enabled for
        /// a domain name identity (e.g., <code>example.com</code>), then Amazon SES will DKIM-sign
        /// all email sent by addresses under that domain name (e.g.,
        /// <code>user@example.com</code>).</li>                <li>If Easy DKIM signing
        /// is enabled for an email address, then Amazon SES will DKIM-sign            all email
        /// sent by that email address.</li>            </ul>
        /// <para>
        /// For email addresses (e.g., <code>user@example.com</code>), you can only enable Easy
        /// DKIM signing  if the        corresponding domain (e.g., <code>example.com</code>)
        /// has been set up for Easy DKIM using the AWS Console or             the <code>VerifyDomainDkim</code>
        /// action.
        /// </para>
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// 
        /// <para>
        /// For more information about Easy DKIM signing, go to the             <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityDkimEnabled service method.</param>
        /// 
        /// <returns>The response from the SetIdentityDkimEnabled service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SetIdentityDkimEnabledResponse> SetIdentityDkimEnabledAsync(SetIdentityDkimEnabledRequest setIdentityDkimEnabledRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Given an identity (email address or domain), enables or disables whether Amazon SES
        /// forwards            bounce and complaint notifications as email. Feedback forwarding
        /// can only be disabled when            Amazon Simple Notification Service (Amazon SNS)
        /// topics are specified for both bounces and complaints.
        /// 
        /// <note>Feedback forwarding does not apply to delivery notifications.
        /// Delivery notifications are only available through Amazon SNS.</note>
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// 
        /// <para>
        /// For more information about using notifications with Amazon SES,            see the
        /// <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/notifications.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityFeedbackForwardingEnabled service method.</param>
        /// 
        /// <returns>The response from the SetIdentityFeedbackForwardingEnabled service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SetIdentityFeedbackForwardingEnabledResponse> SetIdentityFeedbackForwardingEnabledAsync(SetIdentityFeedbackForwardingEnabledRequest setIdentityFeedbackForwardingEnabledRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Given an identity (email address or domain), sets the Amazon Simple Notification Service
        /// (Amazon SNS) topic to which Amazon SES will publish        bounce, complaint, and/or
        /// delivery notifications for emails sent with that identity as the <code>Source</code>.
        /// 
        /// <note>Unless feedback forwarding is enabled, you must specify Amazon SNS topics
        /// for bounce and complaint notifications.            For more information, see <code>SetIdentityFeedbackForwardingEnabled</code>.
        /// </note>
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// 
        /// <para>
        /// For more information about feedback notification, see the            <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/notifications.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityNotificationTopic service method.</param>
        /// 
        /// <returns>The response from the SetIdentityNotificationTopic service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SetIdentityNotificationTopicResponse> SetIdentityNotificationTopicAsync(SetIdentityNotificationTopicRequest setIdentityNotificationTopicRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns a set of DKIM tokens for a domain. DKIM <i>tokens</i> are character strings
        /// that            represent your domain's identity. Using these tokens, you will need
        /// to create DNS CNAME            records that point to DKIM public keys hosted by Amazon
        /// SES. Amazon Web Services will            eventually detect that you have updated your
        /// DNS records; this detection process may            take up to 72 hours. Upon successful
        /// detection, Amazon SES will be able to DKIM-sign            email originating from
        /// that domain.
        /// 
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// 
        /// <para>
        /// To enable or disable Easy DKIM signing for            a domain, use the <code>SetIdentityDkimEnabled</code>
        /// action.
        /// </para>
        /// 
        /// <para>
        /// For more information about creating DNS records using DKIM tokens, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim-dns-records.html">Amazon
        /// SES                Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyDomainDkim service method.</param>
        /// 
        /// <returns>The response from the VerifyDomainDkim service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<VerifyDomainDkimResponse> VerifyDomainDkimAsync(VerifyDomainDkimRequest verifyDomainDkimRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Verifies a domain.
        /// 
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyDomainIdentity service method.</param>
        /// 
        /// <returns>The response from the VerifyDomainIdentity service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<VerifyDomainIdentityResponse> VerifyDomainIdentityAsync(VerifyDomainIdentityRequest verifyDomainIdentityRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Verifies an email address. This action causes a confirmation email message to be
        /// sent to the specified address.
        /// 
        /// <important>The VerifyEmailAddress action is deprecated as of the May 15, 2012
        /// release        of Domain Verification. The VerifyEmailIdentity action is now preferred.</important>
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyEmailAddress service method.</param>
        /// 
        /// <returns>The response from the VerifyEmailAddress service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<VerifyEmailAddressResponse> VerifyEmailAddressAsync(VerifyEmailAddressRequest verifyEmailAddressRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Verifies an email address. This action causes a confirmation email message
        /// to be sent to the specified address.
        /// 
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyEmailIdentity service method.</param>
        /// 
        /// <returns>The response from the VerifyEmailIdentity service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<VerifyEmailIdentityResponse> VerifyEmailIdentityAsync(VerifyEmailIdentityRequest verifyEmailIdentityRequest, CancellationToken cancellationToken = default(CancellationToken));
    }
}