//-----------------------------------------------------------------------
// <copyright file="Models.cs">
// * Copyright (C) 2019 63354261@qq.com
// * version : V 1.0
// * author  : cuiguoliang
// * FileName: Model.cs
// * history : Created by T4 10/28/2019 15:09:42 
// </copyright>
//-----------------------------------------------------------------------


/// <summary>
/// 全部DB实体类
/// </summary>
namespace Liang.Models
{
	using System;
	
	#region ApplyApproveRecord定义
	/// <summary>
    /// ApplyApproveRecord数据访问类
    /// </summary>
	public partial class ApplyApproveRecord
	{
		/// <summary>
		/// Id
		/// </summary>
		public long Id { get; set; }
		/// <summary>
		/// ApplyVehicleId
		/// </summary>
		public long? ApplyVehicleId { get; set; }
		/// <summary>
		/// ReturnVehicleRecordId
		/// </summary>
		public long? ReturnVehicleRecordId { get; set; }
		/// <summary>
		/// UserId
		/// </summary>
		public string UserId { get; set; }
		/// <summary>
		/// EnterpriseId
		/// </summary>
		public string EnterpriseId { get; set; }
		/// <summary>
		/// ApproveUserName
		/// </summary>
		public string ApproveUserName { get; set; }
		/// <summary>
		/// TripMileage
		/// </summary>
		public int? TripMileage { get; set; }
		/// <summary>
		/// Cost
		/// </summary>
		public decimal? Cost { get; set; }
		/// <summary>
		/// VehicleCondition
		/// </summary>
		public string VehicleCondition { get; set; }
		/// <summary>
		/// ApproveTime
		/// </summary>
		public DateTime? ApproveTime { get; set; }
		/// <summary>
		/// Attachments
		/// </summary>
		public string Attachments { get; set; }
		/// <summary>
		/// Content
		/// </summary>
		public string Content { get; set; }
		/// <summary>
		/// 0. 通过 1.拒绝
		/// </summary>
		public int? Status { get; set; }
		/// <summary>
		/// AddTime
		/// </summary>
		public DateTime? AddTime { get; set; }
		/// <summary>
		/// UpdateTime
		/// </summary>
		public DateTime? UpdateTime { get; set; }
		/// <summary>
		/// Dr
		/// </summary>
		public short Dr { get; set; }
		/// <summary>
		/// Ts
		/// </summary>
		public DateTime? Ts { get; set; }
	}
	#endregion
	
	#region ApplyRelatedUsers定义
	/// <summary>
    /// ApplyRelatedUsers数据访问类
    /// </summary>
	public partial class ApplyRelatedUsers
	{
		/// <summary>
		/// Id
		/// </summary>
		public long Id { get; set; }
		/// <summary>
		/// EnterpriseId
		/// </summary>
		public string EnterpriseId { get; set; }
		/// <summary>
		/// ApplyVehicleId
		/// </summary>
		public long? ApplyVehicleId { get; set; }
		/// <summary>
		/// UserId
		/// </summary>
		public string UserId { get; set; }
		/// <summary>
		/// 1.申请人 2.审批 3.驾驶人4.专职司机 5.车辆负责人
		/// </summary>
		public string Roles { get; set; }
		/// <summary>
		/// 0待办 1已办
		/// </summary>
		public int? Status { get; set; }
		/// <summary>
		/// AddTime
		/// </summary>
		public DateTime? AddTime { get; set; }
		/// <summary>
		/// UpdateTime
		/// </summary>
		public DateTime? UpdateTime { get; set; }
		/// <summary>
		/// Dr
		/// </summary>
		public int? Dr { get; set; }
		/// <summary>
		/// Ts
		/// </summary>
		public DateTime? Ts { get; set; }
	}
	#endregion
	
