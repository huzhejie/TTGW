<%@ Page Title="" Language="C#" MasterPageFile="~/Subpage.Master" AutoEventWireup="true"
    CodeBehind="Announce.aspx.cs" Inherits="TTG.Web.Announce" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/indexCss.css" rel="stylesheet" type="text/css" />   
    <link href="Css/allinone_thumbnailsBanner.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/jquery.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery-ui.min.js" type="text/javascript"></script>
    <script src="Scripts/allinone_thumbnailsBanner.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="anndetail">
        <div style="height: 30px;">
        </div>
        <p style="font-size: 20px; font-weight: bold; text-align: center;" id="ptitle" runat="server">
            湖北省三峡办调研移民小区综合帮扶项目</p>
        <p style="font-size: 15px; text-align: center;" id="ptime" runat="server">
            2015-9-6</p>
        <div class="textcontent" id="divcontent" runat="server">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </div>
   
</asp:Content>
