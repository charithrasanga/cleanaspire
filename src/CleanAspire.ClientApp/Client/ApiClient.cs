// <auto-generated/>
#pragma warning disable CS0618
using CleanAspire.Api.Client.ConfirmEmail;
using CleanAspire.Api.Client.ForgotPassword;
using CleanAspire.Api.Client.Login;
using CleanAspire.Api.Client.Logout;
using CleanAspire.Api.Client.Manage;
using CleanAspire.Api.Client.Profile;
using CleanAspire.Api.Client.Refresh;
using CleanAspire.Api.Client.Register;
using CleanAspire.Api.Client.ResendConfirmationEmail;
using CleanAspire.Api.Client.ResetPassword;
using CleanAspire.Api.Client.Weatherforecast;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace CleanAspire.Api.Client
{
    /// <summary>
    /// The main entry point of the SDK, exposes the configuration and the fluent API.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ApiClient : BaseRequestBuilder
    {
        /// <summary>The confirmEmail property</summary>
        public global::CleanAspire.Api.Client.ConfirmEmail.ConfirmEmailRequestBuilder ConfirmEmail
        {
            get => new global::CleanAspire.Api.Client.ConfirmEmail.ConfirmEmailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The forgotPassword property</summary>
        public global::CleanAspire.Api.Client.ForgotPassword.ForgotPasswordRequestBuilder ForgotPassword
        {
            get => new global::CleanAspire.Api.Client.ForgotPassword.ForgotPasswordRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The login property</summary>
        public global::CleanAspire.Api.Client.Login.LoginRequestBuilder Login
        {
            get => new global::CleanAspire.Api.Client.Login.LoginRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The logout property</summary>
        public global::CleanAspire.Api.Client.Logout.LogoutRequestBuilder Logout
        {
            get => new global::CleanAspire.Api.Client.Logout.LogoutRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The manage property</summary>
        public global::CleanAspire.Api.Client.Manage.ManageRequestBuilder Manage
        {
            get => new global::CleanAspire.Api.Client.Manage.ManageRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The profile property</summary>
        public global::CleanAspire.Api.Client.Profile.ProfileRequestBuilder Profile
        {
            get => new global::CleanAspire.Api.Client.Profile.ProfileRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The refresh property</summary>
        public global::CleanAspire.Api.Client.Refresh.RefreshRequestBuilder Refresh
        {
            get => new global::CleanAspire.Api.Client.Refresh.RefreshRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The register property</summary>
        public global::CleanAspire.Api.Client.Register.RegisterRequestBuilder Register
        {
            get => new global::CleanAspire.Api.Client.Register.RegisterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The resendConfirmationEmail property</summary>
        public global::CleanAspire.Api.Client.ResendConfirmationEmail.ResendConfirmationEmailRequestBuilder ResendConfirmationEmail
        {
            get => new global::CleanAspire.Api.Client.ResendConfirmationEmail.ResendConfirmationEmailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The resetPassword property</summary>
        public global::CleanAspire.Api.Client.ResetPassword.ResetPasswordRequestBuilder ResetPassword
        {
            get => new global::CleanAspire.Api.Client.ResetPassword.ResetPasswordRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The weatherforecast property</summary>
        public global::CleanAspire.Api.Client.Weatherforecast.WeatherforecastRequestBuilder Weatherforecast
        {
            get => new global::CleanAspire.Api.Client.Weatherforecast.WeatherforecastRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::CleanAspire.Api.Client.ApiClient"/> and sets the default values.
        /// </summary>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ApiClient(IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}", new Dictionary<string, object>())
        {
        }
    }
}
#pragma warning restore CS0618