	#region ApplyVehicle定义
	/// <summary>
    /// ApplyVehicle数据访问类
    /// </summary>
	public partial class ApplyVehicle
	{
		/// <summary>
		/// Id
		/// </summary>
		public long Id { get; set; }
		/// <summary>
		/// UserId
		/// </summary>
		public string UserId { get; set; }
		/// <summary>
		/// EnterpriseId
		/// </summary>
		public string EnterpriseId { get; set; }
		/// <summary>
		/// VehicleId
		/// </summary>
		public string VehicleId { get; set; }
		/// <summary>
		/// 0:公车1:私车
		/// </summary>
		public short VehicleType { get; set; }
		/// <summary>
		/// PlateNumber
		/// </summary>
		public string PlateNumber { get; set; }
		/// <summary>
		/// BrandName
		/// </summary>
		public string BrandName { get; set; }
		/// <summary>
		/// SeriesName
		/// </summary>
		public string SeriesName { get; set; }
		/// <summary>
		/// StartPosition
		/// </summary>
		public string StartPosition { get; set; }
		/// <summary>
		/// StartLat
		/// </summary>
		public string StartLat { get; set; }
		/// <summary>
		/// StartLng
		/// </summary>
		public string StartLng { get; set; }
		/// <summary>
		/// StartAddress
		/// </summary>
		public string StartAddress { get; set; }
		/// <summary>
		/// StartTime
		/// </summary>
		public DateTime? StartTime { get; set; }
		/// <summary>
		/// EndTime
		/// </summary>
		public DateTime? EndTime { get; set; }
		/// <summary>
		/// ReturnTime
		/// </summary>
		public DateTime? ReturnTime { get; set; }
		/// <summary>
		/// Destinations
		/// </summary>
		public string Destinations { get; set; }
		/// <summary>
		/// IsNeedVehicle
		/// </summary>
		public short? IsNeedVehicle { get; set; }
		/// <summary>
		/// IsNeedDriver
		/// </summary>
		public short? IsNeedDriver { get; set; }
		/// <summary>
		/// DriverId
		/// </summary>
		public string DriverId { get; set; }
		/// <summary>
		/// DriverName
		/// </summary>
		public string DriverName { get; set; }
		/// <summary>
		/// ApplyReason
		/// </summary>
		public string ApplyReason { get; set; }
		/// <summary>
		/// ApproveUserIds
		/// </summary>
		public string ApproveUserIds { get; set; }
		/// <summary>
		/// CCUserIds
		/// </summary>
		public string CCUserIds { get; set; }
		/// <summary>
		/// 1:已申请,待审批 2:审批通过 3：审批拒绝 4:派车失败 5:派车成功 6:已出车,待还车 7已提交还车,待审核 8:还车审核通过,用车结束 9:还车审核未通过 10:撤销申请
		/// </summary>
		public int? Status { get; set; }
		/// <summary>
		/// ApplyUserName
		/// </summary>
		public string ApplyUserName { get; set; }
		/// <summary>
		/// ApplyDeptName
		/// </summary>
		public string ApplyDeptName { get; set; }
		/// <summary>
		/// InternalPassengerIds
		/// </summary>
		public string InternalPassengerIds { get; set; }
		/// <summary>
		/// ExternalPassengers
		/// </summary>
		public string ExternalPassengers { get; set; }
		/// <summary>
		/// VehicleManagerId
		/// </summary>
		public string VehicleManagerId { get; set; }
		/// <summary>
		/// IsChauffeur
		/// </summary>
		public short? IsChauffeur { get; set; }
		/// <summary>
		/// Attachments
		/// </summary>
		public string Attachments { get; set; }
		/// <summary>
		/// AddTime
		/// </summary>
		public DateTime? AddTime { get; set; }
		/// <summary>
		/// UpdateTime
		/// </summary>
		public DateTime? UpdateTime { get; set; }
		/// <summary>
		/// Dr
		/// </summary>
		public short Dr { get; set; }
		/// <summary>
		/// Ts
		/// </summary>
		public DateTime? Ts { get; set; }
	}
	#endregion
	
	#region AppointPolicy定义
	/// <summary>
    /// AppointPolicy数据访问类
    /// </summary>
	public partial class AppointPolicy
	{
		/// <summary>
		/// Id
		/// </summary>
		public long Id { get; set; }
		/// <summary>
		/// VehicleId
		/// </summary>
		public string VehicleId { get; set; }
		/// <summary>
		/// EnterpriseId
		/// </summary>
		public string EnterpriseId { get; set; }
		/// <summary>
		/// CannotValue
		/// </summary>
		public string CannotValue { get; set; }
		/// <summary>
		/// 1:星期2:自定义3:禁止
		/// </summary>
		public short? CannotType { get; set; }
		/// <summary>
		/// AddTime
		/// </summary>
		public DateTime? AddTime { get; set; }
		/// <summary>
		/// UpdateTime
		/// </summary>
		public DateTime? UpdateTime { get; set; }
		/// <summary>
		/// Dr
		/// </summary>
		public short Dr { get; set; }
		/// <summary>
		/// Ts
		/// </summary>
		public DateTime? Ts { get; set; }
	}
	#endregion
	
