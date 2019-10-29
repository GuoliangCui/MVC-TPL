//-----------------------------------------------------------------------
// <copyright file="DAL.cs">
// * Copyright (C) 2019 63354261@qq.com
// * version : V 1.0
// * author  : cuiguoliang
// * FileName: DAL.cs
// * history : Created by T4 10/28/2019 15:36:20 
// </copyright>
//-----------------------------------------------------------------------



/// <summary>
/// 全部DAL实体类
/// </summary>
namespace Liang.DAL
{
    using System;
    using System.Collections.Generic;
	using Liang.Models;
	using Liang.Model.Query;
	
	#region ApplyApproveRecord定义
    /// <summary>
    /// ApplyApproveRecord数据访问类
    /// </summary>
	public partial class ApplyApproveRecordDAL : BaseDAL, IDAL<ApplyApproveRecord>
	{ 
		/// <summary>
        /// 插入一个ApplyApproveRecord对象
        /// </summary>
		/// <param name="model">要插入的对象</param>
        public void Insert(ApplyApproveRecord model)
        {
			string sql = "INSERT INTO APPLYAPPROVERECORD (Id,ApplyVehicleId,ReturnVehicleRecordId,UserId,EnterpriseId,ApproveUserName,TripMileage,Cost,VehicleCondition,ApproveTime,Attachments,Content,Status,AddTime,UpdateTime,Dr,Ts) values (@Id,@ApplyVehicleId,@ReturnVehicleRecordId,@UserId,@EnterpriseId,@ApproveUserName,@TripMileage,@Cost,@VehicleCondition,@ApproveTime,@Attachments,@Content,@Status,@AddTime,@UpdateTime,@Dr,@Ts)";
            base.Execute(sql,model);
        }

		/// <summary>
        /// 根据Id删除一个ApplyApproveRecord对象
        /// </summary>
        /// <param name="id">主键Id</param>
		public void Delete(long id)
        {
             string sql = "DELETE FROM USER WHERE ID=@Id";
             base.Execute(sql, new { Id = id });
        }

		/// <summary>
        /// 更新一个ApplyApproveRecord对象
        /// </summary>
		/// <param name="model">要更新的对象</param>
        public void Update(ApplyApproveRecord model)
        {
            string sql = "UPDATE APPLYAPPROVERECORD SET ApplyVehicleId=@ApplyVehicleId,ReturnVehicleRecordId=@ReturnVehicleRecordId,UserId=@UserId,EnterpriseId=@EnterpriseId,ApproveUserName=@ApproveUserName,TripMileage=@TripMileage,Cost=@Cost,VehicleCondition=@VehicleCondition,ApproveTime=@ApproveTime,Attachments=@Attachments,Content=@Content,Status=@Status,AddTime=@AddTime,UpdateTime=@UpdateTime,Dr=@Dr,Ts=@Ts WHERE Id=@Id";
            base.Execute(sql,model);
        }

		/// <summary>
        /// 根据Id获取一个ApplyApproveRecord对象
        /// </summary>
        /// <param name="id">主键Id</param>
		 public ApplyApproveRecord Get(long id)
        {
            string sql = "SELECT * FROM USER WHERE ID=@Id";
            return base.QueryFirstOrDefault<ApplyApproveRecord>(sql, new { Id=id});
        }
		/// <summary>
        /// 根据条件查询ApplyApproveRecord列表
        /// </summary>
        /// <param name="condition">查询条件</param>
        public IList<ApplyApproveRecord> GetList(Condition condition = null)
        {
            string sql = "SELECT * FROM APPLYAPPROVERECORD";
            return base.QueryByCondition<ApplyApproveRecord>(sql, condition);
        }
		/// <summary>
        /// 根据条件分页查询ApplyApproveRecord列表
        /// </summary>
		/// <param name="pageInfo">分页信息(必填)</param>
        /// <param name="condition">查询条件</param>
        public PageData<ApplyApproveRecord> GetList(PageInfo pageInfo, Condition condition = null)
        {
            string sql = "SELECT * FROM APPLYAPPROVERECORD";
            return base.QueryByPageCondition<ApplyApproveRecord>(sql,pageInfo,condition);
        }
	}
	#endregion
	
	#region ApplyRelatedUsers定义
    /// <summary>
    /// ApplyRelatedUsers数据访问类
    /// </summary>
	public partial class ApplyRelatedUsersDAL : BaseDAL, IDAL<ApplyRelatedUsers>
	{ 
		/// <summary>
        /// 插入一个ApplyRelatedUsers对象
        /// </summary>
		/// <param name="model">要插入的对象</param>
        public void Insert(ApplyRelatedUsers model)
        {
			string sql = "INSERT INTO APPLYRELATEDUSERS (Id,EnterpriseId,ApplyVehicleId,UserId,Roles,Status,AddTime,UpdateTime,Dr,Ts) values (@Id,@EnterpriseId,@ApplyVehicleId,@UserId,@Roles,@Status,@AddTime,@UpdateTime,@Dr,@Ts)";
            base.Execute(sql,model);
        }

