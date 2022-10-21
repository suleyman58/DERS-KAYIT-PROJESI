<%@ Page Title="" Language="C#" MasterPageFile="~/YAZOKULU.Master" AutoEventWireup="true" CodeBehind="Dersler.aspx.cs" Inherits="YAZOKULU.Dersler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Lütfen ders seçin"></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;
        <asp:DropDownList ID="dropders" runat="server"></asp:DropDownList> &nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Lütfen öğrenci ıd si girin "></asp:Label>  &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtkayitogrid" runat="server" ></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="derskayit" runat="server" Text="KAYIT OLUŞTUR" CssClass="btn btn-group" OnClick="derskayit_Click" />
    </form>
    
</asp:Content>
