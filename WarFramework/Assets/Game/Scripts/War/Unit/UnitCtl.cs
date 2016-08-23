using UnityEngine;
using System.Collections;


namespace Games
{
	/** 单位控制中心 (对外接口，管理决策，集合引用) */
	public partial class UnitCtl : BaseScript, IEComponent
	{
		/** 单位数据 */
		public UnitData 	unitData;
		/** 单位代理 */
		public UnitAgent 	unitAgent;


		/** 设置单位数据 */
		public void SetData(UnitData unitData)
		{
			this.unitData = unitData;
		}

		
		/** 安装 */
		public void Install()
		{

		}





		/** 重置, 用在对象池 */
		override public void CReset()
		{
			base.CReset();

		}
		
		/** 释放,一般用在销毁或对象池释放 */
		override public void CRelease()
		{
			base.CRelease();
		}
		
		/** 销毁内存分配 */
		override public void CDealloc()
		{
			base.CDealloc();
		}

	}
}