		/// <summary>
        /// 根据Id删除一个ApplyRelatedUsers对象
        /// </summary>
        /// <param name="id">主键Id</param>
		public void Delete(long id)
        {
             string sql = "DELETE FROM USER WHERE ID=@Id";
             base.Execute(sql, new { Id = id });
        }

		/// <summary>
        /// 更新一个ApplyRelatedUsers对象
        /// </summary>
		/// <param name="model">要更新的对象</param>
        public void Update(ApplyRelatedUsers model)
        {
            string sql = "UPDATE APPLYRELATEDUSERS SET EnterpriseId=@EnterpriseId,ApplyVehicleId=@ApplyVehicleId,UserId=@UserId,Roles=@Roles,Status=@Status,AddTime=@AddTime,UpdateTime=@UpdateTime,Dr=@Dr,Ts=@Ts WHERE Id=@Id";
            base.Execute(sql,model);
        }

		/// <summary>
        /// 根据Id获取一个ApplyRelatedUsers对象
        /// </summary>
        /// <param name="id">主键Id</param>
		 public ApplyRelatedUsers Get(long id)
        {
            string sql = "SELECT * FROM USER WHERE ID=@Id";
            return base.QueryFirstOrDefault<ApplyRelatedUsers>(sql, new { Id=id});
        }
		/// <summary>
        /// 根据条件查询ApplyRelatedUsers列表
        /// </summary>
        /// <param name="condition">查询条件</param>
        public IList<ApplyRelatedUsers> GetList(Condition condition = null)
        {
            string sql = "SELECT * FROM APPLYRELATEDUSERS";
            return base.QueryByCondition<ApplyRelatedUsers>(sql, condition);
        }
		/// <summary>
        /// 根据条件分页查询ApplyRelatedUsers列表
        /// </summary>
		/// <param name="pageInfo">分页信息(必填)</param>
        /// <param name="condition">查询条件</param>
        public PageData<ApplyRelatedUsers> GetList(PageInfo pageInfo, Condition condition = null)
        {
            string sql = "SELECT * FROM APPLYRELATEDUSERS";
            return base.QueryByPageCondition<ApplyRelatedUsers>(sql,pageInfo,condition);
        }
	}
	#endregion
	
	#region ApplyVehicle定义
    /// <summary>
    /// ApplyVehicle数据访问类
    /// </summary>
	public partial class ApplyVehicleDAL : BaseDAL, IDAL<ApplyVehicle>
	{ 
		/// <summary>
        /// 插入一个ApplyVehicle对象
        /// </summary>
		/// <param name="model">要插入的对象</param>
        public void Insert(ApplyVehicle model)
        {
			string sql = "INSERT INTO APPLYVEHICLE (Id,UserId,EnterpriseId,VehicleId,VehicleType,PlateNumber,BrandName,SeriesName,StartPosition,StartLat,StartLng,StartAddress,StartTime,EndTime,ReturnTime,Destinations,IsNeedVehicle,IsNeedDriver,DriverId,DriverName,ApplyReason,ApproveUserIds,CCUserIds,Status,ApplyUserName,ApplyDeptName,InternalPassengerIds,ExternalPassengers,VehicleManagerId,IsChauffeur,Attachments,AddTime,UpdateTime,Dr,Ts) values (@Id,@UserId,@EnterpriseId,@VehicleId,@VehicleType,@PlateNumber,@BrandName,@SeriesName,@StartPosition,@StartLat,@StartLng,@StartAddress,@StartTime,@EndTime,@ReturnTime,@Destinations,@IsNeedVehicle,@IsNeedDriver,@DriverId,@DriverName,@ApplyReason,@ApproveUserIds,@CCUserIds,@Status,@ApplyUserName,@ApplyDeptName,@InternalPassengerIds,@ExternalPassengers,@VehicleManagerId,@IsChauffeur,@Attachments,@AddTime,@UpdateTime,@Dr,@Ts)";
            base.Execute(sql,model);
        }

		/// <summary>
        /// 根据Id删除一个ApplyVehicle对象
        /// </summary>
        /// <param name="id">主键Id</param>
		public void Delete(long id)
        {
             string sql = "DELETE FROM USER WHERE ID=@Id";
             base.Execute(sql, new { Id = id });
        }

		/// <summary>
        /// 更新一个ApplyVehicle对象
        /// </summary>
		/// <param name="model">要更新的对象</param>
        public void Update(ApplyVehicle model)
        {
            string sql = "UPDATE APPLYVEHICLE SET UserId=@UserId,EnterpriseId=@EnterpriseId,VehicleId=@VehicleId,VehicleType=@VehicleType,PlateNumber=@PlateNumber,BrandName=@BrandName,SeriesName=@SeriesName,StartPosition=@StartPosition,StartLat=@StartLat,StartLng=@StartLng,StartAddress=@StartAddress,StartTime=@StartTime,EndTime=@EndTime,ReturnTime=@ReturnTime,Destinations=@Destinations,IsNeedVehicle=@IsNeedVehicle,IsNeedDriver=@IsNeedDriver,DriverId=@DriverId,DriverName=@DriverName,ApplyReason=@ApplyReason,ApproveUserIds=@ApproveUserIds,CCUserIds=@CCUserIds,Status=@Status,ApplyUserName=@ApplyUserName,ApplyDeptName=@ApplyDeptName,InternalPassengerIds=@InternalPassengerIds,ExternalPassengers=@ExternalPassengers,VehicleManagerId=@VehicleManagerId,IsChauffeur=@IsChauffeur,Attachments=@Attachments,AddTime=@AddTime,UpdateTime=@UpdateTime,Dr=@Dr,Ts=@Ts WHERE Id=@Id";
            base.Execute(sql,model);
        }

