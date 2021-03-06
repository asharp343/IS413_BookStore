﻿using System;
using System.Collections.Generic;
using IS413_BookStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;


namespace IS413_BookStore.Infrastructure
{

    [HtmlTargetElement("div", Attributes = "page-model")]

    public class PageLinkTagHelper : TagHelper
    {

        private IUrlHelperFactory urlHelperFactory;

        public PageLinkTagHelper(IUrlHelperFactory hp)
        {
            urlHelperFactory = hp;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }
        public PagingInfo PageModel { get; set; }
        public string PageAction { get; set; }

        [HtmlAttributeName(DictionaryAttributePrefix = "page-url-")]
        public Dictionary<string, object> PageUrlValues { get; set; } = new Dictionary<string, object>();

        public bool PageClassesEnabled { get; set; } = false;
        public string PageClass { get; set; }
        public string PageClassNormal { get; set; }
        public string PageClassSelected { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);

            TagBuilder result = new TagBuilder("div");


            // Create html tags for back and forward arrow in navigation
            TagBuilder backTag = new TagBuilder("a");
            TagBuilder forwardTag = new TagBuilder("a");

            int prevPage;
            int nextPage;

            if (PageModel.CurrentPage == 1) { prevPage = 1; }
            else { prevPage = PageModel.CurrentPage - 1; }

            if (PageModel.CurrentPage == PageModel.TotalPages) { nextPage = PageModel.TotalPages; }
            else { nextPage = PageModel.CurrentPage + 1; }

            backTag.Attributes["href"] = urlHelper.Action(PageAction, new { pageNum = prevPage });
            backTag.AddCssClass("btn-secondary btn ml-1 mr-1 pl-2 pr-2 mb-5");
            backTag.InnerHtml.AppendHtml("<<");
            result.InnerHtml.AppendHtml(backTag);

            // Create page link for every page in navigation
            for (int i = 1; i <= PageModel.TotalPages; i++)
            {

                TagBuilder tag = new TagBuilder("a");

                PageUrlValues["pageNum"] = i;
                tag.Attributes["href"] = urlHelper.Action(PageAction,
                    PageUrlValues);

                if (PageClassesEnabled)
                {
                    tag.AddCssClass(PageClass);
                    tag.AddCssClass(i == PageModel.CurrentPage ? PageClassSelected : PageClassNormal);
                }

                tag.InnerHtml.Append(i.ToString());

                result.InnerHtml.AppendHtml(tag);
            }

            forwardTag.Attributes["href"] = urlHelper.Action(PageAction, new { pageNum = nextPage });
            forwardTag.AddCssClass("btn-secondary btn ml-1 mr-1 pl-2 pr-2 mb-5");
            forwardTag.InnerHtml.AppendHtml(">>");
            result.InnerHtml.AppendHtml(forwardTag);

            result.AddCssClass("pagination justify-content-center");

            output.Content.AppendHtml(result.InnerHtml);
        }


    }
}
