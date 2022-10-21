<%@ Page Title="" Language="C#" MasterPageFile="~/YAZOKULU.Master" AutoEventWireup="true" CodeBehind="öğretmentablo.aspx.cs" Inherits="YAZOKULU.öğretmentablo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <table class="table table-bordered table-hover ">
            <tr>
                <th>Öğretmen ID </th>
                <th>Öğretmen Ad Soyad </th>
                <th>Öğretmen Branş </th>
            </tr>

            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>


                        <tr>
                            <td><%#Eval("OGRTID")%></td>
                            <td><%#Eval("OGRTADSOYAD")%></td>
                            <td><%#Eval("OGRTBRANS")%></td>
                           
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </form>



</asp:Content>
