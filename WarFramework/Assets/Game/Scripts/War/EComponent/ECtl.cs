using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;


namespace Games.Wars
{
    /** 实体 控制中心 */
    public class ECtl : PoolItem<ECtl>, IPause
	{
		public List<EBehaviour> 		behaviourList 		= new List<EBehaviour>();
		public List<EMonoBehaviour> 	monoBehaviourList 	= new List<EMonoBehaviour>();
		public List<EData> 				dataList 			= new List<EData>();

		virtual public void AddBehaviour(EBehaviour behaviour)
		{
			if (!behaviourList.Contains (behaviour)) 
			{
				behaviour.OnAddCtl (this);
				behaviourList.Add (behaviour);
			}
		}


		virtual public void AddMonoBehaviour(EMonoBehaviour behaviour)
		{
			if (!monoBehaviourList.Contains (behaviour)) 
			{
				behaviour.OnAddCtl (this);
				monoBehaviourList.Add (behaviour);
			}
		}


		virtual public void AddData(EData data)
		{
			if (!dataList.Contains (data)) 
			{
				data.OnAddCtl (this);
				dataList.Add (data);
			}
		}


        #region IPause
        /** 暂停 */
        virtual public void Pause()
        {
			for(int i = 0; i < behaviourList.Count; i ++)
			{
				behaviourList [i].Pause ();
			}

			for(int i = 0; i < monoBehaviourList.Count; i ++)
			{
				monoBehaviourList [i].Pause ();
			}
        }

        /** 继续 */
        virtual public void Resume()
        {
			for(int i = 0; i < behaviourList.Count; i ++)
			{
				behaviourList [i].Resume ();
			}

			for(int i = 0; i < monoBehaviourList.Count; i ++)
			{
				monoBehaviourList [i].Resume ();
			}
        }
        #endregion


		#region IScript
		/** 释放 */
		override public void CRelease()
		{
			base.CRelease ();


			for(int i = behaviourList.Count - 1; i >= 0; i --)
			{
				behaviourList[i].OnRemoveCtl ();
			}


			for(int i = monoBehaviourList.Count - 1; i >= 0; i --)
			{
				monoBehaviourList [i].OnRemoveCtl ();
			}

			for(int i = dataList.Count - 1; i >= 0; i --)
			{
				dataList [i].OnRemoveCtl ();
			}

			behaviourList.Clear ();
			monoBehaviourList.Clear ();
			dataList.Clear ();
		}
		#endregion
	}
}