		/// <summary>
        /// 根据Id获取一个ApplyVehicle对象
        /// </summary>
        /// <param name="id">主键Id</param>
		 public ApplyVehicle Get(long id)
        {
            string sql = "SELECT * FROM USER WHERE ID=@Id";
            return base.QueryFirstOrDefault<ApplyVehicle>(sql, new { Id=id});
        }
		/// <summary>
        /// 根据条件查询ApplyVehicle列表
        /// </summary>
        /// <param name="condition">查询条件</param>
        public IList<ApplyVehicle> GetList(Condition condition = null)
        {
            string sql = "SELECT * FROM APPLYVEHICLE";
            return base.QueryByCondition<ApplyVehicle>(sql, condition);
        }
		/// <summary>
        /// 根据条件分页查询ApplyVehicle列表
        /// </summary>
		/// <param name="pageInfo">分页信息(必填)</param>
        /// <param name="condition">查询条件</param>
        public PageData<ApplyVehicle> GetList(PageInfo pageInfo, Condition condition = null)
        {
            string sql = "SELECT * FROM APPLYVEHICLE";
            return base.QueryByPageCondition<ApplyVehicle>(sql,pageInfo,condition);
        }
	}
	#endregion
	
	#region AppointPolicy定义
    /// <summary>
    /// AppointPolicy数据访问类
    /// </summary>
	public partial class AppointPolicyDAL : BaseDAL, IDAL<AppointPolicy>
	{ 
		/// <summary>
        /// 插入一个AppointPolicy对象
        /// </summary>
		/// <param name="model">要插入的对象</param>
        public void Insert(AppointPolicy model)
        {
			string sql = "INSERT INTO APPOINTPOLICY (Id,VehicleId,EnterpriseId,CannotValue,CannotType,AddTime,UpdateTime,Dr,Ts) values (@Id,@VehicleId,@EnterpriseId,@CannotValue,@CannotType,@AddTime,@UpdateTime,@Dr,@Ts)";
            base.Execute(sql,model);
        }

		/// <summary>
        /// 根据Id删除一个AppointPolicy对象
        /// </summary>
        /// <param name="id">主键Id</param>
		public void Delete(long id)
        {
             string sql = "DELETE FROM USER WHERE ID=@Id";
             base.Execute(sql, new { Id = id });
        }

		/// <summary>
        /// 更新一个AppointPolicy对象
        /// </summary>
		/// <param name="model">要更新的对象</param>
        public void Update(AppointPolicy model)
        {
            string sql = "UPDATE APPOINTPOLICY SET VehicleId=@VehicleId,EnterpriseId=@EnterpriseId,CannotValue=@CannotValue,CannotType=@CannotType,AddTime=@AddTime,UpdateTime=@UpdateTime,Dr=@Dr,Ts=@Ts WHERE Id=@Id";
            base.Execute(sql,model);
        }

		/// <summary>
        /// 根据Id获取一个AppointPolicy对象
        /// </summary>
        /// <param name="id">主键Id</param>
		 public AppointPolicy Get(long id)
        {
            string sql = "SELECT * FROM USER WHERE ID=@Id";
            return base.QueryFirstOrDefault<AppointPolicy>(sql, new { Id=id});
        }
		/// <summary>
        /// 根据条件查询AppointPolicy列表
        /// </summary>
        /// <param name="condition">查询条件</param>
        public IList<AppointPolicy> GetList(Condition condition = null)
        {
            string sql = "SELECT * FROM APPOINTPOLICY";
            return base.QueryByCondition<AppointPolicy>(sql, condition);
        }
		/// <summary>
        /// 根据条件分页查询AppointPolicy列表
        /// </summary>
		/// <param name="pageInfo">分页信息(必填)</param>
        /// <param name="condition">查询条件</param>
        public PageData<AppointPolicy> GetList(PageInfo pageInfo, Condition condition = null)
        {
            string sql = "SELECT * FROM APPOINTPOLICY";
            return base.QueryByPageCondition<AppointPolicy>(sql,pageInfo,condition);
        }
	}
	#endregion
	
	#region ApproveCarbonCopy定义
    /// <summary>
    /// ApproveCarbonCopy数据访问类
    /// </summary>
	public partial class ApproveCarbonCopyDAL : BaseDAL, IDAL<ApproveCarbonCopy>
	{ 
		/// <summary>
        /// 插入一个ApproveCarbonCopy对象
        /// </summary>
		/// <param name="model">要插入的对象</param>
        public void Insert(ApproveCarbonCopy model)
        {
			string sql = "INSERT INTO APPROVECARBONCOPY (Id,EnterpriseId,DeptId,UserId,BusinessType,ToUserId,ToUserName,ToUserDeptName,Status,AddTime,UpdateTime,Dr,Ts) values (@Id,@EnterpriseId,@DeptId,@UserId,@BusinessType,@ToUserId,@ToUserName,@ToUserDeptName,@Status,@AddTime,@UpdateTime,@Dr,@Ts)";
            base.Execute(sql,model);
        }

