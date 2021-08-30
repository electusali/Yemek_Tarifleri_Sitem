<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="KategoriAdminDetay.aspx.cs" Inherits="Yemek_Tarifleri_Sitem2.KategoriAdminDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>KATEGORİ AD :</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="tb5" Width="150px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>ADET :</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="tb5" Width="150px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>RESİM</td>
        <td>
            <asp:FileUpload ID="FileUpload1" runat="server" CssClass="tb5" Width="150px" />
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" CssClass="btn" Height="40px" OnClick="Button1_Click" Text="GÜNCELLE" Width="150px" />
        </td>
    </tr>
</table>
</asp:Content>
