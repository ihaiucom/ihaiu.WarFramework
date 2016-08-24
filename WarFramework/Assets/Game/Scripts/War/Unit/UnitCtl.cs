using UnityEngine;
using System.Collections;


namespace Games.Wars
{
	/** 单位控制中心 (对外接口，管理决策，集合引用) */
    public partial class UnitCtl : ECtl
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

	}
}