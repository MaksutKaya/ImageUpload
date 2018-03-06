<%@ Page Title="" Language="C#" MasterPageFile="~/genel.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ImageUpload.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 82px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="auto-style1">

                <asp:Label ID="lblUyari" runat="server" Text="" ForeColor="Red"></asp:Label>

        <tr>
            <td class="auto-style2">
                <asp:Image ID="imgSmall" runat="server" Style="width: 75px; height: 75px;" />
                &nbsp;</td>
            <td>
                <asp:FileUpload ID="flSmallPhoto" runat="server" Width="249px" /></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td style="text-align: left; vertical-align: top; width: 250px;">
                <asp:Button Style="width: 100%" ID="BtnEkle" runat="server" Text="Ekle" OnClick="BtnEkle_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>

    </table>


</asp:Content>
