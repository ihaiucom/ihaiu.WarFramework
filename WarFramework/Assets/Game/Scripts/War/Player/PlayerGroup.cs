using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Games
{
	/** 战斗玩家联盟 */
	public class PlayerGroup : BaseScript
	{
		/** 联盟里的玩家 */
		public Dictionary<int, Player> playerDict = new Dictionary<int, Player>(); 
	}
}