	#region ApproveCarbonCopy定义
	/// <summary>
    /// ApproveCarbonCopy数据访问类
    /// </summary>
	public partial class ApproveCarbonCopy
	{
		/// <summary>
		/// Id
		/// </summary>
		public long Id { get; set; }
		/// <summary>
		/// EnterpriseId
		/// </summary>
		public string EnterpriseId { get; set; }
		/// <summary>
		/// DeptId
		/// </summary>
		public string DeptId { get; set; }
		/// <summary>
		/// UserId
		/// </summary>
		public string UserId { get; set; }
		/// <summary>
		/// BusinessType
		/// </summary>
		public short? BusinessType { get; set; }
		/// <summary>
		/// ToUserId
		/// </summary>
		public string ToUserId { get; set; }
		/// <summary>
		/// ToUserName
		/// </summary>
		public string ToUserName { get; set; }
		/// <summary>
		/// ToUserDeptName
		/// </summary>
		public string ToUserDeptName { get; set; }
		/// <summary>
		/// Status
		/// </summary>
		public int? Status { get; set; }
		/// <summary>
		/// AddTime
		/// </summary>
		public DateTime? AddTime { get; set; }
		/// <summary>
		/// UpdateTime
		/// </summary>
		public DateTime? UpdateTime { get; set; }
		/// <summary>
		/// Dr
		/// </summary>
		public short Dr { get; set; }
		/// <summary>
		/// Ts
		/// </summary>
		public DateTime? Ts { get; set; }
	}
	#endregion
	
	#region ApproveTask定义
	/// <summary>
    /// ApproveTask数据访问类
    /// </summary>
	public partial class ApproveTask
	{
		/// <summary>
		/// Id
		/// </summary>
		public long Id { get; set; }
		/// <summary>
		/// ApplyVehicleId
		/// </summary>
		public long? ApplyVehicleId { get; set; }
		/// <summary>
		/// UserId
		/// </summary>
		public string UserId { get; set; }
		/// <summary>
		/// DeptId
		/// </summary>
		public string DeptId { get; set; }
		/// <summary>
		/// EnterpriseId
		/// </summary>
		public string EnterpriseId { get; set; }
		/// <summary>
		/// TaskName
		/// </summary>
		public string TaskName { get; set; }
		/// <summary>
		/// Description
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// SortNo
		/// </summary>
		public int? SortNo { get; set; }
		/// <summary>
		/// ActorName
		/// </summary>
		public string ActorName { get; set; }
		/// <summary>
		/// ActorDeptName
		/// </summary>
		public string ActorDeptName { get; set; }
		/// <summary>
		/// Content
		/// </summary>
		public string Content { get; set; }
		/// <summary>
		/// ProcessTime
		/// </summary>
		public DateTime? ProcessTime { get; set; }
		/// <summary>
		/// 用车审批任务时，1：车辆管理员审批，2：非车辆管理员审批"
		/// </summary>
		public short? IsManagerApprove { get; set; }
		/// <summary>
		/// 1.待审批（Waiting)2.审批通过（Completed）3.审批未通过（Terminated） 4.已撤销
		/// </summary>
		public short? Status { get; set; }
		/// <summary>
		/// AddTime
		/// </summary>
		public DateTime? AddTime { get; set; }
		/// <summary>
		/// UpdateTime
		/// </summary>
		public DateTime? UpdateTime { get; set; }
		/// <summary>
		/// Dr
		/// </summary>
		public short Dr { get; set; }
		/// <summary>
		/// Ts
		/// </summary>
		public DateTime? Ts { get; set; }
	}
	#endregion
	
