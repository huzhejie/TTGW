﻿using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using TTG.Model.TTGWeb;
namespace TTG.BLL.TTGWeb
{
	/// <summary>
	/// project_progress
	/// </summary>
	public partial class project_progress
	{
		private readonly TTG.DAL.TTGWeb.project_progress dal=new TTG.DAL.TTGWeb.project_progress();
		public project_progress()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string project_id,DateTime time)
		{
			return dal.Exists(project_id,time);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.project_progress model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(TTG.Model.TTGWeb.project_progress model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string project_id,DateTime time)
		{
			
			return dal.Delete(project_id,time);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public TTG.Model.TTGWeb.project_progress GetModel(string project_id,DateTime time)
		{
			
			return dal.GetModel(project_id,time);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public TTG.Model.TTGWeb.project_progress GetModelByCache(string project_id,DateTime time)
		{
			
			string CacheKey = "project_progressModel-" + project_id+time;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(project_id,time);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (TTG.Model.TTGWeb.project_progress)objModel;
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
		public List<TTG.Model.TTGWeb.project_progress> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<TTG.Model.TTGWeb.project_progress> DataTableToList(DataTable dt)
		{
			List<TTG.Model.TTGWeb.project_progress> modelList = new List<TTG.Model.TTGWeb.project_progress>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				TTG.Model.TTGWeb.project_progress model;
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

