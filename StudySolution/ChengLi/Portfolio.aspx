<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Portfolio.aspx.cs" Inherits="ChengLi.Portfolio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="/styles/inner.css" />
	<link rel="stylesheet" href="/styles/prettyPhoto.css" media="screen" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- MAIN CONTENT -->
        <div id="outermain" class="inner">
        	<div class="container">
        	<section id="maincontent" class="twelve columns">
            
            	<h1 class="pagetitle">
                    <asp:Label ID="lbTitle" runat="server" Text=""></asp:Label>
            	</h1>
                
                <div id="ts-display-portfolio">
                
                <ul id="filter" class="controlnav">
                    <li class="segment-1 <%=GetSelectedClass(-1) %>"><a href="/Portfolio.aspx?st=<%=SmallTypeVal %>" data-value="all">所有分类</a></li>
                    <asp:Repeater runat="server" ID="repList">
                        <ItemTemplate>
                            <li class="segment-1 <%# GetSelectedClass(Eval("Id")) %>"><a href="/Portfolio.aspx?st=<%=SmallTypeVal %>&type=<%# Eval("Id") %>" data-value="business"><%# Eval("TypeName") %></a></li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
                <ul id="ts-display-pf-filterable" class="ts-display-pf-col-4 image-grid">
                    <asp:Repeater runat="server" ID="repList2">
                        <ItemTemplate>
                            <li class="business">
                                <div class="ts-display-pf-img">
                                    <a class="image" href="#">
                                    <span class="rollover"></span>
                                    <img src="/images/content/pf/pf8.jpg" alt="" />
                                    </a>							
                                </div>
                                <span class="shadowpfimg"></span>
                                <div class="ts-display-pf-text">
                                    <h2><a href="/Single.aspx?id=<%#Eval("Id") %>"><%# Eval("Title") %></a></h2>
                                    <%--<span>Lorem ipsum dolor sit, consectetur. </span>--%>
                                </div>
                                <div class="ts-display-clear"></div>
                            </li>
                    </ItemTemplate>
                    </asp:Repeater>
                </ul>
                
                <div class="clear"></div>
                
                </div><!-- end #ts-display-portfolio -->
                
                <div class="clear"></div><!-- clear float --> 
            </section>
            </div>
        </div>
   <!-- END MAIN CONTENT -->
</asp:Content>
