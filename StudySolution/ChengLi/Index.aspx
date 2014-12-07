<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ChengLi.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <!-- SLIDER -->
        <div id="outerslider">
        	<div class="container">
        	<div id="slidercontainer" class="twelve columns">
            
            	<section id="slider">
                    <div id="slideritems" class="flexslider">
                        <ul class="slides">
                            <li>
                            	<img src="/Upload/index_1.jpg" alt="" />
                                <div class="flex-caption">
                                    <%--<h1>Think Unique</h1>
                                    <div class="slidetext1">Mauris ligula <span class="colortext">molestie</span> &amp; <span class="colortext">scelerisque</span></div>
                                    <div class="slidetext2">Donec consectetur libero ut tortor condimentum eu egestas</div>--%>
                                </div>
                            </li>
                            <li>
                            	<img src="/Upload/index_2.jpg" alt="" />
                                <div class="flex-caption">
                                    <%--<h1>Feel alive</h1>
                                    <div class="slidetext1">Mauris ligula <span class="colortext">molestie</span> &amp; <span class="colortext">scelerisque</span></div>
                                    <div class="slidetext2">Donec consectetur libero ut tortor condimentum eu egestas</div>--%>
                                </div>
                            </li>
                            <li>
                                <img src="/Upload/index_3.jpg" alt="" />
                                <div class="flex-caption">
                                    <%--<h1>Think Real</h1>
                                    <div class="slidetext1">Mauris ligula <span class="colortext">molestie</span> &amp; <span class="colortext">scelerisque</span></div>
                                    <div class="slidetext2">Donec consectetur libero ut tortor condimentum eu egestas</div>--%>
                                </div>
                            </li>
                        </ul>
                    </div>
                </section>
                
            </div>
            </div>
        </div>
        <!-- END SLIDER -->
        
        <!-- MAIN CONTENT -->
        <div id="outermain">
        	<div class="container">
        	<section id="maincontent" class="twelve columns">
            
            	<h2 class="titleSection">What We Do</h2>
                <div class="one_third firstcols">
                	<h3 class="titleRegular"><img src="images/icons/icon1.png" alt="" class="alignleft" />SEO Optimized with Control Panel</h3>
                    <p>
                    Quisque tellus sem, hendrerit vitae suscipit sed, consequat non dui. Sed eget tortor ut neque scelerisque vehicula pretium eget libero.
                    Aliquam hendrerit tincidunt dictum.</p>
                </div>
                <div class="one_third">
                	<h3 class="titleRegular"><img src="images/icons/icon2.png" alt="" class="alignleft" />Clean and Easy Code
Customizable</h3>
                    <p>
                    Quisque tellus sem, hendrerit vitae suscipit sed, consequat non dui. Sed eget tortor ut neque scelerisque vehicula pretium eget libero.
                    Aliquam hendrerit tincidunt dictum.</p>
                </div>
                <div class="one_third lastcols">
                	<h3 class="titleRegular"><img src="images/icons/icon3.png" alt="" class="alignleft" />Unlimited Possibilities<br />
for Pages</h3>
                    <p>
                    Quisque tellus sem, hendrerit vitae suscipit sed, consequat non dui. Sed eget tortor ut neque scelerisque vehicula pretium eget libero.
                    Aliquam hendrerit tincidunt dictum.</p>
                </div>
                
                <div class="separator line"></div>
                
                <div class="eight columns alpha">
                    <h2 class="titleSection">Welcome to Think Theme</h2>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ultrices dui eu lectus fringilla non pellentesque magna<br /> egestas. Suspendisse potenti. Vivamus at magna libero. </p>
                    <div class="one_half firstcols">
                        <ul class="row-list">
                            <li>
                                <span class="circle alignleft">1</span>
                                <h5 class="titleSemibold colortext margin_bottomoff">Great Support</h5>
                                <div class="indentleft">Aliquam luctus rhoncus eros malesuam nun.</div>
                            </li>
                            <li>
                                <span class="circle alignleft">2</span>
                                <h5 class="titleSemibold colortext margin_bottomoff">Very Flexible</h5>
                                <div class="indentleft">Aliquam luctus rhoncus eros malesuam nun.</div>
                            </li>
                            <li>
                                <span class="circle alignleft">3</span>
                                <h5 class="titleSemibold colortext margin_bottomoff">Clean and Simple</h5>
                                <div class="indentleft">Aliquam luctus rhoncus eros malesuam nun.</div>
                            </li>
                        </ul>
                    </div>
                    <div class="one_half lastcols">
                        <ul class="row-list">
                            <li>
                                <span class="circle alignleft">4</span>
                                <h5 class="titleSemibold colortext margin_bottomoff">Ideal Supporting</h5>
                                <div class="indentleft">Aliquam luctus rhoncus eros malesuam nun.</div>
                            </li>
                            <li>
                                <span class="circle alignleft">5</span>
                                <h5 class="titleSemibold colortext margin_bottomoff">Unique Works</h5>
                                <div class="indentleft">Aliquam luctus rhoncus eros malesuam nun.</div>
                            </li>
                            <li>
                                <span class="circle alignleft">6</span>
                                <h5 class="titleSemibold colortext margin_bottomoff">Dedicated for Your Work</h5>
                                <div class="indentleft">Aliquam luctus rhoncus eros malesuam nun.</div>
                            </li>
                        </ul>
                    </div>
                </div>
                <div class="four columns omega">
                    <img src="images/content/pic1.jpg" alt="" class="scale-with-grid" />
                    <div class="center"><a href="#" class="button large">More about Think Theme</a></div>
                </div>
                
                <div class="clear"></div><!-- clear float --> 
            </section>
            </div>
        </div>
        <!-- END MAIN CONTENT -->
        
<script type="text/javascript">
jQuery(window).load(function() {
    jQuery('.flexslider').flexslider({
          animation: "fade",              //String: Select your animation type, "fade" or "slide"
		  directionNav: false, //Boolean: Create navigation for previous/next navigation? (true/false)
		  controlNav: true  //Boolean: Create navigation for paging control of each clide? Note: Leave true for manualControls usage
        });
});
</script>	

</asp:Content>
