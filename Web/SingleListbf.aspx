<%@ Page Title="" Language="C#" MasterPageFile="~/Subpage.Master" AutoEventWireup="true"
    CodeBehind="SingleListbf.aspx.cs" Inherits="TTG.Web.SingleListbf" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/indexCss.css" rel="stylesheet" type="text/css" />
    <link href="Css/allinone_thumbnailsBanner.css" rel="stylesheet" type="text/css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <p class="item">
        综合帮扶信息
    </p>
    <div class="longline">
    </div>
    <div class="listContent">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>

                <ul>
                    <asp:Repeater ID="RepeaterAidInf" runat="server">
                        <ItemTemplate>
                            <li>
                                <div class="fl mf20">
                                    <a href="Announce.aspx?nfid=<%#Eval("nf_id").ToString()%>">
                                        <%#trimanno(Eval("nf_title").ToString())%>
                                    </a>
                                </div>
                                <div class="dow">
                                    <%#DateTime.Parse(Eval("nf_time").ToString()).ToString("yyyy-MM-dd")%>
                                </div>
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>


                <div class="fl tc width100">
                <webdiyer:AspNetPager ID="AspNetPager1" CssClass="pages" CurrentPageButtonClass="cpb"
                    PagingButtonSpacing="0" runat="server" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页"
                    PrevPageText="上一页" SubmitButtonText="前往" TextAfterPageIndexBox="页" TextBeforePageIndexBox="到"
                    SubmitButtonStyle="padding: 0 5px; vertical-align:bottom;border:1px solid  #ddd; ;font-size:14px;color:#000;margin-left:10px;"
                    OnPageChanged="AspNetPager1_PageChanged" HorizontalAlign="Center">
                </webdiyer:AspNetPager>
                    </div>

            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>
