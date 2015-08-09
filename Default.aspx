<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="landlorder2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <h1>Welcome to the punch clock app!</h1>

    <asp:PlaceHolder ID="PublicMessage" runat="server"><h2>Please sign in to access all the features.</h2></asp:PlaceHolder>
    <asp:PlaceHolder ID="PrivateMessage" runat="server"><p>Thank you for signing in.  Please enjoy the site.</p></asp:PlaceHolder>
    

</asp:Content>
