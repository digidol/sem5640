<%@ Page Title="Second Page" 
    Language="C#" 
    MasterPageFile="~/SiteMaster.Master" 
    ValidateRequest="false"
    AutoEventWireup="true" 
    CodeBehind="SecondPage.aspx.cs" 
    Inherits="InitialWebFormExamples.SecondPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="IsbnLabel" runat="server" Text="Label"></asp:Label>

</asp:Content>
