<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebTest3.aspx.cs" Inherits="BookManager.WebTest3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>WebTest3</title>
    <style>
      
        .content 
        {
        width:364px;
        border:solid 1px black;
        background-color:white;
        } 
       
        .form 
        {
        padding-top:50px;
        }
</style>   
        

   
</head>
<body>
    <form id="form1" runat="server" class ="form" >
    <div class="content">
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
                <table border="1">
                    <tr>
                        <td>开户人</td>
                        <td>身份证</td>
                        <td>电话</td>
                        <td>地址</td>
                    </tr>
           </HeaderTemplate>
           <ItemTemplate>
               <tr>
                   <td><%# Eval("CustomerName") %></td>
                   <td><%# Eval("Pid") %></td>
                   <td><%# Eval("TelPhone") %></td>
                   <td><%# Eval("Address") %></td>
               </tr>
           </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>


        </asp:Repeater>  
    </div>
        <br/><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl ="http://www.baidu.com" Target ="_blank">百度</asp:HyperLink>
        <br/><asp:Image ID="Image1" runat="server"   ImageUrl ="http://gtms02.alicdn.com/tps/i2/TB14hWqGVXXXXXOXVXXCtjtIVXX-570-400.jpg"/>
        <br/><asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
   <br/> <div>   
         <asp:RadioButton ID="RadioButton1" runat="server" />
       <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
       <asp:LinkButton ID="LinkButton2" runat="server">LinkButton</asp:LinkButton>
    </div>
        <br/>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
