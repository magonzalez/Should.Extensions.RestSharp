using System;

namespace Should.Extensions.RestSharp.UnitTests.Models
{
    public class TestModelOne
    {
        public string String { get; set; }
        public short Short { get; set; }
        public int Integer { get; set; }
        public long Long { get; set; }
        public double Double { get; set; }
        public decimal Decimal { get; set; }
        public bool Boolean { get; set; }
        public DateTime DateTime { get; set; }

        public TestModelOne Clone()
        {
            return new TestModelOne
            {
                String = String,
                Short = Short,
                Integer = Integer,
                Long = Long,
                Double = Double,
                Decimal = Decimal,
                Boolean = Boolean,
                DateTime = DateTime
            };  
        }

        public TestModelTwo ToTestModelTwo()
        {
            return new TestModelTwo
            {
                String = String,
                Short = Short,
                Integer = Integer,
                Long = Long,
                Double = Double,
                Decimal = Decimal,
                Boolean = Boolean
            };
        }
    }
}
