// ***********************************************************************
// Assembly         : EveLib.EveAuth
// Author           : Lars Kristian
// Created          : 12-10-2014
//
// Last Modified By : Lars Kristian
// Last Modified On : 12-17-2014
// ***********************************************************************
// <copyright file="EveAuth.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;

namespace borkedLabs.CrestScribe
{
    /// <summary>
    ///     Class EveAuth. A helper class for Eve Online SSO authentication
    /// </summary>
    public class EveAuth
    {
        private static HttpClient httpClient = new HttpClient();
        public static string UserAgent { get; set; } = "siggy.scribe/1.0.0.0 (siggy.borkedlabs.com)";

        /// <summary>
        ///     Initializes a new instance of the <see cref="EveAuth" /> class.
        /// </summary>
        public EveAuth()
        {
            Host = "login.eveonline.com";
            Protocol = "https://";
        }

        /// <summary>
        /// Gets or sets the protocol.
        /// </summary>
        /// <value>The protocol.</value>
        public string Protocol { get; set; }

        /// <summary>
        ///     Gets or sets the base URI.
        /// </summary>
        /// <value>The base URI.</value>
        public string Host { get; set; }

        /// <summary>
        ///     Authenticates the specified encoded key.
        /// </summary>
        /// <param name="encodedKey">The encoded key.</param>
        /// <param name="authCode">The authentication code.</param>
        /// <returns>Task&lt;AuthResponse&gt;.</returns>
        public async Task<AuthResponse> AuthenticateAsync(string encodedKey, string authCode)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, new Uri(Protocol + Host + "/v2/oauth/token"));
            request.Headers.UserAgent.ParseAdd(UserAgent);

            request.Headers.Add("Authorization", "Basic " + encodedKey);
            var formContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "authorization_code"),
                new KeyValuePair<string, string>("code", authCode)
            });

            request.Content = formContent;

            using HttpResponseMessage responseMessage = await httpClient.SendAsync(request).ConfigureAwait(false);

            responseMessage.EnsureSuccessStatusCode();

            string response = await responseMessage.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<AuthResponse>(response);
            return result;
        }

        /// <summary>
        ///     Refreshes the specified encoded key.
        /// </summary>
        /// <param name="encodedKey">The encoded key.</param>
        /// <param name="refreshToken">The refresh token.</param>
        /// <returns>Task&lt;AuthResponse&gt;.</returns>
        public async Task<AuthResponse> RefreshAsync(string encodedKey, string refreshToken)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, new Uri(Protocol + Host + "/v2/oauth/token"));
            request.Headers.Add("Authorization", "Basic " + encodedKey);
            var formContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "refresh_token"),
                new KeyValuePair<string, string>("code", HttpUtility.UrlEncode(refreshToken))
            });
            request.Content = formContent;

            using HttpResponseMessage responseMessage = await httpClient.SendAsync(request).ConfigureAwait(false);

            responseMessage.EnsureSuccessStatusCode();

            string response = await responseMessage.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<AuthResponse>(response);
            return result;
        }

        /// <summary>
        ///     Encodes the specified client identifier and secret.
        /// </summary>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="clientSecret">The client secret.</param>
        /// <returns>System.String.</returns>
        public static string Encode(string clientId, string clientSecret)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(clientId + ":" + clientSecret);
            return Convert.ToBase64String(plainTextBytes);
        }
    }
}