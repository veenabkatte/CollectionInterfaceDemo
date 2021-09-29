using System;
using System.Collections;
using System.Collections.Generic;


namespace CollectionInterfaceDemo
{
    class Cars : IEnumerator<Car>
    {
        List<Car> carList = new List<Car>();
        int position = -1;

        public Car this[int index]
        {
            get
            {
                return carList[index];
            }
            set
            {
                carList.Add(value);
            }
        }

        public Car Current
        {
            get
            {
                if (position < carList.Count)
                {
                    return null;
                }
                else
                {
                    return carList[position];
                }
            }
            set
            {

            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public bool MoveNext()
        {
            position++;
            return (position < carList.Count);
        }

        public void Reset()
        {
            position = -1;
        }
    }
    class Car
    {
        public int Year { get; set; }

        public string ModelName { get; set; }
    }
}