		/// <summary>
        /// 根据Id删除一个ApproveCarbonCopy对象
        /// </summary>
        /// <param name="id">主键Id</param>
		public void Delete(long id)
        {
             string sql = "DELETE FROM USER WHERE ID=@Id";
             base.Execute(sql, new { Id = id });
        }

		/// <summary>
        /// 更新一个ApproveCarbonCopy对象
        /// </summary>
		/// <param name="model">要更新的对象</param>
        public void Update(ApproveCarbonCopy model)
        {
            string sql = "UPDATE APPROVECARBONCOPY SET EnterpriseId=@EnterpriseId,DeptId=@DeptId,UserId=@UserId,BusinessType=@BusinessType,ToUserId=@ToUserId,ToUserName=@ToUserName,ToUserDeptName=@ToUserDeptName,Status=@Status,AddTime=@AddTime,UpdateTime=@UpdateTime,Dr=@Dr,Ts=@Ts WHERE Id=@Id";
            base.Execute(sql,model);
        }

		/// <summary>
        /// 根据Id获取一个ApproveCarbonCopy对象
        /// </summary>
        /// <param name="id">主键Id</param>
		 public ApproveCarbonCopy Get(long id)
        {
            string sql = "SELECT * FROM USER WHERE ID=@Id";
            return base.QueryFirstOrDefault<ApproveCarbonCopy>(sql, new { Id=id});
        }
		/// <summary>
        /// 根据条件查询ApproveCarbonCopy列表
        /// </summary>
        /// <param name="condition">查询条件</param>
        public IList<ApproveCarbonCopy> GetList(Condition condition = null)
        {
            string sql = "SELECT * FROM APPROVECARBONCOPY";
            return base.QueryByCondition<ApproveCarbonCopy>(sql, condition);
        }
		/// <summary>
        /// 根据条件分页查询ApproveCarbonCopy列表
        /// </summary>
		/// <param name="pageInfo">分页信息(必填)</param>
        /// <param name="condition">查询条件</param>
        public PageData<ApproveCarbonCopy> GetList(PageInfo pageInfo, Condition condition = null)
        {
            string sql = "SELECT * FROM APPROVECARBONCOPY";
            return base.QueryByPageCondition<ApproveCarbonCopy>(sql,pageInfo,condition);
        }
	}
	#endregion
	
	#region ApproveTask定义
    /// <summary>
    /// ApproveTask数据访问类
    /// </summary>
	public partial class ApproveTaskDAL : BaseDAL, IDAL<ApproveTask>
	{ 
		/// <summary>
        /// 插入一个ApproveTask对象
        /// </summary>
		/// <param name="model">要插入的对象</param>
        public void Insert(ApproveTask model)
        {
			string sql = "INSERT INTO APPROVETASK (Id,ApplyVehicleId,UserId,DeptId,EnterpriseId,TaskName,Description,SortNo,ActorName,ActorDeptName,Content,ProcessTime,IsManagerApprove,Status,AddTime,UpdateTime,Dr,Ts) values (@Id,@ApplyVehicleId,@UserId,@DeptId,@EnterpriseId,@TaskName,@Description,@SortNo,@ActorName,@ActorDeptName,@Content,@ProcessTime,@IsManagerApprove,@Status,@AddTime,@UpdateTime,@Dr,@Ts)";
            base.Execute(sql,model);
        }

		/// <summary>
        /// 根据Id删除一个ApproveTask对象
        /// </summary>
        /// <param name="id">主键Id</param>
		public void Delete(long id)
        {
             string sql = "DELETE FROM USER WHERE ID=@Id";
             base.Execute(sql, new { Id = id });
        }

		/// <summary>
        /// 更新一个ApproveTask对象
        /// </summary>
		/// <param name="model">要更新的对象</param>
        public void Update(ApproveTask model)
        {
            string sql = "UPDATE APPROVETASK SET ApplyVehicleId=@ApplyVehicleId,UserId=@UserId,DeptId=@DeptId,EnterpriseId=@EnterpriseId,TaskName=@TaskName,Description=@Description,SortNo=@SortNo,ActorName=@ActorName,ActorDeptName=@ActorDeptName,Content=@Content,ProcessTime=@ProcessTime,IsManagerApprove=@IsManagerApprove,Status=@Status,AddTime=@AddTime,UpdateTime=@UpdateTime,Dr=@Dr,Ts=@Ts WHERE Id=@Id";
            base.Execute(sql,model);
        }

