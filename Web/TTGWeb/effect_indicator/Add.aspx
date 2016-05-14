<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="TTG.Web.TTGWeb.effect_indicator.Add" Title="增加页" %>

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
		<asp:TextBox id="txtcommunity_id" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		statistics_date
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtstatistics_date" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		structure_safe_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtstructure_safe_good_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		roof_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtroof_good_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		wall_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtwall_good_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		slope_safe_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtslope_safe_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		concil_house_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtconcil_house_validate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		road_link_degree
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtroad_link_degree" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		road_good_degree
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtroad_good_degree" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		traffic_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttraffic_validate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		water_capcity_degree
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtwater_capcity_degree" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		water_pipe_net_good_degree
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtwater_pipe_net_good_degree" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		one_hou_one_water_meter_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtone_hou_one_water_meter_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		water_supply_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtwater_supply_validate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		elec_capcity_degree
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtelec_capcity_degree" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		elec_wire_safe_degree
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtelec_wire_safe_degree" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		one_hou_one_elec_meter_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtone_hou_one_elec_meter_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		elec_supply_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtelec_supply_validate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		road_light_suff_degree
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtroad_light_suff_degree" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		passway_light_suff_degree
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpassway_light_suff_degree" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		light_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtlight_validate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		outdoors_ff_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtoutdoors_ff_good_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indoors_ff_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindoors_ff_good_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ff_way_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtff_way_good_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ff_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtff_validate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		basic_facility_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtbasic_facility_validate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		refuse_collect_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtrefuse_collect_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		toilet_cover_degree
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttoilet_cover_degree" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sanitation_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsanitation_validate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sewage_collect_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsewage_collect_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		drain_safe_degree
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdrain_safe_degree" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		drain_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdrain_validate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		green_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgreen_validate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		environment_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtenvironment_validate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		service_gfs_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtservice_gfs_good_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		kindergarten_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtkindergarten_good_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		medical_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtmedical_good_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		parking_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtparking_good_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CVS_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCVS_good_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		vegetable_market_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtvegetable_market_good_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		commerce_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommerce_validate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cul_fitness_facility_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcul_fitness_facility_good_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		older_facility_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtolder_facility_good_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		public_service_good_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpublic_service_good_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		shop_front_use_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtshop_front_use_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		shop_front_rent_level
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtshop_front_rent_level" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		shop_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtshop_validate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_validate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_validate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator9
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator9" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator10
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator10" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator11
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator11" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator12
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator12" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator13
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator13" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator14
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator14" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator15
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator15" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator16
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator16" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator17
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator17" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator18
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator18" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator19
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator19" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator20
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator20" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator21
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator21" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator22
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator22" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator23
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator23" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator24
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator24" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator25
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator25" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator26
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator26" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator27
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator27" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator28
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator28" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator29
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator29" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator30
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator30" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator31
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator31" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator32
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator32" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator33
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator33" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator34
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator34" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator35
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator35" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator36
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator36" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator37
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator37" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator38
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator38" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator39
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator39" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator40
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator40" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator41
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator41" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator42
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator42" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator43
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator43" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator44
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator44" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator45
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator45" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		indicator46
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtindicator46" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lock_tables
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtlock_tables" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		labor_employment_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtlabor_employment_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		disposable_money_per_people
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdisposable_money_per_people" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
