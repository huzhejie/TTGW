using System;

namespace TTG.Model.TTGWeb
{
    /// <summary>
    /// excel_special_structure:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class grand_investment_case
    {
        public grand_investment_case()
        { }
        #region Model
        private string _grand_project_id;
        private float _month_total_investment;

        public float month_total_investment
        {
            get { return _month_total_investment; }
            set { _month_total_investment = value; }
        }
        private float _month_special_fonds;

        public float month_special_fonds
        {
            get { return _month_special_fonds; }
            set { _month_special_fonds = value; }
        }
        private float _month_conterpart_fonds;

        public float month_conterpart_fonds
        {
            get { return _month_conterpart_fonds; }
            set { _month_conterpart_fonds = value; }
        }
        private float _month_other_matching_fonds;

        public float month_other_matching_fonds
        {
            get { return _month_other_matching_fonds; }
            set { _month_other_matching_fonds = value; }
        }
        private int _month;

        public int month
        {
            get { return _month; }
            set { _month = value; }
        }
        private int _year;

        public int year
        {
            get { return _year; }
            set { _year = value; }
        }
        private float _month_other_fonds;

        public float month_other_fonds
        {
            get { return _month_other_fonds; }
            set { _month_other_fonds = value; }
        }
        public string grand_project_id
        {
            get { return _grand_project_id; }
            set { _grand_project_id = value; }
        }
        #endregion Model
    }
}
