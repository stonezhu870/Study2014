<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="WebTest2.aspx.cs" Inherits="BookManager.WebTest2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        $(function() {
            $('#HyperLink1').on('click', function() {
                $.ajax({
                    type: "GET",
                    url: "/Ajax/CommonAjax.aspx",
                    data: { 'name': 'Json' },
                    dataType : 'json',
                    success: function (msg) {
                        alert('1' + msg['status']);
                    },
                    error:function (XMLHttpRequest, textStatus, errorThrown) {
                        alert('系统正忙，无法完成操作');
                    }
                });

                $.get("/Ajax/CommonAjax.aspx",
                    { name: "John", time: "2pm" },
                    function(data) {
                        alert('2' + data['status']);
                    }, 'json');

                $.post("/Ajax/CommonAjax.aspx",
                    { name: "John", time: "2pm" },
                    function (data) {
                        alert('3' + data['status']);
                    }, 'json');
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    这是ContentPlaceHolder1的内容
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    这是ContentPlaceHolder2的内容
    <asp:HyperLink ID="HyperLink1" ClientIDMode="Static" NavigateUrl="javascript:void(0);" runat="server">HyperLink</asp:HyperLink>
    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>
</asp:Content>
