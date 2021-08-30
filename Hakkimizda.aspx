<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Hakkimizda.aspx.cs" Inherits="Yemek_Tarifleri_Sitem2.Hakkimizda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style4" style="font-weight: 700; font-style: italic">
        HAKKIMIZDA</p>
    <p style="text-align: center; font-weight: 700; font-style: italic">
        <asp:DataList ID="DataList2" runat="server" Width="448px" style="text-align: left">
            <ItemTemplate>
                <asp:Label ID="Label3" runat="server" Text='<%# Eval("Metin") %>'></asp:Label>
            </ItemTemplate>
        </asp:DataList>
        <asp:Image ID="Image1" runat="server" Height="138px" ImageUrl="~/Resimler/Ekran.png" Width="381px" />
    </p>
</asp:Content>
