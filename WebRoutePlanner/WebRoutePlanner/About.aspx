<%@ Page Title="About Us" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="About.aspx.cs" Inherits="WebRoutePlanner.About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <p>
    Author: Jason Carvalho</p>
<p>
    &nbsp;</p>
<p>
    Route Planner Project - London Underground</p>
This project gives the user the shortest path between two stations for the 
London Underground Subway System.&nbsp; When you have selected two stations, the 
shortest path is given, along with which station should a transfer occur.&nbsp; 
If there is more than one available path, the program compares the amount of 
stops between the paths and if they are equal, it then compares the amount of 
transfers.&nbsp; The output also gives the total amount of stops and the total 
amount of line changes.
</asp:Content>
