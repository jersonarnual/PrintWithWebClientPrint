<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PrintWithWebClientPrint._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row">

        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Imprimir" />

    </div>

</asp:Content>
