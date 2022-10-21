<%@ Page Title="" Language="C#" MasterPageFile="~/SİTEANASAYFA.Master" AutoEventWireup="true" CodeBehind="SİTEkayit.aspx.cs" Inherits="YAZOKULU.SİTEkayit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    
    <form id="form1" runat="server">

        <asp:Label ID="Label1" runat="server" Text="Yönetici numarası : "></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="txtyntcno2" runat="server"></asp:TextBox> 
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Yönetici şifresi : "></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="txtyntcsifre2" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br /> 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="YÖNETİCİ KAYIT OL " CssClass="btn btn-primary" OnClick="Button1_Click" />



    </form>

</asp:Content>
