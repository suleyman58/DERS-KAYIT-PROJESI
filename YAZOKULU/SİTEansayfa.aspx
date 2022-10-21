<%@ Page Title="" Language="C#" MasterPageFile="~/SİTEANASAYFA.Master" AutoEventWireup="true" CodeBehind="SİTEansayfa.aspx.cs" Inherits="YAZOKULU.SİTEansayfa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <br />
    <font size="5" color="yellow">ÖĞRENCİ KAYIT PROJESİNE HOŞGELDİNİZ </font>
    <br />
    <br />
    <font size="5" color="red">SİSTEME SADECE YÖNETİCİ GİRİŞİ İLE GİRİŞ YAPILABİLİR.YÖNETİCİ İŞLEMLERİ YAPABİLMEK İÇİN LÜTFEN GİRİŞ YAPIN  </font>
    <br />
    <br />
    <br />

    <form id="form1" runat="server">

        <asp:Label ID="Label1" runat="server" Text="Yönetici numarası : "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="txtyntcno" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Yönetici şifresi : "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="txtyntcsifre" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="GİRİŞ YAP " CssClass="btn btn-primary" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Kayıt ol </asp:LinkButton>


    </form>

</asp:Content>
