<%@ Page Title="" Language="C#" MasterPageFile="~/YAZOKULU.Master" AutoEventWireup="true" CodeBehind="öğrencikayıt.aspx.cs" Inherits="YAZOKULU.öğrencikayıt" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">
      <div>
        <strong>
        <asp:Label ID="label1" runat="server" Text="ÖĞRENCİ ADI"></asp:Label>
        </strong>
        <br />
        <asp:TextBox ID="txtograd" runat="server" CssClass="form-control" ></asp:TextBox>
      </div>
      <div>
        <strong>
        <asp:Label ID="label2" runat="server" Text="ÖĞRENCİ SOYADI"></asp:Label>
        </strong>
        <br />
        <asp:TextBox ID="txtogrsoyad" runat="server" CssClass="form-control" ></asp:TextBox>
       </div>
        <div>
        <strong>
        <asp:Label ID="label3" runat="server" Text="ÖĞRENCİ NUMARASI"></asp:Label>
        </strong>
        <br />
        <asp:TextBox ID="txtogrno" runat="server" CssClass="form-control" ></asp:TextBox>
       </div>
        <div>
        <strong>
        <asp:Label ID="label4" runat="server" Text="ÖĞRENCİ FOTOĞRAF LİNKİ"></asp:Label>
        </strong>
        <br />
        <asp:TextBox ID="txtogrfoto" runat="server" CssClass="form-control" ></asp:TextBox>
       </div>
        <div>
        <strong>
        <asp:Label ID="label6" runat="server" Text="ÖĞRENCİ BAKİYE"></asp:Label>
        </strong>
        <br />
        <asp:TextBox ID="txtogrbakiye" runat="server" CssClass="form-control" ></asp:TextBox>
       </div>
        <asp:Button ID="btn_kayit" runat="server" Text="KAYIT OL" CssClass="btn-info" OnClick="btn_kayit_Click" />

    </form>

</asp:Content>
