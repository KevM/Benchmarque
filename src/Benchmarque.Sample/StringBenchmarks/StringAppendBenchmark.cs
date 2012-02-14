﻿// Copyright 2007-2010 The Apache Software Foundation.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Benchmarque.Sample.StringBenchmarks
{
    using System.Collections.Generic;

    public class StringAppendBenchmark :
        Benchmark<StringRunner>
    {
        public IEnumerable<int> Iterations
        {
            get { return new[] {50, 10000}; }
        }

        public void WarmUp(StringRunner instance)
        {
            instance.Append("HELLO");
        }

        public void Shutdown(StringRunner instance)
        {
        }

        public void Run(StringRunner instance, int iterationCount)
        {
            const string value = "ABCDEFG";

            for (int i = 0; i < iterationCount; i++)
                instance.Append(value);
        }
    }
}