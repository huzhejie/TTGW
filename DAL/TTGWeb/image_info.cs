using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:image_info
	/// </summary>
	public partial class image_info
	{
		public image_info()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string image_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_image_info");
			strSql.Append(" where image_id=@image_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@image_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = image_id;
			parameters[1].Value = statistics_date;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.image_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_image_info(");
			strSql.Append("image_name,image_address,community_id,image_type,statistics_date,nf_id)");
			strSql.Append(" values (");
			strSql.Append("@image_name,@image_address,@community_id,@image_type,GETDATE(),@nf_id)");
			SqlParameter[] parameters = {
					new SqlParameter("@image_id", SqlDbType.VarChar,20),
					new SqlParameter("@image_name", SqlDbType.VarChar,50),
					new SqlParameter("@image_address", SqlDbType.VarChar,200),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@image_type", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@nf_id", SqlDbType.VarChar,20)};
			parameters[0].Value = model.image_id;
			parameters[1].Value = model.image_name;
			parameters[2].Value = model.image_address;
			parameters[3].Value = model.community_id;
			parameters[4].Value = model.image_type;
			parameters[5].Value = model.statistics_date;
			parameters[6].Value = model.nf_id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(TTG.Model.TTGWeb.image_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_image_info set ");
			strSql.Append("image_name=@image_name,");
			strSql.Append("image_address=@image_address,");
			strSql.Append("community_id=@community_id,");
			strSql.Append("image_type=@image_type,");
			strSql.Append("nf_id=@nf_id");
			strSql.Append(" where image_id=@image_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@image_name", SqlDbType.VarChar,50),
					new SqlParameter("@image_address", SqlDbType.VarChar,200),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@image_type", SqlDbType.VarChar,20),
					new SqlParameter("@nf_id", SqlDbType.VarChar,20),
					new SqlParameter("@image_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.image_name;
			parameters[1].Value = model.image_address;
			parameters[2].Value = model.community_id;
			parameters[3].Value = model.image_type;
			parameters[4].Value = model.nf_id;
			parameters[5].Value = model.image_id;
			parameters[6].Value = model.statistics_date;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string image_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_image_info ");
			strSql.Append(" where image_id=@image_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@image_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = image_id;
			parameters[1].Value = statistics_date;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public TTG.Model.TTGWeb.image_info GetModel(string image_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 image_id,image_name,image_address,community_id,image_type,statistics_date,nf_id from T_image_info ");
			strSql.Append(" where image_id=@image_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@image_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = image_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.image_info model=new TTG.Model.TTGWeb.image_info();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public TTG.Model.TTGWeb.image_info DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.image_info model=new TTG.Model.TTGWeb.image_info();
			if (row != null)
			{
				if(row["image_id"]!=null)
				{
					model.image_id=Convert.ToInt32(row["image_id"]);
				}
				if(row["image_name"]!=null)
				{
					model.image_name=row["image_name"].ToString();
				}
				if(row["image_address"]!=null)
				{
					model.image_address=row["image_address"].ToString();
				}
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["image_type"]!=null)
				{
					model.image_type=row["image_type"].ToString();
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["nf_id"]!=null)
				{
                    model.nf_id = Convert.ToInt32(row["nf_id"]);
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select image_id,image_name,image_address,community_id,image_type,statistics_date,nf_id ");
			strSql.Append(" FROM T_image_info ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" image_id,image_name,image_address,community_id,image_type,statistics_date,nf_id ");
			strSql.Append(" FROM T_image_info ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM T_image_info ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.statistics_date desc");
			}
			strSql.Append(")AS Row, T.*  from T_image_info T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "T_image_info";
			parameters[1].Value = "statistics_date";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod
        /// <summary>
        /// 得到首页图片
        /// </summary>
        /// <param name="image_id"></param>
        /// <param name="statistics_date"></param>
        /// <returns></returns>
        public DataSet getFitstImg(string community_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 image_address from T_image_info");
            strSql.Append(" where community_id=@community_id order by statistics_date desc");
            SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20)
                                        };
            parameters[0].Value = community_id;       
            return DbHelperSQL.Query(strSql.ToString(), parameters);
        }
        //临时插入数据用，可删除
        //public DataSet Existsssss()
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("select distinct community_id from T_Community_Base");
            
        //    return DbHelperSQL.Query(strSql.ToString());
        //}
        //public int insertSpecial() {
        //    DataSet ds = Existsssss();
        //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //    {
        //        StringBuilder strSql = new StringBuilder();
        //        strSql.Append("insert into T_image_info(");
        //        strSql.Append("image_name,image_address,community_id,image_type,statistics_date)");
        //        strSql.Append(" values (");
        //        strSql.Append("@image_name,@image_address,@community_id,@image_type,GETDATE())");
        //        SqlParameter[] parameters = {
        //            new SqlParameter("@image_id", SqlDbType.VarChar,20),
        //            new SqlParameter("@image_name", SqlDbType.VarChar,50),
        //            new SqlParameter("@image_address", SqlDbType.VarChar,200),
        //            new SqlParameter("@community_id", SqlDbType.VarChar,20),
        //            new SqlParameter("@image_type", SqlDbType.VarChar,20),
        //            new SqlParameter("@statistics_date", SqlDbType.Date,3)
        //            };
        //        parameters[0].Value = "";
        //        parameters[1].Value = "DEFAULT";
        //        parameters[2].Value = "DEFAULT.png";
        //        parameters[3].Value = ds.Tables[0].Rows[i][0].ToString();
        //        parameters[4].Value = "png";
        //        parameters[5].Value = DateTime.Now;


        //        int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
               
        //    }
        //    return 1;
        //}
		#endregion  ExtensionMethod
	}
}

