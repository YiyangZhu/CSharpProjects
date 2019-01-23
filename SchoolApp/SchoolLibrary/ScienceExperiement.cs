using System;
namespace SchoolLibrary
{
    //base class and an interface
    public class ScienceExperiement : Person, IScored
    {
        public string Hypothesis { get; set; }
        public string Materials { get; set; }
        public string Method { get; set; }
        public string Conclusion { get; set; }

        public float Score { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float MaximumScore { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        //interface can also be implemented in the following way:
        //public float Score { get; set; }
        //public float MaximumScore { get; set; }


        public override float ComputeGradeAverage()
        {
            throw new NotImplementedException();
        }
    }
}
