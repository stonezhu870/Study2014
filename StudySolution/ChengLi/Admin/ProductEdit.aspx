<%@ Page Title="商品编辑" Language="C#" ValidateRequest="false" EnableEventValidation="false" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ProductEdit.aspx.cs" Inherits="ChengLi.Admin.ProductEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="/Kindeditor/kindeditor-min.js"></script>
    <link href="/Kindeditor/themes/default/default.css" rel="stylesheet" />
    <script src="/Kindeditor/lang/zh_CN.js"></script>
    <script>
        var editor;

        var smallTypeName = '';
        var newsType = [];
        var productType = [];

        $(function() {
            $('#SmallType1').on('click', function () { //新闻
                smallTypeName = 'News';
                bindTypeId(newsType);
            });

            $('#SmallType2').on('click', function () { //产品
                smallTypeName = 'Products';
                bindTypeId(productType);
            });

            $('#linkTypeAdd').on('click', function() {
                var name = $('#TypeName').val();
                if (name == '') {
                    alert('请填写类别名称');
                    return;
                }

                $.ajax({
                    type: "GET",
                    url: "/CommonAjax.aspx",
                    data: { 'fun': 'addType', 'TypeName': name, 'SmallType': smallTypeName },
                    dataType: 'json',
                    success: function (data) {
                        var obj = { 'Id': data, 'TypeName': name };
                        if (smallTypeName == 'News')
                            newsType.push(obj);
                        else
                            productType.push(obj);

                        $('#SmallType1:checked, #SmallType2:checked').click();

                        $('#TypeName').val('');

                        //选中对应的值
                        $('#TypeId').val(data);
                    },
                    error: function (XMLHttpRequest, textStatus, errorThrown) {
                        alert('系统正忙，无法完成操作');
                    }
                });
            });

            $('#SmallType1:checked, #SmallType2:checked').click();
        });

        function bindTypeId(arr) {
            var html = [];
            for (var i = 0; i < arr.length; i++) {
                html.push('<option value="' + arr[i].Id + '">' + arr[i].TypeName + '</option>');
            }

            $('#TypeId').html(html.join(''));
        }


        KindEditor.ready(function (K) {
            editor = K.create('textarea[name="MConent"]', {
                allowFileManager: true
            });
            
            /*
            K('input[name=clear]').click(function (e) {
                editor.html('');
            });
            */
        });

        function Check() {
            var error = [];
            if ($('#txtTitle').val() == '') {
                error.push('请填写标题！');
            }

            if ($('#TypeId').val() == '') {
                error.push('请填写类别！');
            } else {
                $('#TypeIdVal').val($('#TypeId').val());
            }

            if ($('#CreateTime').val() == '') {
                error.push('请填写创建时间！');
            }

            if (editor.isEmpty()) {
                error.push('请填写内容！');
            } else {
                $('#hidMConent').val(editor.html());
            }

            if (error.length > 0) {
                alert(error.join('\n'));
                return false;
            }

            return true;
        }

        function afterSave(isSuccess) {
            if (isSuccess) {
                alert('保存成功');
                location.href = location.href;
            } else {
                alert('保存失败');
            }
        }

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="dvCnt">
        <table id="tbMain">
            <tr>
                <td class="line-title">分类：</td>
                <td>
                    <asp:RadioButton ID="SmallType1" GroupName="SmallType" ClientIDMode="Static" runat="server"  Checked="true" Text="新闻" />
                    <asp:RadioButton ID="SmallType2" GroupName="SmallType" ClientIDMode="Static" runat="server" Text="产品" />
                </td>
            </tr>
            <tr>
                <td class="line-title">标题：</td>
                <td><asp:TextBox ID="txtTitle" CssClass="line-input" Width="400px" ClientIDMode="Static" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="line-title">类别：</td>
                <td>
                   <asp:HiddenField ID="TypeIdVal" ClientIDMode="Static" runat="server" />
                    <asp:DropDownList ID="TypeId"  Width="120px" CssClass="line-input line-select" ClientIDMode="Static" runat="server"></asp:DropDownList>
                    | <asp:TextBox ID="TypeName" MaxLength="10" CssClass="line-input" ClientIDMode="Static" runat="server"></asp:TextBox>
                      <a href="javascript:void(0)" id="linkTypeAdd" class="btn">添加</a>
                </td>
            </tr>
            <tr>
                <td class="line-title">点击数：</td>
                <td><asp:TextBox ID="ClickCount" CssClass="line-input" ClientIDMode="Static" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="line-title">创建时间：</td>
                <td><asp:TextBox ID="CreateTime" CssClass="line-input Wdate" onClick="WdatePicker()" ClientIDMode="Static" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="line-title">内容：</td>
                <td>
                    <asp:HiddenField ID="hidMConent" ClientIDMode="Static" runat="server" />
                    <textarea name="MConent" style="width:800px;height:300px;visibility:hidden;"></textarea>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="tcenter">
                    <asp:LinkButton ID="btnAdd" CssClass="btn" OnClientClick="return Check()" runat="server" OnClick="btnAdd_Click">保 存</asp:LinkButton>
                </td>
            </tr>
        </table>
        <asp:Literal ID="litJs" runat="server"></asp:Literal>
    </div>
</asp:Content>
