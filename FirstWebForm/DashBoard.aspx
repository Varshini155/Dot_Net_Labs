<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="FirstWebForm.DashBoard" %>

<asp:Content ContentPlaceHolderID="Pages" runat="server">
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="View Hobbies" />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="View Cookie Data" />
        <br />
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        <br />
        Manually added Items<br />
        <asp:ListBox ID="ListBox2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox2_SelectedIndexChanged">
            <asp:ListItem Value="1001">Item 1</asp:ListItem>
            <asp:ListItem Value="1002">Item 2</asp:ListItem>
            <asp:ListItem Value="1003">Item 3</asp:ListItem>
        </asp:ListBox>
        <br />
        <asp:Button ID="lblSelected" runat="server" Text="Selected value =" OnClick="lblSelected_Click" />
        <br />
        <br />
        <strong>Working with ViewState and GridView</strong><asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="ViewData" />
        <br />
    </form>
</body>
</asp:Content>