	#region DepartureRecord定义
	/// <summary>
    /// DepartureRecord数据访问类
    /// </summary>
	public partial class DepartureRecord
	{
		/// <summary>
		/// Id
		/// </summary>
		public long Id { get; set; }
		/// <summary>
		/// ApplyVehicleId
		/// </summary>
		public long? ApplyVehicleId { get; set; }
		/// <summary>
		/// UserId
		/// </summary>
		public string UserId { get; set; }
		/// <summary>
		/// EnterpriseId
		/// </summary>
		public string EnterpriseId { get; set; }
		/// <summary>
		/// PassengerName
		/// </summary>
		public string PassengerName { get; set; }
		/// <summary>
		/// Mileage
		/// </summary>
		public int? Mileage { get; set; }
		/// <summary>
		/// ContinueMileage
		/// </summary>
		public int? ContinueMileage { get; set; }
		/// <summary>
		/// DeparturePosition
		/// </summary>
		public string DeparturePosition { get; set; }
		/// <summary>
		/// DepartureLat
		/// </summary>
		public string DepartureLat { get; set; }
		/// <summary>
		/// DepartureLng
		/// </summary>
		public string DepartureLng { get; set; }
		/// <summary>
		/// DepartureAddress
		/// </summary>
		public string DepartureAddress { get; set; }
		/// <summary>
		/// DepartureTime
		/// </summary>
		public DateTime? DepartureTime { get; set; }
		/// <summary>
		/// Attachments
		/// </summary>
		public string Attachments { get; set; }
		/// <summary>
		/// Content
		/// </summary>
		public string Content { get; set; }
		/// <summary>
		/// AddTime
		/// </summary>
		public DateTime? AddTime { get; set; }
		/// <summary>
		/// UpdateTime
		/// </summary>
		public DateTime? UpdateTime { get; set; }
		/// <summary>
		/// Dr
		/// </summary>
		public short Dr { get; set; }
		/// <summary>
		/// Ts
		/// </summary>
		public DateTime? Ts { get; set; }
		/// <summary>
		/// Version
		/// </summary>
		public decimal? Version { get; set; }
	}
	#endregion
	
	#region DispatchRecord定义
	/// <summary>
    /// DispatchRecord数据访问类
    /// </summary>
	public partial class DispatchRecord
	{
		/// <summary>
		/// Id
		/// </summary>
		public long Id { get; set; }
		/// <summary>
		/// DriverId
		/// </summary>
		public string DriverId { get; set; }
		/// <summary>
		/// ApplyVehicleId
		/// </summary>
		public long? ApplyVehicleId { get; set; }
		/// <summary>
		/// EnterpriseId
		/// </summary>
		public string EnterpriseId { get; set; }
		/// <summary>
		/// VehicleId
		/// </summary>
		public string VehicleId { get; set; }
		/// <summary>
		/// PlateNumber
		/// </summary>
		public string PlateNumber { get; set; }
		/// <summary>
		/// BrandName
		/// </summary>
		public string BrandName { get; set; }
		/// <summary>
		/// SeriesName
		/// </summary>
		public string SeriesName { get; set; }
		/// <summary>
		/// VehicleColor
		/// </summary>
		public string VehicleColor { get; set; }
		/// <summary>
		/// DriverName
		/// </summary>
		public string DriverName { get; set; }
		/// <summary>
		/// Attachments
		/// </summary>
		public string Attachments { get; set; }
		/// <summary>
		/// DriverType
		/// </summary>
		public short? DriverType { get; set; }
		/// <summary>
		/// Content
		/// </summary>
		public string Content { get; set; }
		/// <summary>
		/// 0.派车成功1.派车失败
		/// </summary>
		public short? Status { get; set; }
		/// <summary>
		/// AddTime
		/// </summary>
		public DateTime? AddTime { get; set; }
		/// <summary>
		/// UpdateTime
		/// </summary>
		public DateTime? UpdateTime { get; set; }
		/// <summary>
		/// Dr
		/// </summary>
		public short Dr { get; set; }
		/// <summary>
		/// Ts
		/// </summary>
		public DateTime? Ts { get; set; }
	}
	#endregion
	
