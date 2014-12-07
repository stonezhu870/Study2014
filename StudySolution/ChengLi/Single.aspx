<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Single.aspx.cs" Inherits="ChengLi.Single" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="/styles/inner.css" />
	<link rel="stylesheet" href="/styles/prettyPhoto.css" media="screen" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <!-- MAIN CONTENT -->
        <div id="outermain" class="inner">
        	<div class="container">
        	<section id="maincontent" class="twelve columns">
				<section id="content" class="positionleft nine columns alpha"> 
                	<div class="padcontent">
                                   
                	<article class="post">
                    	<h1 class="posttitle">
                            <asp:Label ID="lbTitle" runat="server"></asp:Label>
                    	</h1>
                        <div class="entry-utility">
                            创建日期：<asp:Label ID="lbCreateTime" runat="server"></asp:Label>
                            点击数：<asp:Label ID="lbClickCount" runat="server"></asp:Label>
                        </div>
                        <div class="entry-content">
                            <asp:Literal ID="litHtml" runat="server"></asp:Literal>
                            <div class="clearfix"></div>
                        </div>
                    </article>
                    
                    <section id="comment">
                        <h4 class="titleBold">4 Comments</h4>
                        <ol class="commentlist">
                            <li>
                                <div class="comment-body">
                                    <div class="avatar-img"><img src="images/content/avatar.gif" alt="" class="avatar" /></div>
                                    <cite class="fn"><a href="#">Richard Delano</a></cite><span class="tdate">August 17, 2010 7:15 am</span> &middot; <span class="reply"><a href="#" class="more">Reply</a></span>
                                    <div class="commenttext">
                                        <p>Nulla lobortis facilisis eros vitae mollis. Morbi consectetur, tortor ut feugiat rhoncus, nunc augue placerat massa, sit amet laoreet est libero quis nisl. Integer cursus sodales sem eu dapibus. Morbi lobortis eleifend lectus sit amet porttitor. Nam tincidunt congue laoreet.</p>
                                    </div>
                                </div>
                            </li>
                            <li>
                                <div class="comment-body">
                                    <div class="avatar-img"><img src="images/content/avatar.gif" alt="" class="avatar" /></div>
                                    <cite class="fn"><a href="#">Michael John</a></cite><span class="tdate">August 17, 2010 7:15 am</span> &middot; <span class="reply"><a href="#" class="more">Reply</a></span>
                                    <div class="commenttext">
                                        <p>Nulla lobortis facilisis eros vitae mollis. Morbi consectetur, tortor ut feugiat rhoncus, nunc augue placerat massa, sit amet laoreet est libero quis nisl. Integer cursus sodales sem eu dapibus. Morbi lobortis eleifend lectus sit amet porttitor. Nam tincidunt congue laoreet.</p>
                                    </div>
                                </div>
                                <ol>
                                    </ol></li><li>
                                        <div class="comment-body">
                                            <div class="avatar-img"><img src="images/content/avatar.gif" alt="" class="avatar" /></div>
                                            <cite class="fn"><a href="#">Wayne Rooney</a></cite><span class="tdate">August 17, 2010 7:15 am</span> &middot; <span class="reply"><a href="#" class="more">Reply</a></span>
                                            <div class="commenttext">
                                                <p>Nulla lobortis facilisis eros vitae mollis. Morbi consectetur, tortor ut feugiat rhoncus, nunc augue placerat massa, sit amet laoreet est libero quis nisl. Integer cursus sodales sem eu dapibus. Morbi lobortis eleifend lectus sit amet porttitor. Nam tincidunt congue laoreet.</p>
                                            </div>
                                        </div>
                                    </li>
                                
                            
                            <li>
                                <div class="comment-body">
                                    <div class="avatar-img"><img src="images/content/avatar.gif" alt="" class="avatar" /></div>
                                    <cite class="fn"><a href="#">John Doe</a></cite><span class="tdate">August 17, 2010 7:15 am</span> &middot; <span class="reply"><a href="#" class="more">Reply</a></span>
                                    <div class="commenttext">
                                        <p>Nulla lobortis facilisis eros vitae mollis. Morbi consectetur, tortor ut feugiat rhoncus, nunc augue placerat massa, sit amet laoreet est libero quis nisl. Integer cursus sodales sem eu dapibus. Morbi lobortis eleifend lectus sit amet porttitor. Nam tincidunt congue laoreet.</p>
                                    </div>
                                </div>
                            </li>
                        
                        <h4 class="titleBold">Leave Comment</h4>
                          <form id="commentform" action="#" />
                            <fieldset>
                              <label for="name" id="name_label">Name:</label>
                              <input type="text" name="name" id="name" size="40" value="" class="text-input" />
                              <label for="email" id="email_label">Email:</label>
                              <input type="text" name="email" id="email" size="40" value="" class="text-input" />
                              <label for="msg" id="msg_label">Message:</label>
                             <textarea rows="10" name="msg" id="msg" class="textarea"></textarea><br />
                              <input type="submit" name="submit" class="button mini" id="submit_btn" value="Submit" />
                            </fieldset>
                    
                          </form>
                    </ol></section>                    
                                        
                	</div>
                </section>
                <div class="clear"></div><!-- clear float --> 
            </section>
            </div>
        </div>
 <!-- END MAIN CONTENT -->
</asp:Content>