		/// <summary>
        /// 根据Id获取一个ApproveTask对象
        /// </summary>
        /// <param name="id">主键Id</param>
		 public ApproveTask Get(long id)
        {
            string sql = "SELECT * FROM USER WHERE ID=@Id";
            return base.QueryFirstOrDefault<ApproveTask>(sql, new { Id=id});
        }
		/// <summary>
        /// 根据条件查询ApproveTask列表
        /// </summary>
        /// <param name="condition">查询条件</param>
        public IList<ApproveTask> GetList(Condition condition = null)
        {
            string sql = "SELECT * FROM APPROVETASK";
            return base.QueryByCondition<ApproveTask>(sql, condition);
        }
		/// <summary>
        /// 根据条件分页查询ApproveTask列表
        /// </summary>
		/// <param name="pageInfo">分页信息(必填)</param>
        /// <param name="condition">查询条件</param>
        public PageData<ApproveTask> GetList(PageInfo pageInfo, Condition condition = null)
        {
            string sql = "SELECT * FROM APPROVETASK";
            return base.QueryByPageCondition<ApproveTask>(sql,pageInfo,condition);
        }
	}
	#endregion
	
	#region DepartureRecord定义
    /// <summary>
    /// DepartureRecord数据访问类
    /// </summary>
	public partial class DepartureRecordDAL : BaseDAL, IDAL<DepartureRecord>
	{ 
		/// <summary>
        /// 插入一个DepartureRecord对象
        /// </summary>
		/// <param name="model">要插入的对象</param>
        public void Insert(DepartureRecord model)
        {
			string sql = "INSERT INTO DEPARTURERECORD (Id,ApplyVehicleId,UserId,EnterpriseId,PassengerName,Mileage,ContinueMileage,DeparturePosition,DepartureLat,DepartureLng,DepartureAddress,DepartureTime,Attachments,Content,AddTime,UpdateTime,Dr,Ts,Version) values (@Id,@ApplyVehicleId,@UserId,@EnterpriseId,@PassengerName,@Mileage,@ContinueMileage,@DeparturePosition,@DepartureLat,@DepartureLng,@DepartureAddress,@DepartureTime,@Attachments,@Content,@AddTime,@UpdateTime,@Dr,@Ts,@Version)";
            base.Execute(sql,model);
        }

		/// <summary>
        /// 根据Id删除一个DepartureRecord对象
        /// </summary>
        /// <param name="id">主键Id</param>
		public void Delete(long id)
        {
             string sql = "DELETE FROM USER WHERE ID=@Id";
             base.Execute(sql, new { Id = id });
        }

		/// <summary>
        /// 更新一个DepartureRecord对象
        /// </summary>
		/// <param name="model">要更新的对象</param>
        public void Update(DepartureRecord model)
        {
            string sql = "UPDATE DEPARTURERECORD SET ApplyVehicleId=@ApplyVehicleId,UserId=@UserId,EnterpriseId=@EnterpriseId,PassengerName=@PassengerName,Mileage=@Mileage,ContinueMileage=@ContinueMileage,DeparturePosition=@DeparturePosition,DepartureLat=@DepartureLat,DepartureLng=@DepartureLng,DepartureAddress=@DepartureAddress,DepartureTime=@DepartureTime,Attachments=@Attachments,Content=@Content,AddTime=@AddTime,UpdateTime=@UpdateTime,Dr=@Dr,Ts=@Ts,Version=@Version WHERE Id=@Id";
            base.Execute(sql,model);
        }

		/// <summary>
        /// 根据Id获取一个DepartureRecord对象
        /// </summary>
        /// <param name="id">主键Id</param>
		 public DepartureRecord Get(long id)
        {
            string sql = "SELECT * FROM USER WHERE ID=@Id";
            return base.QueryFirstOrDefault<DepartureRecord>(sql, new { Id=id});
        }
		/// <summary>
        /// 根据条件查询DepartureRecord列表
        /// </summary>
        /// <param name="condition">查询条件</param>
        public IList<DepartureRecord> GetList(Condition condition = null)
        {
            string sql = "SELECT * FROM DEPARTURERECORD";
            return base.QueryByCondition<DepartureRecord>(sql, condition);
        }
		/// <summary>
        /// 根据条件分页查询DepartureRecord列表
        /// </summary>
		/// <param name="pageInfo">分页信息(必填)</param>
        /// <param name="condition">查询条件</param>
        public PageData<DepartureRecord> GetList(PageInfo pageInfo, Condition condition = null)
        {
            string sql = "SELECT * FROM DEPARTURERECORD";
            return base.QueryByPageCondition<DepartureRecord>(sql,pageInfo,condition);
        }
	}
	#endregion
	
	#region DispatchRecord定义
    /// <summary>
    /// DispatchRecord数据访问类
    /// </summary>
	public partial class DispatchRecordDAL : BaseDAL, IDAL<DispatchRecord>
	{ 
		/// <summary>
        /// 插入一个DispatchRecord对象
        /// </summary>
		/// <param name="model">要插入的对象</param>
        public void Insert(DispatchRecord model)
        {
			string sql = "INSERT INTO DISPATCHRECORD (Id,DriverId,ApplyVehicleId,EnterpriseId,VehicleId,PlateNumber,BrandName,SeriesName,VehicleColor,DriverName,Attachments,DriverType,Content,Status,AddTime,UpdateTime,Dr,Ts) values (@Id,@DriverId,@ApplyVehicleId,@EnterpriseId,@VehicleId,@PlateNumber,@BrandName,@SeriesName,@VehicleColor,@DriverName,@Attachments,@DriverType,@Content,@Status,@AddTime,@UpdateTime,@Dr,@Ts)";
            base.Execute(sql,model);
        }

