<%@ Page MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Professional.aspx.cs" Inherits="FirstWebForm.Professional" %>

<asp:Content ContentPlaceHolderID="Pages" runat="server">
    <h2>This is a content page</h2>
    <p>&nbsp;</p>
    <p><strong>Add New Employee</strong></p>
    <form runat="server">
        <p>
            <asp:TextBox ID="txtName"  runat="server" Width="190px" placeholder="Enter your name"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtDesign" runat="server" Width="187px" placeholder="Enter your Designation"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtSalary" runat="server" Width="186px" placeholder="Enter your Salary" TextMode="Number"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Employee" />
        </p>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    <hr />
    <h3>Databinding with Database</h3>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="EmpID" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" AllowSorting="True">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
            <asp:BoundField DataField="EmpID" HeaderText="EmpID" ReadOnly="True" SortExpression="EmpID" InsertVisible="False" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Designation" HeaderText="Designation" SortExpression="Designation" />
            <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:kpmgDbConnectionString %>" 
        SelectCommand="SELECT * FROM [Employees]" 
        DeleteCommand="DELETE FROM [Employees] WHERE [EmpID] = @EmpID" 
        InsertCommand="INSERT INTO [Employees] ([Name], [Designation], [Salary]) VALUES (@Name, @Designation, @Salary)"
        UpdateCommand="UPDATE [Employees] SET [Name] = @Name, [Designation] = @Designation, [Salary] = @Salary WHERE [EmpID] = @EmpID">
        <DeleteParameters>
            <asp:Parameter Name="EmpID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Designation" Type="String" />
            <asp:Parameter Name="Salary" Type="Double" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Designation" Type="String" />
            <asp:Parameter Name="Salary" Type="Double" />
            <asp:Parameter Name="EmpID" Type="Int32" />
        </UpdateParameters>
        </asp:SqlDataSource>
        </form>
</asp:Content>
