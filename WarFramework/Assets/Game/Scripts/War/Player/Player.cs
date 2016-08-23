using UnityEngine;
using System.Collections;

namespace Games.Wars
{
	/** 战斗玩家控制中心 (对外接口，管理决策，集合引用) */
	public partial class Player : BaseScript
	{
		/** 玩家联盟 */
		public PlayerGroup playerGroup;
		/** 控制的单位 */
		public UnitCtl unit;
	}
}

