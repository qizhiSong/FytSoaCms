#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ShopModify.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdd27a02cfa923d16b4d533b9e8e01136337efeb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Shop.Pages_FytAdmin_Shop_ShopModify), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Shop/ShopModify.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Shop/ShopModify.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Shop.Pages_FytAdmin_Shop_ShopModify), null)]
namespace FytSoa.Web.Pages.FytAdmin.Shop
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdd27a02cfa923d16b4d533b9e8e01136337efeb", @"/Pages/FytAdmin/Shop/ShopModify.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Shop_ShopModify : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form form-cus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/css/city-picker.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ShopModify.cshtml"
  
    ViewData["Title"] = "店铺管理";
    Layout = "~/Pages/FytAdmin/_Layout.cshtml";

#line default
#line hidden
            BeginContext(151, 125, true);
            WriteLiteral("<style>\r\n    .layui-form-item .layui-input-inline{width:280px;}\r\n    .layui-textarea{width:97%; min-height:60px;}\r\n</style>\r\n");
            EndContext();
            BeginContext(276, 4799, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9c407f4778240a1926bd16ce1da4a9b", async() => {
                BeginContext(320, 228, true);
                WriteLiteral("\r\n    <div class=\"layui-form-item\">\r\n        <div class=\"layui-inline\">\r\n            <label class=\"layui-form-label\">登录账号</label>\r\n            <div class=\"layui-input-inline\">\r\n                <input type=\"text\" name=\"LoginName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 548, "\"", 582, 1);
#line 16 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ShopModify.cshtml"
WriteAttributeValue("", 556, Model.shopModel.LoginName, 556, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(583, 328, true);
                WriteLiteral(@" maxlength=""20"" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
        <div class=""layui-inline"">
            <label class=""layui-form-label"">登录密码</label>
            <div class=""layui-input-inline"">
                <input type=""password"" name=""LoginPwd""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 911, "\"", 944, 1);
#line 22 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ShopModify.cshtml"
WriteAttributeValue("", 919, Model.shopModel.LoginPwd, 919, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(945, 371, true);
                WriteLiteral(@" maxlength=""20"" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-inline"">
            <label class=""layui-form-label"">店铺名称</label>
            <div class=""layui-input-inline"">
                <input type=""text"" name=""ShopName""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1316, "\"", 1349, 1);
#line 30 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ShopModify.cshtml"
WriteAttributeValue("", 1324, Model.shopModel.ShopName, 1324, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1350, 264, true);
                WriteLiteral(@" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
        <div class=""layui-inline"">
            <label class=""layui-form-label"">座机号码</label>
            <div class=""layui-input-inline"">
                <input type=""email"" name=""Tel""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1614, "\"", 1642, 1);
#line 36 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ShopModify.cshtml"
WriteAttributeValue("", 1622, Model.shopModel.Tel, 1622, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1643, 316, true);
                WriteLiteral(@" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-inline"">
            <label class=""layui-form-label"">店铺所在地</label>
            <div class=""layui-input-inline"">
                <input type=""text"" name=""ShopCity""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1959, "\"", 1992, 1);
#line 44 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ShopModify.cshtml"
WriteAttributeValue("", 1967, Model.shopModel.ShopCity, 1967, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1993, 316, true);
                WriteLiteral(@" data-toggle=""city-picker"" autocomplete=""off"" class=""layui-input city-picker-input"">
            </div>
        </div>
        <div class=""layui-inline"">
            <label class=""layui-form-label"">详细地址</label>
            <div class=""layui-input-inline"">
                <input type=""email"" name=""ShopAddress""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2309, "\"", 2345, 1);
#line 50 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ShopModify.cshtml"
WriteAttributeValue("", 2317, Model.shopModel.ShopAddress, 2317, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2346, 317, true);
                WriteLiteral(@" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-inline"">
            <label class=""layui-form-label"">负责人姓名</label>
            <div class=""layui-input-inline"">
                <input type=""text"" name=""AdminName""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2663, "\"", 2697, 1);
#line 58 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ShopModify.cshtml"
WriteAttributeValue("", 2671, Model.shopModel.AdminName, 2671, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2698, 322, true);
                WriteLiteral(@" maxlength=""10"" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
        <div class=""layui-inline"">
            <label class=""layui-form-label"">联系方式</label>
            <div class=""layui-input-inline"">
                <input type=""text"" name=""Mobile""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3020, "\"", 3051, 1);
#line 64 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ShopModify.cshtml"
WriteAttributeValue("", 3028, Model.shopModel.Mobile, 3028, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3052, 386, true);
                WriteLiteral(@" maxlength=""20"" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-inline"">
            <label class=""layui-form-label"">性别</label>
            <div class=""layui-input-inline"">
                <input type=""radio"" name=""Sex"" value=""男"" title=""男"" ");
                EndContext();
                BeginContext(3440, 43, false);
#line 72 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ShopModify.cshtml"
                                                               Write(Model.shopModel.Sex == "男" ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(3484, 70, true);
                WriteLiteral(">\r\n                <input type=\"radio\" name=\"Sex\" value=\"女\" title=\"女\" ");
                EndContext();
                BeginContext(3556, 43, false);
#line 73 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ShopModify.cshtml"
                                                               Write(Model.shopModel.Sex == "女" ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(3600, 248, true);
                WriteLiteral(">\r\n            </div>\r\n        </div>\r\n        <div class=\"layui-inline\">\r\n            <label class=\"layui-form-label\">状态</label>\r\n            <div class=\"layui-input-inline\">\r\n                <input type=\"radio\" name=\"Status\" value=\"0\" title=\"营业\" ");
                EndContext();
                BeginContext(3850, 44, false);
#line 79 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ShopModify.cshtml"
                                                                   Write(Model.shopModel.Status == 0 ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(3895, 74, true);
                WriteLiteral(">\r\n                <input type=\"radio\" name=\"Status\" value=\"1\" title=\"冻结\" ");
                EndContext();
                BeginContext(3971, 44, false);
#line 80 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ShopModify.cshtml"
                                                                   Write(Model.shopModel.Status == 1 ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(4016, 74, true);
                WriteLiteral(">\r\n                <input type=\"radio\" name=\"Status\" value=\"2\" title=\"停业\" ");
                EndContext();
                BeginContext(4092, 44, false);
#line 81 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ShopModify.cshtml"
                                                                   Write(Model.shopModel.Status == 2 ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(4137, 239, true);
                WriteLiteral(">\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">描述</label>\r\n        <div class=\"layui-input-block\">\r\n            <textarea name=\"Summary\" class=\"layui-textarea\">");
                EndContext();
                BeginContext(4377, 23, false);
#line 88 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ShopModify.cshtml"
                                                       Write(Model.shopModel.Summary);

#line default
#line hidden
                EndContext();
                BeginContext(4400, 376, true);
                WriteLiteral(@"</textarea>
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-input-block"">
            <button class=""layui-btn"" lay-submit="""" lay-filter=""submit"">立即提交</button>
            <button type=""button"" class=""layui-btn layui-btn-primary btn-open-close"">取消</button>
        </div>
    </div>
    <input type=""hidden"" name=""Guid"" id=""Guid""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4776, "\"", 4805, 1);
#line 97 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ShopModify.cshtml"
WriteAttributeValue("", 4784, Model.shopModel.Guid, 4784, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4806, 50, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"LastLoginDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4856, "\"", 4894, 1);
#line 98 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ShopModify.cshtml"
WriteAttributeValue("", 4864, Model.shopModel.LastLoginDate, 4864, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4895, 47, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"LoginCount\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4942, "\"", 4977, 1);
#line 99 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ShopModify.cshtml"
WriteAttributeValue("", 4950, Model.shopModel.LoginCount, 4950, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4978, 48, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"UpLoginDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5026, "\"", 5062, 1);
#line 100 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ShopModify.cshtml"
WriteAttributeValue("", 5034, Model.shopModel.UpLoginDate, 5034, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5063, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5075, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(5077, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e917a3b114b44b2e9fa97c18c2ceb05d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5152, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5171, 1159, true);
                WriteLiteral(@"
    <script>
        layui.define(['layer','city-picker'], function (exports) {
            ""use strict"";
            exports('citys', null);
        });
        layui.config({
            base: '/themes/js/modules/'
        }).use(['layer', 'jquery', 'common', 'form'], function () {
            var form = layui.form, $ = layui.$, os = layui.common;
            var index = parent.layer.getFrameIndex(window.name);
            //监听提交
            form.on('submit(submit)', function (data) {
                var urls = ""api/shops/add"";
                if ($(""#Guid"").val()) {
                    urls = ""api/shops/edit"";
                }
                os.ajax(urls, data.field, function (res) {
                    if (res.statusCode == 200) {
                        parent.layer.close(index);
                    }
                    else {
                        os.error(res.message);
                    }
                });
                return false;
            });
            $(");
                WriteLiteral("\".btn-open-close\").on(\'click\', function () {\r\n                parent.layer.close(index);\r\n            });\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(6333, 2, true);
            WriteLiteral("\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Shop.ShopModifyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Shop.ShopModifyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Shop.ShopModifyModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Shop.ShopModifyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591