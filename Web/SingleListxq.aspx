﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Subpage.Master" AutoEventWireup="true"
    CodeBehind="SingleListxq.aspx.cs" Inherits="TTG.Web.SingleListxq" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/indexCss.css" rel="stylesheet" type="text/css" />
    <link href="Css/allinone_thumbnailsBanner.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/jquery.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery-ui.min.js" type="text/javascript"></script>
    <script src="Scripts/allinone_thumbnailsBanner.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="item">
        小区帮扶标准规范
    </div>
    <div class="longline">
    </div>
    <div class="listContent">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>

                <ul>
                    <asp:Repeater ID="RepeaterAidStandard" runat="server" OnItemCommand="RepeaterAidStandard_ItemCommand">
                        <ItemTemplate>
                            <li>
                                <div class="mf20 fl">
                                    <%#trimanno(Eval("file_name").ToString())%>
                                </div>
                                <div class="dow">
                                    <asp:ImageButton ID="ImageButtonForRas" runat="server" ImageUrl="img/download.png"
                                        CommandName="d" CommandArgument='<%#Eval("file_address") %>' />
                                </div>
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>

                <div class="fl tc width100">
                    <webdiyer:AspNetPager ID="AspNetPager1" OnPageChanged="AspNetPager1_PageChanged"
                        CssClass="pages" CurrentPageButtonClass="cpb" PagingButtonSpacing="0" runat="server" HorizontalAlign="Center"
                        RecordCount="2280" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页"
                        SubmitButtonText="前往" TextAfterPageIndexBox="页" TextBeforePageIndexBox="到" SubmitButtonStyle="padding: 0 5px; vertical-align:bottom;border:1px solid  #ddd; ;font-size:14px;color:#000;margin-left:10px;">
                    </webdiyer:AspNetPager>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>

</asp:Content>