		/// <summary>
        /// 根据Id删除一个DispatchRecord对象
        /// </summary>
        /// <param name="id">主键Id</param>
		public void Delete(long id)
        {
             string sql = "DELETE FROM USER WHERE ID=@Id";
             base.Execute(sql, new { Id = id });
        }

		/// <summary>
        /// 更新一个DispatchRecord对象
        /// </summary>
		/// <param name="model">要更新的对象</param>
        public void Update(DispatchRecord model)
        {
            string sql = "UPDATE DISPATCHRECORD SET DriverId=@DriverId,ApplyVehicleId=@ApplyVehicleId,EnterpriseId=@EnterpriseId,VehicleId=@VehicleId,PlateNumber=@PlateNumber,BrandName=@BrandName,SeriesName=@SeriesName,VehicleColor=@VehicleColor,DriverName=@DriverName,Attachments=@Attachments,DriverType=@DriverType,Content=@Content,Status=@Status,AddTime=@AddTime,UpdateTime=@UpdateTime,Dr=@Dr,Ts=@Ts WHERE Id=@Id";
            base.Execute(sql,model);
        }

		/// <summary>
        /// 根据Id获取一个DispatchRecord对象
        /// </summary>
        /// <param name="id">主键Id</param>
		 public DispatchRecord Get(long id)
        {
            string sql = "SELECT * FROM USER WHERE ID=@Id";
            return base.QueryFirstOrDefault<DispatchRecord>(sql, new { Id=id});
        }
		/// <summary>
        /// 根据条件查询DispatchRecord列表
        /// </summary>
        /// <param name="condition">查询条件</param>
        public IList<DispatchRecord> GetList(Condition condition = null)
        {
            string sql = "SELECT * FROM DISPATCHRECORD";
            return base.QueryByCondition<DispatchRecord>(sql, condition);
        }
		/// <summary>
        /// 根据条件分页查询DispatchRecord列表
        /// </summary>
		/// <param name="pageInfo">分页信息(必填)</param>
        /// <param name="condition">查询条件</param>
        public PageData<DispatchRecord> GetList(PageInfo pageInfo, Condition condition = null)
        {
            string sql = "SELECT * FROM DISPATCHRECORD";
            return base.QueryByPageCondition<DispatchRecord>(sql,pageInfo,condition);
        }
	}
	#endregion
	
	#region ReturnVehicleRecord定义
    /// <summary>
    /// ReturnVehicleRecord数据访问类
    /// </summary>
	public partial class ReturnVehicleRecordDAL : BaseDAL, IDAL<ReturnVehicleRecord>
	{ 
		/// <summary>
        /// 插入一个ReturnVehicleRecord对象
        /// </summary>
		/// <param name="model">要插入的对象</param>
        public void Insert(ReturnVehicleRecord model)
        {
			string sql = "INSERT INTO RETURNVEHICLERECORD (Id,UserId,ApplyVehicleId,EnterpriseId,ReturnUserName,Mileage,ContinueMileage,CostItems,Cost,Attachments,ReturnPosition,ReturnAddress,ReturnLat,ReturnLng,Version,Content,AddTime,UpdateTime,Dr,Ts,VehicleCondition,ReturnTime) values (@Id,@UserId,@ApplyVehicleId,@EnterpriseId,@ReturnUserName,@Mileage,@ContinueMileage,@CostItems,@Cost,@Attachments,@ReturnPosition,@ReturnAddress,@ReturnLat,@ReturnLng,@Version,@Content,@AddTime,@UpdateTime,@Dr,@Ts,@VehicleCondition,@ReturnTime)";
            base.Execute(sql,model);
        }

		/// <summary>
        /// 根据Id删除一个ReturnVehicleRecord对象
        /// </summary>
        /// <param name="id">主键Id</param>
		public void Delete(long id)
        {
             string sql = "DELETE FROM USER WHERE ID=@Id";
             base.Execute(sql, new { Id = id });
        }

		/// <summary>
        /// 更新一个ReturnVehicleRecord对象
        /// </summary>
		/// <param name="model">要更新的对象</param>
        public void Update(ReturnVehicleRecord model)
        {
            string sql = "UPDATE RETURNVEHICLERECORD SET UserId=@UserId,ApplyVehicleId=@ApplyVehicleId,EnterpriseId=@EnterpriseId,ReturnUserName=@ReturnUserName,Mileage=@Mileage,ContinueMileage=@ContinueMileage,CostItems=@CostItems,Cost=@Cost,Attachments=@Attachments,ReturnPosition=@ReturnPosition,ReturnAddress=@ReturnAddress,ReturnLat=@ReturnLat,ReturnLng=@ReturnLng,Version=@Version,Content=@Content,AddTime=@AddTime,UpdateTime=@UpdateTime,Dr=@Dr,Ts=@Ts,VehicleCondition=@VehicleCondition,ReturnTime=@ReturnTime WHERE Id=@Id";
            base.Execute(sql,model);
        }

