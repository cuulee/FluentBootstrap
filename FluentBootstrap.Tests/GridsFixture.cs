﻿using HtmlAgilityPack;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBootstrap.Tests
{
    [TestFixture]
    public class GridsFixture
    {
        [Test]
        public void ContainerProducesCorrectHtml()
        {
            TestHelper.AssertHtml<ASP._Views_Tests_Grids_cshtml>("test-container", 
@"<div class=""container"">            Container
</div>");
        }

        [Test]
        public void FluidContainerProducesCorrectHtml()
        {
            TestHelper.AssertHtml<ASP._Views_Tests_Grids_cshtml>("test-fluid-container", 
@"<div class=""container-fluid"">            Fluid Container
</div>");

        }
        [Test]
        public void SimpleGridProducesCorrectHtml()
        {
            TestHelper.AssertHtml<ASP._Views_Tests_Grids_cshtml>("test-simple-grid",
@"<div class=""row"">
   <div class=""col-md-3"">                3
</div>
   <div class=""col-md-4"">                4
</div>
   <div class=""col-md-5"">                5
</div>
  </div>");
        }

        [Test]
        public void ComplexGridProducesCorrectHtml()
        {
            TestHelper.AssertHtml<ASP._Views_Tests_Grids_cshtml>("test-complex-grid",
@"<div class=""row"">
   <div class=""col-xs-1"">                Xs1
</div>
   <div class=""col-sm-2"">                Sm2
</div>
   <div class=""col-md-3"">                Md3
</div>
   <div class=""col-lg-4"">                Lg4
</div>
   <div class=""col-xs-2 col-lg-3"">                Xs2Lg3
</div>
  </div>");
        }

        [Test]
        public void OffsetPullPushGridProducesCorrectHtml()
        {
            TestHelper.AssertHtml<ASP._Views_Tests_Grids_cshtml>("test-offset-pull-push-grid",
@"<div class=""row"">
   <div class=""col-sm-5 col-md-6"">                A
</div>
   <div class=""col-sm-5 col-sm-offset-2 col-md-6 col-md-offset-0"">                B
</div>
  </div>
  <div class=""row"">
   <div class=""col-md-9 col-md-push-3"">                D
</div>
   <div class=""col-md-3 col-md-pull-9"">                C
</div>
  </div>");
        }
    }
}
