﻿using System.Web;
using System.Web.Optimization;

namespace MsmqManager.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/bootstrap")
                .Include("~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/Scripts/jquery.tablesorter")
                .Include("~/Scripts/jquery.tablesorter.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/jquery-{version}.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrap")
                .Include("~/Content/bootstrap/bootstrap.css")
                .Include("~/Content/bootstrap/bootstrap-responsive.css"));

            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/site.css"));
        }
    }
}