		/// <summary>
        /// 根据Id获取一个ReturnVehicleRecord对象
        /// </summary>
        /// <param name="id">主键Id</param>
		 public ReturnVehicleRecord Get(long id)
        {
            string sql = "SELECT * FROM USER WHERE ID=@Id";
            return base.QueryFirstOrDefault<ReturnVehicleRecord>(sql, new { Id=id});
        }
		/// <summary>
        /// 根据条件查询ReturnVehicleRecord列表
        /// </summary>
        /// <param name="condition">查询条件</param>
        public IList<ReturnVehicleRecord> GetList(Condition condition = null)
        {
            string sql = "SELECT * FROM RETURNVEHICLERECORD";
            return base.QueryByCondition<ReturnVehicleRecord>(sql, condition);
        }
		/// <summary>
        /// 根据条件分页查询ReturnVehicleRecord列表
        /// </summary>
		/// <param name="pageInfo">分页信息(必填)</param>
        /// <param name="condition">查询条件</param>
        public PageData<ReturnVehicleRecord> GetList(PageInfo pageInfo, Condition condition = null)
        {
            string sql = "SELECT * FROM RETURNVEHICLERECORD";
            return base.QueryByPageCondition<ReturnVehicleRecord>(sql,pageInfo,condition);
        }
	}
	#endregion
	
	#region WorkflowApply定义
    /// <summary>
    /// WorkflowApply数据访问类
    /// </summary>
	public partial class WorkflowApplyDAL : BaseDAL, IDAL<WorkflowApply>
	{ 
		/// <summary>
        /// 插入一个WorkflowApply对象
        /// </summary>
		/// <param name="model">要插入的对象</param>
        public void Insert(WorkflowApply model)
        {
			string sql = "INSERT INTO WORKFLOWAPPLY (Id,EnterpriseId,ApplyVehicleId,WorkflowTemplateId,UserId,AddTime,UpdateTime,Dr,Ts) values (@Id,@EnterpriseId,@ApplyVehicleId,@WorkflowTemplateId,@UserId,@AddTime,@UpdateTime,@Dr,@Ts)";
            base.Execute(sql,model);
        }

		/// <summary>
        /// 根据Id删除一个WorkflowApply对象
        /// </summary>
        /// <param name="id">主键Id</param>
		public void Delete(long id)
        {
             string sql = "DELETE FROM USER WHERE ID=@Id";
             base.Execute(sql, new { Id = id });
        }

		/// <summary>
        /// 更新一个WorkflowApply对象
        /// </summary>
		/// <param name="model">要更新的对象</param>
        public void Update(WorkflowApply model)
        {
            string sql = "UPDATE WORKFLOWAPPLY SET EnterpriseId=@EnterpriseId,ApplyVehicleId=@ApplyVehicleId,WorkflowTemplateId=@WorkflowTemplateId,UserId=@UserId,AddTime=@AddTime,UpdateTime=@UpdateTime,Dr=@Dr,Ts=@Ts WHERE Id=@Id";
            base.Execute(sql,model);
        }

		/// <summary>
        /// 根据Id获取一个WorkflowApply对象
        /// </summary>
        /// <param name="id">主键Id</param>
		 public WorkflowApply Get(long id)
        {
            string sql = "SELECT * FROM USER WHERE ID=@Id";
            return base.QueryFirstOrDefault<WorkflowApply>(sql, new { Id=id});
        }
		/// <summary>
        /// 根据条件查询WorkflowApply列表
        /// </summary>
        /// <param name="condition">查询条件</param>
        public IList<WorkflowApply> GetList(Condition condition = null)
        {
            string sql = "SELECT * FROM WORKFLOWAPPLY";
            return base.QueryByCondition<WorkflowApply>(sql, condition);
        }
		/// <summary>
        /// 根据条件分页查询WorkflowApply列表
        /// </summary>
		/// <param name="pageInfo">分页信息(必填)</param>
        /// <param name="condition">查询条件</param>
        public PageData<WorkflowApply> GetList(PageInfo pageInfo, Condition condition = null)
        {
            string sql = "SELECT * FROM WORKFLOWAPPLY";
            return base.QueryByPageCondition<WorkflowApply>(sql,pageInfo,condition);
        }
	}
	#endregion
	
	#region WorkflowTask定义
    /// <summary>
    /// WorkflowTask数据访问类
    /// </summary>
	public partial class WorkflowTaskDAL : BaseDAL, IDAL<WorkflowTask>
	{ 
		/// <summary>
        /// 插入一个WorkflowTask对象
        /// </summary>
		/// <param name="model">要插入的对象</param>
        public void Insert(WorkflowTask model)
        {
			string sql = "INSERT INTO WORKFLOWTASK (Id,EnterpriseId,WorkflowTemplateId,ApplyVehicleId,UserId,WorkflowApplyId,Status,AddTime,UpdateTime,Dr,Ts) values (@Id,@EnterpriseId,@WorkflowTemplateId,@ApplyVehicleId,@UserId,@WorkflowApplyId,@Status,@AddTime,@UpdateTime,@Dr,@Ts)";
            base.Execute(sql,model);
        }

