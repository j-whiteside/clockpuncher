<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tracker.aspx.cs" Inherits="landlorder2.Tracker" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label><br />




    <asp:Button ID="Button1" runat="server" Text="Clock in" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="Clock out" Visible="false" OnClick="Button2_Click" />
</asp:Content>