	#region ReturnVehicleRecord定义
	/// <summary>
    /// ReturnVehicleRecord数据访问类
    /// </summary>
	public partial class ReturnVehicleRecord
	{
		/// <summary>
		/// Id
		/// </summary>
		public long Id { get; set; }
		/// <summary>
		/// UserId
		/// </summary>
		public string UserId { get; set; }
		/// <summary>
		/// ApplyVehicleId
		/// </summary>
		public long? ApplyVehicleId { get; set; }
		/// <summary>
		/// EnterpriseId
		/// </summary>
		public string EnterpriseId { get; set; }
		/// <summary>
		/// ReturnUserName
		/// </summary>
		public string ReturnUserName { get; set; }
		/// <summary>
		/// Mileage
		/// </summary>
		public int? Mileage { get; set; }
		/// <summary>
		/// ContinueMileage
		/// </summary>
		public int? ContinueMileage { get; set; }
		/// <summary>
		/// CostItems
		/// </summary>
		public string CostItems { get; set; }
		/// <summary>
		/// Cost
		/// </summary>
		public decimal? Cost { get; set; }
		/// <summary>
		/// Attachments
		/// </summary>
		public string Attachments { get; set; }
		/// <summary>
		/// ReturnPosition
		/// </summary>
		public string ReturnPosition { get; set; }
		/// <summary>
		/// ReturnAddress
		/// </summary>
		public string ReturnAddress { get; set; }
		/// <summary>
		/// ReturnLat
		/// </summary>
		public string ReturnLat { get; set; }
		/// <summary>
		/// ReturnLng
		/// </summary>
		public string ReturnLng { get; set; }
		/// <summary>
		/// Version
		/// </summary>
		public decimal? Version { get; set; }
		/// <summary>
		/// Content
		/// </summary>
		public string Content { get; set; }
		/// <summary>
		/// AddTime
		/// </summary>
		public DateTime? AddTime { get; set; }
		/// <summary>
		/// UpdateTime
		/// </summary>
		public DateTime? UpdateTime { get; set; }
		/// <summary>
		/// Dr
		/// </summary>
		public short Dr { get; set; }
		/// <summary>
		/// Ts
		/// </summary>
		public DateTime? Ts { get; set; }
		/// <summary>
		/// VehicleCondition
		/// </summary>
		public string VehicleCondition { get; set; }
		/// <summary>
		/// ReturnTime
		/// </summary>
		public DateTime? ReturnTime { get; set; }
	}
	#endregion
	
	#region WorkflowApply定义
	/// <summary>
    /// WorkflowApply数据访问类
    /// </summary>
	public partial class WorkflowApply
	{
		/// <summary>
		/// Id
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// EnterpriseId
		/// </summary>
		public string EnterpriseId { get; set; }
		/// <summary>
		/// ApplyVehicleId
		/// </summary>
		public long? ApplyVehicleId { get; set; }
		/// <summary>
		/// WorkflowTemplateId
		/// </summary>
		public string WorkflowTemplateId { get; set; }
		/// <summary>
		/// UserId
		/// </summary>
		public string UserId { get; set; }
		/// <summary>
		/// AddTime
		/// </summary>
		public DateTime? AddTime { get; set; }
		/// <summary>
		/// UpdateTime
		/// </summary>
		public DateTime? UpdateTime { get; set; }
		/// <summary>
		/// Dr
		/// </summary>
		public int? Dr { get; set; }
		/// <summary>
		/// Ts
		/// </summary>
		public DateTime? Ts { get; set; }
	}
	#endregion
	
	#region WorkflowTask定义
	/// <summary>
    /// WorkflowTask数据访问类
    /// </summary>
	public partial class WorkflowTask
	{
		/// <summary>
		/// Id
		/// </summary>
		public long Id { get; set; }
		/// <summary>
		/// EnterpriseId
		/// </summary>
		public string EnterpriseId { get; set; }
		/// <summary>
		/// WorkflowTemplateId
		/// </summary>
		public string WorkflowTemplateId { get; set; }
		/// <summary>
		/// ApplyVehicleId
		/// </summary>
		public long? ApplyVehicleId { get; set; }
		/// <summary>
		/// UserId
		/// </summary>
		public string UserId { get; set; }
		/// <summary>
		/// WorkflowApplyId
		/// </summary>
		public string WorkflowApplyId { get; set; }
		/// <summary>
		/// Status
		/// </summary>
		public int? Status { get; set; }
		/// <summary>
		/// AddTime
		/// </summary>
		public DateTime? AddTime { get; set; }
		/// <summary>
		/// UpdateTime
		/// </summary>
		public DateTime? UpdateTime { get; set; }
		/// <summary>
		/// Dr
		/// </summary>
		public int? Dr { get; set; }
		/// <summary>
		/// Ts
		/// </summary>
		public DateTime? Ts { get; set; }
	}
	#endregion
	
	#region WorkflowTemplate定义
	/// <summary>
    /// WorkflowTemplate数据访问类
    /// </summary>
	public partial class WorkflowTemplate
	{
		/// <summary>
		/// Id
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// EnterpriseId
		/// </summary>
		public string EnterpriseId { get; set; }
		/// <summary>
		/// AddTime
		/// </summary>
		public DateTime? AddTime { get; set; }
		/// <summary>
		/// UpdateTime
		/// </summary>
		public DateTime? UpdateTime { get; set; }
		/// <summary>
		/// Dr
		/// </summary>
		public int? Dr { get; set; }
		/// <summary>
		/// Ts
		/// </summary>
		public DateTime? Ts { get; set; }
		/// <summary>
		/// Name
		/// </summary>
		public string Name { get; set; }
	}
	#endregion
}