		/// <summary>
        /// 根据Id删除一个WorkflowTask对象
        /// </summary>
        /// <param name="id">主键Id</param>
		public void Delete(long id)
        {
             string sql = "DELETE FROM USER WHERE ID=@Id";
             base.Execute(sql, new { Id = id });
        }

		/// <summary>
        /// 更新一个WorkflowTask对象
        /// </summary>
		/// <param name="model">要更新的对象</param>
        public void Update(WorkflowTask model)
        {
            string sql = "UPDATE WORKFLOWTASK SET EnterpriseId=@EnterpriseId,WorkflowTemplateId=@WorkflowTemplateId,ApplyVehicleId=@ApplyVehicleId,UserId=@UserId,WorkflowApplyId=@WorkflowApplyId,Status=@Status,AddTime=@AddTime,UpdateTime=@UpdateTime,Dr=@Dr,Ts=@Ts WHERE Id=@Id";
            base.Execute(sql,model);
        }

		/// <summary>
        /// 根据Id获取一个WorkflowTask对象
        /// </summary>
        /// <param name="id">主键Id</param>
		 public WorkflowTask Get(long id)
        {
            string sql = "SELECT * FROM USER WHERE ID=@Id";
            return base.QueryFirstOrDefault<WorkflowTask>(sql, new { Id=id});
        }
		/// <summary>
        /// 根据条件查询WorkflowTask列表
        /// </summary>
        /// <param name="condition">查询条件</param>
        public IList<WorkflowTask> GetList(Condition condition = null)
        {
            string sql = "SELECT * FROM WORKFLOWTASK";
            return base.QueryByCondition<WorkflowTask>(sql, condition);
        }
		/// <summary>
        /// 根据条件分页查询WorkflowTask列表
        /// </summary>
		/// <param name="pageInfo">分页信息(必填)</param>
        /// <param name="condition">查询条件</param>
        public PageData<WorkflowTask> GetList(PageInfo pageInfo, Condition condition = null)
        {
            string sql = "SELECT * FROM WORKFLOWTASK";
            return base.QueryByPageCondition<WorkflowTask>(sql,pageInfo,condition);
        }
	}
	#endregion
	
	#region WorkflowTemplate定义
    /// <summary>
    /// WorkflowTemplate数据访问类
    /// </summary>
	public partial class WorkflowTemplateDAL : BaseDAL, IDAL<WorkflowTemplate>
	{ 
		/// <summary>
        /// 插入一个WorkflowTemplate对象
        /// </summary>
		/// <param name="model">要插入的对象</param>
        public void Insert(WorkflowTemplate model)
        {
			string sql = "INSERT INTO WORKFLOWTEMPLATE (Id,EnterpriseId,AddTime,UpdateTime,Dr,Ts,Name) values (@Id,@EnterpriseId,@AddTime,@UpdateTime,@Dr,@Ts,@Name)";
            base.Execute(sql,model);
        }

		/// <summary>
        /// 根据Id删除一个WorkflowTemplate对象
        /// </summary>
        /// <param name="id">主键Id</param>
		public void Delete(long id)
        {
             string sql = "DELETE FROM USER WHERE ID=@Id";
             base.Execute(sql, new { Id = id });
        }

		/// <summary>
        /// 更新一个WorkflowTemplate对象
        /// </summary>
		/// <param name="model">要更新的对象</param>
        public void Update(WorkflowTemplate model)
        {
            string sql = "UPDATE WORKFLOWTEMPLATE SET EnterpriseId=@EnterpriseId,AddTime=@AddTime,UpdateTime=@UpdateTime,Dr=@Dr,Ts=@Ts,Name=@Name WHERE Id=@Id";
            base.Execute(sql,model);
        }

		/// <summary>
        /// 根据Id获取一个WorkflowTemplate对象
        /// </summary>
        /// <param name="id">主键Id</param>
		 public WorkflowTemplate Get(long id)
        {
            string sql = "SELECT * FROM USER WHERE ID=@Id";
            return base.QueryFirstOrDefault<WorkflowTemplate>(sql, new { Id=id});
        }
		/// <summary>
        /// 根据条件查询WorkflowTemplate列表
        /// </summary>
        /// <param name="condition">查询条件</param>
        public IList<WorkflowTemplate> GetList(Condition condition = null)
        {
            string sql = "SELECT * FROM WORKFLOWTEMPLATE";
            return base.QueryByCondition<WorkflowTemplate>(sql, condition);
        }
		/// <summary>
        /// 根据条件分页查询WorkflowTemplate列表
        /// </summary>
		/// <param name="pageInfo">分页信息(必填)</param>
        /// <param name="condition">查询条件</param>
        public PageData<WorkflowTemplate> GetList(PageInfo pageInfo, Condition condition = null)
        {
            string sql = "SELECT * FROM WORKFLOWTEMPLATE";
            return base.QueryByPageCondition<WorkflowTemplate>(sql,pageInfo,condition);
        }
	}
	#endregion
}