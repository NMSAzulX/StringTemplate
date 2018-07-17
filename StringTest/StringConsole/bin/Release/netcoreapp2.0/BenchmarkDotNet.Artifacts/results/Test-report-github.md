``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
Frequency=2156251 Hz, Resolution=463.7679 ns, Timer=TSC
.NET Core SDK=2.1.202
  [Host] : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT  [AttachedDebugger]
  Core   : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT

Job=Core  Runtime=Core  

```
|         Method | count |         Mean |        Error |       StdDev |       Median |   Gen 0 | Allocated |
|--------------- |------ |-------------:|-------------:|-------------:|-------------:|--------:|----------:|
|  **StringBuilder** |    **10** |     **753.7 ns** |     **9.978 ns** |     **8.332 ns** |     **751.9 ns** |  **0.4063** |    **1920 B** |
|   StringFormat |    10 |   1,597.3 ns |    31.814 ns |    73.733 ns |   1,562.0 ns |  0.2365 |    1120 B |
| TemplateFormat |    10 |     632.3 ns |    15.019 ns |    18.445 ns |     625.7 ns |  0.1860 |     880 B |
|  **StringBuilder** |  **1000** |  **77,247.7 ns** |   **932.753 ns** |   **826.862 ns** |  **77,235.9 ns** | **40.6494** |  **192000 B** |
|   StringFormat |  1000 | 157,256.5 ns | 1,585.411 ns | 1,482.995 ns | 157,001.6 ns | 23.6816 |  112000 B |
| TemplateFormat |  1000 |  61,062.8 ns |   174.361 ns |   145.599 ns |  61,072.6 ns | 18.6157 |   88000 B |
