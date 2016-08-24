using UnityEngine;
using System.Collections;
using Ihaius;

namespace Games
{
    public class PoolItem<T> : BaseScript, IPoolItem where T : PoolItem<T>
    {
		ObjectPool<T> pool;

        /** 对象池的名称描述 */
        public string PName{ get; set;}

        /** 销毁 */
        virtual public void PDestruct()
        {
			CDealloc ();
			pool = null;
        }

        /** 对象池设置--设置为使用状态消息 */
        virtual public void POnSpawned<T>(ObjectPool<T> pool)
        {
			this.pool = pool;
			CReset ();
        }

        /** 对象池设置--该对象为闲置状态 */
        virtual public void POnDespawned<T>(ObjectPool<T> pool)
        {
			CRelease ();
        }

        /** 对象池设置--该对象是否激活 */
        virtual public void PSetActive(bool value)
        {
            
        }

        /** 对象池设置--该对象重设参数 */
        virtual public void PSetArg(params object[] args)
        {
            
        }

		/** 对象池设置--放回对象池 设置为空闲状态 */
        virtual public bool Despawned()
		{
            return pool.DespawnInstance((T)this);
		}
    }
}
