<%@ Page Title="" Language="C#" MasterPageFile="~/Manage.Master" AutoEventWireup="true"
    CodeBehind="MutipleAnalysis.aspx.cs" Inherits="TTG.Web.MutipleAnalysis" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/indexCss.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div>
            <select id="selectvalue" onchange="showdiv()">
                <option selected="selected" value="1">未发布数据</option>
                <option value="2">工作报告</option>
                <option value="3">监测日志</option>
            </select>
        </div>
        <div class="examTable" id="helpcontent1" runat="server">
            <div class="examTop fl">

                <img src="Images/wait_to_check_se.png" alt="" />

                <span>未发布数据</span>
                <a href="MutipleHasPublish.aspx" target="_blank">查看已经发布的数据>></a>
            </div>
             <div class="examTop fr">
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                       
                            <asp:TextBox ID="TextBoxCom" runat="server" CssClass="manageInput"
                                placeholder="请输入小区名"></asp:TextBox>
                            <asp:TextBox ID="TextBoxInves" runat="server" CssClass="manageInput" placeholder="请输入调查员"></asp:TextBox>
                            <asp:TextBox ID="TextBoxArea" runat="server" CssClass="manageInput"
                                placeholder="请输入片区负责人"></asp:TextBox>
                            <asp:Button ID="btnQueryRig" runat="server" class="mybtn" Text="查询" onclick="btnQueryRig_Click" />
                        
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <div class="longline fl">
            </div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <table>
                        <thead>
                            <tr>
                                <th>数据表名</th>
                                <th>小区名</th>
                                <th>调查员</th>
                                <th>片区负责人</th>
                                <th>填写时间</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="RepeaterAidInf" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><a href="DataExcel.aspx?officeFile=<%#Eval("excel_name").ToString()%>&comId=<%#Eval("community_id").ToString()%>&invesId=<%#Eval("investigator_id").ToString()%>&time=<%#DateTime.Parse(Eval("fill_time").ToString()).ToString("yyyy")%>" target="_blank">
                                            <%#Eval("excel_name").ToString()%>
                                        </a></td>
                                        <td><%#Eval("community_name").ToString()%></td>
                                        <td><%#toName(Eval("investigator_id").ToString())%></td>
                                        <td><%#toName(Eval("areaChief_id").ToString())%></td>
                                        <td><%#DateTime.Parse(Eval("fill_time").ToString()).ToString("yyyy-MM-dd")%></td>

                                    </tr>

                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>

                    <div class="fl tc width100">
                        <webdiyer:AspNetPager ID="AspNetPager1" CssClass="pages fl" CurrentPageButtonClass="cpb"
                            PagingButtonSpacing="0" runat="server" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页"
                            PrevPageText="上一页" SubmitButtonText="前往" TextAfterPageIndexBox="页" TextBeforePageIndexBox="到"
                            SubmitButtonStyle="padding: 0 5px; vertical-align:bottom;border:1px solid  #ddd; ;font-size:14px;color:#000;margin-left:10px;"
                            OnPageChanged="AspNetPager1_PageChanged" Width="100%" HorizontalAlign="Center">
                        </webdiyer:AspNetPager>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>

        <div class="examTable dn" id="helpcontent2" runat="server">
            <div class="examTop fl">

                <img src="Images/wait_to_check_se.png" alt="" />

                <span>工作报告</span>
            </div>
            <div class="examTop fr">


                <span>上传报告：</span>
                <asp:FileUpload ID="FileUploadBg" runat="server" />
                <span>请添加文件标题：</span>
                <asp:TextBox ID="TextBoxBgTitle" runat="server"></asp:TextBox>
                <asp:Button ID="ButtonBg" runat="server" Text="上传" CssClass="mybtn" OnClick="ButtonBg_Click" />

                <asp:UpdatePanel ID="UpdatePanel4" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                    </ContentTemplate>
                    <Triggers>
                        <asp:PostBackTrigger ControlID="ButtonBg" />
                    </Triggers>
                </asp:UpdatePanel>
            </div>

            <div class="longline fl">
            </div>
            <asp:UpdatePanel ID="UpdatePanel5" runat="server" UpdateMode="Always">
                <ContentTemplate>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <div class="examTable dn" id="helpcontent3" runat="server">
            <div class="examTop fl">

                <img src="Images/wait_to_check_se.png" alt="" />

                <span>监测日志</span>

            </div>
            <div class="longline fl">

            </div>
             <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                <ContentTemplate>
                    <table>
                        <thead>
                            <tr>
                                <th>检测日志</th>
                                <th>调查员</th>
                                <th>调查员ID</th>
                                <th>上传日期</th>
                                
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="RepeaterLog" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><a href="ReadOnlyExcel.aspx?officeFile=<%#Eval("file_path").ToString()%>&dcyId=<%#Eval("investigator_id").ToString()%>" target="_blank">
                                            <%#Eval("file_name").ToString()%>
                                        </a></td>                                      
                                        <td><%#toName(Eval("investigator_id").ToString())%></td>
                                        <td><%#Eval("investigator_id").ToString()%></td>
                                        <td><%#DateTime.Parse(Eval("fill_time").ToString()).ToString("yyyy-MM-dd")%></td>

                                    </tr>

                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>

                    <div class="fl tc width100">
                        <webdiyer:AspNetPager ID="AspNetPager2" CssClass="pages fl" CurrentPageButtonClass="cpb"
                            PagingButtonSpacing="0" runat="server" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页"
                            PrevPageText="上一页" SubmitButtonText="前往" TextAfterPageIndexBox="页" TextBeforePageIndexBox="到"
                            SubmitButtonStyle="padding: 0 5px; vertical-align:bottom;border:1px solid  #ddd; ;font-size:14px;color:#000;margin-left:10px;"
                            OnPageChanged="AspNetPager2_PageChanged" Width="100%" HorizontalAlign="Center">
                        </webdiyer:AspNetPager>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
    <script type="text/javascript">
        function showdiv() {
            var selectObj = document.getElementById("selectvalue");
            var index = selectObj.selectedIndex;
            var num = selectObj.options[index].value - 0;

            if (num == 1) {
                document.getElementById("<%=helpcontent1.ClientID %>").style.display = "block";
                document.getElementById("<%=helpcontent2.ClientID %>").style.display = "none";
                document.getElementById("<%=helpcontent3.ClientID %>").style.display = "none";

            } else if (num == 2) {
                document.getElementById("<%=helpcontent1.ClientID %>").style.display = "none";
                document.getElementById("<%=helpcontent2.ClientID %>").style.display = "block";
                document.getElementById("<%=helpcontent3.ClientID %>").style.display = "none";

            } else if (num == 3) {
                document.getElementById("<%=helpcontent1.ClientID %>").style.display = "none";
                document.getElementById("<%=helpcontent2.ClientID %>").style.display = "none";
                document.getElementById("<%=helpcontent3.ClientID %>").style.display = "block";

            }
}

function showdiv2() {
    var selectObj = document.getElementById("selectvalue");
    selectObj.selectedIndex = 1;
    document.getElementById("<%=helpcontent1.ClientID %>").style.display = "none";
    document.getElementById("<%=helpcontent2.ClientID %>").style.display = "block";
    document.getElementById("<%=helpcontent3.ClientID %>").style.display = "none";

}
    </script>
</asp:Content>
