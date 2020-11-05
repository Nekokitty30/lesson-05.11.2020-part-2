using System;

namespace DataStructure
{
    public class ArrayList
    {   

        public int length { get; private set; }
        private int[] _array;

        public ArrayList()
        {
            _array = new int[3];
            length = 0;
        }

        public void Add(int value)
        {
            if (length>_array.Length)
            {
               
            }
            else
            {
                RizeSize();
            } 
            _array[length] = value;
                length++;
        }

        public override bool Equals(object obj)
        {
            ArrayList arrayList = (ArrayList)obj;
            //arrayList._array;
            return true;
        }


        private void RizeSize(int size=1)
        {
            int newLength = _array.Length;
            while (newLength<length+size)
            {
                newLength= (int)(newLength*1.33d+1);
            }

            int[] newArray = new int[newLength];
            Array.Copy(_array, newArray, _array.Length);
            _array = newArray;
        }
    }
}
