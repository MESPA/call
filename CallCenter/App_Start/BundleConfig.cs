﻿using System.Web;
using System.Web.Optimization;

namespace CallCenter
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)


        {
            bundles.Add(new ScriptBundle("~/bundles/sweetalert2/js").Include(
                       "~/Content/sweetaler2/sweetalert2.all.js"));

            bundles.Add(new StyleBundle("~/bundles/sweetalert2/css").Include(
                      "~/Content/sweetaler2/sweetalert2.all.css"));






            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
         
            "~/Scripts/bootstrap.js",
            "~/Scripts/sweetalert.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                       "~/Content/sweetalert.css",
                      "~/Content/site.css"));
        }
    }
}
