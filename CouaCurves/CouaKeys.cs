using System;
using System.Collections.Generic;
using System.Text;

namespace CouaCurves
{
    public struct CouaKeys
    {
        CouaVector2[] keys;

        internal void AddKey(CouaVector2 v)
        {
            CouaVector2[] newKeys = new CouaVector2[keys.Length + 1];

            for (int i = 0; i < newKeys.Length; i++)
            {
                newKeys[i] = keys[i];
                if (i == newKeys.Length - 1)
                {
                    newKeys[newKeys.Length] = v;
                }
            }
            keys = newKeys;
        }

        internal void RemoveKeyAt(int index)
        {
            if (index < 0 || index >= keys.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }
            CouaVector2[] newKeys = new CouaVector2[keys.Length - 1];
            int y = 0;
            for (int i = 0; i < keys.Length; i++)
            {
                if (i != index)
                {
                    newKeys[y] = keys[i];
                    y++;
                }
            }
            keys = newKeys;
        }
        internal CouaVector2 GetKey(int index)
        {
            if (index < 0 || index >= keys.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }
            return new CouaVector2(keys[index].x, keys[index].y);
        }
    }
}
