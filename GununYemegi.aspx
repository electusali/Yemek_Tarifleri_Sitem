<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="GununYemegi.aspx.cs" Inherits="Yemek_Tarifleri_Sitem2.GununYemegi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <asp:DataList ID="DataList2" runat="server" style="text-align: left; margin-right: 68px">
        <ItemTemplate>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" style="font-weight: 700; font-size: x-large; text-align: center;" Text='<%# Eval("GununYemegiAd") %>'></asp:Label>
                        <br />
                        <br />
                        &nbsp;<strong>Malzemeler : </strong>
                        <asp:Label ID="Label8" runat="server" Text='<%# Eval("GununYemegiMalzeme") %>'></asp:Label>
                        <br />
                        <br />
                        <strong>Tarif :</strong>
                        <asp:Label ID="Label9" runat="server" Text='<%# Eval("GununYemegiTarif") %>'></asp:Label>
                        <br />
                        <asp:Image ID="Image1" runat="server" Height="180px" ImageUrl="~/Resimler/Mücver.jpg" style="text-align: center" Width="370px" />
                        <br />
                        <strong>Puan :</strong>
                        <asp:Label ID="Label10" runat="server" Text='<%# Eval("GununYemegiPuan") %>'></asp:Label>
                        <br />
                        <strong>&nbsp;Ekleme Tarihi :</strong>
                        <asp:Label ID="Label11" runat="server" Text='<%# Eval("GununYemegiTarihi") %>'></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</p>
</asp:Content>
