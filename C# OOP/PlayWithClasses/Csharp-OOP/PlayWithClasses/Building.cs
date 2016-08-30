using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithClasses
{
    class Building
    {
        public string Address { get; set; }
        public int Floors { get; set; }
        public double SizeSquareInM { get; set; }

        public Building(string adress,int floors,double sizeSquareInM)
        {
            this.Address = adress;
            this.Floors = floors;
            this.SizeSquareInM = sizeSquareInM;
        }
        public Building(string address)
        {
            this.Address = address;
            
        }
        public override string ToString()
        {
            return String.Format("Address:{0};Floor:{1};Size:{2}SqM",
                this.Address, this.Floors, this.SizeSquareInM);
        }
    }
}
