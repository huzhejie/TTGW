using System;
namespace TTG.Model.TTGWeb
{
    /// <summary>
    /// notification_info:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class notification_info
    {
        public notification_info()
        { }
        #region Model
        private int _nf_id;
        private string _nf_title;
        private string _nf_content;
        private DateTime? _nf_time;
        private string _nf_depart;
        private string _nf_type;
        private int? _nf_image;
        /// <summary>
        /// 
        /// </summary>
        public int nf_id
        {
            set { _nf_id = value; }
            get { return _nf_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string nf_title
        {
            set { _nf_title = value; }
            get { return _nf_title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string nf_content
        {
            set { _nf_content = value; }
            get { return _nf_content; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? nf_time
        {
            set { _nf_time = value; }
            get { return _nf_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string nf_depart
        {
            set { _nf_depart = value; }
            get { return _nf_depart; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string nf_type
        {
            set { _nf_type = value; }
            get { return _nf_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? nf_image
        {
            set { _nf_image = value; }
            get { return _nf_image; }
        }
        #endregion Model

    }
}

