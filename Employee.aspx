<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="landlorder2.Employee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Employee Details</h1>
    <div class="form-group">
        <label for="UserName" class="col-sm-3">Username: </label>
        <asp:TextBox ID="UserName" runat="server" required="true" />
        <asp:RequiredFieldValidator ID="UsernameFieldValidator" runat="server" ErrorMessage="You need a username." ControlToValidate="UserName" Display="Dynamic"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
        <label for="EmailAddress" class="col-sm-3">Email address: </label>
        <asp:TextBox ID="EmailAddress" runat="server" required="true" />
        <asp:RequiredFieldValidator ID="EmailFieldValidator" runat="server" ErrorMessage="You need an email address." ControlToValidate="EmailAddress" Display="Dynamic"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
        <label for="HourlyWage" class="col-sm-3">Hourly wage: </label>
        <asp:TextBox ID="HourlyWage" runat="server" required="true" />
        <asp:RequiredFieldValidator ID="HourlyWageFieldValidator" runat="server" ErrorMessage="You need an hourly wage." ControlToValidate="HourlyWage" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="HourlyWageRangeValidator" runat="server" ErrorMessage="Your hourly wage must be greater than 11 and less than 100." ControlToValidate="HourlyWage" Display="Dynamic" MaximumValue="99" MinimumValue="11" Type="Integer"></asp:RangeValidator>
    </div>
    <div class="form-group">
        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" CssClass="btn btn-primary" />
    </div>
</asp:Content>
