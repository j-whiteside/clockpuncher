<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="landlorder2.Employees" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Employees</h1>
    <a href="Employee.aspx">Add New Employee</a>
    <asp:GridView ID="GrdEmployee" runat="server" AutoGenerateColumns="false" OnRowDeleting="GrdEmployee_RowDeleting" DataKeyNames="Id" OnRowDataBound="GrdEmployee_RowDataBound">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="ID" />
            <asp:BoundField DataField="Username" HeaderText="Username" />
            <asp:BoundField DataField="Email" HeaderText="Name" />
            <asp:BoundField DataField="hourlyWage" HeaderText="Hourly Wage" />
<asp:HyperLinkField HeaderText="Edit" ControlStyle-CssClass="table table-striped" NavigateUrl="Employee.aspx" Text="Edit" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="Employee.aspx?Id={0}" />
            <asp:CommandField DeleteText="Delete" ShowDeleteButton="true" HeaderText="Delete" />
        </Columns>
    </asp:GridView>

</asp:Content>
