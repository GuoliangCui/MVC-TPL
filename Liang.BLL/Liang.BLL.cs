//-----------------------------------------------------------------------
// <copyright file="BLL.cs">
// * Copyright (C) 2019 63354261@qq.com
// * version : V 1.0
// * author  : cuiguoliang
// * FileName: BLL.cs
// * history : Created by T4 10/28/2019 15:06:09 
// </copyright>
//-----------------------------------------------------------------------


/// <summary>
/// 全部实体业务类
/// </summary>
namespace Liang.BLL
{
	using Liang.DAL;
    using Liang.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;
	
	/// <summary>
    /// ApplyApproveRecord业务类
    /// </summary>
	public partial class ApplyApproveRecordBLL:BaseBLL<ApplyApproveRecord, ApplyApproveRecordDAL> { }
	
	/// <summary>
    /// ApplyRelatedUsers业务类
    /// </summary>
	public partial class ApplyRelatedUsersBLL:BaseBLL<ApplyRelatedUsers, ApplyRelatedUsersDAL> { }
	
	/// <summary>
    /// ApplyVehicle业务类
    /// </summary>
	public partial class ApplyVehicleBLL:BaseBLL<ApplyVehicle, ApplyVehicleDAL> { }
	
	/// <summary>
    /// AppointPolicy业务类
    /// </summary>
	public partial class AppointPolicyBLL:BaseBLL<AppointPolicy, AppointPolicyDAL> { }
	
	/// <summary>
    /// ApproveCarbonCopy业务类
    /// </summary>
	public partial class ApproveCarbonCopyBLL:BaseBLL<ApproveCarbonCopy, ApproveCarbonCopyDAL> { }
	
	/// <summary>
    /// ApproveTask业务类
    /// </summary>
	public partial class ApproveTaskBLL:BaseBLL<ApproveTask, ApproveTaskDAL> { }
	
	/// <summary>
    /// DepartureRecord业务类
    /// </summary>
	public partial class DepartureRecordBLL:BaseBLL<DepartureRecord, DepartureRecordDAL> { }
	
	/// <summary>
    /// DispatchRecord业务类
    /// </summary>
	public partial class DispatchRecordBLL:BaseBLL<DispatchRecord, DispatchRecordDAL> { }
	
	/// <summary>
    /// ReturnVehicleRecord业务类
    /// </summary>
	public partial class ReturnVehicleRecordBLL:BaseBLL<ReturnVehicleRecord, ReturnVehicleRecordDAL> { }
	
	/// <summary>
    /// WorkflowApply业务类
    /// </summary>
	public partial class WorkflowApplyBLL:BaseBLL<WorkflowApply, WorkflowApplyDAL> { }
	
	/// <summary>
    /// WorkflowTask业务类
    /// </summary>
	public partial class WorkflowTaskBLL:BaseBLL<WorkflowTask, WorkflowTaskDAL> { }
	
	/// <summary>
    /// WorkflowTemplate业务类
    /// </summary>
	public partial class WorkflowTemplateBLL:BaseBLL<WorkflowTemplate, WorkflowTemplateDAL> { }
}