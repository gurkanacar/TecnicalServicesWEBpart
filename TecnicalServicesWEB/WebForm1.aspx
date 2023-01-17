<%@ Page Title="" Language="C#" MasterPageFile="~/users.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TecnicalServicesWEB.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Label ID="Label1" runat="server" Text="Product Serial Number : " Font-Bold="True" Font-Italic="False"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" Width="196px"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Search" Width="140px" OnClick="Button1_Click" CssClass="btn btn-primary" />

    <table class="table table-bordered"; style="margin-top : 15px">
        <tr>
            <th>Explanation</th>
            <th>Date</th>
        </tr>
               <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("EXPLANATION")%></td>
                        <td><%# Eval("DATE")%></td>
                    </tr>
            </ItemTemplate>
             </asp:Repeater>
               
    </table>
</asp:Content>
