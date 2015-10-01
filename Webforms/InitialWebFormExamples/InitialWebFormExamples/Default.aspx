<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Default.aspx.cs" 
    Inherits="InitialWebFormExamples.Default"
    ValidateRequest="false" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <!-- 
    -->
    <form id="form1" runat="server" defaultbutton="SayHelloButton">
    <div>
        <span class="auto-style1">SEM5640 - First Web Form</span><br />
        <!-- 
            This example all shows a Validation Summary. This will pick up messages from 
            Validation controls on the same page. You can use this to group messages 
            together. 
        -->
        <asp:ValidationSummary ID="ValidationSummaryMessages" runat="server" />
        <div>
        Enter a name:
        <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="SayHelloButton" OnClick="SayHelloButton_Version2_Click" runat="server" Text="Button" />

        <!-- 
            The following control was added in the third version, which is trying to show 
            validation messages if there is nothing in the text. You will also need 
            to add the ValidationSettings:UnobtrusiveValidationMode key into the WebConfig
            so that you can avoid an error message. 
        -->
        <asp:RequiredFieldValidator ID="RequiredNameValidator" runat="server" ErrorMessage="Summary message about the name" ControlToValidate="NameTextBox" ForeColor="Red">* Please enter a name</asp:RequiredFieldValidator>
        </div>
        <asp:Label ID="HelloLabel" runat="server" Text="Label" Visible="false"></asp:Label>

        <!--
            The following control was added to show the World image. By default, it is set 
            to  
        -->
        <asp:Image ID="WorldImage" runat="server" Visible="false" ImageUrl="~/World_Image_1.png" />
        <asp:HyperLink ID="IsbnLink" runat="server">Isbn Link</asp:HyperLink>
    </div>
    </form>
</body>
</html>
