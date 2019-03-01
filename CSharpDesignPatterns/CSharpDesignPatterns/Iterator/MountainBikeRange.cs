using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Iterator
{
    class MountainBikeRange
    {
        private IBicycle[] _bicycles;

        public virtual IBicycle[] Range
        {
            get
            {
                return _bicycles;
            }
        }
        public MountainBikeRange()
        {
            _bicycles = new IBicycle[5];

            //define the range of maountain bikes available
            _bicycles[0] = new Downhill(new WideWheel(22));
            _bicycles[1] = new Downhill(BikeColor.Blue, new WideWheel(24));
            _bicycles[2] = new Downhill(BikeColor.Black, new WideWheel(26));
            _bicycles[3] = new CrossCountry(new WideWheel(22));
            _bicycles[4] = new CrossCountry(BikeColor.Green, new WideWheel(24));
        }

        public virtual IEnumerator<IBicycle> GetEnumerator()
        {
            return ((IEnumerable<IBicycle>)_bicycles).GetEnumerator();
        }
    }
}
