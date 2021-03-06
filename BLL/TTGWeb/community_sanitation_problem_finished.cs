﻿using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using TTG.Model.TTGWeb;
namespace TTG.BLL.TTGWeb
{
	/// <summary>
	/// community_sanitation_problem_finished
	/// </summary>
	public partial class community_sanitation_problem_finished
	{
		private readonly TTG.DAL.TTGWeb.community_sanitation_problem_finished dal=new TTG.DAL.TTGWeb.community_sanitation_problem_finished();
		public community_sanitation_problem_finished()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date,string project_name)
		{
			return dal.Exists(community_id,statistics_date,project_name);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.community_sanitation_problem_finished model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(TTG.Model.TTGWeb.community_sanitation_problem_finished model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string community_id,DateTime statistics_date,string project_name)
		{
			
			return dal.Delete(community_id,statistics_date,project_name);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public TTG.Model.TTGWeb.community_sanitation_problem_finished GetModel(string community_id,DateTime statistics_date,string project_name)
		{
			
			return dal.GetModel(community_id,statistics_date,project_name);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public TTG.Model.TTGWeb.community_sanitation_problem_finished GetModelByCache(string community_id,DateTime statistics_date,string project_name)
		{
			
			string CacheKey = "community_sanitation_problem_finishedModel-" + community_id+statistics_date+project_name;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(community_id,statistics_date,project_name);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (TTG.Model.TTGWeb.community_sanitation_problem_finished)objModel;
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
		public List<TTG.Model.TTGWeb.community_sanitation_problem_finished> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<TTG.Model.TTGWeb.community_sanitation_problem_finished> DataTableToList(DataTable dt)
		{
			List<TTG.Model.TTGWeb.community_sanitation_problem_finished> modelList = new List<TTG.Model.TTGWeb.community_sanitation_problem_finished>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				TTG.Model.TTGWeb.community_sanitation_problem_finished model;
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

