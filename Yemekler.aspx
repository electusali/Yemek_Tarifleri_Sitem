<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yemekler.aspx.cs" Inherits="Yemek_Tarifleri_Sitem2.Yemekler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
        text-align: right;
    }
        .auto-style5 {
            width: 119px;
        }
        .auto-style6 {
            font-weight: bold;
            font-size: x-large;
        }
        .auto-style7 {
            width: 35px;
        }
        .auto-style8 {
            width: 44px;
        }
        .auto-style9 {
            background-color: #FFFF66;
        }
        .auto-style10 {
            width: 44px;
            background-color: #FFFF66;
        }
        .auto-style11 {
            width: 35px;
            background-color: #FFFF66;
        }
        .auto-style12 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" style="background-color: #FFFF66">
        <table class="auto-style1">
            <tr>
                <td class="auto-style7">
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style6" Height="30px" Text="+" Width="30px" OnClick="Button1_Click" />
                </td>
                <td class="auto-style8">
                    <asp:Button ID="Button2" runat="server" CssClass="auto-style6" Height="30px"  Text="-" Width="30px" OnClick="Button2_Click" />
                </td>
                <strong>
                <td><strong>YEMEK LİSTESİ</strong></td>
                </strong>
            </tr>
        </table>
        </strong></asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        <asp:DataList ID="DataList1" runat="server" Width="450px">
            <ItemTemplate>
                <table class="auto-style1">
                    <tr>
                        <td style="text-align: left" class="auto-style5">
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("YemekAd") %>' style="text-align: left"></asp:Label>
                        </td>
                        <td class="auto-style4">
                          <a href="Kategoriler.aspx?Kategoriid=<%#Eval("kategoriid") %>&islem=sil"> <asp:Image ID="Image2" runat="server" Height="30px" ImageUrl="~/iconlar/delete.png" Width="30px" /></a> 
                        </td>
                        <td class="auto-style4">
                        <a href="KategoriAdminDetay.aspx?Kategoriid=<%#Eval("kategoriid") %>">  <asp:Image ID="Image3" runat="server" Height="30px" ImageUrl="~/iconlar/updated.png" Width="30px" /></a>  
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
</asp:Panel>
    <asp:Panel ID="Panel3" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style11">
                    <asp:Button ID="Button3" runat="server" CssClass="auto-style6" Height="30px"  Text="+" Width="30px" OnClick="Button3_Click"/>
                </td>
                <td class="auto-style10">
                    <asp:Button ID="Button4" runat="server" CssClass="auto-style6" Height="30px"  Text="-" Width="30px" OnClick="Button4_Click" />
                </td>
                <strong>
                <td class="auto-style9"><strong>YEMEK EKLEME</strong></td>
                </strong>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel4" runat="server">
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>YEMEK AD :</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="230px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>MALZEMELER: </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Height="100px" TextMode="MultiLine" Width="230px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>YEMEK TARİFİ :</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Height="130px" TextMode="MultiLine" Width="230px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>KATEGORİ :</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="250px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style12">
                    <asp:Button ID="btnEkle" runat="server" CssClass="Buton" Font-Bold="True" Font-Size="Medium" Height="40px" OnClick="btnEkle_Click" Text="EKLE" Width="150px" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>  