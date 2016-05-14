using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// community_management_responsible:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class community_management_responsible
	{
		public community_management_responsible()
		{}
		#region Model
		private string _community_address;
		private string _community_id;
		private string _community_manage_charge_person_name;
		private string _community_manage_charge_person_telphone;
		private string _community_monitor_charge_person_name;
		private string _community_monitor_charge_person_telphone;
		private string _community_contacts_telephone;
		private string _community_staff_telephone;
		private string _tcmrunset1;
		private string _tcmrunset2;
		private string _tcmrunset3;
		private string _tcmrunset4;
		private string _tcmrunset5;
		private string _tcmrunset6;
		private string _community_name;
        private string _community_contacts_name;

        public string community_contacts_name
        {
            get { return _community_contacts_name; }
            set { _community_contacts_name = value; }
        }
        private string _community_manage_person_name;

        public string community_manage_person_name
        {
            get { return _community_manage_person_name; }
            set { _community_manage_person_name = value; }
        }
		/// <summary>
		/// 
		/// </summary>
		public string community_address
		{
			set{ _community_address=value;}
			get{return _community_address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string community_id
		{
			set{ _community_id=value;}
			get{return _community_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string community_manage_charge_person_name
		{
			set{ _community_manage_charge_person_name=value;}
			get{return _community_manage_charge_person_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string community_manage_charge_person_telphone
		{
			set{ _community_manage_charge_person_telphone=value;}
			get{return _community_manage_charge_person_telphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string community_monitor_charge_person_name
		{
			set{ _community_monitor_charge_person_name=value;}
			get{return _community_monitor_charge_person_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string community_monitor_charge_person_telphone
		{
			set{ _community_monitor_charge_person_telphone=value;}
			get{return _community_monitor_charge_person_telphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string community_contacts_telephone
		{
			set{ _community_contacts_telephone=value;}
			get{return _community_contacts_telephone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string community_staff_telephone
		{
			set{ _community_staff_telephone=value;}
			get{return _community_staff_telephone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcmrunset1
		{
			set{ _tcmrunset1=value;}
			get{return _tcmrunset1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcmrunset2
		{
			set{ _tcmrunset2=value;}
			get{return _tcmrunset2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcmrunset3
		{
			set{ _tcmrunset3=value;}
			get{return _tcmrunset3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcmrunset4
		{
			set{ _tcmrunset4=value;}
			get{return _tcmrunset4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcmrunset5
		{
			set{ _tcmrunset5=value;}
			get{return _tcmrunset5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcmrunset6
		{
			set{ _tcmrunset6=value;}
			get{return _tcmrunset6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string community_name
		{
			set{ _community_name=value;}
			get{return _community_name;}
		}
		#endregion Model

	}
}

