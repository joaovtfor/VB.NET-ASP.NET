<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="CRUD_ASP_Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="box" style="background-color:blue; font-size:xx-large; color:white;" align="center">
        CRUD Operation in Aps.Net VB
    </div>
    <br />
    <div style="padding:15px;">

        <table class="nav-justified">
            <tr>
                <td style="height: 21px">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" Text="Product ID"></asp:Label>
                </td>
                <td style="height: 21px">
                    <asp:TextBox ID="txtProductID" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                &nbsp;&nbsp;
                    <asp:Button ID="Button4" runat="server" BackColor="#3333FF" ForeColor="White" Height="36px" Text="Search" Width="72px" OnClientClick="return confirm('Are you sure to delete?')" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" Text="Item Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtItemName" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Medium" Text="Specification"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSpecification" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Medium" Text="Unit"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="dropUnit" runat="server" Font-Size="Medium" Width="200px">
                        <asp:ListItem>KG</asp:ListItem>
                        <asp:ListItem>PCS</asp:ListItem>
                        <asp:ListItem>DZN</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Medium" Text="Color"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="radioColor" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>RED</asp:ListItem>
                        <asp:ListItem>GREEN</asp:ListItem>
                        <asp:ListItem>BLACK</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Medium" Text="Insert Date"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDate" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Medium" Text="Opening Quantity"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtOpeningQty" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="Medium" Text="Product Status"></asp:Label>
                </td>
                <td>
                    <asp:CheckBox ID="checkRegular" runat="server" Text="Regular" />
                    <asp:CheckBox ID="checkIrregular" runat="server" Text="Irregular" />
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" BackColor="#3333FF" ForeColor="White" Height="36px" Text="Insert" Width="72px" />
                &nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" BackColor="#3333FF" ForeColor="White" Height="36px" Text="Update" Width="72px" />
                &nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" BackColor="#3333FF" ForeColor="White" Height="36px" Text="Delete" Width="72px" OnClientClick="return confirm('Are you sure to delete?')" />
                </td>
            </tr>
        </table>
        <div align="center">

            <hr />

            <asp:GridView ID="GridView1" runat="server" BackColor="#3333FF" ForeColor="White" Width="80%">
            </asp:GridView>

        </div>
    </div>

</asp:Content>