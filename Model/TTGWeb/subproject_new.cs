using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// subproject_new:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class subproject_new
	{
		public subproject_new()
		{}
		#region Model
		private string _subproject_id;
		private string _subproject_name;
        private string _involve_community;
        private string _project_id;

        public string project_id
        {
            get { return _project_id; }
            set { _project_id = value; }
        }

        public string involve_community
        {
            get { return _involve_community; }
            set { _involve_community = value; }
        }
        private string _project_owner;

        public string project_owner
        {
            get { return _project_owner; }
            set { _project_owner = value; }
        }
        private string _main_construct_content;

        public string main_construct_content
        {
            get { return _main_construct_content; }
            set { _main_construct_content = value; }
        }
        private string _start_date;

        public string start_date
        {
            get { return _start_date; }
            set { _start_date = value; }
        }
        private string _finish_date;

        public string finish_date
        {
            get { return _finish_date; }
            set { _finish_date = value; }
        }
        private string _project_community_description;

        public string project_community_description
        {
            get { return _project_community_description; }
            set { _project_community_description = value; }
        }
        private string _radial_project;

        public string radial_project
        {
            get { return _radial_project; }
            set { _radial_project = value; }
        }
		private DateTime _fill_time;
		/// <summary>
		/// 
		/// </summary>
		public string subproject_id
		{
			set{ _subproject_id=value;}
			get{return _subproject_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string subproject_name
		{
			set{ _subproject_name=value;}
			get{return _subproject_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime fill_time
		{
			set{ _fill_time=value;}
			get{return _fill_time;}
		}
		#endregion Model

	}
}

