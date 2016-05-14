using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using TTG.Model.TTGWeb;
namespace TTG.BLL.TTGWeb
{
	/// <summary>
	/// excel_message
	/// </summary>
	public partial class excel_message
	{
		private readonly TTG.DAL.TTGWeb.excel_message dal=new TTG.DAL.TTGWeb.excel_message();
		public excel_message()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int table_id)
		{
			return dal.Exists(table_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(TTG.Model.TTGWeb.excel_message model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(TTG.Model.TTGWeb.excel_message model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int table_id)
		{
			
			return dal.Delete(table_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string table_idlist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(table_idlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public TTG.Model.TTGWeb.excel_message GetModel(int table_id)
		{
			
			return dal.GetModel(table_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public TTG.Model.TTGWeb.excel_message GetModelByCache(int table_id)
		{
			
			string CacheKey = "excel_messageModel-" + table_id;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(table_id);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (TTG.Model.TTGWeb.excel_message)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<TTG.Model.TTGWeb.excel_message> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<TTG.Model.TTGWeb.excel_message> DataTableToList(DataTable dt)
		{
			List<TTG.Model.TTGWeb.excel_message> modelList = new List<TTG.Model.TTGWeb.excel_message>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				TTG.Model.TTGWeb.excel_message model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

