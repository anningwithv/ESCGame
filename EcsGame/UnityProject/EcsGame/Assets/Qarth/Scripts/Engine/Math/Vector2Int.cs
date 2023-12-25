using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace GameFrame
{
    [Serializable]
    public struct Vector2Int
    {
        public int x;
        public int y;

        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return x;
                    case 1:
                        return y;
                }
                return 0;
            }
            set
            {
                switch (index)
                {
                    case 0:
                        x = value;
                        break;
                    case 1:
                        y = value;
                        break;
                }
            }
        }

        //public static Vector2Int zero = new Vector2Int(0, 0);

        public Vector2Int(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2Int(Vector2Int raw)
        {
            this.x = raw.x;
            this.y = raw.y;
        }

        public void Set(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}

        //public override string ToString()
        //{
        //    return base.ToString();
        //}

        public static Vector2Int operator +(Vector2Int a, Vector2Int b)
        {
            return new Vector2Int(a.x + b.x, a.y + b.y);
        }

        public static Vector2Int operator -(Vector2Int a)
        {
            return new Vector2Int(-a.x, -a.y);
        }

        public static Vector2Int operator -(Vector2Int a, Vector2Int b)
        {
            return new Vector2Int(a.x - b.x, a.y - b.y);
        }

        public static Vector2Int operator *(int d, Vector2Int a)
        {
            return new Vector2Int(a.x * d, a.y * d);
        }

        public static Vector2Int operator *(Vector2Int a, int d)
        {
            return new Vector2Int(a.x * d, a.y * d);
        }

        public static Vector2Int operator /(Vector2Int a, int d)
        {
            return new Vector2Int(a.x / d, a.y / d);
        }

        //public static bool operator ==(Vector2Int a, Vector2Int b)
        //{
        //    return a.x == b.x && a.y == b.y;
        //}

        //public static bool operator !=(Vector2Int a, Vector2Int b)
        //{
        //    return a.x != b.x || a.y != b.y;
        //}

        public bool IsEqual(Vector2Int b)
        {
            return this.x == b.x && this.y == b.y;
        }
    }
}
