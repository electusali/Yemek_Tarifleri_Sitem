<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="TarifOner.aspx.cs" Inherits="Yemek_Tarifleri_Sitem2.TarifOner" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style4 {
        text-align: left;
    }
    .auto-style5 {
        text-align: right;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style5"><strong>
            <br />
            Tarifad :</strong><br />
            <strong>Malzemeler :</strong><br />
            <strong>Yapılış :</strong><br />
            <strong>Resim :</strong><br />
            <strong>TarifOner:</strong><br />
            <strong>MailAdres:</strong></td>
        <td class="auto-style4">
            <asp:TextBox ID="tbxTaifad" runat="server" OnTextChanged="TextBox1_TextChanged" Width="250px"></asp:TextBox>
            <br />
            <asp:TextBox ID="tbxMalzemeler" runat="server" Height="80px" TextMode="MultiLine" Width="250px"></asp:TextBox>
            <br />
            <asp:TextBox ID="tbxYapilis" runat="server" Height="200px" TextMode="MultiLine"></asp:TextBox>
            <br />
            <asp:FileUpload ID="FileResim" runat="server" Width="250px" />
            <br />
            <asp:TextBox ID="tbxTarifOner" runat="server" Width="250px"></asp:TextBox>
            <br />
            <asp:TextBox ID="tbxMailAdres" runat="server" TextMode="Email" Width="250px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnTarifOner" runat="server" BackColor="#33CCCC" style="text-align: center" Text="Tarif Oner" Width="170px" OnClick="btnTarifOner_Click" />
        </td>
    </tr>
</table>
</asp:Content>
