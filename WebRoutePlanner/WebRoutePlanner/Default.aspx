<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="WebRoutePlanner._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            text-align: center;
        }
        .style3
        {
            width: 452px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2 style="text-align: center">
        Route Planner! - Find 
        the shortest route from a to b.</h2>
    <p style="text-align: center">
        &nbsp;</p>
    <table class="style1">
        <tr>
            <td style="text-align: right">
                Start:</td>
            <td class="style3">
                <asp:DropDownList ID="drp_dwn_start" runat="server" AutoPostBack="True" 
                    Height="20px" Width="232px" onselectedindexchanged="clearTextBox">
                </asp:DropDownList>
            </td>
            <td style="text-align: right">
                Destination:
            </td>
            <td>
                <asp:DropDownList ID="drp_dwn_destination" runat="server" AutoPostBack="True" 
                    Height="20px" Width="232px" onselectedindexchanged="clearTextBox">
                </asp:DropDownList>
                <asp:CustomValidator ID="validator_same" runat="server" 
                    ControlToValidate="drp_dwn_destination" 
                    ErrorMessage="Error, Stations cannot be the same!" 
                    onservervalidate="validator_same_ServerValidate" 
                    ToolTip="Stations must be different!">*</asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" colspan="4">
                <asp:Button ID="routes_btn" runat="server" Height="35px" 
                    onclick="routes_btn_Click" style="text-align: left; margin-left: 0px" 
                    Text="Find Routes!" Width="93px" />
                <asp:ValidationSummary ID="Error_empty" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="style2" colspan="4">
                <asp:TextBox ID="txt_box_journey" runat="server" Height="329px" ReadOnly="True" 
                    TextMode="MultiLine" Width="923px"></asp:TextBox>
                <br />
            </td>
        </tr>
    </table>
</asp:Content>
