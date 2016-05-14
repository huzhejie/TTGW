<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.effect_indicator.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		community_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		statistics_date
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstatistics_date" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		structure_safe_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstructure_safe_good_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		roof_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblroof_good_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		wall_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblwall_good_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		slope_safe_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblslope_safe_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		concil_house_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblconcil_house_validate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		road_link_degree
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblroad_link_degree" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		road_good_degree
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblroad_good_degree" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		traffic_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltraffic_validate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		water_capcity_degree
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblwater_capcity_degree" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		water_pipe_net_good_degree
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblwater_pipe_net_good_degree" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		one_hou_one_water_meter_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblone_hou_one_water_meter_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		water_supply_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblwater_supply_validate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		elec_capcity_degree
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblelec_capcity_degree" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		elec_wire_safe_degree
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblelec_wire_safe_degree" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		one_hou_one_elec_meter_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblone_hou_one_elec_meter_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		elec_supply_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblelec_supply_validate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		road_light_suff_degree
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblroad_light_suff_degree" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		passway_light_suff_degree
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpassway_light_suff_degree" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		light_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllight_validate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		outdoors_ff_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbloutdoors_ff_good_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indoors_ff_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindoors_ff_good_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ff_way_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblff_way_good_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ff_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblff_validate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		basic_facility_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbasic_facility_validate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		refuse_collect_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblrefuse_collect_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		toilet_cover_degree
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltoilet_cover_degree" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sanitation_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsanitation_validate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sewage_collect_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsewage_collect_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		drain_safe_degree
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldrain_safe_degree" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		drain_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldrain_validate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		green_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblgreen_validate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		environment_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblenvironment_validate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		service_gfs_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblservice_gfs_good_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		kindergarten_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblkindergarten_good_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		medical_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblmedical_good_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		parking_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblparking_good_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CVS_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCVS_good_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		vegetable_market_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblvegetable_market_good_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		commerce_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommerce_validate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cul_fitness_facility_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcul_fitness_facility_good_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		older_facility_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblolder_facility_good_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		public_service_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpublic_service_good_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		shop_front_use_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblshop_front_use_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		shop_front_rent_level
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblshop_front_rent_level" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		shop_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblshop_validate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_validate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator10" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator11
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator11" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator12
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator12" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator13
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator13" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator14
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator14" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator15
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator15" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator16
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator16" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator17
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator17" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator18
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator18" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator19
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator19" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator20
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator20" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator21
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator21" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator22
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator22" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator23
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator23" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator24
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator24" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator25
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator25" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator26
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator26" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator27
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator27" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator28
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator28" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator29
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator29" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator30
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator30" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator31
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator31" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator32
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator32" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator33
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator33" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator34
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator34" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator35
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator35" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator36
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator36" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator37
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator37" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator38
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator38" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator39
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator39" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator40
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator40" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator41
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator41" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator42
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator42" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator43
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator43" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator44
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator44" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator45
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator45" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator46
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblindicator46" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lock_tables
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllock_tables" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		labor_employment_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllabor_employment_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		disposable_money_per_people
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldisposable_money_per_people" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




