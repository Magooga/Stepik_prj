using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

using Stepik_prj;

namespace Benchmark
{
    [MemoryDiagnoser]   //dlia prosmotra ipolzovania pamiati testiryemimi syshnostiami
    [RankColumn]        //dlia ozenki kakaya testiryemaya syshnost lychshe rabotaet

    public class MyParserBenchmark
    {
        private readonly Test1 _tst1 = new Test1();

        [Benchmark]
        public void TestPysk()
        {
           int rslt = _tst1.pysk(); 
        }
    }
}
