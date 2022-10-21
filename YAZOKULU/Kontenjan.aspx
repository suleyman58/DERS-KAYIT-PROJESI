<%@ Page Title="" Language="C#" MasterPageFile="~/YAZOKULU.Master" AutoEventWireup="true" CodeBehind="Kontenjan.aspx.cs" Inherits="YAZOKULU.Kontenjan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <table class="table table-bordered table-hover ">
            <tr>
                <th>DERS ID </th>
                <th>DERS AD  </th>
                <th>DERS MİNİMUM KONTENJAN</th>
                <th>DERS MİNİMUM KONTENJAN</th>
            </tr>

            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>


                        <tr>
                            <td><%#Eval("DERSID")%></td>
                            <td><%#Eval("DERSAD ")%></td>
                            <td><%#Eval("DERSMINKONT")%></td>
                           <td><%#Eval("DERSMAXKONT")%></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </form>
</asp:Content>
