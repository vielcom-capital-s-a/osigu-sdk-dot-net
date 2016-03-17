﻿using OsiguSDK.Core.Config;
using OsiguSDK.Core.Authentication;
using OsiguSDK.Providers.Clients;
using OsiguSDK.Providers.Models.Requests;
using Ploeh.AutoFixture;


namespace OsiguSDK.SpecificationTests
{
    public static class Tools
    {
        public static readonly Fixture Fixture = new Fixture();

        public static ProductsClient ProductsProviderClient { get; set; }
        public static ProductsClient ProductsProductsClientWithNoPermission { get; set; }
        public static SubmitProductRequest SubmitProductRequest { get; set; }
        public static Insurers.Clients.ProductsClient productsInsurerClient { get; set; }
        public static Insurers.Models.Requests.SubmitProductRequest submitInsurerProductRequest { get; set; }


        public static IConfiguration ConfigInsurersSandbox { get
        {
            return _configInsurersSandbox ?? (_configInsurersSandbox = new Configuration
            {
                BaseUrl = "https://sandbox.paycodenetwork.com/v1",
                Slug = "test-insurer",
                Authentication = new Authentication("589a4586628aac2815d20c1e17bc11ab")
            });
        } }
        private static IConfiguration _configInsurersSandbox;

        public static IConfiguration ConfigProvidersSandbox { get
        {
            return _configProvidersSandbox ?? (_configProvidersSandbox = new Configuration
            {
                BaseUrl = "https://sandbox.paycodenetwork.com/v1",
                Slug = "test-insurer",
                Authentication = new Authentication("589a4586628aac2815d20c1e17bc11ab")
            });
        } }

        private static IConfiguration _configProvidersSandbox;

        public static IConfiguration ConfigInsurer1Development
        {
            get
            {
                return _configInsurer1Development ?? (_configInsurer1Development = new Configuration
                {
                    BaseUrl = "https://dev.paycodenetwork.com",
                    Slug = "test-insurer",
                    Authentication = new Authentication("eyJhbGciOiJIUzI1NiJ9.eyJlbnRpdHlfdHlwZSI6IklOU1VSRVIiLCJ1c2VyX25hbWUiOiJJTlNVUkVSLTEiLCJzY29wZSI6WyJyZWFkIiwid3JpdGUiXSwiZW50aXR5X2lkIjoxLCJhdXRob3JpdGllcyI6WyJST0xFX0lOU1VSRVIiXSwianRpIjoiZDVlM2ZjYWUtYjg5Yi00ZjI2LWFhMWUtYWU2NjcxZTk5YTk0Iiwic2x1ZyI6InRlc3QtaW5zdXJlciIsImNsaWVudF9pZCI6Im9zaWd1X2luc3VyZXJzX2FwcCJ9.zin1h7secwEYXCLJzKPVnyQiyo3otWDSoiVtkFY21PQ")
                });
            }
        }

        private static IConfiguration _configInsurer1Development;

        public static IConfiguration ConfigInsurer2Development
        {
            get
            {
                return _configInsurer2Development ?? (_configInsurer2Development = new Configuration
                {
                    BaseUrl = "https://dev.paycodenetwork.com",
                    Slug = "test-insurer-2",
                    Authentication = new Authentication("eyJhbGciOiJIUzI1NiJ9.eyJlbnRpdHlfdHlwZSI6IklOU1VSRVIiLCJ1c2VyX25hbWUiOiJJTlNVUkVSLTIiLCJzY29wZSI6WyJyZWFkIiwid3JpdGUiXSwiZW50aXR5X2lkIjoyLCJhdXRob3JpdGllcyI6WyJST0xFX0lOU1VSRVIiXSwianRpIjoiMjAyODNmYTMtOWY1Ny00OTFmLWI3MGUtYmY2OWU1N2ZhODg5Iiwic2x1ZyI6InRlc3QtaW5zdXJlci0yIiwiY2xpZW50X2lkIjoib3NpZ3VfaW5zdXJlcnNfYXBwIn0.3EOhYFU6OttPF_5Yob-S0yKy5gnF8NjLJ_qbsv_cU2Y")
                });
            }
        }

        private static IConfiguration _configInsurer2Development;

        public static IConfiguration ConfigProviderBranch1Development
        {
            get
            {
                return _configProviderBranch1Development ?? (_configProviderBranch1Development = new Configuration
                {
                    BaseUrl = "https://paycode-rds-dev.cc25dqlmelik.us-east-1.rds.amazonaws.com:5432/paycode_dev",
                    Slug = "test-provider",
                    Authentication = new Authentication("eyJhbGciOiJIUzI1NiJ9.eyJlbnRpdHlfdHlwZSI6IlBST1ZJREVSX0JSQU5DSCIsInVzZXJfbmFtZSI6IlBST1ZJREVSX0JSQU5DSC0xIiwic2NvcGUiOlsicmVhZCIsIndyaXRlIl0sImVudGl0eV9pZCI6MSwiYXV0aG9yaXRpZXMiOlsiUk9MRV9QUk9WSURFUl9CUkFOQ0giXSwianRpIjoiNzdmMDM1YWQtMTRlMi00YzFlLTk4NmMtZWNjZDJiZGNlNzBkIiwic2x1ZyI6InRlc3QtcHJvdmlkZXIiLCJjbGllbnRfaWQiOiJvc2lndV9pbnN1cmVyc19hcHAifQ.vGAGxY90dJ1IcAgP8Nc4uG3aiQgEVKMVTjWtiVmn28I")
                });
            }
        }

        private static IConfiguration _configProviderBranch1Development;

        public static IConfiguration ConfigProviderBranch2Development
        {
            get
            {
                return _configProviderBranch2Development ?? (_configProviderBranch2Development = new Configuration
                {
                    BaseUrl = "https://paycode-rds-dev.cc25dqlmelik.us-east-1.rds.amazonaws.com:5432/paycode_dev",
                    Slug = "test-provider-2",
                    Authentication = new Authentication("TOKEN: eyJhbGciOiJIUzI1NiJ9.eyJlbnRpdHlfdHlwZSI6IlBST1ZJREVSX0JSQU5DSCIsInVzZXJfbmFtZSI6IlBST1ZJREVSX0JSQU5DSC0yIiwic2NvcGUiOlsicmVhZCIsIndyaXRlIl0sImVudGl0eV9pZCI6MiwiYXV0aG9yaXRpZXMiOlsiUk9MRV9QUk9WSURFUl9CUkFOQ0giXSw")
                });
            }
        }

        private static IConfiguration _configProviderBranch2Development;

    }
}
