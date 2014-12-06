<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookList.aspx.cs" Inherits="BookManager.BookList" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="OSC_Banner">
        <div class="wp998">
            <a href="http://www.oschina.net/" class="Logo" title="OSChina 开源中国">开源中国</a>
            <h1><a href="/news">开源资讯</a></h1>
            <dl>
                <dt>&nbsp;</dt>
                <dt>共有 <em>53359</em> 篇资讯， <a href="http://www.oschina.net/home/go?page=admin%2Fnew-release">投递新闻»</a></dt>
            </dl>
            <form action="http://www.oschina.net/search" class="search">
            <input type="hidden" name="scope" value="project">
            <input id="channel_q" type="text" name="q" value="" placeholder="资讯、软件、分享、代码、博客" class="TXT">
            <button type="submit" class="BTN">搜 索</button>
            </form>
            <div class="clear"></div>
        </div>
    </div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <a id="linka" href="http://www.baidu.com">baidu</a>
        <br />
        <br />
        <a id="linkb" runat="server" href="http://www.baidu.com">baidu</a>
        <br />
        <br />
        <asp:HyperLink NavigateUrl="http://www.baidu.com" ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>

        <asp:CheckBox ID="CheckBox1" runat="server" Text="test" />
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>

        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:HiddenField ID="HiddenField1" runat="server" />
        <input type="hidden" />
        <asp:Image ID="Image1" runat="server" ImageUrl="http://i.mmcdn.cn/simba/img/TB19LDQGFXXXXaZXVXXSutbFXXX.jpg" Width="581px" />
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>

        <!--此控件不会帮我们生成任何副作用代码-->
        <asp:Literal ID="Literal1" runat="server" Text="asdfasdfasdf">
        </asp:Literal>
        <asp:Panel ID="Panel1" runat="server" Style="display: none;">
            asfsdfasd
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <asp:ImageMap ID="ImageMap1" runat="server"></asp:ImageMap>
            asdfasdfas
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" Visible="false">
            asfsdfasd
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <asp:ImageMap ID="ImageMap2" runat="server"></asp:ImageMap>
            asdfasdfas
        </asp:Panel>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server">
            <asp:Panel ID="Panel2" runat="server"></asp:Panel>
            <asp:Localize ID="Localize1" runat="server"></asp:Localize>
        </asp:PlaceHolder>
    </div>

    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Style="color: red" ErrorMessage="*"></asp:RequiredFieldValidator>
    <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />
    </asp:GridView>

    <asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate>
            <table>
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
                <td><%# DataBinder.Eval(Container.DataItem,"Address")%></td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
    <input id="Button1" type="button" value="button" /><input id="Reset1" type="reset" value="reset" /><input id="Submit1" type="submit" value="submit" /><input id="File1" type="file" /><input id="Checkbox1" type="checkbox" />

    </form>
</body>
</html>
