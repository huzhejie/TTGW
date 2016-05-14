<%@ Page Title="" Language="C#" MasterPageFile="~/Subpage.Master" AutoEventWireup="true"
    CodeBehind="Announce.aspx.cs" Inherits="TTG.Web.Announce" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="annDetail">
        <p  class="ptitle" id="ptitle" runat="server"></p>
        <p id="ptime" runat="server"></p>
        <div class="textcontent" id="divcontent" runat="server">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </div>
   
</asp:Content>
