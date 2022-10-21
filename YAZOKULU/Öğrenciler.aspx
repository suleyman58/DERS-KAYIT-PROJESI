 <%@ Page Title="" Language="C#" MasterPageFile="~/YAZOKULU.Master" AutoEventWireup="true" CodeBehind="Öğrenciler.aspx.cs" Inherits="YAZOKULU.Öğrenciler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <form id="form1" runat="server">
        
        <table class="table table-bordered table-hover "> 
            <tr>
                <th>Öğrenci ID </th>
                <th>Öğrenci Ad </th>
                <th>Öğrenci Soyad </th>
                <th>Öğrenci Numara </th>
                <th>Öğrenci Fotoğraf </th>
                <th>Öğrenci Bakiye </th>
                <th>İşlemler </th>
                
            </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        
                    
            <tr>
                <td><%#Eval("ID")%></td>
                <td><%#Eval("AD")%></td>
                <td><%#Eval("SOYAD")%></td>
                <td><%#Eval("NUMARA")%></td>
                <td><%#Eval("FOTOGRAF")%></td>
                <td><%#Eval("BAKIYE")%></td>
                <td>
                            <asp:HyperLink NavigateUrl='<%#"~/öğrencisil.aspx?ID=" + Eval ("ID")%>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#"~/öğrencigüncelle.aspx?ID="+Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-primary">Güncelle</asp:HyperLink>
                </td>
            </tr>
                        </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>

    </form>
    
</asp:Content>
