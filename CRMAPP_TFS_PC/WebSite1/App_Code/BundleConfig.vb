﻿Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Optimization
Imports System.Web.UI

Public Module BundleConfig
    ' 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkID=303951
    Public Sub RegisterBundles(bundles As BundleCollection)
        bundles.Add(New ScriptBundle("~/bundles/WebFormsJs").Include(
            "~/Scripts/WebForms/WebForms.js",
            "~/Scripts/WebForms/WebUIValidation.js",
            "~/Scripts/WebForms/MenuStandards.js",
            "~/Scripts/WebForms/Focus.js", "~/Scripts/WebForms/GridView.js", 
            "~/Scripts/WebForms/DetailsView.js",
            "~/Scripts/WebForms/TreeView.js",
            "~/Scripts/WebForms/WebParts.js"))

        ' 若要使这些文件正常工作，采用适当的顺序是非常重要的；这些文件具有显式依赖关系
        bundles.Add(New ScriptBundle("~/bundles/MsAjaxJs").Include(
            "~/Scripts/WebForms/MsAjax/MicrosoftAjax.js",
            "~/Scripts/WebForms/MsAjax/MicrosoftAjaxApplicationServices.js",
            "~/Scripts/WebForms/MsAjax/MicrosoftAjaxTimer.js",
            "~/Scripts/WebForms/MsAjax/MicrosoftAjaxWebForms.js"))

        ' 使用 Modernizr 开发版本进行开发和学习。然后，在准备好进行生产时，
        ' 使用 http://modernizr.com 上的生成工具来仅选取所需的测试
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
            "~/Scripts/modernizr-*"))

        ScriptManager.ScriptResourceMapping.AddDefinition("respond", New ScriptResourceDefinition() With {
            .Path = "~/Scripts/respond.min.js",
            .DebugPath = "~/Scripts/respond.js"})

    End Sub
End Module
