﻿using System.Text;
using OsiguSDK.Core.Client;
using OsiguSDK.Core.Config;
using OsiguSDK.Core.Models;
using OsiguSDK.Core.Requests;
using OsiguSDK.Insurers.Models.Responses;
using RestSharp;

namespace OsiguSDK.Insurers.Clients
{
    public class AuthorizationExpressClient : BaseClient
    {

        public enum ExpressAuthorizationStatus
        {
            INSURER_PENDING_REVIEW,
            INSURER_APPROVED,
            INSURER_REJECTED,
            PENDING_PAID,
            PAID
        }

        public AuthorizationExpressClient(IConfiguration configuration) : base(configuration)
        {
        }

        public AuthorizationExpressResponse GetSingleAuthorization(string id)
        {
            var urlBuilder = new StringBuilder("/insurers/").Append(Configuration.Slug).Append("/authorizations/express/").Append(id);
            var requestData = new RequestData(urlBuilder.ToString(), Method.GET, null, null);
            return ExecuteMethod<AuthorizationExpressResponse>(requestData);
        }

        public Pagination<AuthorizationExpressResponse> GetListOfAuthorizationExpress(ExpressAuthorizationStatus status = ExpressAuthorizationStatus.INSURER_PENDING_REVIEW,  int? page = 0, int? size = 25)
        {
            var urlBuilder = new StringBuilder("/insurers/").Append(Configuration.Slug).Append("/authorizations/express").Append("?status=").Append(status.ToString().ToLower()).Append("&page=").Append(page).Append("&size=").Append(size); ;
            var requestData = new RequestData(urlBuilder.ToString(), Method.GET, null, null);
            return ExecuteMethod<Pagination<AuthorizationExpressResponse>>(requestData);
        }

        public void ApproveExpressAuthorization(string id)
        {
            var urlBuilder = new StringBuilder("/insurers/").Append(Configuration.Slug).Append("/authorizations/express/").Append(id).Append("/approve");
            var requestData = new RequestData(urlBuilder.ToString(), Method.POST, null, null);
            ExecuteMethod(requestData);
        }

        public void RejectExpressAuthorization(string id)
        {
            var urlBuilder = new StringBuilder("/insurers/").Append(Configuration.Slug).Append("/authorizations/express/").Append(id).Append("/reject");
            var requestData = new RequestData(urlBuilder.ToString(), Method.POST, null, null);
            ExecuteMethod(requestData);
        }
    }
}
