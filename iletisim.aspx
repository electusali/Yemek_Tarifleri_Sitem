<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="iletisim.aspx.cs" Inherits="Yemek_Tarifleri_Sitem2.iletisim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style4 {
        width: 100%;
    }
    .auto-style5 {
        font-size: x-large;
        text-align: right;
    }
    .auto-style6 {
        background-color: #FF66FF;
    }
        .auto-style7 {
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style4">
    <tr>
        <td class="auto-style5"><strong><span class="auto-style6"><em>MESAJ PANELİ</em></span></strong></td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style7"><strong>Ad Soyad :</strong></td>
        <td>
            <asp:TextBox ID="tbxGonderen" runat="server" Font-Bold="False" Width="250px" CssClass="tb5"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7"><strong>Mail Adres :</strong></td>
        <td>
            <asp:TextBox ID="tbxMail" runat="server" Font-Bold="False" Width="250px" CssClass="tb5"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7"><strong>Konu :</strong></td>
        <td>
            <asp:TextBox ID="tbxBaslik" runat="server" Font-Bold="False" Width="250px" CssClass="tb5"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7"><strong>Mesaj :</strong></td>
        <td>
            <asp:TextBox ID="tbxMesaj" runat="server" Font-Bold="False" Width="250px" CssClass="tb5" Height="150px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="btnGonder" runat="server" BackColor="#66FF66" Font-Bold="True" Font-Names="Bauhaus 93" Font-Overline="False" style="text-align: center" Text=" GÖNDER" Width="150px" CssClass="btn" OnClick="btnGonder_Click" />
        </td>
    </tr>
</table>
</asp:Content>
